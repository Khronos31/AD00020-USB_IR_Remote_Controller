//-------------------------------------------------------------------------------------------------------------------------------------------------------------------
//-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------
/********************************************************************
 FileName:		Form1.cs
 Dependencies:	When compiled, needs .NET framework 2.0 redistributable to run.
 Hardware:		Need a free USB port to connect USB peripheral device
				programmed with appropriate Generic HID firmware.  VID and
				PID in firmware must match the VID and PID in this
				program.
 Compiler:  	Microsoft Visual C# 2005 Express Edition (or better)
 Company:		Microchip Technology, Inc.

 Software License Agreement:

 The software supplied herewith by Microchip Technology Incorporated
 (the 鼎ompany・ for its PICｮ Microcontroller is intended and
 supplied to you, the Company痴 customer, for use solely and
 exclusively with Microchip PIC Microcontroller products. The
 software is owned by the Company and/or its supplier, and is
 protected under applicable copyright laws. All rights are reserved.
 Any use in violation of the foregoing restrictions may subject the
 user to criminal sanctions under applicable laws, as well as to
 civil liability for the breach of the terms and conditions of this
 license.

 THIS SOFTWARE IS PROVIDED IN AN 鄭S IS・CONDITION. NO WARRANTIES,
 WHETHER EXPRESS, IMPLIED OR STATUTORY, INCLUDING, BUT NOT LIMITED
 TO, IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
 PARTICULAR PURPOSE APPLY TO THIS SOFTWARE. THE COMPANY SHALL NOT,
 IN ANY CIRCUMSTANCES, BE LIABLE FOR SPECIAL, INCIDENTAL OR
 CONSEQUENTIAL DAMAGES, FOR ANY REASON WHATSOEVER.

********************************************************************
 File Description:

 Change History:
  Rev   Date         Description
  2.5a	07/17/2009	 Initial Release.  Ported from HID PnP Demo
                     application source, which was originally 
                     written in MSVC++ 2005 Express Edition.
********************************************************************
NOTE:	All user made code contained in this project is in the Form1.cs file.
		All other code and files were generated automatically by either the
		new project wizard, or by the development environment (ex: code is
		automatically generated if you create a new button on the form, and
		then double click on it, which creates a click event handler
		function).  User developed code (code not developed by the IDE) has
        been marked in "cut and paste blocks" to make it easier to identify.
********************************************************************/

//NOTE: In order for this program to "find" a USB device with a given VID and PID, 
//both the VID and PID in the USB device descriptor (in the USB firmware on the 
//microcontroller), as well as in this PC application source code, must match.
//To change the VID/PID in this PC application source code, scroll down to the 
//CheckIfPresentAndGetUSBDevicePath() function, and change the line that currently
//reads:

//   String DeviceIDToFind = "Vid_04d8&Pid_003f";


//NOTE 2: This C# program makes use of several functions in setupapi.dll and
//other Win32 DLLs.  However, one cannot call the functions directly in a 
//32-bit DLL if the project is built in "Any CPU" mode, when run on a 64-bit OS.
//When configured to build an "Any CPU" executable, the executable will "become"
//a 64-bit executable when run on a 64-bit OS.  On a 32-bit OS, it will run as 
//a 32-bit executable, and the pointer sizes and other aspects of this 
//application will be compatible with calling 32-bit DLLs.

//Therefore, on a 64-bit OS, this application will not work unless it is built in
//"x86" mode.  When built in this mode, the exectuable always runs in 32-bit mode
//even on a 64-bit OS.  This allows this application to make 32-bit DLL function 
//calls, when run on either a 32-bit or 64-bit OS.

//By default, on a new project, C# normally wants to build in "Any CPU" mode.  
//To switch to "x86" mode, open the "Configuration Manager" window.  In the 
//"Active solution platform:" drop down box, select "x86".  If this option does
//not appear, select: "<New...>" and then select the x86 option in the 
//"Type or select the new platform:" drop down box.  

//-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
//-------------------------------------------------------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;
using System.Threading;


namespace HID_PnP_Demo
{
    public partial class Form1 : Form
    {

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------

        //Constant definitions from setupapi.h, which we aren't allowed to include directly since this is C#
        internal const uint DIGCF_PRESENT = 0x02;
        internal const uint DIGCF_DEVICEINTERFACE = 0x10;
        //Constants for CreateFile() and other file I/O functions
        internal const short FILE_ATTRIBUTE_NORMAL = 0x80;
        internal const short INVALID_HANDLE_VALUE = -1;
        internal const uint GENERIC_READ = 0x80000000;
        internal const uint GENERIC_WRITE = 0x40000000;
        internal const uint CREATE_NEW = 1;
        internal const uint CREATE_ALWAYS = 2;
        internal const uint OPEN_EXISTING = 3;
        internal const uint FILE_SHARE_READ = 0x00000001;
        internal const uint FILE_SHARE_WRITE = 0x00000002;
        //Constant definitions for certain WM_DEVICECHANGE messages
        internal const uint WM_DEVICECHANGE = 0x0219;
        internal const uint DBT_DEVICEARRIVAL = 0x8000;
        internal const uint DBT_DEVICEREMOVEPENDING = 0x8003;
        internal const uint DBT_DEVICEREMOVECOMPLETE = 0x8004;
        internal const uint DBT_CONFIGCHANGED = 0x0018;
        //Other constant definitions
        internal const uint DBT_DEVTYP_DEVICEINTERFACE = 0x05;
        internal const uint DEVICE_NOTIFY_WINDOW_HANDLE = 0x00;
        internal const uint ERROR_SUCCESS = 0x00;
        internal const uint ERROR_NO_MORE_ITEMS = 0x00000103;
        internal const uint SPDRP_HARDWAREID = 0x00000001;

        //Various structure definitions for structures that this code will be using
        internal struct SP_DEVICE_INTERFACE_DATA
        {
            internal uint cbSize;               //DWORD
            internal Guid InterfaceClassGuid;   //GUID
            internal uint Flags;                //DWORD
            internal uint Reserved;             //ULONG_PTR MSDN says ULONG_PTR is "typedef unsigned __int3264 ULONG_PTR;"  
        }

        internal struct SP_DEVICE_INTERFACE_DETAIL_DATA
        {
            internal uint cbSize;               //DWORD
            internal char[] DevicePath;         //TCHAR array of any size
        }
        
        internal struct SP_DEVINFO_DATA
        {
            internal uint cbSize;       //DWORD
            internal Guid ClassGuid;    //GUID
            internal uint DevInst;      //DWORD
            internal uint Reserved;     //ULONG_PTR  MSDN says ULONG_PTR is "typedef unsigned __int3264 ULONG_PTR;"  
        }

        internal struct DEV_BROADCAST_DEVICEINTERFACE
        {
            internal uint dbcc_size;            //DWORD
            internal uint dbcc_devicetype;      //DWORD
            internal uint dbcc_reserved;        //DWORD
            internal Guid dbcc_classguid;       //GUID
            internal char[] dbcc_name;          //TCHAR array
        }
        internal struct STR_EEPROM_DATA
        {
            internal byte change_flag;       //変更フラグ
            internal byte mode;              //モード mouse, key, joystick
            internal byte value;             //USBコード
            internal byte modifier;          //モディファイア
            internal byte reader_code;       //赤外線リーダコード
            internal byte[] data;            //赤外線データコード
            internal void init_data(int num)
            {
                data = new byte[num];
            }
        }

        //DLL Imports.  Need these to access various C style unmanaged functions contained in their respective DLL files.
        //--------------------------------------------------------------------------------------------------------------
        //Returns a HDEVINFO type for a device information set.  We will need the 
        //HDEVINFO as in input parameter for calling many of the other SetupDixxx() functions.
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern IntPtr SetupDiGetClassDevs(
            ref Guid ClassGuid,     //LPGUID    Input: Need to supply the class GUID. 
            IntPtr Enumerator,      //PCTSTR    Input: Use NULL here, not important for our purposes
            IntPtr hwndParent,      //HWND      Input: Use NULL here, not important for our purposes
            uint Flags);            //DWORD     Input: Flags describing what kind of filtering to use.

	    //Gives us "PSP_DEVICE_INTERFACE_DATA" which contains the Interface specific GUID (different
	    //from class GUID).  We need the interface GUID to get the device path.
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SetupDiEnumDeviceInterfaces(
            IntPtr DeviceInfoSet,           //Input: Give it the HDEVINFO we got from SetupDiGetClassDevs()
            IntPtr DeviceInfoData,          //Input (optional)
            ref Guid InterfaceClassGuid,    //Input 
            uint MemberIndex,               //Input: "Index" of the device you are interested in getting the path for.
            ref SP_DEVICE_INTERFACE_DATA DeviceInterfaceData);    //Output: This function fills in an "SP_DEVICE_INTERFACE_DATA" structure.

        //SetupDiDestroyDeviceInfoList() frees up memory by destroying a DeviceInfoList
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SetupDiDestroyDeviceInfoList(
            IntPtr DeviceInfoSet);          //Input: Give it a handle to a device info list to deallocate from RAM.

        //SetupDiEnumDeviceInfo() fills in an "SP_DEVINFO_DATA" structure, which we need for SetupDiGetDeviceRegistryProperty()
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SetupDiEnumDeviceInfo(
            IntPtr DeviceInfoSet,
            uint MemberIndex,
            ref SP_DEVINFO_DATA DeviceInterfaceData);

        //SetupDiGetDeviceRegistryProperty() gives us the hardware ID, which we use to check to see if it has matching VID/PID
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SetupDiGetDeviceRegistryProperty(
            IntPtr DeviceInfoSet,
            ref SP_DEVINFO_DATA DeviceInfoData,
            uint Property,
            ref uint PropertyRegDataType,
            IntPtr PropertyBuffer,
            uint PropertyBufferSize,
            ref uint RequiredSize);

        //SetupDiGetDeviceInterfaceDetail() gives us a device path, which is needed before CreateFile() can be used.
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SetupDiGetDeviceInterfaceDetail(
            IntPtr DeviceInfoSet,                   //Input: Wants HDEVINFO which can be obtained from SetupDiGetClassDevs()
            ref SP_DEVICE_INTERFACE_DATA DeviceInterfaceData,                    //Input: Pointer to an structure which defines the device interface.  
            IntPtr  DeviceInterfaceDetailData,      //Output: Pointer to a SP_DEVICE_INTERFACE_DETAIL_DATA structure, which will receive the device path.
            uint DeviceInterfaceDetailDataSize,     //Input: Number of bytes to retrieve.
            ref uint RequiredSize,                  //Output (optional): The number of bytes needed to hold the entire struct 
            IntPtr DeviceInfoData);                 //Output (optional): Pointer to a SP_DEVINFO_DATA structure

        //Overload for SetupDiGetDeviceInterfaceDetail().  Need this one since we can't pass NULL pointers directly in C#.
        [DllImport("setupapi.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool SetupDiGetDeviceInterfaceDetail(
            IntPtr DeviceInfoSet,                   //Input: Wants HDEVINFO which can be obtained from SetupDiGetClassDevs()
            ref SP_DEVICE_INTERFACE_DATA DeviceInterfaceData,               //Input: Pointer to an structure which defines the device interface.  
            IntPtr DeviceInterfaceDetailData,       //Output: Pointer to a SP_DEVICE_INTERFACE_DETAIL_DATA structure, which will contain the device path.
            uint DeviceInterfaceDetailDataSize,     //Input: Number of bytes to retrieve.
            IntPtr RequiredSize,                    //Output (optional): Pointer to a DWORD to tell you the number of bytes needed to hold the entire struct 
            IntPtr DeviceInfoData);                 //Output (optional): Pointer to a SP_DEVINFO_DATA structure

        //Need this function for receiving all of the WM_DEVICECHANGE messages.  See MSDN documentation for
        //description of what this function does/how to use it. Note: name is remapped "RegisterDeviceNotificationUM" to
        //avoid possible build error conflicts.
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern IntPtr RegisterDeviceNotification(
            IntPtr hRecipient,
            IntPtr NotificationFilter,
            uint Flags);

        //Takes in a device path and opens a handle to the device.
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeFileHandle CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode, 
            IntPtr lpSecurityAttributes, 
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes, 
            IntPtr hTemplateFile);

        //Uses a handle (created with CreateFile()), and lets us write USB data to the device.
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern bool WriteFile(
            SafeFileHandle hFile,
            byte[] lpBuffer,
            uint nNumberOfBytesToWrite,
            ref uint lpNumberOfBytesWritten,
            IntPtr lpOverlapped);

        //Uses a handle (created with CreateFile()), and lets us read USB data from the device.
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern bool ReadFile(
            SafeFileHandle hFile,
            IntPtr lpBuffer,
            uint nNumberOfBytesToRead,
            ref uint lpNumberOfBytesRead,
            IntPtr lpOverlapped);



	    //--------------- Global Varibles Section ------------------
	    //USB related variables that need to have wide scope.
	    bool AttachedState = false;						//Need to keep track of the USB device attachment status for proper plug and play operation.
	    bool AttachedButBroken = false;
        SafeFileHandle WriteHandleToUSBDevice = null;
        SafeFileHandle ReadHandleToUSBDevice = null;
        String DevicePath = null;   //Need the find the proper device path before you can open file handles.

	    //Variables used by the application/form updates.
        //byte[] eeprom_data = new byte[64]{0,0,0,0,0,0,0,0,0,0,
        //                                  0,0,0,0,0,0,0,0,0,0,
        //                                  0,0,0,0,0,0,0,0,0,0,
        //                                  0,0,0,0,0,0,0,0,0,0,
        //                                  0,0,0,0,0,0,0,0,0,0,
        //                                  0,0,0,0,0,0,0,0,0,0,
        //                                  0,0,0,0};
        bool[] ChangeAssign = new bool[Constants.EEPROM_DATA_NUM] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true };
        bool ConnectFirstTime = true;
        bool Changevalue_btn_pressed = false;

        byte DeviceType_selected = 0;
        byte MouseValue_selected = 0;
        byte KeyboardValue_selected = 0;
        byte KeyboardModifier_selected = 0;
        byte VolumeValue_selected = 0;
        //byte LeverValue_selected = 0;
        int SetPin_selected = 0;
        byte MouseMoveValue_selected = 80;
        byte Now_Background_image = 1;  //どっちの背景が表示されているか。0:未接続 1:接続済み
        int StatusBoxChange = 99;
        bool ReadFromDevice = true;

        private System.Windows.Forms.PictureBox[] myPictureBoxON;
        byte[] RemoconReceiveData = new byte[Constants.EEPROM_DATA_READER_SIZE + Constants.EEPROM_DATA_DATA_SIZE];    // リモコン受信データ
        int i_receive_wait_mode = 0;			    /* PC側が赤外線データ受信待ちのとき1 */
        STR_EEPROM_DATA[] my_EEPROM_DATA;
        byte[] EEPROM_data_0 = new byte[Constants.EEPROM_DATA_NUM];        /* 各データの0バイト目を保存 */
        int i_receive_del_btn_chg = 1;
        int Debug_1 = 0;    //DEBUG
        int Debug_2 = 0;    //DEBUG
        int Debug_3 = 0;    //DEBUG
        int Debug_4 = 0;    //DEBUG
        int Debug_5 = 0;    //DEBUG
        int Debug_6 = 0;    //DEBUG
        int Debug_7 = 0;    //DEBUG
        int Debug_8 = 0;    //DEBUG
        int Debug_9 = 0;    //DEBUG
        byte[] Debug_Arr = new byte[64]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
        byte[] Debug_Arr2 = new byte[64]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
                                        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

        //バーチャルキーコードとUSBキーコードの変換用配列
        byte[] VKtoUSBkey = new byte[256]{
            0x00,   //0
            0x00,   //1
            0x00,   //2
            0x00,   //3
            0x00,   //4
            0x00,   //5
            0x00,   //6
            0x00,   //7
            0x2A,   //8
            0x2B,   //9
            0x00,   //10
            0x00,   //11
            0x00,   //12
            0x28,   //13
            0x00,   //14
            0x00,   //15
            0xE1,   //16
            0xE0,   //17
            0xE2,   //18
            0x48,   //19
            0x39,   //20
            0x88,   //21
            0x00,   //22
            0x00,   //23
            0x00,   //24
            0x35,   //25
            0x00,   //26
            0x29,   //27
            0x8A,   //28
            0x8B,   //29
            0x00,   //30
            0x00,   //31
            0x2C,   //32
            0x4B,   //33
            0x4E,   //34
            0x4D,   //35
            0x4A,   //36
            0x50,   //37
            0x52,   //38
            0x4F,   //39
            0x51,   //40
            0x00,   //41
            0x00,   //42
            0x00,   //43
            0x46,   //44
            0x49,   //45
            0x4C,   //46
            0x00,   //47
            0x27,   //48
            0x1E,   //49
            0x1F,   //50
            0x20,   //51
            0x21,   //52
            0x22,   //53
            0x23,   //54
            0x24,   //55
            0x25,   //56
            0x26,   //57
            0x00,   //58
            0x00,   //59
            0x00,   //60
            0x00,   //61
            0x00,   //62
            0x00,   //63
            0x00,   //64
            0x04,   //65
            0x05,   //66
            0x06,   //67
            0x07,   //68
            0x08,   //69
            0x09,   //70
            0x0A,   //71
            0x0B,   //72
            0x0C,   //73
            0x0D,   //74
            0x0E,   //75
            0x0F,   //76
            0x10,   //77
            0x11,   //78
            0x12,   //79
            0x13,   //80
            0x14,   //81
            0x15,   //82
            0x16,   //83
            0x17,   //84
            0x18,   //85
            0x19,   //86
            0x1A,   //87
            0x1B,   //88
            0x1C,   //89
            0x1D,   //90
            0xE3,   //91
            0xE7,   //92
            0x65,   //93
            0x00,   //94
            0x00,   //95
            0x62,   //96
            0x59,   //97
            0x5A,   //98
            0x5B,   //99
            0x5C,   //100
            0x5D,   //101
            0x5E,   //102
            0x5F,   //103
            0x60,   //104
            0x61,   //105
            0x55,   //106
            0x57,   //107
            0x85,   //108
            0x56,   //109
            0x63,   //110
            0x54,   //111
            0x3A,   //112
            0x3B,   //113
            0x3C,   //114
            0x3D,   //115
            0x3E,   //116
            0x3F,   //117
            0x40,   //118
            0x41,   //119
            0x42,   //120
            0x43,   //121
            0x44,   //122
            0x45,   //123
            0x68,   //124
            0x69,   //125
            0x6A,   //126
            0x6B,   //127
            0x6C,   //128
            0x6D,   //129
            0x6E,   //130
            0x6F,   //131
            0x70,   //132
            0x71,   //133
            0x72,   //134
            0x73,   //135
            0x00,   //136
            0x00,   //137
            0x00,   //138
            0x00,   //139
            0x00,   //140
            0x00,   //141
            0x00,   //142
            0x00,   //143
            0x53,   //144
            0x47,   //145
            0x67,   //146
            0x00,   //147
            0x00,   //148
            0x00,   //149
            0x00,   //150
            0x00,   //151
            0x00,   //152
            0x00,   //153
            0x00,   //154
            0x00,   //155
            0x00,   //156
            0x00,   //157
            0x00,   //158
            0x00,   //159
            0xE1,   //160
            0xE5,   //161
            0xE0,   //162
            0xE4,   //163
            0xE2,   //164
            0xE6,   //165
            0x00,   //166
            0x00,   //167
            0x00,   //168
            0x00,   //169
            0x00,   //170
            0x00,   //171
            0x00,   //172
            0x00,   //173
            0x00,   //174
            0x00,   //175
            0x00,   //176
            0x00,   //177
            0x00,   //178
            0x00,   //179
            0x00,   //180
            0x00,   //181
            0x00,   //182
            0x00,   //183
            0x00,   //184
            0x00,   //185
            0x34,   //186
            0x33,   //187
            0x36,   //188
            0x2D,   //189
            0x37,   //190
            0x38,   //191
            0x2F,   //192
            0x00,   //193
            0x00,   //194
            0x00,   //195
            0x00,   //196
            0x00,   //197
            0x00,   //198
            0x00,   //199
            0x00,   //200
            0x00,   //201
            0x00,   //202
            0x00,   //203
            0x00,   //204
            0x00,   //205
            0x00,   //206
            0x00,   //207
            0x00,   //208
            0x00,   //209
            0x00,   //210
            0x00,   //211
            0x00,   //212
            0x00,   //213
            0x00,   //214
            0x00,   //215
            0x00,   //216
            0x00,   //217
            0x00,   //218
            0x30,   //219
            0x89,   //220
            0x32,   //221
            0x2E,   //222
            0x00,   //223
            0x00,   //224
            0x00,   //225
            0x87,   //226
            0x00,   //227
            0x00,   //228
            0x00,   //229
            0x00,   //230
            0x00,   //231
            0x00,   //232
            0x00,   //233
            0x00,   //234
            0x00,   //235
            0x00,   //236
            0x00,   //237
            0x00,   //238
            0x00,   //239
            0x00,   //240
            0x00,   //241
            0x00,   //242
            0x00,   //243
            0x00,   //244
            0x00,   //245
            0x00,   //246
            0x00,   //247
            0x00,   //248
            0x00,   //249
            0x00,   //250
            0x00,   //251
            0x00,   //252
            0x00,   //253
            0x00,   //254
            0x00,   //255
       };


        //Globally Unique Identifier (GUID) for HID class devices.  Windows uses GUIDs to identify things.
        Guid InterfaceClassGuid = new Guid(0x4d1e55b2, 0xf16f, 0x11cf, 0x88, 0xcb, 0x00, 0x11, 0x11, 0x00, 0x00, 0x30); 
	    //--------------- End of Global Varibles ------------------

        //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //Need to check "Allow unsafe code" checkbox in build properties to use unsafe keyword.  Unsafe is needed to
        //properly interact with the unmanged C++ style APIs used to find and connect with the USB device.
        public unsafe Form1()
        {
            InitializeComponent();

            
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------
			//Additional constructor code

            try
            {

                my_EEPROM_DATA = new STR_EEPROM_DATA[Constants.EEPROM_DATA_NUM];
                for (int i = 0; i < Constants.EEPROM_DATA_NUM; i++)
                {
                    my_EEPROM_DATA[i].init_data(Constants.EEPROM_DATA_DATA_SIZE);
                }
                //ピクチャーコントロール配列の作成（）
                myPictureBoxON = new System.Windows.Forms.PictureBox[20];
                //現在のコードを実行しているAssemblyを取得
                System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                //指定されたマニフェストリソースを読み込む
                Bitmap bmp = new Bitmap(myAssembly.GetManifestResourceStream("USB_IR_REMOCON_CT.Resources.R_ON.png"));
                //ピクチャーコントロールのインスタンス作成し、プロパティを設定する
                SuspendLayout();
                for (int i = 0; i < 20; i++)
                {
                    //インスタンス作成
                    myPictureBoxON[i] = new System.Windows.Forms.PictureBox();
                    //プロパティ設定
                    myPictureBoxON[i].Name = "PictureBoxON_" + i.ToString();
                    myPictureBoxON[i].Image = bmp;
                    myPictureBoxON[i].Size = new Size(25, 19);
                    myPictureBoxON[i].Location = new Point(168, i * 26 + 25);
                    //フォームにコントロールを追加
                    BackGround_pb.Controls.Add(myPictureBoxON[i]);
                    myPictureBoxON[i].TopLevelControl.BringToFront();
                    myPictureBoxON[i].Visible = false;
                }
                ResumeLayout(false);

                //Initialize tool tips, to provide pop up help when the mouse cursor is moved over objects on the form.
                ToggleLEDToolTip.SetToolTip(this.Changevalue_btn, "Sends a packet of data to the USB device.");

                //Register for WM_DEVICECHANGE notifications.  This code uses these messages to detect plug and play connection/disconnection events for USB devices
                DEV_BROADCAST_DEVICEINTERFACE DeviceBroadcastHeader = new DEV_BROADCAST_DEVICEINTERFACE();
                DeviceBroadcastHeader.dbcc_devicetype = DBT_DEVTYP_DEVICEINTERFACE;
                DeviceBroadcastHeader.dbcc_size = (uint)Marshal.SizeOf(DeviceBroadcastHeader);
                DeviceBroadcastHeader.dbcc_reserved = 0;	//Reserved says not to use...
                DeviceBroadcastHeader.dbcc_classguid = InterfaceClassGuid;

                //Need to get the address of the DeviceBroadcastHeader to call RegisterDeviceNotification(), but
                //can't use "&DeviceBroadcastHeader".  Instead, using a roundabout means to get the address by 
                //making a duplicate copy using Marshal.StructureToPtr().
                IntPtr pDeviceBroadcastHeader = IntPtr.Zero;  //Make a pointer.
                pDeviceBroadcastHeader = Marshal.AllocHGlobal(Marshal.SizeOf(DeviceBroadcastHeader)); //allocate memory for a new DEV_BROADCAST_DEVICEINTERFACE structure, and return the address 
                Marshal.StructureToPtr(DeviceBroadcastHeader, pDeviceBroadcastHeader, false);  //Copies the DeviceBroadcastHeader structure into the memory already allocated at DeviceBroadcastHeaderWithPointer
                RegisterDeviceNotification(this.Handle, pDeviceBroadcastHeader, DEVICE_NOTIFY_WINDOW_HANDLE);
     

			    //Now make an initial attempt to find the USB device, if it was already connected to the PC and enumerated prior to launching the application.
			    //If it is connected and present, we should open read and write handles to the device so we can communicate with it later.
			    //If it was not connected, we will have to wait until the user plugs the device in, and the WM_DEVICECHANGE callback function can process
			    //the message and again search for the device.
			    if(CheckIfPresentAndGetUSBDevicePath())	//Check and make sure at least one device with matching VID/PID is attached
			    {
				    uint ErrorStatusWrite;
				    uint ErrorStatusRead;

				    //We now have the proper device path, and we can finally open read and write handles to the device.
                    WriteHandleToUSBDevice = CreateFile(DevicePath, GENERIC_WRITE, FILE_SHARE_READ | FILE_SHARE_WRITE, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                    ErrorStatusWrite = (uint)Marshal.GetLastWin32Error();
                    ReadHandleToUSBDevice = CreateFile(DevicePath, GENERIC_READ, FILE_SHARE_READ | FILE_SHARE_WRITE, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                    ErrorStatusRead = (uint)Marshal.GetLastWin32Error();

				    if((ErrorStatusWrite == ERROR_SUCCESS) && (ErrorStatusRead == ERROR_SUCCESS))
				    {
					    AttachedState = true;		//Let the rest of the PC application know the USB device is connected, and it is safe to read/write to it
					    AttachedButBroken = false;
                        StatusBox_lbl.Text = "デバイス検出済";
				    }
				    else //for some reason the device was physically plugged in, but one or both of the read/write handles didn't open successfully...
				    {
					    AttachedState = false;		//Let the rest of this application known not to read/write to the device.
					    AttachedButBroken = true;	//Flag so that next time a WM_DEVICECHANGE message occurs, can retry to re-open read/write pipes
					    if(ErrorStatusWrite == ERROR_SUCCESS)
						    WriteHandleToUSBDevice.Close();
					    if(ErrorStatusRead == ERROR_SUCCESS)
						    ReadHandleToUSBDevice.Close();
				    }
			    }
			    else	//Device must not be connected (or not programmed with correct firmware)
			    {
				    AttachedState = false;
				    AttachedButBroken = false;
			    }

                if (AttachedState == true)
                {
                    StatusBox_lbl.Text = "デバイス検出済";
                }
                else
                {
                    StatusBox_lbl.Text = "デバイス未検出";
                }

			    ReadWriteThread.RunWorkerAsync();	//Recommend performing USB read/write operations in a separate thread.  Otherwise,
												    //the Read/Write operations are effectively blocking functions and can lock up the
												    //user interface if the I/O operations take a long time to complete.
            }
            catch
            {
            }

            //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------

        //FUNCTION:	CheckIfPresentAndGetUSBDevicePath()
        //PURPOSE:	Check if a USB device is currently plugged in with a matching VID and PID
        //INPUT:	Uses globally declared String DevicePath, globally declared GUID, and the MY_DEVICE_ID constant.
        //OUTPUT:	Returns BOOL.  TRUE when device with matching VID/PID found.  FALSE if device with VID/PID could not be found.
        //			When returns TRUE, the globally accessable "DetailedInterfaceDataStructure" will contain the device path
        //			to the USB device with the matching VID/PID.
        bool CheckIfPresentAndGetUSBDevicePath()
        {
		    /* 
		    Before we can "connect" our application to our USB embedded device, we must first find the device.
		    A USB bus can have many devices simultaneously connected, so somehow we have to find our device only.
		    This is done with the Vendor ID (VID) and Product ID (PID).  Each USB product line should have
		    a unique combination of VID and PID.  

		    Microsoft has created a number of functions which are useful for finding plug and play devices.  Documentation
		    for each function used can be found in the MSDN library.  We will be using the following functions (unmanaged C functions):

		    SetupDiGetClassDevs()					//provided by setupapi.dll, which comes with Windows
		    SetupDiEnumDeviceInterfaces()			//provided by setupapi.dll, which comes with Windows
		    GetLastError()							//provided by kernel32.dll, which comes with Windows
		    SetupDiDestroyDeviceInfoList()			//provided by setupapi.dll, which comes with Windows
		    SetupDiGetDeviceInterfaceDetail()		//provided by setupapi.dll, which comes with Windows
		    SetupDiGetDeviceRegistryProperty()		//provided by setupapi.dll, which comes with Windows
		    CreateFile()							//provided by kernel32.dll, which comes with Windows

            In order to call these unmanaged functions, the Marshal class is very useful.
             
		    We will also be using the following unusual data types and structures.  Documentation can also be found in
		    the MSDN library:

		    PSP_DEVICE_INTERFACE_DATA
		    PSP_DEVICE_INTERFACE_DETAIL_DATA
		    SP_DEVINFO_DATA
		    HDEVINFO
		    HANDLE
		    GUID

		    The ultimate objective of the following code is to get the device path, which will be used elsewhere for getting
		    read and write handles to the USB device.  Once the read/write handles are opened, only then can this
		    PC application begin reading/writing to the USB device using the WriteFile() and ReadFile() functions.

		    Getting the device path is a multi-step round about process, which requires calling several of the
		    SetupDixxx() functions provided by setupapi.dll.
		    */

            try
            {
		        IntPtr DeviceInfoTable = IntPtr.Zero;
		        SP_DEVICE_INTERFACE_DATA InterfaceDataStructure = new SP_DEVICE_INTERFACE_DATA();
                SP_DEVICE_INTERFACE_DETAIL_DATA DetailedInterfaceDataStructure = new SP_DEVICE_INTERFACE_DETAIL_DATA();
                SP_DEVINFO_DATA DevInfoData = new SP_DEVINFO_DATA();

		        uint InterfaceIndex = 0;
		        uint dwRegType = 0;
		        uint dwRegSize = 0;
                uint dwRegSize2 = 0;
		        uint StructureSize = 0;
		        IntPtr PropertyValueBuffer = IntPtr.Zero;
		        bool MatchFound = false;
                bool MatchFound2 = false;
                uint ErrorStatus;
		        uint LoopCounter = 0;

                //Use the formatting: "Vid_xxxx&Pid_xxxx" where xxxx is a 16-bit hexadecimal number.
                //Make sure the value appearing in the parathesis matches the USB device descriptor
                //of the device that this aplication is intending to find.
                String DeviceIDToFind = "Vid_22ea&Pid_001E";
                String DeviceIDToFind2 = "Mi_03";

		        //First populate a list of plugged in devices (by specifying "DIGCF_PRESENT"), which are of the specified class GUID. 
		        DeviceInfoTable = SetupDiGetClassDevs(ref InterfaceClassGuid, IntPtr.Zero, IntPtr.Zero, DIGCF_PRESENT | DIGCF_DEVICEINTERFACE);

                if(DeviceInfoTable != IntPtr.Zero)
                {
		            //Now look through the list we just populated.  We are trying to see if any of them match our device. 
		            while(true)
		            {
                        InterfaceDataStructure.cbSize = (uint)Marshal.SizeOf(InterfaceDataStructure);
			            if(SetupDiEnumDeviceInterfaces(DeviceInfoTable, IntPtr.Zero, ref InterfaceClassGuid, InterfaceIndex, ref InterfaceDataStructure))
			            {
                            ErrorStatus = (uint)Marshal.GetLastWin32Error();
                            if (ErrorStatus == ERROR_NO_MORE_ITEMS)	//Did we reach the end of the list of matching devices in the DeviceInfoTable?
				            {	//Cound not find the device.  Must not have been attached.
					            SetupDiDestroyDeviceInfoList(DeviceInfoTable);	//Clean up the old structure we no longer need.
					            return false;		
				            }
			            }
			            else	//Else some other kind of unknown error ocurred...
			            {
                            ErrorStatus = (uint)Marshal.GetLastWin32Error();
				            SetupDiDestroyDeviceInfoList(DeviceInfoTable);	//Clean up the old structure we no longer need.
				            return false;	
			            }

			            //Now retrieve the hardware ID from the registry.  The hardware ID contains the VID and PID, which we will then 
			            //check to see if it is the correct device or not.

			            //Initialize an appropriate SP_DEVINFO_DATA structure.  We need this structure for SetupDiGetDeviceRegistryProperty().
                        DevInfoData.cbSize = (uint)Marshal.SizeOf(DevInfoData);
			            SetupDiEnumDeviceInfo(DeviceInfoTable, InterfaceIndex, ref DevInfoData);

			            //First query for the size of the hardware ID, so we can know how big a buffer to allocate for the data.
			            SetupDiGetDeviceRegistryProperty(DeviceInfoTable, ref DevInfoData, SPDRP_HARDWAREID, ref dwRegType, IntPtr.Zero, 0, ref dwRegSize);

			            //Allocate a buffer for the hardware ID.
                        //Should normally work, but could throw exception "OutOfMemoryException" if not enough resources available.
                        PropertyValueBuffer = Marshal.AllocHGlobal((int)dwRegSize);

			            //Retrieve the hardware IDs for the current device we are looking at.  PropertyValueBuffer gets filled with a 
			            //REG_MULTI_SZ (array of null terminated strings).  To find a device, we only care about the very first string in the
			            //buffer, which will be the "device ID".  The device ID is a string which contains the VID and PID, in the example 
			            //format "Vid_04d8&Pid_003f".
                        SetupDiGetDeviceRegistryProperty(DeviceInfoTable, ref DevInfoData, SPDRP_HARDWAREID, ref dwRegType, PropertyValueBuffer, dwRegSize, ref dwRegSize2);

			            //Now check if the first string in the hardware ID matches the device ID of the USB device we are trying to find.
			            String DeviceIDFromRegistry = Marshal.PtrToStringUni(PropertyValueBuffer); //Make a new string, fill it with the contents from the PropertyValueBuffer

			            Marshal.FreeHGlobal(PropertyValueBuffer);		//No longer need the PropertyValueBuffer, free the memory to prevent potential memory leaks

			            //Convert both strings to lower case.  This makes the code more robust/portable accross OS Versions
			            DeviceIDFromRegistry = DeviceIDFromRegistry.ToLowerInvariant();	
			            DeviceIDToFind = DeviceIDToFind.ToLowerInvariant();
                        DeviceIDToFind2 = DeviceIDToFind2.ToLowerInvariant();
                        //Now check if the hardware ID we are looking at contains the correct VID/PID
			            MatchFound = DeviceIDFromRegistry.Contains(DeviceIDToFind);
                        MatchFound2 = DeviceIDFromRegistry.Contains(DeviceIDToFind2);
                        if (MatchFound == true && MatchFound2 == true)
			            {
                            //Device must have been found.  In order to open I/O file handle(s), we will need the actual device path first.
				            //We can get the path by calling SetupDiGetDeviceInterfaceDetail(), however, we have to call this function twice:  The first
				            //time to get the size of the required structure/buffer to hold the detailed interface data, then a second time to actually 
				            //get the structure (after we have allocated enough memory for the structure.)
                            DetailedInterfaceDataStructure.cbSize = (uint)Marshal.SizeOf(DetailedInterfaceDataStructure);
				            //First call populates "StructureSize" with the correct value
				            SetupDiGetDeviceInterfaceDetail(DeviceInfoTable, ref InterfaceDataStructure, IntPtr.Zero, 0, ref StructureSize, IntPtr.Zero);
                            //Need to call SetupDiGetDeviceInterfaceDetail() again, this time specifying a pointer to a SP_DEVICE_INTERFACE_DETAIL_DATA buffer with the correct size of RAM allocated.
                            //First need to allocate the unmanaged buffer and get a pointer to it.
                            IntPtr pUnmanagedDetailedInterfaceDataStructure = IntPtr.Zero;  //Declare a pointer.
                            pUnmanagedDetailedInterfaceDataStructure = Marshal.AllocHGlobal((int)StructureSize);    //Reserve some unmanaged memory for the structure.
                            DetailedInterfaceDataStructure.cbSize = 6; //Initialize the cbSize parameter (4 bytes for DWORD + 2 bytes for unicode null terminator)
                            Marshal.StructureToPtr(DetailedInterfaceDataStructure, pUnmanagedDetailedInterfaceDataStructure, false); //Copy managed structure contents into the unmanaged memory buffer.

                            //Now call SetupDiGetDeviceInterfaceDetail() a second time to receive the device path in the structure at pUnmanagedDetailedInterfaceDataStructure.
                            if (SetupDiGetDeviceInterfaceDetail(DeviceInfoTable, ref InterfaceDataStructure, pUnmanagedDetailedInterfaceDataStructure, StructureSize, IntPtr.Zero, IntPtr.Zero))
                            {
                                //Need to extract the path information from the unmanaged "structure".  The path starts at (pUnmanagedDetailedInterfaceDataStructure + sizeof(DWORD)).
                                IntPtr pToDevicePath = new IntPtr((uint)pUnmanagedDetailedInterfaceDataStructure.ToInt32() + 4);  //Add 4 to the pointer (to get the pointer to point to the path, instead of the DWORD cbSize parameter)
                                DevicePath = Marshal.PtrToStringUni(pToDevicePath); //Now copy the path information into the globally defined DevicePath String.
                                
                                //We now have the proper device path, and we can finally use the path to open I/O handle(s) to the device.
                                SetupDiDestroyDeviceInfoList(DeviceInfoTable);	//Clean up the old structure we no longer need.
                                Marshal.FreeHGlobal(pUnmanagedDetailedInterfaceDataStructure);  //No longer need this unmanaged SP_DEVICE_INTERFACE_DETAIL_DATA buffer.  We already extracted the path information.
                                return true;    //Returning the device path in the global DevicePath String
                            }
                            else //Some unknown failure occurred
                            {
                                uint ErrorCode = (uint)Marshal.GetLastWin32Error();
                                SetupDiDestroyDeviceInfoList(DeviceInfoTable);	//Clean up the old structure.
                                Marshal.FreeHGlobal(pUnmanagedDetailedInterfaceDataStructure);  //No longer need this unmanaged SP_DEVICE_INTERFACE_DETAIL_DATA buffer.  We already extracted the path information.
                                return false;    
                            }
                        }

			            InterfaceIndex++;	
			            //Keep looping until we either find a device with matching VID and PID, or until we run out of devices to check.
			            //However, just in case some unexpected error occurs, keep track of the number of loops executed.
			            //If the number of loops exceeds a very large number, exit anyway, to prevent inadvertent infinite looping.
			            LoopCounter++;
			            if(LoopCounter == 10000000)	//Surely there aren't more than 10 million devices attached to any forseeable PC...
			            {
				            return false;
			            }
		            }//end of while(true)
                }
                return false;
            }//end of try
            catch
            {
                //Something went wrong if PC gets here.  Maybe a Marshal.AllocHGlobal() failed due to insufficient resources or something.
			    return false;	
            }
        }
        //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------
        //This is a callback function that gets called when a Windows message is received by the form.
        //We will receive various different types of messages, but the ones we really want to use are the WM_DEVICECHANGE messages.
        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    if (((int)m.WParam == DBT_DEVICEARRIVAL) || ((int)m.WParam == DBT_DEVICEREMOVEPENDING) || ((int)m.WParam == DBT_DEVICEREMOVECOMPLETE) || ((int)m.WParam == DBT_CONFIGCHANGED))
                    {
                        //WM_DEVICECHANGE messages by themselves are quite generic, and can be caused by a number of different
                        //sources, not just your USB hardware device.  Therefore, must check to find out if any changes relavant
                        //to your device (with known VID/PID) took place before doing any kind of opening or closing of handles/endpoints.
                        //(the message could have been totally unrelated to your application/USB device)

                        if (CheckIfPresentAndGetUSBDevicePath())	//Check and make sure at least one device with matching VID/PID is attached
                        {
                            //If executes to here, this means the device is currently attached and was found.
                            //This code needs to decide however what to do, based on whether or not the device was previously known to be
                            //attached or not.
                            if ((AttachedState == false) || (AttachedButBroken == true))	//Check the previous attachment state
                            {
                                uint ErrorStatusWrite;
                                uint ErrorStatusRead;

                                //We obtained the proper device path (from CheckIfPresentAndGetUSBDevicePath() function call), and it
                                //is now possible to open read and write handles to the device.
                                WriteHandleToUSBDevice = CreateFile(DevicePath, GENERIC_WRITE, FILE_SHARE_READ | FILE_SHARE_WRITE, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                                ErrorStatusWrite = (uint)Marshal.GetLastWin32Error();
                                ReadHandleToUSBDevice = CreateFile(DevicePath, GENERIC_READ, FILE_SHARE_READ | FILE_SHARE_WRITE, IntPtr.Zero, OPEN_EXISTING, 0, IntPtr.Zero);
                                ErrorStatusRead = (uint)Marshal.GetLastWin32Error();

                                if ((ErrorStatusWrite == ERROR_SUCCESS) && (ErrorStatusRead == ERROR_SUCCESS))
                                {
                                    AttachedState = true;		//Let the rest of the PC application know the USB device is connected, and it is safe to read/write to it
                                    AttachedButBroken = false;
                                    StatusBox_lbl.Text = "デバイス検出済";
                                }
                                else //for some reason the device was physically plugged in, but one or both of the read/write handles didn't open successfully...
                                {
                                    AttachedState = false;		//Let the rest of this application known not to read/write to the device.
                                    AttachedButBroken = true;	//Flag so that next time a WM_DEVICECHANGE message occurs, can retry to re-open read/write pipes
                                    if (ErrorStatusWrite == ERROR_SUCCESS)
                                        WriteHandleToUSBDevice.Close();
                                    if (ErrorStatusRead == ERROR_SUCCESS)
                                        ReadHandleToUSBDevice.Close();
                                }
                            }
                            //else we did find the device, but AttachedState was already true.  In this case, don't do anything to the read/write handles,
                            //since the WM_DEVICECHANGE message presumably wasn't caused by our USB device.  
                        }
                        else	//Device must not be connected (or not programmed with correct firmware)
                        {
                            if (AttachedState == true)		//If it is currently set to true, that means the device was just now disconnected
                            {
                                AttachedState = false;
                                WriteHandleToUSBDevice.Close();
                                ReadHandleToUSBDevice.Close();
                            }
                            AttachedState = false;
                            AttachedButBroken = false;
                        }
                    }
                } //end of: if(m.Msg == WM_DEVICECHANGE)

                base.WndProc(ref m);
            }
            catch
            {
            }
        } //end of: WndProc() function
        //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Changevalue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                my_EEPROM_DATA[SetPin_selected].change_flag = 1;                //変更フラグ
                my_EEPROM_DATA[SetPin_selected].mode = DeviceType_selected;     //デバイス
                // 各デバイスごとの設定値をセット
                switch (DeviceType_selected)
                {
                    case Constants.MODE_MOUSE:
                        my_EEPROM_DATA[SetPin_selected].value = MouseValue_selected;
                        my_EEPROM_DATA[SetPin_selected].modifier = MouseMoveValue_selected;
                        break;
                    case Constants.MODE_KEYBOARD:
                        my_EEPROM_DATA[SetPin_selected].value = KeyboardValue_selected;
                        my_EEPROM_DATA[SetPin_selected].modifier = KeyboardModifier_selected;
                        break;
                    case Constants.MODE_VOLUME:
                        my_EEPROM_DATA[SetPin_selected].value = VolumeValue_selected;
                        break;
                    //case Constants.MODE_JOYSTICK:
                    //    my_EEPROM_DATA[SetPin_selected].value = LeverValue_selected;
                    //    my_EEPROM_DATA[SetPin_selected].value |= ButtonValue_selected2;
                    //    my_EEPROM_DATA[SetPin_selected].modifier = ButtonValue_selected;
                        //break;
                }
                // 赤外線コードを読み込んでいたら更新
                if (RemoconReceiveData[0] != 0)
                {
                    my_EEPROM_DATA[SetPin_selected].reader_code = RemoconReceiveData[0];        //リーダコード
                    for (int i = 0; i < Constants.EEPROM_DATA_DATA_SIZE; i++)
                    {
                        my_EEPROM_DATA[SetPin_selected].data[i] = RemoconReceiveData[i + 1];    //データコード
                    }

                    StatusBoxChange = SetPin_selected;
                } 
                //MEMO
                string s_key = "MEMO" + string.Format("{0:00}", SetPin_selected + 1);
                global::USB_IR_REMOCON_CT.Properties.Settings.Default[s_key] = Memo_txt.Text;
                global::USB_IR_REMOCON_CT.Properties.Settings.Default.Save();
               
                Changevalue_btn_pressed = true;
            }
            catch
            {
            }
        }

        delegate void SetONPictureDelegate();

        void SetONPicture()
        {
            if (InvokeRequired)
            {
                // 別スレッドから呼び出された場合
                Invoke(new SetONPictureDelegate(SetONPicture));
                return;
            }
            myPictureBoxON[SetPin_selected].Visible = true;
            tmrONFlag.Enabled = true;
        }

        private void ReadWriteThread_DoWork(object sender, DoWorkEventArgs e)
        {
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------

            /*This thread does the actual USB read/write operations (but only when AttachedState == true) to the USB device.
            It is generally preferrable to write applications so that read and write operations are handled in a separate
            thread from the main form.  This makes it so that the main form can remain responsive, even if the I/O operations
            take a very long time to complete.

            Since this is a separate thread, this code below executes independently from the rest of the
            code in this application.  All this thread does is read and write to the USB device.  It does not update
            the form directly with the new information it obtains (such as the ANxx/POT Voltage or pushbutton state).
            The information that this thread obtains is stored in atomic global variables.
            Form updates are handled by the FormUpdateTimer Tick event handler function.

            This application sends packets to the endpoint buffer on the USB device by using the "WriteFile()" function.
            This application receives packets from the endpoint buffer on the USB device by using the "ReadFile()" function.
            Both of these functions are documented in the MSDN library.  Calling ReadFile() is a not perfectly straight
            foward in C# environment, since one of the input parameters is a pointer to a buffer that gets filled by ReadFile().
            The ReadFile() function is therefore called through a wrapper function ReadFileManagedBuffer().

            All ReadFile() and WriteFile() operations in this example project are synchronous.  They are blocking function
            calls and only return when they are complete, or if they fail because of some event, such as the user unplugging
            the device.  It is possible to call these functions with "overlapped" structures, and use them as non-blocking
            asynchronous I/O function calls.  

            Note:  This code may perform differently on some machines when the USB device is plugged into the host through a
            USB 2.0 hub, as opposed to a direct connection to a root port on the PC.  In some cases the data rate may be slower
            when the device is connected through a USB 2.0 hub.  This performance difference is believed to be caused by
            the issue described in Microsoft knowledge base article 940021:
            http://support.microsoft.com/kb/940021/en-us 

            Higher effective bandwidth (up to the maximum offered by interrupt endpoints), both when connected
            directly and through a USB 2.0 hub, can generally be achieved by queuing up multiple pending read and/or
            write requests simultaneously.  This can be done when using	asynchronous I/O operations (calling ReadFile() and
            WriteFile()	with overlapped structures).  The Microchip	HID USB Bootloader application uses asynchronous I/O
            for some USB operations and the source code can be used	as an example.*/

            Byte[] OUTBuffer = new byte[65];	//Allocate a memory buffer equal to the OUT endpoint size + 1
		    Byte[] INBuffer = new byte[65];		//Allocate a memory buffer equal to the IN endpoint size + 1
		    uint BytesWritten = 0;
		    uint BytesRead = 0;

		    while(true)
		    {
                try
                {
                    if (AttachedState == true)	//Do not try to use the read/write handles unless the USB device is attached and ready
                    {
                        //Get ANxx/POT Voltage value from the microcontroller firmware.  Note: some demo boards may not have a pot
                        //on them.  In this case, the firmware may be configured to read an ANxx I/O pin voltage with the ADC
                        //instead.  If this is the case, apply a proper voltage to the pin.  See the firmware for exact implementation.

                        if (ReadFromDevice == true)
                        {
                            ReadFromDevice = false;

                            int Loopi_num, Loopj_num;
                            Loopi_num = Constants.EEPROM_DATA_NUM / (63 / Constants.EEPROM_DATA_SIZE) + 1;
                            Loopj_num =(63 / Constants.EEPROM_DATA_SIZE);
                            for (int i = 0; i < Loopi_num; i++)
                            {
                                OUTBuffer[0] = 0x00;	//The first byte is the "Report ID" and does not get sent over the USB bus.  Always set = 0.
                                OUTBuffer[1] = 0x82;	//READ_POT command (see the firmware source code), gets 10-bit ADC Value
                                OUTBuffer[2] = (byte)(i * Loopj_num * Constants.EEPROM_DATA_SIZE);
                                OUTBuffer[3] = (byte)(Loopj_num * Constants.EEPROM_DATA_SIZE);
                                if (OUTBuffer[2] + OUTBuffer[3] > Constants.EEPROM_DATA_NUM * Constants.EEPROM_DATA_SIZE)
                                {
                                    OUTBuffer[3] = (byte)(Constants.EEPROM_DATA_NUM * Constants.EEPROM_DATA_SIZE - OUTBuffer[2]);
                                }
                                //Initialize the rest of the 64-byte packet to "0xFF".  Binary '1' bits do not use as much power, and do not cause as much EMI
                                //when they move across the USB cable.  USB traffic is "NRZI" encoded, where '1' bits do not cause the D+/D- signals to toggle states.
                                //This initialization is not strictly necessary however.
                                for (uint fi = 4; fi < 65; fi++)
                                    OUTBuffer[fi] = 0xFF;

                                //To get the ADCValue, first, we send a packet with our "READ_POT" command in it.
                                if (WriteFile(WriteHandleToUSBDevice, OUTBuffer, 65, ref BytesWritten, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                {
                                    INBuffer[0] = 0;
                                    //Now get the response packet from the firmware.
                                    if (ReadFileManagedBuffer(ReadHandleToUSBDevice, INBuffer, 65, ref BytesRead, IntPtr.Zero))		//Blocking function, unless an "overlapped" structure is used	
                                    {
                                        //INBuffer[0] is the report ID, which we don't care about.
                                        //INBuffer[1] is an echo back of the command (see microcontroller firmware).
                                        if (INBuffer[1] == 0x82 && INBuffer[2] == OUTBuffer[3])
                                        {
                                            for (int j = 0; j < Loopj_num; j++)
                                            {
                                                if (i * Loopj_num + j < Constants.EEPROM_DATA_NUM)
                                                {
                                                    if (INBuffer[j * Constants.EEPROM_DATA_SIZE + 3] == 0xFF)
                                                    {   // EEPROM ALL 0xFFのときは0x00にする
                                                        my_EEPROM_DATA[i * Loopj_num + j].mode = 0x00;
                                                        my_EEPROM_DATA[i * Loopj_num + j].value = 0x00;
                                                        my_EEPROM_DATA[i * Loopj_num + j].modifier = 0x00;
                                                        my_EEPROM_DATA[i * Loopj_num + j].reader_code = 0x00;
                                                        for (int k = 0; k < Constants.EEPROM_DATA_DATA_SIZE; k++)
                                                        {
                                                            my_EEPROM_DATA[i * Loopj_num + j].data[k] = 0x00;
                                                        }
                                                    }
                                                    else
                                                    {   // EEPROMの値を設定する
                                                        my_EEPROM_DATA[i * Loopj_num + j].mode = INBuffer[j * Constants.EEPROM_DATA_SIZE + 3];
                                                        my_EEPROM_DATA[i * Loopj_num + j].value = INBuffer[j * Constants.EEPROM_DATA_SIZE + 4];
                                                        my_EEPROM_DATA[i * Loopj_num + j].modifier = INBuffer[j * Constants.EEPROM_DATA_SIZE + 5];
                                                        my_EEPROM_DATA[i * Loopj_num + j].reader_code = INBuffer[j * Constants.EEPROM_DATA_SIZE + 6];
                                                        for (int k = 0; k < Constants.EEPROM_DATA_DATA_SIZE; k++)
                                                        {
                                                            my_EEPROM_DATA[i * Loopj_num + j].data[k] = INBuffer[j * Constants.EEPROM_DATA_SIZE + 7 + k];
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Get the pushbutton state from the microcontroller firmware.
                        OUTBuffer[0] = 0;			//The first byte is the "Report ID" and does not get sent over the USB bus.  Always set = 0.
                        OUTBuffer[1] = 0x40;		//0x81 is the "Get Pushbutton State" command in the firmware
                        for (uint i = 2; i < 65; i++)	//This loop is not strictly necessary.  Simply initializes unused bytes to
                            OUTBuffer[i] = 0xFF;				//0xFF for lower EMI and power consumption when driving the USB cable.

                        //To get the pushbutton state, first, we send a packet with our "Get Pushbutton State" command in it.
                        if (WriteFile(WriteHandleToUSBDevice, OUTBuffer, 65, ref BytesWritten, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                        {
                            //Now get the response packet from the firmware.
                            INBuffer[0] = 0;
                            {
                                if (ReadFileManagedBuffer(ReadHandleToUSBDevice, INBuffer, 65, ref BytesRead, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                {
                                    //INBuffer[0] is the report ID, which we don't care about.
                                    //INBuffer[1] is an echo back of the command (see microcontroller firmware).
                                    //INBuffer[2] contains the I/O port pin value for the pushbutton (see microcontroller firmware).  
                                    if (INBuffer[1] == 0x40)
                                    {
                                        Debug_1 = (int)(INBuffer[2]);
                                        Debug_2 = (int)(INBuffer[3]);
                                        Debug_3 = (int)(INBuffer[4]);
                                        Debug_4 = (int)(INBuffer[5]);
                                        Debug_5 = (int)(INBuffer[6]);
                                        Debug_6 = (int)(INBuffer[7]);
                                        Debug_7 = (int)(INBuffer[8]);
                                        Debug_8 = (int)(INBuffer[9]);
                                        Debug_9 = (int)(INBuffer[10]);
                                        //Debug_3++;
                                    }
                                }
                            }
                        }
                        //Get the pushbutton state from the microcontroller firmware.
                        OUTBuffer[0] = 0;			//The first byte is the "Report ID" and does not get sent over the USB bus.  Always set = 0.
                        OUTBuffer[1] = 0x41;		//0x81 is the "Get Pushbutton State" command in the firmware
                        for (uint i = 2; i < 65; i++)	//This loop is not strictly necessary.  Simply initializes unused bytes to
                            OUTBuffer[i] = 0xFF;				//0xFF for lower EMI and power consumption when driving the USB cable.

                        //To get the pushbutton state, first, we send a packet with our "Get Pushbutton State" command in it.
                        if (WriteFile(WriteHandleToUSBDevice, OUTBuffer, 65, ref BytesWritten, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                        {
                            //Now get the response packet from the firmware.
                            INBuffer[0] = 0;
                            {
                                if (ReadFileManagedBuffer(ReadHandleToUSBDevice, INBuffer, 65, ref BytesRead, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                {
                                    //INBuffer[0] is the report ID, which we don't care about.
                                    //INBuffer[1] is an echo back of the command (see microcontroller firmware).
                                    //INBuffer[2] contains the I/O port pin value for the pushbutton (see microcontroller firmware).  
                                    if (INBuffer[1] == 0x41)
                                    {
                                        for (int fi = 0; fi < 7; fi++)
                                        {
                                            Debug_Arr[fi] = INBuffer[fi + 2];
                                        }
                                    }
                                }
                            }
                        }

                        /* 受信待ちモード変更？ */
                        if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT)
                        {
                            //Get the pushbutton state from the microcontroller firmware.
                            OUTBuffer[0] = 0;			//The first byte is the "Report ID" and does not get sent over the USB bus.  Always set = 0.
                            OUTBuffer[1] = 0x50;		//0x50 is the "Get Remocon Data" command in the firmware
                            for (uint i = 2; i < 65; i++)	//This loop is not strictly necessary.  Simply initializes unused bytes to
                                OUTBuffer[i] = 0xFF;				//0xFF for lower EMI and power consumption when driving the USB cable.

                            //To get the pushbutton state, first, we send a packet with our "Get Pushbutton State" command in it.
                            if (WriteFile(WriteHandleToUSBDevice, OUTBuffer, 65, ref BytesWritten, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                            {
                                //Now get the response packet from the firmware.
                                INBuffer[0] = 0;
                                {
                                    if (ReadFileManagedBuffer(ReadHandleToUSBDevice, INBuffer, 65, ref BytesRead, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                    {
                                        //INBuffer[0] is the report ID, which we don't care about.
                                        //INBuffer[1] is an echo back of the command (see microcontroller firmware).
                                        //INBuffer[2] contains the I/O port pin value for the pushbutton (see microcontroller firmware).  
                                        if (INBuffer[1] == 0x50 && INBuffer[2] != 0)
                                        {
                                            for (int fi = 0; fi < 7; fi++)
                                            {
                                                RemoconReceiveData[fi] = INBuffer[fi+2];
                                            }
                                            i_receive_wait_mode = Constants.RECEIVE_WAIT_MODE_NONE_CHG;
                                            //Receive_btn.Text = Constants.RECEIVE_WAIT_MODE_NONE_STR;
                                            Receive_btn_Click(null, EventArgs.Empty);
                                            // ON画像表示
                                            SetONPicture();
                                        }
                                    }
                                }
                            }
                        }
                        /* 受信待ちモード変更？ */
                        if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT_CHG || i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_NONE_CHG)
                        {
                            //Get the pushbutton state from the microcontroller firmware.
                            OUTBuffer[0] = 0;			//The first byte is the "Report ID" and does not get sent over the USB bus.  Always set = 0.
                            OUTBuffer[1] = 0x51;		//0x51 is the "Set Remocon Data Receive Mode" command in the firmware
                            if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT_CHG)
                            {
                                OUTBuffer[2] = (byte)Constants.RECEIVE_WAIT_MODE_WAIT;
                            }
                            else
                            {
                                OUTBuffer[2] = (byte)Constants.RECEIVE_WAIT_MODE_NONE;
                            }
                            for (uint i = 3; i < 65; i++)	//This loop is not strictly necessary.  Simply initializes unused bytes to
                                OUTBuffer[i] = 0xFF;				//0xFF for lower EMI and power consumption when driving the USB cable.

                            //To get the pushbutton state, first, we send a packet with our "Get Pushbutton State" command in it.
                            if (WriteFile(WriteHandleToUSBDevice, OUTBuffer, 65, ref BytesWritten, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                            {
                                //Now get the response packet from the firmware.
                                INBuffer[0] = 0;
                                {
                                    if (ReadFileManagedBuffer(ReadHandleToUSBDevice, INBuffer, 65, ref BytesRead, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                    {
                                        //INBuffer[0] is the report ID, which we don't care about.
                                        //INBuffer[1] is an echo back of the command (see microcontroller firmware).
                                        //INBuffer[2] contains the I/O port pin value for the pushbutton (see microcontroller firmware).  
                                        if (INBuffer[1] == 0x51)
                                        {
                                            /* OKアンサ */
                                            if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT_CHG)
                                            {
                                                i_receive_wait_mode = Constants.RECEIVE_WAIT_MODE_WAIT;
                                            }
                                            else
                                            {
                                                i_receive_wait_mode = Constants.RECEIVE_WAIT_MODE_NONE;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        //Check if this thread should send a Toggle LED(s) command to the firmware.  ToggleLEDsPending will get set
                        //by the ToggleLEDs_btn click event handler function if the user presses the button on the form.
                        if (Changevalue_btn_pressed == true)
                        {
                            for (uint i = 0; i < Constants.EEPROM_DATA_NUM; i++)
                            {
                                // 変更あり？
                                if (my_EEPROM_DATA[i].change_flag > 0)
                                {
                                    // 変更フラグクリア
                                    my_EEPROM_DATA[i].change_flag = 0;
                                    // 割付変更フラグセット
                                    ChangeAssign[i] = true;

                                    for (uint j = 0; j < 65; j++)	//This loop is not strictly necessary.  Simply initializes unused bytes to
                                        OUTBuffer[j] = 0xFF;		//0xFF for lower EMI and power consumption when driving the USB cable.

                                    OUTBuffer[0] = 0;				//The first byte is the "Report ID" and does not get sent over the USB bus.  Always set = 0.
                                    OUTBuffer[1] = 0x81;			//0x80 is the "Toggle LED(s)" command in the firmware
                                    OUTBuffer[2] = (byte)(i + 1);   // データNo.
                                    OUTBuffer[3] = (byte)Constants.EEPROM_DATA_SIZE;    //送信サイズ
                                    OUTBuffer[4] = my_EEPROM_DATA[i].mode;
                                    OUTBuffer[5] = my_EEPROM_DATA[i].value;
                                    OUTBuffer[6] = my_EEPROM_DATA[i].modifier;
                                    OUTBuffer[7] = my_EEPROM_DATA[i].reader_code;

                                    for (uint j = 0; j < Constants.EEPROM_DATA_DATA_SIZE; j++)
                                    {
                                        OUTBuffer[j + 8] = my_EEPROM_DATA[i].data[j];
                                    }

                                    //To get the pushbutton state, first, we send a packet with our "Get Pushbutton State" command in it.
                                    if (WriteFile(WriteHandleToUSBDevice, OUTBuffer, 65, ref BytesWritten, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                    {
                                        //Now get the response packet from the firmware.
                                        INBuffer[0] = 0;
                                        {
                                            if (ReadFileManagedBuffer(ReadHandleToUSBDevice, INBuffer, 65, ref BytesRead, IntPtr.Zero))	//Blocking function, unless an "overlapped" structure is used
                                            {
                                                //INBuffer[0] is the report ID, which we don't care about.
                                                //INBuffer[1] is an echo back of the command (see microcontroller firmware).
                                                //INBuffer[2] contains the I/O port pin value for the pushbutton (see microcontroller firmware).  
                                                if (INBuffer[1] == 0x81)
                                                {
                                                    /* OKアンサ */
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                            Changevalue_btn_pressed = false;
                            ConnectFirstTime = true;
                        }
                    } //end of: if(AttachedState == true)
                    else
                    {
                        Thread.Sleep(5);	//Add a small delay.  Otherwise, this while(true) loop can execute very fast and cause 
                                            //high CPU utilization, with no particular benefit to the application.
                    }
                }
                catch
                {
                    //Exceptions can occur during the read or write operations.  For example,
                    //exceptions may occur if for instance the USB device is physically unplugged
                    //from the host while the above read/write functions are executing.

                    //Don't need to do anything special in this case.  The application will automatically
                    //re-establish communications based on the global AttachedState boolean variable used
                    //in conjunction with the WM_DEVICECHANGE messages to dyanmically respond to Plug and Play
                    //USB connection events.
                }

		    } //end of while(true) loop
            //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void FormUpdateTimer_Tick(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------
            //This timer tick event handler function is used to update the user interface on the form, based on data
            //obtained asynchronously by the ReadWriteThread and the WM_DEVICECHANGE event handler functions.

            try
            {
                //Check if user interface on the form should be enabled or not, based on the attachment state of the USB device.
                if (AttachedState == true)
                {
                    //Device is connected and ready to communicate, enable user interface on the form 
                    StatusBox_lbl.Text = "デバイス検出済";

                    if (Now_Background_image == 0)
                    {
//                      this.BackgroundImage = global::Revive_USB_CT.Properties.Resources.BG1_connect;
//                        BackGround_pb.Image = global::Revive_USB_CT.Properties.Resources.BG_ON;
                        Now_Background_image = 1;
                    }

                    Label[] templbls = new Label[] { DeviceAssign_lbl1, DeviceAssign_lbl2, DeviceAssign_lbl3, DeviceAssign_lbl4, DeviceAssign_lbl5, DeviceAssign_lbl6, DeviceAssign_lbl7, DeviceAssign_lbl8, DeviceAssign_lbl9, DeviceAssign_lbl10, 
                                                    DeviceAssign_lbl11, DeviceAssign_lbl12, DeviceAssign_lbl13, DeviceAssign_lbl14, DeviceAssign_lbl15, DeviceAssign_lbl16, DeviceAssign_lbl17, DeviceAssign_lbl18, DeviceAssign_lbl19, DeviceAssign_lbl20 };
                    Label[] templbls2 = new Label[] { devicetype_lbl1, devicetype_lbl2, devicetype_lbl3, devicetype_lbl4, devicetype_lbl5, devicetype_lbl6, devicetype_lbl7, devicetype_lbl8, devicetype_lbl9, devicetype_lbl10, 
                                                    devicetype_lbl11, devicetype_lbl12, devicetype_lbl13, devicetype_lbl14, devicetype_lbl15, devicetype_lbl16, devicetype_lbl17, devicetype_lbl18, devicetype_lbl19, devicetype_lbl20 };
                    string tempAssign = "";

                    if (ConnectFirstTime == true)
                    {
                        Changevalue_btn.Enabled = true;
                        SetPin_combox.Enabled = true;
                        devicetype_combox.Enabled = true;
                        Memo_txt.Enabled = true;

                        Status_C_pb.Visible = true;
                        Status_NC_pb.Visible = false;

                        SetPin_combox.SelectedIndex = SetPin_selected;
                        devicetype_combox.SelectedIndex = (int)my_EEPROM_DATA[SetPin_selected].mode;

                        for (int fi = 0; fi < Constants.EEPROM_DATA_NUM; fi++)
                        {
                            // 割付変更？
                            if (ChangeAssign[fi] == true && my_EEPROM_DATA[fi].reader_code != 0)
                            {
                                //割付変更フラグクリア
                                ChangeAssign[fi] = false;
                                //StatusBoxChange = fi;
                                tempAssign = "";
                                // モード
                                switch (my_EEPROM_DATA[fi].mode & 0x0f)
                                {
                                    case Constants.MODE_MOUSE:
                                        //templbls2[fi].Text = "マウス";
                                        tempAssign = "マウス";

                                        switch (my_EEPROM_DATA[fi].value)
                                        {
                                            case 0:
                                                //templbls[fi].Text = "左クリック";
                                                tempAssign += " 左クリック";
                                                break;
                                            case 1:
                                                //templbls[fi].Text = "右クリック";
                                                tempAssign += " 右クリック";
                                                break;
                                            case 2:
                                                //templbls[fi].Text = "ホイールクリック";
                                                tempAssign += " ホイールクリック";
                                                break;
                                        }
                                        templbls[fi].Text = tempAssign;
                                        break;
                                    case Constants.MODE_KEYBOARD:
                                        //templbls2[fi].Text = "キーボード";
                                        tempAssign = "キーボード";

                                        if (my_EEPROM_DATA[fi].value != 0)
                                        {
                                            for (uint i = 0; i < 256; i++)
                                            {
                                                if (my_EEPROM_DATA[fi].value == VKtoUSBkey[i])
                                                {
                                                    //templbls[fi].Text = ((Keys)i).ToString();
                                                    tempAssign += " " + ((Keys)i).ToString();
                                                }
                                            }
                                        }

                                        if ((my_EEPROM_DATA[fi].modifier & 0x01) != 0)
                                        {
                                            //templbls[fi].Text = templbls[fi].Text.Insert(0, "Ctrl + ");
                                            tempAssign = tempAssign.Insert(6, "Ctrl + ");
                                        }
                                        if ((my_EEPROM_DATA[fi].modifier & 0x02) != 0)
                                        {
                                            //templbls[fi].Text = templbls[fi].Text.Insert(0, "Shift + ");
                                            tempAssign = tempAssign.Insert(6, "Shift + ");
                                        }
                                        if ((my_EEPROM_DATA[fi].modifier & 0x04) != 0)
                                        {
                                            //templbls[fi].Text = templbls[fi].Text.Insert(0, "Alt + ");
                                            tempAssign = tempAssign.Insert(6, "Alt + ");
                                        }
                                        if ((my_EEPROM_DATA[fi].modifier & 0x08) != 0)
                                        {
                                            //templbls[fi].Text = templbls[fi].Text.Insert(0, "Win + ");
                                            tempAssign = tempAssign.Insert(6, "Win + ");
                                        }
                                        break;
                                    case Constants.MODE_VOLUME:
                                        //templbls2[fi].Text = "ボリューム";
                                        tempAssign = "ボリューム";

                                        switch (my_EEPROM_DATA[fi].value)
                                        {
                                            case 0:
                                                //templbls[fi].Text = "アップ";
                                                tempAssign += " アップ";
                                                break;
                                            case 1:
                                                //templbls[fi].Text = "ダウン";
                                                tempAssign += " ダウン";
                                                break;
                                            case 2:
                                                //templbls[fi].Text = "ミュート";
                                                tempAssign += " ミュート";
                                                break;
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                templbls[fi].Text = tempAssign;


                                //Memo
                                string s_key = "MEMO" + string.Format("{0:00}", fi + 1);
                                string tempMemo = (string)global::USB_IR_REMOCON_CT.Properties.Settings.Default[s_key];
                                if (tempMemo.CompareTo("") == 0 || tempMemo.CompareTo("メモ") == 0)
                                {   // メモなしのときはコード表示

                                    string code_str = "";
                                    //code_str = "0x";
                                    //code_str += string.Format("{0:X2}", my_EEPROM_DATA[SetPin_selected].reader_code);
                                    for (int fj = 0; fj < Constants.EEPROM_DATA_DATA_SIZE; fj++)
                                    {
                                        code_str += string.Format("{0:X2}", my_EEPROM_DATA[fi].data[fj]);
                                    }
                                    templbls2[fi].Text = code_str;
                                }
                                else
                                {
                                    templbls2[fi].Text = tempMemo;
                                }



                            }
                            else if (ChangeAssign[fi] == true)
                            {   // リーダコードが０の時は、未割り当てとする
                                templbls[fi].Text = "Assign";
                                templbls2[fi].Text = "code or memo";
                                
                                //割付変更フラグクリア
                                ChangeAssign[fi] = false;
                            }
                        }
                        ConnectFirstTime = false;
                    }
                    if (StatusBoxChange != 99)
                    {
                        StatusBox_lbl2.Text = " ]に設定しました";
                        StatusBox_lbl2.Text = StatusBox_lbl2.Text.Insert(0, templbls[StatusBoxChange].Text);
                        StatusBox_lbl2.Text = StatusBox_lbl2.Text.Insert(0, " / ");
                        StatusBox_lbl2.Text = StatusBox_lbl2.Text.Insert(0, templbls2[StatusBoxChange].Text);
                        StatusBox_lbl2.Text = StatusBox_lbl2.Text.Insert(0, "を[ ");
                        StatusBox_lbl2.Text = StatusBox_lbl2.Text.Insert(0, "ボタン" + string.Format("{0:00}",StatusBoxChange+1) );
                        StatusBoxChange = 99;
                    }
                }
                if ((AttachedState == false) || (AttachedButBroken == true))
                {
                    //Device not available to communicate. Disable user interface on the form.
                    StatusBox_lbl.Text = "デバイス未検出";
                    if (Now_Background_image == 1)
                    {
//                        BackGround_pb.Image = global::Revive_USB_CT.Properties.Resources.BG_OFF;
//                      this.BackgroundImage = global::Revive_USB_CT.Properties.Resources.BG1_notconnect;
                        Now_Background_image = 0;
                        Status_NC_pb.Visible = true;
                        Status_C_pb.Visible = false;

                        Changevalue_btn.Enabled = false;
                        SetPin_combox.Enabled = false;
                        devicetype_combox.Enabled = false;
                    }

                    for (int fi = 0; fi < 12; fi++)
                        ChangeAssign[fi] = true;
                    ConnectFirstTime = true;
                }

//              PictureBox[] TempButton = new PictureBox[] {ButtonPressIcon1 , ButtonPressIcon2 ,ButtonPressIcon3, ButtonPressIcon4,ButtonPressIcon5, ButtonPressIcon6,ButtonPressIcon7, ButtonPressIcon8, ButtonPressIcon9, ButtonPressIcon10, ButtonPressIcon11, ButtonPressIcon12};

                //Update the various status indicators on the form with the latest info obtained from the ReadWriteThread()
                if (AttachedState == true)
                {
                    /* 受信ボタン、消去ボタンの設定 */
                    if (i_receive_del_btn_chg == 1)
                    {   // ボタン変更
                        if (my_EEPROM_DATA[SetPin_selected].reader_code == 0x00)
                        {
                            Receive_btn.Enabled = true;
                            Del_btn.Enabled = false;
                        }
                        else
                        {
                            Receive_btn.Enabled = false;
                            Del_btn.Enabled = true;
                        }
                        devicetype_combox_SelectedIndexChanged(null, EventArgs.Empty);
                        i_receive_del_btn_chg = 0;
                    }

                    /* 受信待ちでない */
                    if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_NONE || i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_NONE_CHG )
                    {
                        /* 受信待ちにする */
                        Receive_btn.Text = Constants.RECEIVE_WAIT_MODE_NONE_STR;
                    }
                    else if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT || i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT_CHG)
                    {
                        /* 受信待ち解除 */
                        Receive_btn.Text = Constants.RECEIVE_WAIT_MODE_WAIT_STR;
                    }

                    string code_str = "";
                    code_str = "0x";
                    code_str += string.Format("{0:X2}", my_EEPROM_DATA[SetPin_selected].reader_code);
                    for (int fi = 0; fi < Constants.EEPROM_DATA_DATA_SIZE; fi++)
                    {
                        code_str += string.Format("{0:X2}", my_EEPROM_DATA[SetPin_selected].data[fi]);
                    }
                    Code_lbl.Text = code_str;

                    //DEBUG
                    string debug_str = "";
                    Debug_label1.Text = string.Format("{0:000} : {1:000} : {2:000} : {3:000} : {4:000} : {5:000} : {6:000} : {7:000} : {8:000}", Debug_1, Debug_2, Debug_3, Debug_4, Debug_5, Debug_6, Debug_7, Debug_8, Debug_9);
                    debug_str = "";
                    for (int fi = 0; fi < 7; fi++)
                    {
                        debug_str += string.Format("0x{0:X2}:", RemoconReceiveData[fi]);
                    }
                    Debug_label2.Text = debug_str;
                    debug_str = "";
                    for (int fi = 0; fi < 7; fi++)
                    {
                        debug_str += string.Format("0x{0:X2}:", Debug_Arr[fi]);
                    }
                    Debug_label3.Text = debug_str;
                    //DEBUG
                }
            }
            catch
            {
            }
            //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------BEGIN CUT AND PASTE BLOCK-----------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------------------
        //FUNCTION:	ReadFileManagedBuffer()
        //PURPOSE:	Wrapper function to call ReadFile()
        //
        //INPUT:	Uses managed versions of the same input parameters as ReadFile() uses.
        //
        //OUTPUT:	Returns boolean indicating if the function call was successful or not.
        //          Also returns data in the byte[] INBuffer, and the number of bytes read. 
        //
        //Notes:    Wrapper function used to call the ReadFile() function.  ReadFile() takes a pointer to an unmanaged buffer and deposits
        //          the bytes read into the buffer.  However, can't pass a pointer to a managed buffer directly to ReadFile().
        //          This ReadFileManagedBuffer() is a wrapper function to make it so application code can call ReadFile() easier
        //          by specifying a managed buffer.
        //--------------------------------------------------------------------------------------------------------------------------
        public unsafe bool ReadFileManagedBuffer(SafeFileHandle hFile, byte[] INBuffer, uint nNumberOfBytesToRead, ref uint lpNumberOfBytesRead, IntPtr lpOverlapped)
        {
            IntPtr pINBuffer = IntPtr.Zero;

            try
            {
                pINBuffer = Marshal.AllocHGlobal((int)nNumberOfBytesToRead);    //Allocate some unmanged RAM for the receive data buffer.

                if (ReadFile(hFile, pINBuffer, nNumberOfBytesToRead, ref lpNumberOfBytesRead, lpOverlapped))
                {
                    Marshal.Copy(pINBuffer, INBuffer, 0, (int)lpNumberOfBytesRead);    //Copy over the data from unmanged memory into the managed byte[] INBuffer
                    Marshal.FreeHGlobal(pINBuffer);
                    return true;
                }
                else
                {
                    Marshal.FreeHGlobal(pINBuffer);
                    return false;
                }
            }
            catch
            {
                if (pINBuffer != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(pINBuffer);
                }
                return false;
            }
        }

        private void devicetype_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DeviceType_selected = (byte)devicetype_combox.SelectedIndex;

                if (my_EEPROM_DATA[SetPin_selected].reader_code == 0x00)
                {   // 赤外線コード未受信のときはデバイス選択以下すべて非表示
                    devicetype_combox.Visible = false;
                    mousevalue_combx.Visible = false;
                    volumevalue_combx.Visible = false;
                    KeyboardValue_txtbx.Visible = false;
                    Alt_cbox.Visible = false;
                    Ctrl_cbox.Visible = false;
                    Shift_cbox.Visible = false;
                    Win_cbox.Visible = false;
                    Arrow_Keyboard_pb.Visible = false;
                    Arrow_Com_pb.Visible = false;

                    pictureBox5.Visible = false;
                }
                else
                {   // 赤外線コード受信済み
                    devicetype_combox.Visible = true;
                    pictureBox5.Visible = true;

                    switch (DeviceType_selected)
                    {
                        case Constants.MODE_MOUSE:     //マウス
                            mousevalue_combx.Visible = true;
                            volumevalue_combx.Visible = false;
                            KeyboardValue_txtbx.Visible = false;
                            Alt_cbox.Visible = false;
                            Ctrl_cbox.Visible = false;
                            Shift_cbox.Visible = false;
                            Win_cbox.Visible = false;
                            Arrow_Keyboard_pb.Visible = false;

                            Arrow_Com_pb.Visible = false;

                            if (my_EEPROM_DATA[SetPin_selected].value > 9)
                            {
                                my_EEPROM_DATA[SetPin_selected].value = 0;
                            }
                            mousevalue_combx.SelectedIndex = my_EEPROM_DATA[SetPin_selected].value;
                            mousevalue_combx_SelectedIndexChanged(null, EventArgs.Empty);
                            break;
                        case Constants.MODE_KEYBOARD:     //キーボード
                            mousevalue_combx.Visible = false;
                            volumevalue_combx.Visible = false;
                            KeyboardValue_txtbx.Visible = true;
                            Alt_cbox.Visible = true;
                            Ctrl_cbox.Visible = true;
                            Shift_cbox.Visible = true;
                            Win_cbox.Visible = true;
                            Arrow_Keyboard_pb.Visible = true;

                            Arrow_Mouse1_pb.Visible = false;
                            Arrow_Mouse2_pb.Visible = false;
                            Arrow_Mouse3_pb.Visible = false;
                            Arrow_Com_pb.Visible = true;

                            for (uint i = 0; i < 256; i++)
                            {
                                if (my_EEPROM_DATA[SetPin_selected].value == VKtoUSBkey[i])
                                {
                                    KeyboardValue_txtbx.Text = ((Keys)i).ToString();
                                }
                            }
                            if (my_EEPROM_DATA[SetPin_selected].value == 0)
                            {
                                KeyboardValue_txtbx.Text = "ここに入力";
                            }

                            if ((my_EEPROM_DATA[SetPin_selected].modifier & 0x01) != 0)
                            {
                                Ctrl_cbox.Checked = true;
                            }
                            else
                            {
                                Ctrl_cbox.Checked = false;
                            }
                            if ((my_EEPROM_DATA[SetPin_selected].modifier & 0x02) != 0)
                            {
                                Shift_cbox.Checked = true;
                            }
                            else
                            {
                                Shift_cbox.Checked = false;
                            }
                            if ((my_EEPROM_DATA[SetPin_selected].modifier & 0x04) != 0)
                            {
                                Alt_cbox.Checked = true;
                            }
                            else
                            {
                                Alt_cbox.Checked = false;
                            }
                            if ((my_EEPROM_DATA[SetPin_selected].modifier & 0x08) != 0)
                            {
                                Win_cbox.Checked = true;
                            }
                            else
                            {
                                Win_cbox.Checked = false;
                            }
                            MouseMove_UD.Visible = false;

                            break;
                        case Constants.MODE_VOLUME:     //ボリューム
                            mousevalue_combx.Visible = false;
                            volumevalue_combx.Visible = true;
                            KeyboardValue_txtbx.Visible = false;
                            Alt_cbox.Visible = false;
                            Ctrl_cbox.Visible = false;
                            Shift_cbox.Visible = false;
                            Win_cbox.Visible = false;
                            Arrow_Keyboard_pb.Visible = false;

                            Arrow_Com_pb.Visible = false;

                            if (my_EEPROM_DATA[SetPin_selected].value > 2)
                            {
                                my_EEPROM_DATA[SetPin_selected].value = 0;
                            }
                            volumevalue_combx.SelectedIndex = my_EEPROM_DATA[SetPin_selected].value;
                            volumevalue_combx_SelectedIndexChanged(null, EventArgs.Empty);
                            break;
                    }
                }
            }
            catch
            {
            }
        }

        private void mousevalue_combx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MouseValue_selected = (byte)mousevalue_combx.SelectedIndex;

                Arrow_Mouse1_pb.Visible = false;
                Arrow_Mouse2_pb.Visible = true;
                Arrow_Mouse3_pb.Visible = false;
                MouseMove_UD.Visible = false;
            }
            catch
            {
            }
        }
        private void volumevalue_combx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VolumeValue_selected = (byte)volumevalue_combx.SelectedIndex;

                Arrow_Mouse1_pb.Visible = false;
                Arrow_Mouse2_pb.Visible = true;
                Arrow_Mouse3_pb.Visible = false;
                MouseMove_UD.Visible = false;
            }
            catch
            {
            }
        }

        private void SetPin_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SetPin_selected = SetPin_combox.SelectedIndex;

                devicetype_combox.SelectedIndex = my_EEPROM_DATA[SetPin_selected].mode;
                devicetype_combox_SelectedIndexChanged(null, EventArgs.Empty);

                //Memo
                string s_key = "MEMO" + string.Format("{0:00}", SetPin_selected + 1);
                Memo_txt.Text = (string)global::USB_IR_REMOCON_CT.Properties.Settings.Default[s_key];

                //ボタン変更セット
                i_receive_del_btn_chg = 1;
            }
            catch
            {
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MouseMoveValue_selected = (byte)MouseMove_UD.Value;
        }

        private void ButtonRightA_pb_Click(object sender, EventArgs e)
        {
            if(Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 3;
        }

        private void ButtonUpA_pb_Click(object sender, EventArgs e)
        {
            if (Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 0;
        }

        private void ButtonLeftA_pb_Click(object sender, EventArgs e)
        {
            if (Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 2;
        }

        private void ButtonDownA_pb_Click(object sender, EventArgs e)
        {
            if (Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 1;
        }

        private void Button01A_pb_Click(object sender, EventArgs e)
        {
            if (Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 4;
        }

        private void Button02A_pb_Click(object sender, EventArgs e)
        {
            if (Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 5;
        }

        private void Button03A_pb_Click(object sender, EventArgs e)
        {
            if (Now_Background_image == 1)
                SetPin_combox.SelectedIndex = 6;
        }

        private void Receive_btn_Click(object sender, EventArgs e)
        {
            try
            {
                /* 受信待ちでない */
                if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_NONE || i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT_CHG)
                {
                    /* 受信待ちにする */
                    i_receive_wait_mode = Constants.RECEIVE_WAIT_MODE_WAIT_CHG;
                    //Receive_btn.Text = Constants.RECEIVE_WAIT_MODE_WAIT_STR;
                }
                else if (i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_WAIT || i_receive_wait_mode == Constants.RECEIVE_WAIT_MODE_NONE_CHG)
                {
                    /* 受信待ち解除 */
                    i_receive_wait_mode = Constants.RECEIVE_WAIT_MODE_NONE_CHG;
                    //Receive_btn.Text = Constants.RECEIVE_WAIT_MODE_NONE_STR;

                    if(RemoconReceiveData[0] != 0)
                    {
                        my_EEPROM_DATA[SetPin_selected].reader_code = RemoconReceiveData[0];
                        for (int i = 0; i < Constants.EEPROM_DATA_DATA_SIZE; i++)
                        {
                            my_EEPROM_DATA[SetPin_selected].data[i] = RemoconReceiveData[i+1];
                        }
                    }
                }
                //ボタン変更セット
                i_receive_del_btn_chg = 1;
            }
            catch
            {
            }
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("コードを消去してもよろしいですか？", "コード消去確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    my_EEPROM_DATA[SetPin_selected].reader_code = 0;
                    for (int i = 0; i < Constants.EEPROM_DATA_DATA_SIZE; i++)
                    {
                        my_EEPROM_DATA[SetPin_selected].data[i] = 0;
                    }
                    //コード消去時にその他の設定値もクリアする
                    my_EEPROM_DATA[SetPin_selected].change_flag = 1;
                    my_EEPROM_DATA[SetPin_selected].mode = 0;
                    my_EEPROM_DATA[SetPin_selected].value = 0;
                    my_EEPROM_DATA[SetPin_selected].modifier = 0;
                    //受信データもクリア
                    RemoconReceiveData[0] = 0;
                    //ボタン変更セット
                    i_receive_del_btn_chg = 1;
                    ConnectFirstTime = true;

                    //MEMO
                    string s_key = "MEMO" + string.Format("{0:00}", SetPin_selected + 1);
                    global::USB_IR_REMOCON_CT.Properties.Settings.Default[s_key] = Memo_txt.Text;
                    global::USB_IR_REMOCON_CT.Properties.Settings.Default.Save();

                    Changevalue_btn_pressed = true;
               }
            }
            catch
            {
            }
        }
        // エリアボタンクリック
        private void Area_Button_Click(object sender, EventArgs e)
        {
            int i_tag = 0;
            
            try
            {
                string str_tag = (string)((System.Windows.Forms.Button)sender).Tag;
                i_tag = int.Parse(str_tag);

                SetPin_combox.SelectedIndex = i_tag - 1;
            }
            catch
            {
            }
        }
        // キーボード
        private void KeyboardModifier_cbox_CheckedChanged(object sender, EventArgs e)
        {
            int i_tag = 0;
            byte mask = 0;

            try
            {
                string str_tag = (string)((System.Windows.Forms.CheckBox)sender).Tag;
                i_tag = int.Parse(str_tag);

                switch (i_tag)
                {
                    case Constants.KEYBOARD_CTRL:
                        mask = 0x01;
                        break;
                    case Constants.KEYBOARD_SHIFT:
                        mask = 0x02;
                        break;
                    case Constants.KEYBOARD_ALT:
                        mask = 0x04;
                        break;
                    case Constants.KEYBOARD_WIN:
                        mask = 0x08;
                        break;
                    default:
                        break;
                }
                if (((System.Windows.Forms.CheckBox)sender).Checked == true)
                {
                    KeyboardModifier_selected |= mask;
                }
                else
                {
                    //KeyboardModifier_selected &= (byte)~mask;
                    mask = (byte)(mask ^ 0xFF);
                    KeyboardModifier_selected &= mask;
                }
            }
            catch
            {
            }
        }
        private void KeyboardValue_txtbx_KeyDown(object sender, KeyEventArgs e)
        {
            KeyboardValue_txtbx.Text = e.KeyCode.ToString();
            KeyboardValue_selected = VKtoUSBkey[e.KeyCode.GetHashCode()];
            e.SuppressKeyPress = true;
        }

        private void KeyboardValue_txtbx_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (KeyboardValue_txtbx.Text != e.KeyCode.ToString())
                {
                    KeyboardValue_txtbx.Text = e.KeyCode.ToString();
                    KeyboardValue_selected = VKtoUSBkey[e.KeyCode.GetHashCode()];
                    e.IsInputKey = true;
                }
            }
        }

        private void tmrONFlag_Tick(object sender, EventArgs e)
        {
            tmrONFlag.Enabled = false;
            for (int i = 0; i < 20; i++)
            {
                myPictureBoxON[i].Visible = false;
            }
        }


        //-------------------------------------------------------END CUT AND PASTE BLOCK-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
    } //public partial class Form1 : Form
    static class Constants
    {
        public const int RECEIVE_WAIT_MODE_NONE = 0;    /* PC側赤外線コード受信待ちモード　NONE */
        public const int RECEIVE_WAIT_MODE_WAIT = 1;    /* PC側赤外線コード受信待ちモード　WAIT */
        public const int RECEIVE_WAIT_MODE_WAIT_CHG = 2;    /* PC側赤外線コード受信待ちモード　WAITへ変更 */
        public const int RECEIVE_WAIT_MODE_NONE_CHG = 3;    /* PC側赤外線コード受信待ちモード　NONEへ変更 */
        public const string RECEIVE_WAIT_MODE_NONE_STR = "受信開始";    /* PC側赤外線コード受信待ちモード　NONE */
        public const string RECEIVE_WAIT_MODE_WAIT_STR = "受信待ち解除";    /* PC側赤外線コード受信待ちモード　WAIT */
        
        public const byte MODE_MOUSE            = 0;
        public const byte MODE_KEYBOARD = 1;
        public const byte MODE_VOLUME = 2;
        //public const byte MODE_JOYSTICK = 2;
        public const byte EEPROM_DATA_NUM = 20;         /* EEPROM格納データ数 */
        public const byte EEPROM_DATA_SIZE = 10;        /* EEPROM格納１データのサイズ */
        public const byte EEPROM_DATA_TOTAL_SIZE = EEPROM_DATA_NUM*EEPROM_DATA_SIZE;	/* EEPROM格納データのトータルサイズ */
        public const byte EEPROM_DATA_READER_SIZE = 1;  /* EEPROM格納１データのリーダ部のサイズ */
        public const byte EEPROM_DATA_DATA_SIZE = 6;    /* EEPROM格納１データのデータ部のサイズ */
        public const byte EEPROM_DATA_MODE = 0;         /* 0:モード */
        public const byte EEPROM_DATA_VALUE = 1;        /* 1:値 */
        public const byte EEPROM_DATA_MODIFIER = 2;     /* 2:Modifier（キーボード用） */
        public const byte EEPROM_DATA_READERCODE = 3;	/* 赤外線リーダコード格納位置 */
        public const byte EEPROM_DATA_DATACODE  = 4;	/* 赤外線データコード格納位置 */

        public const int KEYBOARD_CTRL = 1;             /* キーボード CTRL */
        public const int KEYBOARD_SHIFT = 2;            /* キーボード SHIFT */
        public const int KEYBOARD_ALT = 3;              /* キーボード ALT */
        public const int KEYBOARD_WIN = 4;              /* キーボード WIN */
        public const int JOYSTICK_LEVER_UP = 1;         /* ジョイスティックレバー UP */
        public const int JOYSTICK_LEVER_DOWN = 2;       /* ジョイスティックレバー DOWN */
        public const int JOYSTICK_LEVER_LEFT = 3;       /* ジョイスティックレバー LEFT */
        public const int JOYSTICK_LEVER_RIGHT = 4;      /* ジョイスティックレバー RIGHT */
        public const int JOYSTICK_BUTTON_01 = 1;        /* ジョイスティックボタン 01 */
        public const int JOYSTICK_BUTTON_02 = 2;
        public const int JOYSTICK_BUTTON_03 = 3;
        public const int JOYSTICK_BUTTON_04 = 4;
        public const int JOYSTICK_BUTTON_05 = 5;
        public const int JOYSTICK_BUTTON_06 = 6;
        public const int JOYSTICK_BUTTON_07 = 7;
        public const int JOYSTICK_BUTTON_08 = 8;
        public const int JOYSTICK_BUTTON_09 = 9;
        public const int JOYSTICK_BUTTON_10 = 10;
        public const int JOYSTICK_BUTTON_11 = 11;
        public const int JOYSTICK_BUTTON_12 = 12;

    }
} //namespace HID_PnP_Demo
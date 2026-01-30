// USB_IR_Sample.cpp : コンソール アプリケーションのエントリ ポイントを定義します。
//

#include "stdafx.h"
#include "USB_IR_Library.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int type = 0;
	int i_ret;
	clock_t start_time, end_time;
	unsigned char ir_data1[6] = {0xAA, 0x5A, 0x8F, 0x12, 0x4E, 0x32};
	unsigned char ir_data2[12] = {0xAA, 0x5A, 0x8F, 0x12, 0x4E, 0x32, 0xAA, 0x5A, 0x8F, 0x12, 0x4F, 0x22};

	HMODULE hHandle = GetModuleHandle(0);
	HANDLE usbHandle = NULL;
	
	while(1)
	{
		printf_s("\n処理内容を選択して下さい。\n");
		printf("1:USB接続\n");
		printf("2:USB切断\n");
		printf("3:送信1\n");
		printf("4:送信2\n");
		printf("99:終了\n");
		rewind(stdin);
		type = 0;
		printf("処理番号 ? = ");
		scanf_s("%d", &type);

		if(type == 99)
		{
			break;
		}
		
		switch(type)
		{
			case 1:
				start_time = clock();
				usbHandle = openUSBIR(hHandle);
				end_time = clock();
				printf("%d\n", usbHandle);
				printf("%.3f秒かかりました。\n", (double)(end_time-start_time) / CLOCKS_PER_SEC);
				break;
			case 2:
				start_time = clock();
				i_ret = closeUSBIR(usbHandle);
				end_time = clock();
				usbHandle = NULL;
				printf("%d\n", i_ret);
				printf("%.3f秒かかりました。\n", (double)(end_time-start_time) / CLOCKS_PER_SEC);
				break;
			case 3:
				start_time = clock();
				i_ret = writeUSBIR(usbHandle, AEHA, ir_data1, 48);
				end_time = clock();
				printf("%d\n", i_ret);
				printf("%.3f秒かかりました。\n", (double)(end_time-start_time) / CLOCKS_PER_SEC);
				break;
			case 4:
				start_time = clock();
				i_ret = writeUSBIRex(usbHandle, AEHA, ir_data2, 48, 48);
				end_time = clock();
				printf("%d\n", i_ret);
				printf("%.3f秒かかりました。\n", (double)(end_time-start_time) / CLOCKS_PER_SEC);
				break;
			default:
				printf("\n処理番号が正しくありません！！！\n\n");
				break;

		}

	}

	// USBをクローズする
	if(usbHandle != NULL)
	{
		i_ret = closeUSBIR(usbHandle);
	}

	return 0;
}


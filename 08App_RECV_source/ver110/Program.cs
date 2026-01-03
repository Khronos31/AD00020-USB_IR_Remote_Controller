using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HID_PnP_Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //ローカルコンピュータ上で実行されているすべてのプロセスを取得
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcesses();
            string myProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            int myProcessCnt = 0;
            foreach (System.Diagnostics.Process p in ps)
            {
                try
                {
                    if (p.ProcessName.CompareTo(myProcessName) == 0
                        || p.MainModule.ModuleName.IndexOf("REMOCON_CT_RECV.exe") >= 0
                        || p.MainModule.ModuleName.IndexOf("REMOCON_CT_TRANS.exe") >= 0)
                    {
                        myProcessCnt++;
                        //MessageBox.Show(p.ProcessName);
                    }
                }
                catch (Exception ex)
                {
                }
            }
            if (myProcessCnt >= 2)
            {
                //すでに起動していると判断して終了
                MessageBox.Show("多重起動はできません。");
                return;
            }

            ////二重起動をチェックする
            //if (System.Diagnostics.Process.GetProcessesByName(
            //    System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            //{
            //    //すでに起動していると判断して終了
            //    MessageBox.Show("多重起動はできません。");
            //    return;
            //}

            Application.Run(new Form1());

        }
    }
}
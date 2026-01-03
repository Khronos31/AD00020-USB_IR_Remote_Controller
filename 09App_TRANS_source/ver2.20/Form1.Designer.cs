namespace HID_PnP_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReadWriteThread = new System.ComponentModel.BackgroundWorker();
            this.FormUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.ToggleLEDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PushbuttonStateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.StatusBox_lbl = new System.Windows.Forms.Label();
            this.StatusBox_lbl2 = new System.Windows.Forms.Label();
            this.Debug_label1 = new System.Windows.Forms.Label();
            this.Debug_label2 = new System.Windows.Forms.Label();
            this.Debug_label3 = new System.Windows.Forms.Label();
            this.Debug_label4 = new System.Windows.Forms.Label();
            this.Debug_label5 = new System.Windows.Forms.Label();
            this.Code_lbl = new System.Windows.Forms.Label();
            this.Code_10 = new System.Windows.Forms.Label();
            this.Code_09 = new System.Windows.Forms.Label();
            this.Code_08 = new System.Windows.Forms.Label();
            this.Code_07 = new System.Windows.Forms.Label();
            this.Code_06 = new System.Windows.Forms.Label();
            this.Code_05 = new System.Windows.Forms.Label();
            this.Code_04 = new System.Windows.Forms.Label();
            this.Code_03 = new System.Windows.Forms.Label();
            this.Code_02 = new System.Windows.Forms.Label();
            this.Code_01 = new System.Windows.Forms.Label();
            this.Memo01_txt = new System.Windows.Forms.TextBox();
            this.Memo02_txt = new System.Windows.Forms.TextBox();
            this.Memo03_txt = new System.Windows.Forms.TextBox();
            this.Memo04_txt = new System.Windows.Forms.TextBox();
            this.Memo05_txt = new System.Windows.Forms.TextBox();
            this.Memo06_txt = new System.Windows.Forms.TextBox();
            this.Memo07_txt = new System.Windows.Forms.TextBox();
            this.Memo08_txt = new System.Windows.Forms.TextBox();
            this.Memo09_txt = new System.Windows.Forms.TextBox();
            this.Memo10_txt = new System.Windows.Forms.TextBox();
            this.colum_lbl = new System.Windows.Forms.Label();
            this.Debug_label1b = new System.Windows.Forms.Label();
            this.imageList_rec_btn = new System.Windows.Forms.ImageList(this.components);
            this.imageList_send_btn = new System.Windows.Forms.ImageList(this.components);
            this.StatusBox_lbl3 = new System.Windows.Forms.Label();
            this.lbl_FileImport = new System.Windows.Forms.Label();
            this.FileImportExport_imageList = new System.Windows.Forms.ImageList(this.components);
            this.lbl_FileExport = new System.Windows.Forms.Label();
            this.lbl_Send_10 = new System.Windows.Forms.Label();
            this.lbl_Send_09 = new System.Windows.Forms.Label();
            this.lbl_Send_08 = new System.Windows.Forms.Label();
            this.lbl_Send_07 = new System.Windows.Forms.Label();
            this.lbl_Send_06 = new System.Windows.Forms.Label();
            this.lbl_Send_05 = new System.Windows.Forms.Label();
            this.lbl_Send_04 = new System.Windows.Forms.Label();
            this.lbl_Send_03 = new System.Windows.Forms.Label();
            this.lbl_Send_02 = new System.Windows.Forms.Label();
            this.lbl_Send_01 = new System.Windows.Forms.Label();
            this.lbl_Rec_10 = new System.Windows.Forms.Label();
            this.lbl_Rec_09 = new System.Windows.Forms.Label();
            this.lbl_Rec_08 = new System.Windows.Forms.Label();
            this.lbl_Rec_07 = new System.Windows.Forms.Label();
            this.lbl_Rec_06 = new System.Windows.Forms.Label();
            this.lbl_Rec_05 = new System.Windows.Forms.Label();
            this.lbl_Rec_04 = new System.Windows.Forms.Label();
            this.lbl_Rec_03 = new System.Windows.Forms.Label();
            this.lbl_Rec_02 = new System.Windows.Forms.Label();
            this.lbl_Rec_01 = new System.Windows.Forms.Label();
            this.Status_C_pb = new System.Windows.Forms.PictureBox();
            this.Status_NC_pb = new System.Windows.Forms.PictureBox();
            this.BackGround_pb = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadWriteThread
            // 
            this.ReadWriteThread.WorkerReportsProgress = true;
            this.ReadWriteThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadWriteThread_DoWork);
            // 
            // FormUpdateTimer
            // 
            this.FormUpdateTimer.Enabled = true;
            this.FormUpdateTimer.Interval = 6;
            this.FormUpdateTimer.Tick += new System.EventHandler(this.FormUpdateTimer_Tick);
            // 
            // ToggleLEDToolTip
            // 
            this.ToggleLEDToolTip.AutomaticDelay = 2000;
            this.ToggleLEDToolTip.AutoPopDelay = 20000;
            this.ToggleLEDToolTip.InitialDelay = 15;
            this.ToggleLEDToolTip.ReshowDelay = 15;
            // 
            // PushbuttonStateTooltip
            // 
            this.PushbuttonStateTooltip.AutomaticDelay = 20;
            this.PushbuttonStateTooltip.AutoPopDelay = 20000;
            this.PushbuttonStateTooltip.InitialDelay = 15;
            this.PushbuttonStateTooltip.ReshowDelay = 15;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 2000;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 15;
            this.toolTip1.ReshowDelay = 15;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 20;
            this.toolTip2.AutoPopDelay = 20000;
            this.toolTip2.InitialDelay = 15;
            this.toolTip2.ReshowDelay = 15;
            // 
            // StatusBox_lbl
            // 
            this.StatusBox_lbl.AutoSize = true;
            this.StatusBox_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.StatusBox_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.StatusBox_lbl.Location = new System.Drawing.Point(895, 547);
            this.StatusBox_lbl.Name = "StatusBox_lbl";
            this.StatusBox_lbl.Size = new System.Drawing.Size(79, 12);
            this.StatusBox_lbl.TabIndex = 117;
            this.StatusBox_lbl.Text = "デバイス未接続";
            // 
            // StatusBox_lbl2
            // 
            this.StatusBox_lbl2.AutoSize = true;
            this.StatusBox_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.StatusBox_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.StatusBox_lbl2.Location = new System.Drawing.Point(19, 547);
            this.StatusBox_lbl2.Name = "StatusBox_lbl2";
            this.StatusBox_lbl2.Size = new System.Drawing.Size(282, 12);
            this.StatusBox_lbl2.TabIndex = 118;
            this.StatusBox_lbl2.Text = "USB赤外線リモコンキット, Configuration Tool起動しました";
            // 
            // Debug_label1
            // 
            this.Debug_label1.AutoSize = true;
            this.Debug_label1.BackColor = System.Drawing.Color.Yellow;
            this.Debug_label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Debug_label1.Location = new System.Drawing.Point(241, 449);
            this.Debug_label1.Name = "Debug_label1";
            this.Debug_label1.Size = new System.Drawing.Size(41, 12);
            this.Debug_label1.TabIndex = 164;
            this.Debug_label1.Text = "debug1";
            this.Debug_label1.Visible = false;
            // 
            // Debug_label2
            // 
            this.Debug_label2.AutoSize = true;
            this.Debug_label2.BackColor = System.Drawing.Color.Yellow;
            this.Debug_label2.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Debug_label2.Location = new System.Drawing.Point(241, 479);
            this.Debug_label2.Name = "Debug_label2";
            this.Debug_label2.Size = new System.Drawing.Size(41, 12);
            this.Debug_label2.TabIndex = 165;
            this.Debug_label2.Text = "debug1";
            this.Debug_label2.Visible = false;
            // 
            // Debug_label3
            // 
            this.Debug_label3.AutoSize = true;
            this.Debug_label3.BackColor = System.Drawing.Color.Yellow;
            this.Debug_label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Debug_label3.Location = new System.Drawing.Point(241, 491);
            this.Debug_label3.Name = "Debug_label3";
            this.Debug_label3.Size = new System.Drawing.Size(41, 12);
            this.Debug_label3.TabIndex = 166;
            this.Debug_label3.Text = "debug1";
            this.Debug_label3.Visible = false;
            // 
            // Debug_label4
            // 
            this.Debug_label4.AutoSize = true;
            this.Debug_label4.BackColor = System.Drawing.Color.Yellow;
            this.Debug_label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Debug_label4.Location = new System.Drawing.Point(241, 507);
            this.Debug_label4.Name = "Debug_label4";
            this.Debug_label4.Size = new System.Drawing.Size(41, 12);
            this.Debug_label4.TabIndex = 167;
            this.Debug_label4.Text = "debug1";
            this.Debug_label4.Visible = false;
            // 
            // Debug_label5
            // 
            this.Debug_label5.AutoSize = true;
            this.Debug_label5.BackColor = System.Drawing.Color.Yellow;
            this.Debug_label5.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Debug_label5.Location = new System.Drawing.Point(241, 519);
            this.Debug_label5.Name = "Debug_label5";
            this.Debug_label5.Size = new System.Drawing.Size(41, 12);
            this.Debug_label5.TabIndex = 168;
            this.Debug_label5.Text = "debug1";
            this.Debug_label5.Visible = false;
            // 
            // Code_lbl
            // 
            this.Code_lbl.AutoSize = true;
            this.Code_lbl.Location = new System.Drawing.Point(83, 100);
            this.Code_lbl.Name = "Code_lbl";
            this.Code_lbl.Size = new System.Drawing.Size(0, 12);
            this.Code_lbl.TabIndex = 172;
            // 
            // Code_10
            // 
            this.Code_10.BackColor = System.Drawing.SystemColors.Window;
            this.Code_10.Enabled = false;
            this.Code_10.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_10.ForeColor = System.Drawing.Color.Black;
            this.Code_10.Location = new System.Drawing.Point(164, 513);
            this.Code_10.Name = "Code_10";
            this.Code_10.Size = new System.Drawing.Size(580, 15);
            this.Code_10.TabIndex = 240;
            this.Code_10.Tag = "10";
            this.Code_10.Text = "code 10";
            this.Code_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_09
            // 
            this.Code_09.BackColor = System.Drawing.SystemColors.Window;
            this.Code_09.Enabled = false;
            this.Code_09.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_09.ForeColor = System.Drawing.Color.Black;
            this.Code_09.Location = new System.Drawing.Point(164, 460);
            this.Code_09.Name = "Code_09";
            this.Code_09.Size = new System.Drawing.Size(580, 15);
            this.Code_09.TabIndex = 239;
            this.Code_09.Tag = "9";
            this.Code_09.Text = "code 09";
            this.Code_09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_08
            // 
            this.Code_08.BackColor = System.Drawing.SystemColors.Window;
            this.Code_08.Enabled = false;
            this.Code_08.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_08.ForeColor = System.Drawing.Color.Black;
            this.Code_08.Location = new System.Drawing.Point(164, 407);
            this.Code_08.Name = "Code_08";
            this.Code_08.Size = new System.Drawing.Size(580, 15);
            this.Code_08.TabIndex = 238;
            this.Code_08.Tag = "8";
            this.Code_08.Text = "code 08";
            this.Code_08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_07
            // 
            this.Code_07.BackColor = System.Drawing.SystemColors.Window;
            this.Code_07.Enabled = false;
            this.Code_07.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_07.ForeColor = System.Drawing.Color.Black;
            this.Code_07.Location = new System.Drawing.Point(164, 354);
            this.Code_07.Name = "Code_07";
            this.Code_07.Size = new System.Drawing.Size(580, 15);
            this.Code_07.TabIndex = 237;
            this.Code_07.Tag = "7";
            this.Code_07.Text = "code 07";
            this.Code_07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_06
            // 
            this.Code_06.BackColor = System.Drawing.SystemColors.Window;
            this.Code_06.Enabled = false;
            this.Code_06.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_06.ForeColor = System.Drawing.Color.Black;
            this.Code_06.Location = new System.Drawing.Point(164, 301);
            this.Code_06.Name = "Code_06";
            this.Code_06.Size = new System.Drawing.Size(580, 15);
            this.Code_06.TabIndex = 236;
            this.Code_06.Tag = "6";
            this.Code_06.Text = "code 06";
            this.Code_06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_05
            // 
            this.Code_05.BackColor = System.Drawing.SystemColors.Window;
            this.Code_05.Enabled = false;
            this.Code_05.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_05.ForeColor = System.Drawing.Color.Black;
            this.Code_05.Location = new System.Drawing.Point(164, 248);
            this.Code_05.Name = "Code_05";
            this.Code_05.Size = new System.Drawing.Size(580, 15);
            this.Code_05.TabIndex = 235;
            this.Code_05.Tag = "5";
            this.Code_05.Text = "code 05";
            this.Code_05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_04
            // 
            this.Code_04.BackColor = System.Drawing.SystemColors.Window;
            this.Code_04.Enabled = false;
            this.Code_04.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_04.ForeColor = System.Drawing.Color.Black;
            this.Code_04.Location = new System.Drawing.Point(164, 195);
            this.Code_04.Name = "Code_04";
            this.Code_04.Size = new System.Drawing.Size(580, 15);
            this.Code_04.TabIndex = 234;
            this.Code_04.Tag = "4";
            this.Code_04.Text = "code 04";
            this.Code_04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_03
            // 
            this.Code_03.BackColor = System.Drawing.SystemColors.Window;
            this.Code_03.Enabled = false;
            this.Code_03.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_03.ForeColor = System.Drawing.Color.Black;
            this.Code_03.Location = new System.Drawing.Point(164, 142);
            this.Code_03.Name = "Code_03";
            this.Code_03.Size = new System.Drawing.Size(580, 15);
            this.Code_03.TabIndex = 233;
            this.Code_03.Tag = "3";
            this.Code_03.Text = "code 03";
            this.Code_03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_02
            // 
            this.Code_02.BackColor = System.Drawing.SystemColors.Window;
            this.Code_02.Enabled = false;
            this.Code_02.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_02.ForeColor = System.Drawing.Color.Black;
            this.Code_02.Location = new System.Drawing.Point(164, 89);
            this.Code_02.Name = "Code_02";
            this.Code_02.Size = new System.Drawing.Size(580, 15);
            this.Code_02.TabIndex = 232;
            this.Code_02.Tag = "2";
            this.Code_02.Text = "code 02";
            this.Code_02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Code_01
            // 
            this.Code_01.BackColor = System.Drawing.SystemColors.Window;
            this.Code_01.Enabled = false;
            this.Code_01.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Code_01.ForeColor = System.Drawing.Color.Black;
            this.Code_01.Location = new System.Drawing.Point(164, 35);
            this.Code_01.Name = "Code_01";
            this.Code_01.Size = new System.Drawing.Size(580, 15);
            this.Code_01.TabIndex = 231;
            this.Code_01.Tag = "1";
            this.Code_01.Text = "code 01";
            this.Code_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Memo01_txt
            // 
            this.Memo01_txt.Enabled = false;
            this.Memo01_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo01_txt.Location = new System.Drawing.Point(164, 8);
            this.Memo01_txt.Name = "Memo01_txt";
            this.Memo01_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo01_txt.TabIndex = 271;
            this.Memo01_txt.Tag = "1";
            this.Memo01_txt.Text = "memo 01";
            this.Memo01_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo02_txt
            // 
            this.Memo02_txt.Enabled = false;
            this.Memo02_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo02_txt.Location = new System.Drawing.Point(164, 62);
            this.Memo02_txt.Name = "Memo02_txt";
            this.Memo02_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo02_txt.TabIndex = 272;
            this.Memo02_txt.Tag = "2";
            this.Memo02_txt.Text = "memo 02";
            this.Memo02_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo03_txt
            // 
            this.Memo03_txt.Enabled = false;
            this.Memo03_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo03_txt.Location = new System.Drawing.Point(164, 115);
            this.Memo03_txt.Name = "Memo03_txt";
            this.Memo03_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo03_txt.TabIndex = 273;
            this.Memo03_txt.Tag = "3";
            this.Memo03_txt.Text = "memo 03";
            this.Memo03_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo04_txt
            // 
            this.Memo04_txt.Enabled = false;
            this.Memo04_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo04_txt.Location = new System.Drawing.Point(164, 168);
            this.Memo04_txt.Name = "Memo04_txt";
            this.Memo04_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo04_txt.TabIndex = 274;
            this.Memo04_txt.Tag = "4";
            this.Memo04_txt.Text = "memo 04";
            this.Memo04_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo05_txt
            // 
            this.Memo05_txt.Enabled = false;
            this.Memo05_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo05_txt.Location = new System.Drawing.Point(164, 221);
            this.Memo05_txt.Name = "Memo05_txt";
            this.Memo05_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo05_txt.TabIndex = 275;
            this.Memo05_txt.Tag = "5";
            this.Memo05_txt.Text = "memo 05";
            this.Memo05_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo06_txt
            // 
            this.Memo06_txt.Enabled = false;
            this.Memo06_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo06_txt.Location = new System.Drawing.Point(164, 274);
            this.Memo06_txt.Name = "Memo06_txt";
            this.Memo06_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo06_txt.TabIndex = 276;
            this.Memo06_txt.Tag = "6";
            this.Memo06_txt.Text = "memo 06";
            this.Memo06_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo07_txt
            // 
            this.Memo07_txt.Enabled = false;
            this.Memo07_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo07_txt.Location = new System.Drawing.Point(164, 327);
            this.Memo07_txt.Name = "Memo07_txt";
            this.Memo07_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo07_txt.TabIndex = 277;
            this.Memo07_txt.Tag = "7";
            this.Memo07_txt.Text = "memo 07";
            this.Memo07_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo08_txt
            // 
            this.Memo08_txt.Enabled = false;
            this.Memo08_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo08_txt.Location = new System.Drawing.Point(164, 380);
            this.Memo08_txt.Name = "Memo08_txt";
            this.Memo08_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo08_txt.TabIndex = 278;
            this.Memo08_txt.Tag = "8";
            this.Memo08_txt.Text = "memo 08";
            this.Memo08_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo09_txt
            // 
            this.Memo09_txt.Enabled = false;
            this.Memo09_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo09_txt.Location = new System.Drawing.Point(164, 433);
            this.Memo09_txt.Name = "Memo09_txt";
            this.Memo09_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo09_txt.TabIndex = 279;
            this.Memo09_txt.Tag = "9";
            this.Memo09_txt.Text = "memo 09";
            this.Memo09_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // Memo10_txt
            // 
            this.Memo10_txt.Enabled = false;
            this.Memo10_txt.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Memo10_txt.Location = new System.Drawing.Point(164, 486);
            this.Memo10_txt.Name = "Memo10_txt";
            this.Memo10_txt.Size = new System.Drawing.Size(580, 24);
            this.Memo10_txt.TabIndex = 280;
            this.Memo10_txt.Tag = "10";
            this.Memo10_txt.Text = "memo 10";
            this.Memo10_txt.TextChanged += new System.EventHandler(this.Memo_txt_TextChanged);
            // 
            // colum_lbl
            // 
            this.colum_lbl.AutoSize = true;
            this.colum_lbl.BackColor = System.Drawing.Color.Yellow;
            this.colum_lbl.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.colum_lbl.Location = new System.Drawing.Point(241, 436);
            this.colum_lbl.Name = "colum_lbl";
            this.colum_lbl.Size = new System.Drawing.Size(41, 12);
            this.colum_lbl.TabIndex = 291;
            this.colum_lbl.Text = "label1";
            this.colum_lbl.Visible = false;
            // 
            // Debug_label1b
            // 
            this.Debug_label1b.AutoSize = true;
            this.Debug_label1b.BackColor = System.Drawing.Color.Yellow;
            this.Debug_label1b.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Debug_label1b.Location = new System.Drawing.Point(241, 462);
            this.Debug_label1b.Name = "Debug_label1b";
            this.Debug_label1b.Size = new System.Drawing.Size(41, 12);
            this.Debug_label1b.TabIndex = 292;
            this.Debug_label1b.Text = "debug1";
            this.Debug_label1b.Visible = false;
            // 
            // imageList_rec_btn
            // 
            this.imageList_rec_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_rec_btn.ImageStream")));
            this.imageList_rec_btn.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_rec_btn.Images.SetKeyName(0, "REC.png");
            this.imageList_rec_btn.Images.SetKeyName(1, "REC_on.png");
            this.imageList_rec_btn.Images.SetKeyName(2, "REC_click.png");
            this.imageList_rec_btn.Images.SetKeyName(3, "Del.png");
            this.imageList_rec_btn.Images.SetKeyName(4, "Del_on.png");
            this.imageList_rec_btn.Images.SetKeyName(5, "Del_click.png");
            // 
            // imageList_send_btn
            // 
            this.imageList_send_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_send_btn.ImageStream")));
            this.imageList_send_btn.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_send_btn.Images.SetKeyName(0, "send.png");
            this.imageList_send_btn.Images.SetKeyName(1, "send_on.png");
            this.imageList_send_btn.Images.SetKeyName(2, "send_click.png");
            // 
            // StatusBox_lbl3
            // 
            this.StatusBox_lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.StatusBox_lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.StatusBox_lbl3.Location = new System.Drawing.Point(768, 547);
            this.StatusBox_lbl3.Name = "StatusBox_lbl3";
            this.StatusBox_lbl3.Size = new System.Drawing.Size(110, 12);
            this.StatusBox_lbl3.TabIndex = 313;
            this.StatusBox_lbl3.Text = "FW : Ver 1.0.0";
            // 
            // lbl_FileImport
            // 
            this.lbl_FileImport.ImageIndex = 2;
            this.lbl_FileImport.ImageList = this.FileImportExport_imageList;
            this.lbl_FileImport.Location = new System.Drawing.Point(825, 513);
            this.lbl_FileImport.Name = "lbl_FileImport";
            this.lbl_FileImport.Size = new System.Drawing.Size(82, 25);
            this.lbl_FileImport.TabIndex = 601;
            this.lbl_FileImport.MouseLeave += new System.EventHandler(this.lbl_FileImportExport_MouseLeave);
            this.lbl_FileImport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_FileImport_MouseClick);
            this.lbl_FileImport.MouseEnter += new System.EventHandler(this.lbl_FileImportExport_MouseEnter);
            // 
            // FileImportExport_imageList
            // 
            this.FileImportExport_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FileImportExport_imageList.ImageStream")));
            this.FileImportExport_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.FileImportExport_imageList.Images.SetKeyName(0, "LEFTBN_SETTEI-KAKIKOMI.png");
            this.FileImportExport_imageList.Images.SetKeyName(1, "LEFTBN_SETTEI-KAKIKOMI_ACTIVE.png");
            this.FileImportExport_imageList.Images.SetKeyName(2, "LEFTBN_SETTEI-YOMIKOMI.png");
            this.FileImportExport_imageList.Images.SetKeyName(3, "LEFTBN_SETTEI-YOMIKOMI_ACTIVE.png");
            // 
            // lbl_FileExport
            // 
            this.lbl_FileExport.ImageIndex = 0;
            this.lbl_FileExport.ImageList = this.FileImportExport_imageList;
            this.lbl_FileExport.Location = new System.Drawing.Point(920, 513);
            this.lbl_FileExport.Name = "lbl_FileExport";
            this.lbl_FileExport.Size = new System.Drawing.Size(82, 25);
            this.lbl_FileExport.TabIndex = 602;
            this.lbl_FileExport.MouseLeave += new System.EventHandler(this.lbl_FileImportExport_MouseLeave);
            this.lbl_FileExport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_FileExport_MouseClick);
            this.lbl_FileExport.MouseEnter += new System.EventHandler(this.lbl_FileImportExport_MouseEnter);
            // 
            // lbl_Send_10
            // 
            this.lbl_Send_10.ImageIndex = 0;
            this.lbl_Send_10.ImageList = this.imageList_send_btn;
            this.lbl_Send_10.Location = new System.Drawing.Point(761, 486);
            this.lbl_Send_10.Name = "lbl_Send_10";
            this.lbl_Send_10.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_10.TabIndex = 312;
            this.lbl_Send_10.Tag = "10";
            this.lbl_Send_10.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_10.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_10.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_09
            // 
            this.lbl_Send_09.ImageIndex = 0;
            this.lbl_Send_09.ImageList = this.imageList_send_btn;
            this.lbl_Send_09.Location = new System.Drawing.Point(761, 433);
            this.lbl_Send_09.Name = "lbl_Send_09";
            this.lbl_Send_09.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_09.TabIndex = 311;
            this.lbl_Send_09.Tag = "9";
            this.lbl_Send_09.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_09.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_09.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_09.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_09.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_08
            // 
            this.lbl_Send_08.ImageIndex = 0;
            this.lbl_Send_08.ImageList = this.imageList_send_btn;
            this.lbl_Send_08.Location = new System.Drawing.Point(761, 380);
            this.lbl_Send_08.Name = "lbl_Send_08";
            this.lbl_Send_08.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_08.TabIndex = 310;
            this.lbl_Send_08.Tag = "8";
            this.lbl_Send_08.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_08.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_08.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_08.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_08.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_07
            // 
            this.lbl_Send_07.ImageIndex = 0;
            this.lbl_Send_07.ImageList = this.imageList_send_btn;
            this.lbl_Send_07.Location = new System.Drawing.Point(761, 327);
            this.lbl_Send_07.Name = "lbl_Send_07";
            this.lbl_Send_07.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_07.TabIndex = 309;
            this.lbl_Send_07.Tag = "7";
            this.lbl_Send_07.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_07.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_07.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_07.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_07.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_06
            // 
            this.lbl_Send_06.ImageIndex = 0;
            this.lbl_Send_06.ImageList = this.imageList_send_btn;
            this.lbl_Send_06.Location = new System.Drawing.Point(761, 274);
            this.lbl_Send_06.Name = "lbl_Send_06";
            this.lbl_Send_06.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_06.TabIndex = 308;
            this.lbl_Send_06.Tag = "6";
            this.lbl_Send_06.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_06.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_06.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_06.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_06.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_05
            // 
            this.lbl_Send_05.ImageIndex = 0;
            this.lbl_Send_05.ImageList = this.imageList_send_btn;
            this.lbl_Send_05.Location = new System.Drawing.Point(761, 221);
            this.lbl_Send_05.Name = "lbl_Send_05";
            this.lbl_Send_05.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_05.TabIndex = 307;
            this.lbl_Send_05.Tag = "5";
            this.lbl_Send_05.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_05.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_05.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_05.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_05.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_04
            // 
            this.lbl_Send_04.ImageIndex = 0;
            this.lbl_Send_04.ImageList = this.imageList_send_btn;
            this.lbl_Send_04.Location = new System.Drawing.Point(761, 168);
            this.lbl_Send_04.Name = "lbl_Send_04";
            this.lbl_Send_04.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_04.TabIndex = 306;
            this.lbl_Send_04.Tag = "4";
            this.lbl_Send_04.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_04.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_04.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_04.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_03
            // 
            this.lbl_Send_03.ImageIndex = 0;
            this.lbl_Send_03.ImageList = this.imageList_send_btn;
            this.lbl_Send_03.Location = new System.Drawing.Point(761, 115);
            this.lbl_Send_03.Name = "lbl_Send_03";
            this.lbl_Send_03.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_03.TabIndex = 305;
            this.lbl_Send_03.Tag = "3";
            this.lbl_Send_03.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_03.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_03.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_03.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_02
            // 
            this.lbl_Send_02.ImageIndex = 0;
            this.lbl_Send_02.ImageList = this.imageList_send_btn;
            this.lbl_Send_02.Location = new System.Drawing.Point(761, 62);
            this.lbl_Send_02.Name = "lbl_Send_02";
            this.lbl_Send_02.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_02.TabIndex = 304;
            this.lbl_Send_02.Tag = "2";
            this.lbl_Send_02.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_02.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_02.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_02.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Send_01
            // 
            this.lbl_Send_01.ImageIndex = 0;
            this.lbl_Send_01.ImageList = this.imageList_send_btn;
            this.lbl_Send_01.Location = new System.Drawing.Point(761, 8);
            this.lbl_Send_01.Name = "lbl_Send_01";
            this.lbl_Send_01.Size = new System.Drawing.Size(48, 40);
            this.lbl_Send_01.TabIndex = 303;
            this.lbl_Send_01.Tag = "1";
            this.lbl_Send_01.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Send_01.Click += new System.EventHandler(this.lbl_Send_Click);
            this.lbl_Send_01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Send_01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Send_01.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_10
            // 
            this.lbl_Rec_10.ImageIndex = 0;
            this.lbl_Rec_10.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_10.Location = new System.Drawing.Point(62, 486);
            this.lbl_Rec_10.Name = "lbl_Rec_10";
            this.lbl_Rec_10.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_10.TabIndex = 302;
            this.lbl_Rec_10.Tag = "10";
            this.lbl_Rec_10.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_10.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_10.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_09
            // 
            this.lbl_Rec_09.ImageIndex = 0;
            this.lbl_Rec_09.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_09.Location = new System.Drawing.Point(62, 433);
            this.lbl_Rec_09.Name = "lbl_Rec_09";
            this.lbl_Rec_09.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_09.TabIndex = 301;
            this.lbl_Rec_09.Tag = "9";
            this.lbl_Rec_09.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_09.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_09.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_09.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_09.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_08
            // 
            this.lbl_Rec_08.ImageIndex = 0;
            this.lbl_Rec_08.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_08.Location = new System.Drawing.Point(62, 380);
            this.lbl_Rec_08.Name = "lbl_Rec_08";
            this.lbl_Rec_08.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_08.TabIndex = 300;
            this.lbl_Rec_08.Tag = "8";
            this.lbl_Rec_08.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_08.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_08.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_08.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_08.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_07
            // 
            this.lbl_Rec_07.ImageIndex = 0;
            this.lbl_Rec_07.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_07.Location = new System.Drawing.Point(62, 327);
            this.lbl_Rec_07.Name = "lbl_Rec_07";
            this.lbl_Rec_07.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_07.TabIndex = 299;
            this.lbl_Rec_07.Tag = "7";
            this.lbl_Rec_07.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_07.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_07.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_07.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_07.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_06
            // 
            this.lbl_Rec_06.ImageIndex = 0;
            this.lbl_Rec_06.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_06.Location = new System.Drawing.Point(62, 274);
            this.lbl_Rec_06.Name = "lbl_Rec_06";
            this.lbl_Rec_06.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_06.TabIndex = 298;
            this.lbl_Rec_06.Tag = "6";
            this.lbl_Rec_06.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_06.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_06.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_06.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_06.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_05
            // 
            this.lbl_Rec_05.ImageIndex = 0;
            this.lbl_Rec_05.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_05.Location = new System.Drawing.Point(62, 221);
            this.lbl_Rec_05.Name = "lbl_Rec_05";
            this.lbl_Rec_05.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_05.TabIndex = 297;
            this.lbl_Rec_05.Tag = "5";
            this.lbl_Rec_05.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_05.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_05.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_05.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_05.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_04
            // 
            this.lbl_Rec_04.ImageIndex = 0;
            this.lbl_Rec_04.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_04.Location = new System.Drawing.Point(62, 168);
            this.lbl_Rec_04.Name = "lbl_Rec_04";
            this.lbl_Rec_04.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_04.TabIndex = 296;
            this.lbl_Rec_04.Tag = "4";
            this.lbl_Rec_04.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_04.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_04.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_04.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_03
            // 
            this.lbl_Rec_03.ImageIndex = 0;
            this.lbl_Rec_03.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_03.Location = new System.Drawing.Point(62, 115);
            this.lbl_Rec_03.Name = "lbl_Rec_03";
            this.lbl_Rec_03.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_03.TabIndex = 295;
            this.lbl_Rec_03.Tag = "3";
            this.lbl_Rec_03.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_03.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_03.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_03.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_02
            // 
            this.lbl_Rec_02.ImageIndex = 0;
            this.lbl_Rec_02.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_02.Location = new System.Drawing.Point(62, 62);
            this.lbl_Rec_02.Name = "lbl_Rec_02";
            this.lbl_Rec_02.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_02.TabIndex = 294;
            this.lbl_Rec_02.Tag = "2";
            this.lbl_Rec_02.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_02.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_02.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_02.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // lbl_Rec_01
            // 
            this.lbl_Rec_01.ImageIndex = 0;
            this.lbl_Rec_01.ImageList = this.imageList_rec_btn;
            this.lbl_Rec_01.Location = new System.Drawing.Point(62, 8);
            this.lbl_Rec_01.Name = "lbl_Rec_01";
            this.lbl_Rec_01.Size = new System.Drawing.Size(48, 40);
            this.lbl_Rec_01.TabIndex = 293;
            this.lbl_Rec_01.Tag = "1";
            this.lbl_Rec_01.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            this.lbl_Rec_01.Click += new System.EventHandler(this.lbl_Rec_Click);
            this.lbl_Rec_01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseDown);
            this.lbl_Rec_01.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseUp);
            this.lbl_Rec_01.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            // 
            // Status_C_pb
            // 
            this.Status_C_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_C_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.ON;
            this.Status_C_pb.Location = new System.Drawing.Point(981, 548);
            this.Status_C_pb.Name = "Status_C_pb";
            this.Status_C_pb.Size = new System.Drawing.Size(27, 8);
            this.Status_C_pb.TabIndex = 94;
            this.Status_C_pb.TabStop = false;
            this.Status_C_pb.Visible = false;
            // 
            // Status_NC_pb
            // 
            this.Status_NC_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_NC_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.OFF;
            this.Status_NC_pb.Location = new System.Drawing.Point(981, 548);
            this.Status_NC_pb.Name = "Status_NC_pb";
            this.Status_NC_pb.Size = new System.Drawing.Size(27, 8);
            this.Status_NC_pb.TabIndex = 95;
            this.Status_NC_pb.TabStop = false;
            this.Status_NC_pb.Visible = false;
            // 
            // BackGround_pb
            // 
            this.BackGround_pb.BackColor = System.Drawing.Color.White;
            this.BackGround_pb.BackgroundImage = global::USB_IR_REMOCON_CT.Properties.Resources.BG;
            this.BackGround_pb.Location = new System.Drawing.Point(0, 0);
            this.BackGround_pb.Name = "BackGround_pb";
            this.BackGround_pb.Size = new System.Drawing.Size(1015, 560);
            this.BackGround_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackGround_pb.TabIndex = 163;
            this.BackGround_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1014, 560);
            this.Controls.Add(this.lbl_FileExport);
            this.Controls.Add(this.lbl_FileImport);
            this.Controls.Add(this.StatusBox_lbl3);
            this.Controls.Add(this.Debug_label1b);
            this.Controls.Add(this.colum_lbl);
            this.Controls.Add(this.Debug_label5);
            this.Controls.Add(this.Debug_label4);
            this.Controls.Add(this.Debug_label3);
            this.Controls.Add(this.Debug_label2);
            this.Controls.Add(this.Debug_label1);
            this.Controls.Add(this.lbl_Send_10);
            this.Controls.Add(this.lbl_Send_09);
            this.Controls.Add(this.lbl_Send_08);
            this.Controls.Add(this.lbl_Send_07);
            this.Controls.Add(this.lbl_Send_06);
            this.Controls.Add(this.lbl_Send_05);
            this.Controls.Add(this.lbl_Send_04);
            this.Controls.Add(this.lbl_Send_03);
            this.Controls.Add(this.lbl_Send_02);
            this.Controls.Add(this.lbl_Send_01);
            this.Controls.Add(this.lbl_Rec_10);
            this.Controls.Add(this.lbl_Rec_09);
            this.Controls.Add(this.lbl_Rec_08);
            this.Controls.Add(this.lbl_Rec_07);
            this.Controls.Add(this.lbl_Rec_06);
            this.Controls.Add(this.lbl_Rec_05);
            this.Controls.Add(this.lbl_Rec_04);
            this.Controls.Add(this.lbl_Rec_03);
            this.Controls.Add(this.lbl_Rec_02);
            this.Controls.Add(this.lbl_Rec_01);
            this.Controls.Add(this.Code_10);
            this.Controls.Add(this.Code_09);
            this.Controls.Add(this.Code_08);
            this.Controls.Add(this.Code_07);
            this.Controls.Add(this.Code_06);
            this.Controls.Add(this.Code_05);
            this.Controls.Add(this.Code_04);
            this.Controls.Add(this.Code_03);
            this.Controls.Add(this.Code_02);
            this.Controls.Add(this.Memo10_txt);
            this.Controls.Add(this.Memo09_txt);
            this.Controls.Add(this.Memo08_txt);
            this.Controls.Add(this.Memo07_txt);
            this.Controls.Add(this.Memo06_txt);
            this.Controls.Add(this.Memo05_txt);
            this.Controls.Add(this.Memo04_txt);
            this.Controls.Add(this.Memo03_txt);
            this.Controls.Add(this.Memo02_txt);
            this.Controls.Add(this.Memo01_txt);
            this.Controls.Add(this.Code_01);
            this.Controls.Add(this.Code_lbl);
            this.Controls.Add(this.StatusBox_lbl2);
            this.Controls.Add(this.StatusBox_lbl);
            this.Controls.Add(this.Status_C_pb);
            this.Controls.Add(this.Status_NC_pb);
            this.Controls.Add(this.BackGround_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 593);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "USB赤外線リモコンキット 送信設定, Configuration Tool ver 2.1.0";
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker ReadWriteThread;
        private System.Windows.Forms.Timer FormUpdateTimer;
        private System.Windows.Forms.ToolTip ToggleLEDToolTip;
        private System.Windows.Forms.ToolTip PushbuttonStateTooltip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox Status_C_pb;
        private System.Windows.Forms.PictureBox Status_NC_pb;
        private System.Windows.Forms.Label StatusBox_lbl;
        private System.Windows.Forms.Label StatusBox_lbl2;
        private System.Windows.Forms.Label Debug_label1;
        private System.Windows.Forms.Label Debug_label2;
        private System.Windows.Forms.Label Debug_label3;
        private System.Windows.Forms.Label Debug_label4;
        private System.Windows.Forms.Label Debug_label5;
        private System.Windows.Forms.Label Code_lbl;
        private System.Windows.Forms.Label Code_10;
        private System.Windows.Forms.Label Code_09;
        private System.Windows.Forms.Label Code_08;
        private System.Windows.Forms.Label Code_07;
        private System.Windows.Forms.Label Code_06;
        private System.Windows.Forms.Label Code_05;
        private System.Windows.Forms.Label Code_04;
        private System.Windows.Forms.Label Code_03;
        private System.Windows.Forms.Label Code_02;
        private System.Windows.Forms.Label Code_01;
        private System.Windows.Forms.TextBox Memo01_txt;
        private System.Windows.Forms.TextBox Memo02_txt;
        private System.Windows.Forms.TextBox Memo03_txt;
        private System.Windows.Forms.TextBox Memo04_txt;
        private System.Windows.Forms.TextBox Memo05_txt;
        private System.Windows.Forms.TextBox Memo06_txt;
        private System.Windows.Forms.TextBox Memo07_txt;
        private System.Windows.Forms.TextBox Memo08_txt;
        private System.Windows.Forms.TextBox Memo09_txt;
        private System.Windows.Forms.TextBox Memo10_txt;
        private System.Windows.Forms.PictureBox BackGround_pb;
        private System.Windows.Forms.Label colum_lbl;
        private System.Windows.Forms.Label Debug_label1b;
        private System.Windows.Forms.Label lbl_Rec_01;
        private System.Windows.Forms.Label lbl_Rec_02;
        private System.Windows.Forms.Label lbl_Rec_03;
        private System.Windows.Forms.Label lbl_Rec_04;
        private System.Windows.Forms.Label lbl_Rec_05;
        private System.Windows.Forms.Label lbl_Rec_06;
        private System.Windows.Forms.Label lbl_Rec_07;
        private System.Windows.Forms.Label lbl_Rec_08;
        private System.Windows.Forms.Label lbl_Rec_09;
        private System.Windows.Forms.Label lbl_Rec_10;
        private System.Windows.Forms.Label lbl_Send_01;
        private System.Windows.Forms.Label lbl_Send_02;
        private System.Windows.Forms.Label lbl_Send_03;
        private System.Windows.Forms.Label lbl_Send_04;
        private System.Windows.Forms.Label lbl_Send_05;
        private System.Windows.Forms.Label lbl_Send_06;
        private System.Windows.Forms.Label lbl_Send_07;
        private System.Windows.Forms.Label lbl_Send_08;
        private System.Windows.Forms.Label lbl_Send_09;
        private System.Windows.Forms.Label lbl_Send_10;
        private System.Windows.Forms.ImageList imageList_rec_btn;
        private System.Windows.Forms.ImageList imageList_send_btn;
        private System.Windows.Forms.Label StatusBox_lbl3;
        private System.Windows.Forms.Label lbl_FileImport;
        private System.Windows.Forms.Label lbl_FileExport;
        private System.Windows.Forms.ImageList FileImportExport_imageList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


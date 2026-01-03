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
            this.KeyboardValue_txtbx = new System.Windows.Forms.TextBox();
            this.ToggleLEDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PushbuttonStateTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.MouseMove_UD = new System.Windows.Forms.NumericUpDown();
            this.SetPin_combox = new System.Windows.Forms.ComboBox();
            this.Win_cbox = new System.Windows.Forms.CheckBox();
            this.Shift_cbox = new System.Windows.Forms.CheckBox();
            this.Alt_cbox = new System.Windows.Forms.CheckBox();
            this.Ctrl_cbox = new System.Windows.Forms.CheckBox();
            this.mousevalue_combx = new System.Windows.Forms.ComboBox();
            this.devicetype_combox = new System.Windows.Forms.ComboBox();
            this.devicetype_lbl4 = new System.Windows.Forms.Label();
            this.devicetype_lbl1 = new System.Windows.Forms.Label();
            this.devicetype_lbl3 = new System.Windows.Forms.Label();
            this.devicetype_lbl2 = new System.Windows.Forms.Label();
            this.devicetype_lbl9 = new System.Windows.Forms.Label();
            this.devicetype_lbl8 = new System.Windows.Forms.Label();
            this.devicetype_lbl7 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl4 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl1 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl3 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl2 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl9 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl8 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl7 = new System.Windows.Forms.Label();
            this.StatusBox_lbl = new System.Windows.Forms.Label();
            this.StatusBox_lbl2 = new System.Windows.Forms.Label();
            this.devicetype_lbl5 = new System.Windows.Forms.Label();
            this.devicetype_lbl6 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl5 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl6 = new System.Windows.Forms.Label();
            this.devicetype_lbl10 = new System.Windows.Forms.Label();
            this.devicetype_lbl11 = new System.Windows.Forms.Label();
            this.devicetype_lbl12 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl10 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl11 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl12 = new System.Windows.Forms.Label();
            this.Debug_label1 = new System.Windows.Forms.Label();
            this.Debug_label2 = new System.Windows.Forms.Label();
            this.Debug_label3 = new System.Windows.Forms.Label();
            this.Debug_label4 = new System.Windows.Forms.Label();
            this.Debug_label5 = new System.Windows.Forms.Label();
            this.Receive_btn = new System.Windows.Forms.Button();
            this.Del_btn = new System.Windows.Forms.Button();
            this.Code_lbl = new System.Windows.Forms.Label();
            this.Area01_btn = new System.Windows.Forms.Button();
            this.Area02_btn = new System.Windows.Forms.Button();
            this.Area03_btn = new System.Windows.Forms.Button();
            this.devicetype_lbl13 = new System.Windows.Forms.Label();
            this.devicetype_lbl14 = new System.Windows.Forms.Label();
            this.devicetype_lbl15 = new System.Windows.Forms.Label();
            this.devicetype_lbl16 = new System.Windows.Forms.Label();
            this.devicetype_lbl17 = new System.Windows.Forms.Label();
            this.devicetype_lbl18 = new System.Windows.Forms.Label();
            this.devicetype_lbl19 = new System.Windows.Forms.Label();
            this.devicetype_lbl20 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl13 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl14 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl15 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl16 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl17 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl18 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl19 = new System.Windows.Forms.Label();
            this.DeviceAssign_lbl20 = new System.Windows.Forms.Label();
            this.Memo_txt = new System.Windows.Forms.TextBox();
            this.Area04_btn = new System.Windows.Forms.Button();
            this.Area05_btn = new System.Windows.Forms.Button();
            this.Area06_btn = new System.Windows.Forms.Button();
            this.Area07_btn = new System.Windows.Forms.Button();
            this.Area08_btn = new System.Windows.Forms.Button();
            this.Area09_btn = new System.Windows.Forms.Button();
            this.Area10_btn = new System.Windows.Forms.Button();
            this.Area11_btn = new System.Windows.Forms.Button();
            this.Area12_btn = new System.Windows.Forms.Button();
            this.Area13_btn = new System.Windows.Forms.Button();
            this.Area14_btn = new System.Windows.Forms.Button();
            this.Area15_btn = new System.Windows.Forms.Button();
            this.Area16_btn = new System.Windows.Forms.Button();
            this.Area17_btn = new System.Windows.Forms.Button();
            this.Area18_btn = new System.Windows.Forms.Button();
            this.Area19_btn = new System.Windows.Forms.Button();
            this.Area20_btn = new System.Windows.Forms.Button();
            this.volumevalue_combx = new System.Windows.Forms.ComboBox();
            this.Arrow_Mouse3_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Mouse1_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Com_pb = new System.Windows.Forms.PictureBox();
            this.Arrow_Keyboard_pb = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Status_C_pb = new System.Windows.Forms.PictureBox();
            this.Changevalue_btn = new System.Windows.Forms.Button();
            this.Arrow_Mouse2_pb = new System.Windows.Forms.PictureBox();
            this.Status_NC_pb = new System.Windows.Forms.PictureBox();
            this.BackGround_pb = new System.Windows.Forms.PictureBox();
            this.tmrONFlag = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MouseMove_UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse3_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse1_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Com_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Keyboard_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse2_pb)).BeginInit();
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
            // KeyboardValue_txtbx
            // 
            this.KeyboardValue_txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.KeyboardValue_txtbx.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyboardValue_txtbx.Location = new System.Drawing.Point(26, 361);
            this.KeyboardValue_txtbx.Name = "KeyboardValue_txtbx";
            this.KeyboardValue_txtbx.Size = new System.Drawing.Size(100, 19);
            this.KeyboardValue_txtbx.TabIndex = 112;
            this.KeyboardValue_txtbx.Text = "ここに入力";
            this.KeyboardValue_txtbx.Visible = false;
            this.KeyboardValue_txtbx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyboardValue_txtbx_PreviewKeyDown);
            this.KeyboardValue_txtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardValue_txtbx_KeyDown);
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
            // MouseMove_UD
            // 
            this.MouseMove_UD.BackColor = System.Drawing.SystemColors.Window;
            this.MouseMove_UD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.MouseMove_UD.Location = new System.Drawing.Point(12, 283);
            this.MouseMove_UD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.MouseMove_UD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MouseMove_UD.Name = "MouseMove_UD";
            this.MouseMove_UD.Size = new System.Drawing.Size(128, 19);
            this.MouseMove_UD.TabIndex = 107;
            this.MouseMove_UD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MouseMove_UD.Visible = false;
            this.MouseMove_UD.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // SetPin_combox
            // 
            this.SetPin_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SetPin_combox.Enabled = false;
            this.SetPin_combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.SetPin_combox.FormattingEnabled = true;
            this.SetPin_combox.Items.AddRange(new object[] {
            "ボタン01",
            "ボタン02",
            "ボタン03",
            "ボタン04",
            "ボタン05",
            "ボタン06",
            "ボタン07",
            "ボタン08",
            "ボタン09",
            "ボタン10",
            "ボタン11",
            "ボタン12",
            "ボタン13",
            "ボタン14",
            "ボタン15",
            "ボタン16",
            "ボタン17",
            "ボタン18",
            "ボタン19",
            "ボタン20"});
            this.SetPin_combox.Location = new System.Drawing.Point(16, 84);
            this.SetPin_combox.MaxDropDownItems = 12;
            this.SetPin_combox.Name = "SetPin_combox";
            this.SetPin_combox.Size = new System.Drawing.Size(120, 20);
            this.SetPin_combox.TabIndex = 102;
            this.SetPin_combox.SelectedIndexChanged += new System.EventHandler(this.SetPin_combox_SelectedIndexChanged);
            // 
            // Win_cbox
            // 
            this.Win_cbox.AutoSize = true;
            this.Win_cbox.BackColor = System.Drawing.Color.White;
            this.Win_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Win_cbox.Location = new System.Drawing.Point(54, 298);
            this.Win_cbox.Name = "Win_cbox";
            this.Win_cbox.Size = new System.Drawing.Size(42, 16);
            this.Win_cbox.TabIndex = 111;
            this.Win_cbox.Tag = "4";
            this.Win_cbox.Text = "Win";
            this.Win_cbox.UseVisualStyleBackColor = false;
            this.Win_cbox.Visible = false;
            this.Win_cbox.CheckedChanged += new System.EventHandler(this.KeyboardModifier_cbox_CheckedChanged);
            // 
            // Shift_cbox
            // 
            this.Shift_cbox.AutoSize = true;
            this.Shift_cbox.BackColor = System.Drawing.Color.White;
            this.Shift_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Shift_cbox.Location = new System.Drawing.Point(54, 256);
            this.Shift_cbox.Name = "Shift_cbox";
            this.Shift_cbox.Size = new System.Drawing.Size(48, 16);
            this.Shift_cbox.TabIndex = 109;
            this.Shift_cbox.Tag = "2";
            this.Shift_cbox.Text = "Shift";
            this.Shift_cbox.UseVisualStyleBackColor = false;
            this.Shift_cbox.Visible = false;
            this.Shift_cbox.CheckedChanged += new System.EventHandler(this.KeyboardModifier_cbox_CheckedChanged);
            // 
            // Alt_cbox
            // 
            this.Alt_cbox.AutoSize = true;
            this.Alt_cbox.BackColor = System.Drawing.Color.White;
            this.Alt_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Alt_cbox.Location = new System.Drawing.Point(54, 277);
            this.Alt_cbox.Name = "Alt_cbox";
            this.Alt_cbox.Size = new System.Drawing.Size(39, 16);
            this.Alt_cbox.TabIndex = 110;
            this.Alt_cbox.Tag = "3";
            this.Alt_cbox.Text = "Alt";
            this.Alt_cbox.UseVisualStyleBackColor = false;
            this.Alt_cbox.Visible = false;
            this.Alt_cbox.CheckedChanged += new System.EventHandler(this.KeyboardModifier_cbox_CheckedChanged);
            // 
            // Ctrl_cbox
            // 
            this.Ctrl_cbox.AutoSize = true;
            this.Ctrl_cbox.BackColor = System.Drawing.Color.White;
            this.Ctrl_cbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.Ctrl_cbox.Location = new System.Drawing.Point(54, 235);
            this.Ctrl_cbox.Name = "Ctrl_cbox";
            this.Ctrl_cbox.Size = new System.Drawing.Size(43, 16);
            this.Ctrl_cbox.TabIndex = 108;
            this.Ctrl_cbox.Tag = "1";
            this.Ctrl_cbox.Text = "Ctrl";
            this.Ctrl_cbox.UseVisualStyleBackColor = false;
            this.Ctrl_cbox.Visible = false;
            this.Ctrl_cbox.CheckedChanged += new System.EventHandler(this.KeyboardModifier_cbox_CheckedChanged);
            // 
            // mousevalue_combx
            // 
            this.mousevalue_combx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mousevalue_combx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.mousevalue_combx.FormattingEnabled = true;
            this.mousevalue_combx.Items.AddRange(new object[] {
            "左クリック",
            "右クリック",
            "ホイールクリック"});
            this.mousevalue_combx.Location = new System.Drawing.Point(16, 226);
            this.mousevalue_combx.Name = "mousevalue_combx";
            this.mousevalue_combx.Size = new System.Drawing.Size(120, 20);
            this.mousevalue_combx.TabIndex = 26;
            this.mousevalue_combx.Visible = false;
            this.mousevalue_combx.SelectedIndexChanged += new System.EventHandler(this.mousevalue_combx_SelectedIndexChanged);
            // 
            // devicetype_combox
            // 
            this.devicetype_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.devicetype_combox.Enabled = false;
            this.devicetype_combox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.devicetype_combox.FormattingEnabled = true;
            this.devicetype_combox.Items.AddRange(new object[] {
            "マウス",
            "キーボード",
            "ボリューム"});
            this.devicetype_combox.Location = new System.Drawing.Point(16, 169);
            this.devicetype_combox.Name = "devicetype_combox";
            this.devicetype_combox.Size = new System.Drawing.Size(120, 20);
            this.devicetype_combox.TabIndex = 105;
            this.devicetype_combox.SelectedIndexChanged += new System.EventHandler(this.devicetype_combox_SelectedIndexChanged);
            // 
            // devicetype_lbl4
            // 
            this.devicetype_lbl4.AutoSize = true;
            this.devicetype_lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl4.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl4.Location = new System.Drawing.Point(274, 107);
            this.devicetype_lbl4.Name = "devicetype_lbl4";
            this.devicetype_lbl4.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl4.TabIndex = 99;
            this.devicetype_lbl4.Text = "code or memo";
            // 
            // devicetype_lbl1
            // 
            this.devicetype_lbl1.AutoSize = true;
            this.devicetype_lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl1.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl1.Location = new System.Drawing.Point(274, 29);
            this.devicetype_lbl1.Name = "devicetype_lbl1";
            this.devicetype_lbl1.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl1.TabIndex = 100;
            this.devicetype_lbl1.Tag = "1";
            this.devicetype_lbl1.Text = "code or memo";
            // 
            // devicetype_lbl3
            // 
            this.devicetype_lbl3.AutoSize = true;
            this.devicetype_lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl3.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl3.Location = new System.Drawing.Point(274, 81);
            this.devicetype_lbl3.Name = "devicetype_lbl3";
            this.devicetype_lbl3.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl3.TabIndex = 101;
            this.devicetype_lbl3.Tag = "3";
            this.devicetype_lbl3.Text = "code or memo";
            // 
            // devicetype_lbl2
            // 
            this.devicetype_lbl2.AutoSize = true;
            this.devicetype_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl2.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl2.Location = new System.Drawing.Point(274, 55);
            this.devicetype_lbl2.Name = "devicetype_lbl2";
            this.devicetype_lbl2.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl2.TabIndex = 102;
            this.devicetype_lbl2.Tag = "2";
            this.devicetype_lbl2.Text = "code or memo";
            // 
            // devicetype_lbl9
            // 
            this.devicetype_lbl9.AutoSize = true;
            this.devicetype_lbl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl9.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl9.Location = new System.Drawing.Point(274, 237);
            this.devicetype_lbl9.Name = "devicetype_lbl9";
            this.devicetype_lbl9.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl9.TabIndex = 103;
            this.devicetype_lbl9.Text = "code or memo";
            // 
            // devicetype_lbl8
            // 
            this.devicetype_lbl8.AutoSize = true;
            this.devicetype_lbl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl8.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl8.Location = new System.Drawing.Point(274, 211);
            this.devicetype_lbl8.Name = "devicetype_lbl8";
            this.devicetype_lbl8.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl8.TabIndex = 104;
            this.devicetype_lbl8.Text = "code or memo";
            // 
            // devicetype_lbl7
            // 
            this.devicetype_lbl7.AutoSize = true;
            this.devicetype_lbl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl7.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl7.Location = new System.Drawing.Point(274, 185);
            this.devicetype_lbl7.Name = "devicetype_lbl7";
            this.devicetype_lbl7.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl7.TabIndex = 105;
            this.devicetype_lbl7.Text = "code or memo";
            // 
            // DeviceAssign_lbl4
            // 
            this.DeviceAssign_lbl4.AutoSize = true;
            this.DeviceAssign_lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl4.Location = new System.Drawing.Point(417, 107);
            this.DeviceAssign_lbl4.Name = "DeviceAssign_lbl4";
            this.DeviceAssign_lbl4.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl4.TabIndex = 106;
            this.DeviceAssign_lbl4.Text = "Assign";
            // 
            // DeviceAssign_lbl1
            // 
            this.DeviceAssign_lbl1.AutoSize = true;
            this.DeviceAssign_lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl1.Location = new System.Drawing.Point(417, 29);
            this.DeviceAssign_lbl1.Name = "DeviceAssign_lbl1";
            this.DeviceAssign_lbl1.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl1.TabIndex = 107;
            this.DeviceAssign_lbl1.Tag = "1";
            this.DeviceAssign_lbl1.Text = "Assign";
            // 
            // DeviceAssign_lbl3
            // 
            this.DeviceAssign_lbl3.AutoSize = true;
            this.DeviceAssign_lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl3.Location = new System.Drawing.Point(417, 81);
            this.DeviceAssign_lbl3.Name = "DeviceAssign_lbl3";
            this.DeviceAssign_lbl3.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl3.TabIndex = 108;
            this.DeviceAssign_lbl3.Tag = "3";
            this.DeviceAssign_lbl3.Text = "Assign";
            // 
            // DeviceAssign_lbl2
            // 
            this.DeviceAssign_lbl2.AutoSize = true;
            this.DeviceAssign_lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl2.Location = new System.Drawing.Point(417, 55);
            this.DeviceAssign_lbl2.Name = "DeviceAssign_lbl2";
            this.DeviceAssign_lbl2.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl2.TabIndex = 109;
            this.DeviceAssign_lbl2.Tag = "2";
            this.DeviceAssign_lbl2.Text = "Assign";
            // 
            // DeviceAssign_lbl9
            // 
            this.DeviceAssign_lbl9.AutoSize = true;
            this.DeviceAssign_lbl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl9.Location = new System.Drawing.Point(417, 237);
            this.DeviceAssign_lbl9.Name = "DeviceAssign_lbl9";
            this.DeviceAssign_lbl9.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl9.TabIndex = 110;
            this.DeviceAssign_lbl9.Text = "Assign";
            // 
            // DeviceAssign_lbl8
            // 
            this.DeviceAssign_lbl8.AutoSize = true;
            this.DeviceAssign_lbl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl8.Location = new System.Drawing.Point(417, 211);
            this.DeviceAssign_lbl8.Name = "DeviceAssign_lbl8";
            this.DeviceAssign_lbl8.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl8.TabIndex = 111;
            this.DeviceAssign_lbl8.Text = "Assign";
            // 
            // DeviceAssign_lbl7
            // 
            this.DeviceAssign_lbl7.AutoSize = true;
            this.DeviceAssign_lbl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl7.Location = new System.Drawing.Point(417, 185);
            this.DeviceAssign_lbl7.Name = "DeviceAssign_lbl7";
            this.DeviceAssign_lbl7.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl7.TabIndex = 112;
            this.DeviceAssign_lbl7.Text = "Assign";
            // 
            // StatusBox_lbl
            // 
            this.StatusBox_lbl.AutoSize = true;
            this.StatusBox_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.StatusBox_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.StatusBox_lbl.Location = new System.Drawing.Point(757, 548);
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
            this.StatusBox_lbl2.Location = new System.Drawing.Point(19, 548);
            this.StatusBox_lbl2.Name = "StatusBox_lbl2";
            this.StatusBox_lbl2.Size = new System.Drawing.Size(282, 12);
            this.StatusBox_lbl2.TabIndex = 118;
            this.StatusBox_lbl2.Text = "USB赤外線リモコンキット, Configuration Tool起動しました";
            // 
            // devicetype_lbl5
            // 
            this.devicetype_lbl5.AutoSize = true;
            this.devicetype_lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl5.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl5.Location = new System.Drawing.Point(274, 133);
            this.devicetype_lbl5.Name = "devicetype_lbl5";
            this.devicetype_lbl5.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl5.TabIndex = 153;
            this.devicetype_lbl5.Text = "code or memo";
            // 
            // devicetype_lbl6
            // 
            this.devicetype_lbl6.AutoSize = true;
            this.devicetype_lbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl6.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl6.Location = new System.Drawing.Point(274, 159);
            this.devicetype_lbl6.Name = "devicetype_lbl6";
            this.devicetype_lbl6.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl6.TabIndex = 154;
            this.devicetype_lbl6.Text = "code or memo";
            // 
            // DeviceAssign_lbl5
            // 
            this.DeviceAssign_lbl5.AutoSize = true;
            this.DeviceAssign_lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl5.Location = new System.Drawing.Point(417, 133);
            this.DeviceAssign_lbl5.Name = "DeviceAssign_lbl5";
            this.DeviceAssign_lbl5.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl5.TabIndex = 155;
            this.DeviceAssign_lbl5.Text = "Assign";
            // 
            // DeviceAssign_lbl6
            // 
            this.DeviceAssign_lbl6.AutoSize = true;
            this.DeviceAssign_lbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl6.Location = new System.Drawing.Point(417, 159);
            this.DeviceAssign_lbl6.Name = "DeviceAssign_lbl6";
            this.DeviceAssign_lbl6.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl6.TabIndex = 156;
            this.DeviceAssign_lbl6.Text = "Assign";
            // 
            // devicetype_lbl10
            // 
            this.devicetype_lbl10.AutoSize = true;
            this.devicetype_lbl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl10.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl10.Location = new System.Drawing.Point(274, 263);
            this.devicetype_lbl10.Name = "devicetype_lbl10";
            this.devicetype_lbl10.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl10.TabIndex = 157;
            this.devicetype_lbl10.Text = "code or memo";
            // 
            // devicetype_lbl11
            // 
            this.devicetype_lbl11.AutoSize = true;
            this.devicetype_lbl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl11.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl11.Location = new System.Drawing.Point(274, 289);
            this.devicetype_lbl11.Name = "devicetype_lbl11";
            this.devicetype_lbl11.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl11.TabIndex = 158;
            this.devicetype_lbl11.Text = "code or memo";
            // 
            // devicetype_lbl12
            // 
            this.devicetype_lbl12.AutoSize = true;
            this.devicetype_lbl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl12.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl12.Location = new System.Drawing.Point(274, 315);
            this.devicetype_lbl12.Name = "devicetype_lbl12";
            this.devicetype_lbl12.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl12.TabIndex = 159;
            this.devicetype_lbl12.Text = "code or memo";
            // 
            // DeviceAssign_lbl10
            // 
            this.DeviceAssign_lbl10.AutoSize = true;
            this.DeviceAssign_lbl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl10.Location = new System.Drawing.Point(417, 263);
            this.DeviceAssign_lbl10.Name = "DeviceAssign_lbl10";
            this.DeviceAssign_lbl10.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl10.TabIndex = 160;
            this.DeviceAssign_lbl10.Text = "Assign";
            // 
            // DeviceAssign_lbl11
            // 
            this.DeviceAssign_lbl11.AutoSize = true;
            this.DeviceAssign_lbl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl11.Location = new System.Drawing.Point(417, 289);
            this.DeviceAssign_lbl11.Name = "DeviceAssign_lbl11";
            this.DeviceAssign_lbl11.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl11.TabIndex = 161;
            this.DeviceAssign_lbl11.Text = "Assign";
            // 
            // DeviceAssign_lbl12
            // 
            this.DeviceAssign_lbl12.AutoSize = true;
            this.DeviceAssign_lbl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl12.Location = new System.Drawing.Point(417, 315);
            this.DeviceAssign_lbl12.Name = "DeviceAssign_lbl12";
            this.DeviceAssign_lbl12.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl12.TabIndex = 162;
            this.DeviceAssign_lbl12.Text = "Assign";
            // 
            // Debug_label1
            // 
            this.Debug_label1.AutoSize = true;
            this.Debug_label1.Location = new System.Drawing.Point(505, 442);
            this.Debug_label1.Name = "Debug_label1";
            this.Debug_label1.Size = new System.Drawing.Size(41, 12);
            this.Debug_label1.TabIndex = 164;
            this.Debug_label1.Text = "debug1";
            this.Debug_label1.Visible = false;
            // 
            // Debug_label2
            // 
            this.Debug_label2.AutoSize = true;
            this.Debug_label2.Location = new System.Drawing.Point(505, 454);
            this.Debug_label2.Name = "Debug_label2";
            this.Debug_label2.Size = new System.Drawing.Size(41, 12);
            this.Debug_label2.TabIndex = 165;
            this.Debug_label2.Text = "debug1";
            this.Debug_label2.Visible = false;
            // 
            // Debug_label3
            // 
            this.Debug_label3.AutoSize = true;
            this.Debug_label3.Location = new System.Drawing.Point(505, 466);
            this.Debug_label3.Name = "Debug_label3";
            this.Debug_label3.Size = new System.Drawing.Size(41, 12);
            this.Debug_label3.TabIndex = 166;
            this.Debug_label3.Text = "debug1";
            this.Debug_label3.Visible = false;
            // 
            // Debug_label4
            // 
            this.Debug_label4.AutoSize = true;
            this.Debug_label4.Location = new System.Drawing.Point(505, 495);
            this.Debug_label4.Name = "Debug_label4";
            this.Debug_label4.Size = new System.Drawing.Size(41, 12);
            this.Debug_label4.TabIndex = 167;
            this.Debug_label4.Text = "debug1";
            this.Debug_label4.Visible = false;
            // 
            // Debug_label5
            // 
            this.Debug_label5.AutoSize = true;
            this.Debug_label5.Location = new System.Drawing.Point(505, 507);
            this.Debug_label5.Name = "Debug_label5";
            this.Debug_label5.Size = new System.Drawing.Size(41, 12);
            this.Debug_label5.TabIndex = 168;
            this.Debug_label5.Text = "debug1";
            this.Debug_label5.Visible = false;
            // 
            // Receive_btn
            // 
            this.Receive_btn.Enabled = false;
            this.Receive_btn.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Receive_btn.Location = new System.Drawing.Point(16, 135);
            this.Receive_btn.Name = "Receive_btn";
            this.Receive_btn.Size = new System.Drawing.Size(60, 23);
            this.Receive_btn.TabIndex = 103;
            this.Receive_btn.Text = "受信開始";
            this.Receive_btn.UseVisualStyleBackColor = true;
            this.Receive_btn.Click += new System.EventHandler(this.Receive_btn_Click);
            // 
            // Del_btn
            // 
            this.Del_btn.Enabled = false;
            this.Del_btn.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Del_btn.Location = new System.Drawing.Point(76, 135);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(59, 23);
            this.Del_btn.TabIndex = 104;
            this.Del_btn.Text = "消去";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // Code_lbl
            // 
            this.Code_lbl.AutoSize = true;
            this.Code_lbl.BackColor = System.Drawing.Color.White;
            this.Code_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Code_lbl.Location = new System.Drawing.Point(21, 115);
            this.Code_lbl.Name = "Code_lbl";
            this.Code_lbl.Size = new System.Drawing.Size(0, 12);
            this.Code_lbl.TabIndex = 172;
            // 
            // Area01_btn
            // 
            this.Area01_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area01_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area01_btn.Location = new System.Drawing.Point(193, 25);
            this.Area01_btn.Name = "Area01_btn";
            this.Area01_btn.Size = new System.Drawing.Size(75, 21);
            this.Area01_btn.TabIndex = 201;
            this.Area01_btn.Tag = "1";
            this.Area01_btn.Text = "ボタン01";
            this.Area01_btn.UseVisualStyleBackColor = true;
            this.Area01_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area02_btn
            // 
            this.Area02_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area02_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area02_btn.Location = new System.Drawing.Point(193, 51);
            this.Area02_btn.Name = "Area02_btn";
            this.Area02_btn.Size = new System.Drawing.Size(75, 21);
            this.Area02_btn.TabIndex = 202;
            this.Area02_btn.Tag = "2";
            this.Area02_btn.Text = "ボタン02";
            this.Area02_btn.UseVisualStyleBackColor = true;
            this.Area02_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area03_btn
            // 
            this.Area03_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area03_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area03_btn.Location = new System.Drawing.Point(193, 77);
            this.Area03_btn.Name = "Area03_btn";
            this.Area03_btn.Size = new System.Drawing.Size(75, 21);
            this.Area03_btn.TabIndex = 203;
            this.Area03_btn.Tag = "3";
            this.Area03_btn.Text = "ボタン03";
            this.Area03_btn.UseVisualStyleBackColor = true;
            this.Area03_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // devicetype_lbl13
            // 
            this.devicetype_lbl13.AutoSize = true;
            this.devicetype_lbl13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl13.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl13.Location = new System.Drawing.Point(274, 341);
            this.devicetype_lbl13.Name = "devicetype_lbl13";
            this.devicetype_lbl13.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl13.TabIndex = 176;
            this.devicetype_lbl13.Text = "code or memo";
            // 
            // devicetype_lbl14
            // 
            this.devicetype_lbl14.AutoSize = true;
            this.devicetype_lbl14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl14.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl14.Location = new System.Drawing.Point(274, 367);
            this.devicetype_lbl14.Name = "devicetype_lbl14";
            this.devicetype_lbl14.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl14.TabIndex = 177;
            this.devicetype_lbl14.Text = "code or memo";
            // 
            // devicetype_lbl15
            // 
            this.devicetype_lbl15.AutoSize = true;
            this.devicetype_lbl15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl15.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl15.Location = new System.Drawing.Point(274, 393);
            this.devicetype_lbl15.Name = "devicetype_lbl15";
            this.devicetype_lbl15.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl15.TabIndex = 178;
            this.devicetype_lbl15.Text = "code or memo";
            // 
            // devicetype_lbl16
            // 
            this.devicetype_lbl16.AutoSize = true;
            this.devicetype_lbl16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl16.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl16.Location = new System.Drawing.Point(274, 419);
            this.devicetype_lbl16.Name = "devicetype_lbl16";
            this.devicetype_lbl16.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl16.TabIndex = 179;
            this.devicetype_lbl16.Text = "code or memo";
            // 
            // devicetype_lbl17
            // 
            this.devicetype_lbl17.AutoSize = true;
            this.devicetype_lbl17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl17.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl17.Location = new System.Drawing.Point(274, 445);
            this.devicetype_lbl17.Name = "devicetype_lbl17";
            this.devicetype_lbl17.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl17.TabIndex = 180;
            this.devicetype_lbl17.Text = "code or memo";
            // 
            // devicetype_lbl18
            // 
            this.devicetype_lbl18.AutoSize = true;
            this.devicetype_lbl18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl18.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl18.Location = new System.Drawing.Point(274, 471);
            this.devicetype_lbl18.Name = "devicetype_lbl18";
            this.devicetype_lbl18.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl18.TabIndex = 181;
            this.devicetype_lbl18.Text = "code or memo";
            // 
            // devicetype_lbl19
            // 
            this.devicetype_lbl19.AutoSize = true;
            this.devicetype_lbl19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl19.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl19.Location = new System.Drawing.Point(274, 497);
            this.devicetype_lbl19.Name = "devicetype_lbl19";
            this.devicetype_lbl19.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl19.TabIndex = 182;
            this.devicetype_lbl19.Text = "code or memo";
            // 
            // devicetype_lbl20
            // 
            this.devicetype_lbl20.AutoSize = true;
            this.devicetype_lbl20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.devicetype_lbl20.ForeColor = System.Drawing.Color.White;
            this.devicetype_lbl20.Location = new System.Drawing.Point(274, 523);
            this.devicetype_lbl20.Name = "devicetype_lbl20";
            this.devicetype_lbl20.Size = new System.Drawing.Size(77, 12);
            this.devicetype_lbl20.TabIndex = 183;
            this.devicetype_lbl20.Text = "code or memo";
            // 
            // DeviceAssign_lbl13
            // 
            this.DeviceAssign_lbl13.AutoSize = true;
            this.DeviceAssign_lbl13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl13.Location = new System.Drawing.Point(417, 341);
            this.DeviceAssign_lbl13.Name = "DeviceAssign_lbl13";
            this.DeviceAssign_lbl13.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl13.TabIndex = 184;
            this.DeviceAssign_lbl13.Text = "Assign";
            // 
            // DeviceAssign_lbl14
            // 
            this.DeviceAssign_lbl14.AutoSize = true;
            this.DeviceAssign_lbl14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl14.Location = new System.Drawing.Point(417, 367);
            this.DeviceAssign_lbl14.Name = "DeviceAssign_lbl14";
            this.DeviceAssign_lbl14.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl14.TabIndex = 185;
            this.DeviceAssign_lbl14.Text = "Assign";
            // 
            // DeviceAssign_lbl15
            // 
            this.DeviceAssign_lbl15.AutoSize = true;
            this.DeviceAssign_lbl15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl15.Location = new System.Drawing.Point(417, 393);
            this.DeviceAssign_lbl15.Name = "DeviceAssign_lbl15";
            this.DeviceAssign_lbl15.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl15.TabIndex = 186;
            this.DeviceAssign_lbl15.Text = "Assign";
            // 
            // DeviceAssign_lbl16
            // 
            this.DeviceAssign_lbl16.AutoSize = true;
            this.DeviceAssign_lbl16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl16.Location = new System.Drawing.Point(417, 419);
            this.DeviceAssign_lbl16.Name = "DeviceAssign_lbl16";
            this.DeviceAssign_lbl16.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl16.TabIndex = 187;
            this.DeviceAssign_lbl16.Text = "Assign";
            // 
            // DeviceAssign_lbl17
            // 
            this.DeviceAssign_lbl17.AutoSize = true;
            this.DeviceAssign_lbl17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl17.Location = new System.Drawing.Point(417, 445);
            this.DeviceAssign_lbl17.Name = "DeviceAssign_lbl17";
            this.DeviceAssign_lbl17.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl17.TabIndex = 188;
            this.DeviceAssign_lbl17.Text = "Assign";
            // 
            // DeviceAssign_lbl18
            // 
            this.DeviceAssign_lbl18.AutoSize = true;
            this.DeviceAssign_lbl18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl18.Location = new System.Drawing.Point(417, 471);
            this.DeviceAssign_lbl18.Name = "DeviceAssign_lbl18";
            this.DeviceAssign_lbl18.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl18.TabIndex = 189;
            this.DeviceAssign_lbl18.Text = "Assign";
            // 
            // DeviceAssign_lbl19
            // 
            this.DeviceAssign_lbl19.AutoSize = true;
            this.DeviceAssign_lbl19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl19.Location = new System.Drawing.Point(417, 497);
            this.DeviceAssign_lbl19.Name = "DeviceAssign_lbl19";
            this.DeviceAssign_lbl19.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl19.TabIndex = 190;
            this.DeviceAssign_lbl19.Text = "Assign";
            // 
            // DeviceAssign_lbl20
            // 
            this.DeviceAssign_lbl20.AutoSize = true;
            this.DeviceAssign_lbl20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DeviceAssign_lbl20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DeviceAssign_lbl20.Location = new System.Drawing.Point(417, 523);
            this.DeviceAssign_lbl20.Name = "DeviceAssign_lbl20";
            this.DeviceAssign_lbl20.Size = new System.Drawing.Size(40, 12);
            this.DeviceAssign_lbl20.TabIndex = 191;
            this.DeviceAssign_lbl20.Text = "Assign";
            // 
            // Memo_txt
            // 
            this.Memo_txt.Enabled = false;
            this.Memo_txt.Location = new System.Drawing.Point(26, 52);
            this.Memo_txt.Name = "Memo_txt";
            this.Memo_txt.Size = new System.Drawing.Size(100, 19);
            this.Memo_txt.TabIndex = 101;
            // 
            // Area04_btn
            // 
            this.Area04_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area04_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area04_btn.Location = new System.Drawing.Point(193, 103);
            this.Area04_btn.Name = "Area04_btn";
            this.Area04_btn.Size = new System.Drawing.Size(75, 21);
            this.Area04_btn.TabIndex = 204;
            this.Area04_btn.Tag = "4";
            this.Area04_btn.Text = "ボタン04";
            this.Area04_btn.UseVisualStyleBackColor = true;
            this.Area04_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area05_btn
            // 
            this.Area05_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area05_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area05_btn.Location = new System.Drawing.Point(193, 129);
            this.Area05_btn.Name = "Area05_btn";
            this.Area05_btn.Size = new System.Drawing.Size(75, 21);
            this.Area05_btn.TabIndex = 205;
            this.Area05_btn.Tag = "5";
            this.Area05_btn.Text = "ボタン05";
            this.Area05_btn.UseVisualStyleBackColor = true;
            this.Area05_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area06_btn
            // 
            this.Area06_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area06_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area06_btn.Location = new System.Drawing.Point(193, 155);
            this.Area06_btn.Name = "Area06_btn";
            this.Area06_btn.Size = new System.Drawing.Size(75, 21);
            this.Area06_btn.TabIndex = 206;
            this.Area06_btn.Tag = "6";
            this.Area06_btn.Text = "ボタン06";
            this.Area06_btn.UseVisualStyleBackColor = true;
            this.Area06_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area07_btn
            // 
            this.Area07_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area07_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area07_btn.Location = new System.Drawing.Point(193, 181);
            this.Area07_btn.Name = "Area07_btn";
            this.Area07_btn.Size = new System.Drawing.Size(75, 21);
            this.Area07_btn.TabIndex = 207;
            this.Area07_btn.Tag = "7";
            this.Area07_btn.Text = "ボタン07";
            this.Area07_btn.UseVisualStyleBackColor = true;
            this.Area07_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area08_btn
            // 
            this.Area08_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area08_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area08_btn.Location = new System.Drawing.Point(193, 207);
            this.Area08_btn.Name = "Area08_btn";
            this.Area08_btn.Size = new System.Drawing.Size(75, 21);
            this.Area08_btn.TabIndex = 208;
            this.Area08_btn.Tag = "8";
            this.Area08_btn.Text = "ボタン08";
            this.Area08_btn.UseVisualStyleBackColor = true;
            this.Area08_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area09_btn
            // 
            this.Area09_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area09_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area09_btn.Location = new System.Drawing.Point(193, 233);
            this.Area09_btn.Name = "Area09_btn";
            this.Area09_btn.Size = new System.Drawing.Size(75, 21);
            this.Area09_btn.TabIndex = 209;
            this.Area09_btn.Tag = "9";
            this.Area09_btn.Text = "ボタン09";
            this.Area09_btn.UseVisualStyleBackColor = true;
            this.Area09_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area10_btn
            // 
            this.Area10_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area10_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area10_btn.Location = new System.Drawing.Point(193, 259);
            this.Area10_btn.Name = "Area10_btn";
            this.Area10_btn.Size = new System.Drawing.Size(75, 21);
            this.Area10_btn.TabIndex = 210;
            this.Area10_btn.Tag = "10";
            this.Area10_btn.Text = "ボタン10";
            this.Area10_btn.UseVisualStyleBackColor = true;
            this.Area10_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area11_btn
            // 
            this.Area11_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area11_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area11_btn.Location = new System.Drawing.Point(193, 285);
            this.Area11_btn.Name = "Area11_btn";
            this.Area11_btn.Size = new System.Drawing.Size(75, 21);
            this.Area11_btn.TabIndex = 211;
            this.Area11_btn.Tag = "11";
            this.Area11_btn.Text = "ボタン11";
            this.Area11_btn.UseVisualStyleBackColor = true;
            this.Area11_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area12_btn
            // 
            this.Area12_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area12_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area12_btn.Location = new System.Drawing.Point(193, 311);
            this.Area12_btn.Name = "Area12_btn";
            this.Area12_btn.Size = new System.Drawing.Size(75, 21);
            this.Area12_btn.TabIndex = 212;
            this.Area12_btn.Tag = "12";
            this.Area12_btn.Text = "ボタン12";
            this.Area12_btn.UseVisualStyleBackColor = true;
            this.Area12_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area13_btn
            // 
            this.Area13_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area13_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area13_btn.Location = new System.Drawing.Point(193, 337);
            this.Area13_btn.Name = "Area13_btn";
            this.Area13_btn.Size = new System.Drawing.Size(75, 21);
            this.Area13_btn.TabIndex = 213;
            this.Area13_btn.Tag = "13";
            this.Area13_btn.Text = "ボタン13";
            this.Area13_btn.UseVisualStyleBackColor = true;
            this.Area13_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area14_btn
            // 
            this.Area14_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area14_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area14_btn.Location = new System.Drawing.Point(193, 363);
            this.Area14_btn.Name = "Area14_btn";
            this.Area14_btn.Size = new System.Drawing.Size(75, 21);
            this.Area14_btn.TabIndex = 214;
            this.Area14_btn.Tag = "14";
            this.Area14_btn.Text = "ボタン14";
            this.Area14_btn.UseVisualStyleBackColor = true;
            this.Area14_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area15_btn
            // 
            this.Area15_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area15_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area15_btn.Location = new System.Drawing.Point(193, 389);
            this.Area15_btn.Name = "Area15_btn";
            this.Area15_btn.Size = new System.Drawing.Size(75, 21);
            this.Area15_btn.TabIndex = 215;
            this.Area15_btn.Tag = "15";
            this.Area15_btn.Text = "ボタン15";
            this.Area15_btn.UseVisualStyleBackColor = true;
            this.Area15_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area16_btn
            // 
            this.Area16_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area16_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area16_btn.Location = new System.Drawing.Point(193, 415);
            this.Area16_btn.Name = "Area16_btn";
            this.Area16_btn.Size = new System.Drawing.Size(75, 21);
            this.Area16_btn.TabIndex = 216;
            this.Area16_btn.Tag = "16";
            this.Area16_btn.Text = "ボタン16";
            this.Area16_btn.UseVisualStyleBackColor = true;
            this.Area16_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area17_btn
            // 
            this.Area17_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area17_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area17_btn.Location = new System.Drawing.Point(193, 441);
            this.Area17_btn.Name = "Area17_btn";
            this.Area17_btn.Size = new System.Drawing.Size(75, 21);
            this.Area17_btn.TabIndex = 217;
            this.Area17_btn.Tag = "17";
            this.Area17_btn.Text = "ボタン17";
            this.Area17_btn.UseVisualStyleBackColor = true;
            this.Area17_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area18_btn
            // 
            this.Area18_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area18_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area18_btn.Location = new System.Drawing.Point(193, 467);
            this.Area18_btn.Name = "Area18_btn";
            this.Area18_btn.Size = new System.Drawing.Size(75, 21);
            this.Area18_btn.TabIndex = 218;
            this.Area18_btn.Tag = "18";
            this.Area18_btn.Text = "ボタン18";
            this.Area18_btn.UseVisualStyleBackColor = true;
            this.Area18_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area19_btn
            // 
            this.Area19_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area19_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area19_btn.Location = new System.Drawing.Point(193, 493);
            this.Area19_btn.Name = "Area19_btn";
            this.Area19_btn.Size = new System.Drawing.Size(75, 21);
            this.Area19_btn.TabIndex = 219;
            this.Area19_btn.Tag = "19";
            this.Area19_btn.Text = "ボタン19";
            this.Area19_btn.UseVisualStyleBackColor = true;
            this.Area19_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // Area20_btn
            // 
            this.Area20_btn.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Area20_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Area20_btn.Location = new System.Drawing.Point(193, 519);
            this.Area20_btn.Name = "Area20_btn";
            this.Area20_btn.Size = new System.Drawing.Size(75, 21);
            this.Area20_btn.TabIndex = 220;
            this.Area20_btn.Tag = "20";
            this.Area20_btn.Text = "ボタン20";
            this.Area20_btn.UseVisualStyleBackColor = true;
            this.Area20_btn.Click += new System.EventHandler(this.Area_Button_Click);
            // 
            // volumevalue_combx
            // 
            this.volumevalue_combx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.volumevalue_combx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.volumevalue_combx.FormattingEnabled = true;
            this.volumevalue_combx.Items.AddRange(new object[] {
            "アップ",
            "ダウン",
            "ミュート"});
            this.volumevalue_combx.Location = new System.Drawing.Point(16, 226);
            this.volumevalue_combx.Name = "volumevalue_combx";
            this.volumevalue_combx.Size = new System.Drawing.Size(120, 20);
            this.volumevalue_combx.TabIndex = 106;
            this.volumevalue_combx.Visible = false;
            this.volumevalue_combx.SelectedIndexChanged += new System.EventHandler(this.volumevalue_combx_SelectedIndexChanged);
            // 
            // Arrow_Mouse3_pb
            // 
            this.Arrow_Mouse3_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Mouse3_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.F_arrow;
            this.Arrow_Mouse3_pb.Location = new System.Drawing.Point(71, 252);
            this.Arrow_Mouse3_pb.Name = "Arrow_Mouse3_pb";
            this.Arrow_Mouse3_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Mouse3_pb.TabIndex = 137;
            this.Arrow_Mouse3_pb.TabStop = false;
            this.Arrow_Mouse3_pb.Visible = false;
            // 
            // Arrow_Mouse1_pb
            // 
            this.Arrow_Mouse1_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Mouse1_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.F_arrow;
            this.Arrow_Mouse1_pb.Location = new System.Drawing.Point(71, 370);
            this.Arrow_Mouse1_pb.Name = "Arrow_Mouse1_pb";
            this.Arrow_Mouse1_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Mouse1_pb.TabIndex = 133;
            this.Arrow_Mouse1_pb.TabStop = false;
            this.Arrow_Mouse1_pb.Visible = false;
            // 
            // Arrow_Com_pb
            // 
            this.Arrow_Com_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Com_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.F_arrow;
            this.Arrow_Com_pb.Location = new System.Drawing.Point(71, 403);
            this.Arrow_Com_pb.Name = "Arrow_Com_pb";
            this.Arrow_Com_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Com_pb.TabIndex = 115;
            this.Arrow_Com_pb.TabStop = false;
            this.Arrow_Com_pb.Visible = false;
            // 
            // Arrow_Keyboard_pb
            // 
            this.Arrow_Keyboard_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Keyboard_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.F_arrow;
            this.Arrow_Keyboard_pb.Location = new System.Drawing.Point(71, 322);
            this.Arrow_Keyboard_pb.Name = "Arrow_Keyboard_pb";
            this.Arrow_Keyboard_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Keyboard_pb.TabIndex = 114;
            this.Arrow_Keyboard_pb.TabStop = false;
            this.Arrow_Keyboard_pb.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::USB_IR_REMOCON_CT.Properties.Resources.F_wariate;
            this.pictureBox5.Location = new System.Drawing.Point(59, 210);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 13);
            this.pictureBox5.TabIndex = 113;
            this.pictureBox5.TabStop = false;
            // 
            // Status_C_pb
            // 
            this.Status_C_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_C_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.ON;
            this.Status_C_pb.Location = new System.Drawing.Point(843, 549);
            this.Status_C_pb.Name = "Status_C_pb";
            this.Status_C_pb.Size = new System.Drawing.Size(27, 8);
            this.Status_C_pb.TabIndex = 94;
            this.Status_C_pb.TabStop = false;
            this.Status_C_pb.Visible = false;
            // 
            // Changevalue_btn
            // 
            this.Changevalue_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Changevalue_btn.BackgroundImage")));
            this.Changevalue_btn.Enabled = false;
            this.Changevalue_btn.Location = new System.Drawing.Point(16, 490);
            this.Changevalue_btn.Name = "Changevalue_btn";
            this.Changevalue_btn.Size = new System.Drawing.Size(121, 29);
            this.Changevalue_btn.TabIndex = 151;
            this.Changevalue_btn.UseVisualStyleBackColor = true;
            this.Changevalue_btn.Click += new System.EventHandler(this.Changevalue_btn_Click);
            // 
            // Arrow_Mouse2_pb
            // 
            this.Arrow_Mouse2_pb.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_Mouse2_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.F_arrow;
            this.Arrow_Mouse2_pb.Location = new System.Drawing.Point(71, 334);
            this.Arrow_Mouse2_pb.Name = "Arrow_Mouse2_pb";
            this.Arrow_Mouse2_pb.Size = new System.Drawing.Size(9, 12);
            this.Arrow_Mouse2_pb.TabIndex = 135;
            this.Arrow_Mouse2_pb.TabStop = false;
            this.Arrow_Mouse2_pb.Visible = false;
            // 
            // Status_NC_pb
            // 
            this.Status_NC_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_NC_pb.Image = global::USB_IR_REMOCON_CT.Properties.Resources.OFF;
            this.Status_NC_pb.Location = new System.Drawing.Point(843, 549);
            this.Status_NC_pb.Name = "Status_NC_pb";
            this.Status_NC_pb.Size = new System.Drawing.Size(27, 8);
            this.Status_NC_pb.TabIndex = 95;
            this.Status_NC_pb.TabStop = false;
            this.Status_NC_pb.Visible = false;
            // 
            // BackGround_pb
            // 
            this.BackGround_pb.BackColor = System.Drawing.Color.White;
            this.BackGround_pb.BackgroundImage = global::USB_IR_REMOCON_CT.Properties.Resources.R_BG;
            this.BackGround_pb.Location = new System.Drawing.Point(0, 0);
            this.BackGround_pb.Name = "BackGround_pb";
            this.BackGround_pb.Size = new System.Drawing.Size(878, 561);
            this.BackGround_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BackGround_pb.TabIndex = 163;
            this.BackGround_pb.TabStop = false;
            // 
            // tmrONFlag
            // 
            this.tmrONFlag.Interval = 200;
            this.tmrONFlag.Tick += new System.EventHandler(this.tmrONFlag_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 560);
            this.Controls.Add(this.devicetype_lbl1);
            this.Controls.Add(this.volumevalue_combx);
            this.Controls.Add(this.Area20_btn);
            this.Controls.Add(this.Area19_btn);
            this.Controls.Add(this.Area18_btn);
            this.Controls.Add(this.Area17_btn);
            this.Controls.Add(this.Area16_btn);
            this.Controls.Add(this.Area15_btn);
            this.Controls.Add(this.Area14_btn);
            this.Controls.Add(this.Area13_btn);
            this.Controls.Add(this.Area12_btn);
            this.Controls.Add(this.Area11_btn);
            this.Controls.Add(this.Area10_btn);
            this.Controls.Add(this.Area09_btn);
            this.Controls.Add(this.Area08_btn);
            this.Controls.Add(this.Area07_btn);
            this.Controls.Add(this.Area06_btn);
            this.Controls.Add(this.Area05_btn);
            this.Controls.Add(this.Area04_btn);
            this.Controls.Add(this.Memo_txt);
            this.Controls.Add(this.DeviceAssign_lbl20);
            this.Controls.Add(this.DeviceAssign_lbl19);
            this.Controls.Add(this.DeviceAssign_lbl18);
            this.Controls.Add(this.DeviceAssign_lbl17);
            this.Controls.Add(this.DeviceAssign_lbl16);
            this.Controls.Add(this.DeviceAssign_lbl15);
            this.Controls.Add(this.DeviceAssign_lbl14);
            this.Controls.Add(this.DeviceAssign_lbl13);
            this.Controls.Add(this.devicetype_lbl20);
            this.Controls.Add(this.devicetype_lbl19);
            this.Controls.Add(this.devicetype_lbl18);
            this.Controls.Add(this.devicetype_lbl17);
            this.Controls.Add(this.devicetype_lbl16);
            this.Controls.Add(this.devicetype_lbl15);
            this.Controls.Add(this.devicetype_lbl14);
            this.Controls.Add(this.devicetype_lbl13);
            this.Controls.Add(this.Area03_btn);
            this.Controls.Add(this.Area02_btn);
            this.Controls.Add(this.Area01_btn);
            this.Controls.Add(this.Code_lbl);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.Receive_btn);
            this.Controls.Add(this.Debug_label5);
            this.Controls.Add(this.Debug_label4);
            this.Controls.Add(this.Debug_label3);
            this.Controls.Add(this.Debug_label2);
            this.Controls.Add(this.Debug_label1);
            this.Controls.Add(this.DeviceAssign_lbl12);
            this.Controls.Add(this.DeviceAssign_lbl11);
            this.Controls.Add(this.DeviceAssign_lbl10);
            this.Controls.Add(this.devicetype_lbl12);
            this.Controls.Add(this.devicetype_lbl11);
            this.Controls.Add(this.devicetype_lbl10);
            this.Controls.Add(this.DeviceAssign_lbl6);
            this.Controls.Add(this.DeviceAssign_lbl5);
            this.Controls.Add(this.devicetype_lbl6);
            this.Controls.Add(this.devicetype_lbl5);
            this.Controls.Add(this.Arrow_Mouse3_pb);
            this.Controls.Add(this.Arrow_Mouse1_pb);
            this.Controls.Add(this.StatusBox_lbl2);
            this.Controls.Add(this.StatusBox_lbl);
            this.Controls.Add(this.Arrow_Com_pb);
            this.Controls.Add(this.Arrow_Keyboard_pb);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.DeviceAssign_lbl7);
            this.Controls.Add(this.DeviceAssign_lbl8);
            this.Controls.Add(this.DeviceAssign_lbl9);
            this.Controls.Add(this.DeviceAssign_lbl2);
            this.Controls.Add(this.DeviceAssign_lbl3);
            this.Controls.Add(this.DeviceAssign_lbl1);
            this.Controls.Add(this.DeviceAssign_lbl4);
            this.Controls.Add(this.devicetype_lbl7);
            this.Controls.Add(this.devicetype_lbl8);
            this.Controls.Add(this.devicetype_lbl9);
            this.Controls.Add(this.devicetype_lbl2);
            this.Controls.Add(this.devicetype_lbl3);
            this.Controls.Add(this.devicetype_lbl4);
            this.Controls.Add(this.Status_C_pb);
            this.Controls.Add(this.SetPin_combox);
            this.Controls.Add(this.Win_cbox);
            this.Controls.Add(this.Shift_cbox);
            this.Controls.Add(this.Alt_cbox);
            this.Controls.Add(this.Ctrl_cbox);
            this.Controls.Add(this.KeyboardValue_txtbx);
            this.Controls.Add(this.mousevalue_combx);
            this.Controls.Add(this.devicetype_combox);
            this.Controls.Add(this.Changevalue_btn);
            this.Controls.Add(this.MouseMove_UD);
            this.Controls.Add(this.Arrow_Mouse2_pb);
            this.Controls.Add(this.Status_NC_pb);
            this.Controls.Add(this.BackGround_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(887, 596);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "USB赤外線リモコンキット 受信設定, Configuration Tool ver 1.10";
            ((System.ComponentModel.ISupportInitialize)(this.MouseMove_UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse3_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse1_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Com_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Keyboard_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_Mouse2_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changevalue_btn;
        private System.ComponentModel.BackgroundWorker ReadWriteThread;
        private System.Windows.Forms.Timer FormUpdateTimer;
        private System.Windows.Forms.ToolTip ToggleLEDToolTip;
        private System.Windows.Forms.ToolTip PushbuttonStateTooltip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ComboBox devicetype_combox;
        private System.Windows.Forms.ComboBox mousevalue_combx;
        private System.Windows.Forms.TextBox KeyboardValue_txtbx;
        private System.Windows.Forms.CheckBox Ctrl_cbox;
        private System.Windows.Forms.CheckBox Win_cbox;
        private System.Windows.Forms.CheckBox Shift_cbox;
        private System.Windows.Forms.CheckBox Alt_cbox;
        private System.Windows.Forms.ComboBox SetPin_combox;
        private System.Windows.Forms.NumericUpDown MouseMove_UD;
        private System.Windows.Forms.PictureBox Status_C_pb;
        private System.Windows.Forms.PictureBox Status_NC_pb;
        private System.Windows.Forms.Label devicetype_lbl4;
        private System.Windows.Forms.Label devicetype_lbl1;
        private System.Windows.Forms.Label devicetype_lbl3;
        private System.Windows.Forms.Label devicetype_lbl2;
        private System.Windows.Forms.Label devicetype_lbl9;
        private System.Windows.Forms.Label devicetype_lbl8;
        private System.Windows.Forms.Label devicetype_lbl7;
        private System.Windows.Forms.Label DeviceAssign_lbl4;
        private System.Windows.Forms.Label DeviceAssign_lbl1;
        private System.Windows.Forms.Label DeviceAssign_lbl3;
        private System.Windows.Forms.Label DeviceAssign_lbl2;
        private System.Windows.Forms.Label DeviceAssign_lbl9;
        private System.Windows.Forms.Label DeviceAssign_lbl8;
        private System.Windows.Forms.Label DeviceAssign_lbl7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Arrow_Keyboard_pb;
        private System.Windows.Forms.PictureBox Arrow_Com_pb;
        private System.Windows.Forms.Label StatusBox_lbl;
        private System.Windows.Forms.Label StatusBox_lbl2;
        private System.Windows.Forms.PictureBox Arrow_Mouse1_pb;
        private System.Windows.Forms.PictureBox Arrow_Mouse2_pb;
        private System.Windows.Forms.PictureBox Arrow_Mouse3_pb;
        private System.Windows.Forms.Label devicetype_lbl5;
        private System.Windows.Forms.Label devicetype_lbl6;
        private System.Windows.Forms.Label DeviceAssign_lbl5;
        private System.Windows.Forms.Label DeviceAssign_lbl6;
        private System.Windows.Forms.Label devicetype_lbl10;
        private System.Windows.Forms.Label devicetype_lbl11;
        private System.Windows.Forms.Label devicetype_lbl12;
        private System.Windows.Forms.Label DeviceAssign_lbl10;
        private System.Windows.Forms.Label DeviceAssign_lbl11;
        private System.Windows.Forms.Label DeviceAssign_lbl12;
        private System.Windows.Forms.Label Debug_label1;
        private System.Windows.Forms.Label Debug_label2;
        private System.Windows.Forms.Label Debug_label3;
        private System.Windows.Forms.Label Debug_label4;
        private System.Windows.Forms.Label Debug_label5;
        private System.Windows.Forms.Button Receive_btn;
        private System.Windows.Forms.Button Del_btn;
        private System.Windows.Forms.Label Code_lbl;
        private System.Windows.Forms.Button Area01_btn;
        private System.Windows.Forms.Button Area02_btn;
        private System.Windows.Forms.Button Area03_btn;
        private System.Windows.Forms.Label devicetype_lbl13;
        private System.Windows.Forms.Label devicetype_lbl14;
        private System.Windows.Forms.Label devicetype_lbl15;
        private System.Windows.Forms.Label devicetype_lbl16;
        private System.Windows.Forms.Label devicetype_lbl17;
        private System.Windows.Forms.Label devicetype_lbl18;
        private System.Windows.Forms.Label devicetype_lbl19;
        private System.Windows.Forms.Label devicetype_lbl20;
        private System.Windows.Forms.Label DeviceAssign_lbl13;
        private System.Windows.Forms.Label DeviceAssign_lbl14;
        private System.Windows.Forms.Label DeviceAssign_lbl15;
        private System.Windows.Forms.Label DeviceAssign_lbl16;
        private System.Windows.Forms.Label DeviceAssign_lbl17;
        private System.Windows.Forms.Label DeviceAssign_lbl18;
        private System.Windows.Forms.Label DeviceAssign_lbl19;
        private System.Windows.Forms.Label DeviceAssign_lbl20;
        private System.Windows.Forms.TextBox Memo_txt;
        private System.Windows.Forms.Button Area04_btn;
        private System.Windows.Forms.Button Area05_btn;
        private System.Windows.Forms.Button Area06_btn;
        private System.Windows.Forms.Button Area07_btn;
        private System.Windows.Forms.Button Area08_btn;
        private System.Windows.Forms.Button Area09_btn;
        private System.Windows.Forms.Button Area10_btn;
        private System.Windows.Forms.Button Area11_btn;
        private System.Windows.Forms.Button Area12_btn;
        private System.Windows.Forms.Button Area13_btn;
        private System.Windows.Forms.Button Area14_btn;
        private System.Windows.Forms.Button Area15_btn;
        private System.Windows.Forms.Button Area16_btn;
        private System.Windows.Forms.Button Area17_btn;
        private System.Windows.Forms.Button Area18_btn;
        private System.Windows.Forms.Button Area19_btn;
        private System.Windows.Forms.Button Area20_btn;
        private System.Windows.Forms.ComboBox volumevalue_combx;
        private System.Windows.Forms.PictureBox BackGround_pb;
        private System.Windows.Forms.Timer tmrONFlag;
    }
}


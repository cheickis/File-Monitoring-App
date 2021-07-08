namespace Penguin_File_Monitoring_App
{
    partial class PenguinFileMonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenguinFileMonitorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startMonitoringtoolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.monitoringStatustoolStripLbl = new System.Windows.Forms.ToolStripLabel();
            this.monitoringStatustoolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.mainmetroTabCtrl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logPageTxtB = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPagelogTxt = new MetroFramework.Controls.MetroTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wactcherFolderBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destinationFolderBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.sourceLogTxtB = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.destinationLogTxtB = new MetroFramework.Controls.MetroTextBox();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainmetroTabCtrl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.directoryToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // directoryToolStripMenuItem
            // 
            this.directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            this.directoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.directoryToolStripMenuItem.Text = "Directory";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMonitoringtoolStripBtn,
            this.toolStripLabel1,
            this.monitoringStatustoolStripLbl,
            this.monitoringStatustoolStripBtn});
            this.toolStrip1.Location = new System.Drawing.Point(20, 84);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 67);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startMonitoringtoolStripBtn
            // 
            this.startMonitoringtoolStripBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.startMonitoringtoolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startMonitoringtoolStripBtn.Image = global::Penguin_File_Monitoring_App.Properties.Resources.Artboard_1_9_512;
            this.startMonitoringtoolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startMonitoringtoolStripBtn.Name = "startMonitoringtoolStripBtn";
            this.startMonitoringtoolStripBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startMonitoringtoolStripBtn.Size = new System.Drawing.Size(64, 64);
            this.startMonitoringtoolStripBtn.Text = "Start Monitoring";
            this.startMonitoringtoolStripBtn.Click += new System.EventHandler(this.StartMonitoringtoolStripBtn_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripLabel1.Size = new System.Drawing.Size(160, 64);
            this.toolStripLabel1.Text = "Monitoring Status:";
            // 
            // monitoringStatustoolStripLbl
            // 
            this.monitoringStatustoolStripLbl.BackgroundImage = global::Penguin_File_Monitoring_App.Properties.Resources.iconfinder_Monitoring_85379__3_;
            this.monitoringStatustoolStripLbl.Name = "monitoringStatustoolStripLbl";
            this.monitoringStatustoolStripLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monitoringStatustoolStripLbl.Size = new System.Drawing.Size(0, 64);
            // 
            // monitoringStatustoolStripBtn
            // 
            this.monitoringStatustoolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.monitoringStatustoolStripBtn.Enabled = false;
            this.monitoringStatustoolStripBtn.Image = global::Penguin_File_Monitoring_App.Properties.Resources.iconfinder___Eye_Show_View_Watch_See_Disable_Inactive_Unavailable_Off_3844412;
            this.monitoringStatustoolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.monitoringStatustoolStripBtn.Name = "monitoringStatustoolStripBtn";
            this.monitoringStatustoolStripBtn.Size = new System.Drawing.Size(64, 64);
            // 
            // mainmetroTabCtrl
            // 
            this.mainmetroTabCtrl.Controls.Add(this.metroTabPage1);
            this.mainmetroTabCtrl.Controls.Add(this.metroTabPage2);
            this.mainmetroTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainmetroTabCtrl.Location = new System.Drawing.Point(20, 151);
            this.mainmetroTabCtrl.Name = "mainmetroTabCtrl";
            this.mainmetroTabCtrl.SelectedIndex = 0;
            this.mainmetroTabCtrl.Size = new System.Drawing.Size(927, 532);
            this.mainmetroTabCtrl.TabIndex = 2;
            this.mainmetroTabCtrl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.tableLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(919, 490);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Main Page";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.23613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.76387F));
            this.tableLayoutPanel1.Controls.Add(this.logPageTxtB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 490);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // logPageTxtB
            // 
            this.logPageTxtB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // 
            // 
            this.logPageTxtB.CustomButton.Image = null;
            this.logPageTxtB.CustomButton.Location = new System.Drawing.Point(-95, 2);
            this.logPageTxtB.CustomButton.Name = "";
            this.logPageTxtB.CustomButton.Size = new System.Drawing.Size(479, 479);
            this.logPageTxtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logPageTxtB.CustomButton.TabIndex = 1;
            this.logPageTxtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logPageTxtB.CustomButton.UseSelectable = true;
            this.logPageTxtB.CustomButton.Visible = false;
            this.logPageTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPageTxtB.Lines = new string[0];
            this.logPageTxtB.Location = new System.Drawing.Point(529, 3);
            this.logPageTxtB.MaxLength = 32767;
            this.logPageTxtB.Multiline = true;
            this.logPageTxtB.Name = "logPageTxtB";
            this.logPageTxtB.PasswordChar = '\0';
            this.logPageTxtB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logPageTxtB.SelectedText = "";
            this.logPageTxtB.SelectionLength = 0;
            this.logPageTxtB.SelectionStart = 0;
            this.logPageTxtB.ShortcutsEnabled = true;
            this.logPageTxtB.ShowClearButton = true;
            this.logPageTxtB.Size = new System.Drawing.Size(387, 484);
            this.logPageTxtB.Style = MetroFramework.MetroColorStyle.Black;
            this.logPageTxtB.TabIndex = 0;
            this.logPageTxtB.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logPageTxtB.UseSelectable = true;
            this.logPageTxtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logPageTxtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.mainPagelogTxt, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.26648F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.73352F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(520, 484);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // mainPagelogTxt
            // 
            this.mainPagelogTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.mainPagelogTxt.CustomButton.Image = null;
            this.mainPagelogTxt.CustomButton.Location = new System.Drawing.Point(338, 1);
            this.mainPagelogTxt.CustomButton.Name = "";
            this.mainPagelogTxt.CustomButton.Size = new System.Drawing.Size(175, 175);
            this.mainPagelogTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mainPagelogTxt.CustomButton.TabIndex = 1;
            this.mainPagelogTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mainPagelogTxt.CustomButton.UseSelectable = true;
            this.mainPagelogTxt.CustomButton.Visible = false;
            this.mainPagelogTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPagelogTxt.Lines = new string[0];
            this.mainPagelogTxt.Location = new System.Drawing.Point(3, 304);
            this.mainPagelogTxt.MaxLength = 32767;
            this.mainPagelogTxt.Multiline = true;
            this.mainPagelogTxt.Name = "mainPagelogTxt";
            this.mainPagelogTxt.PasswordChar = '\0';
            this.mainPagelogTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mainPagelogTxt.SelectedText = "";
            this.mainPagelogTxt.SelectionLength = 0;
            this.mainPagelogTxt.SelectionStart = 0;
            this.mainPagelogTxt.ShortcutsEnabled = true;
            this.mainPagelogTxt.Size = new System.Drawing.Size(514, 177);
            this.mainPagelogTxt.TabIndex = 0;
            this.mainPagelogTxt.UseSelectable = true;
            this.mainPagelogTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mainPagelogTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(514, 124);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wactcherFolderBtn);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Watcher directory";
            // 
            // wactcherFolderBtn
            // 
            this.wactcherFolderBtn.Location = new System.Drawing.Point(131, 76);
            this.wactcherFolderBtn.Name = "wactcherFolderBtn";
            this.wactcherFolderBtn.Size = new System.Drawing.Size(88, 23);
            this.wactcherFolderBtn.TabIndex = 1;
            this.wactcherFolderBtn.Text = "Browse";
            this.wactcherFolderBtn.UseSelectable = true;
            this.wactcherFolderBtn.Click += new System.EventHandler(this.WactcherFolderBtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Monitor directory";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.destinationFolderBtn);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(260, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save directory";
            // 
            // destinationFolderBtn
            // 
            this.destinationFolderBtn.Location = new System.Drawing.Point(112, 78);
            this.destinationFolderBtn.Name = "destinationFolderBtn";
            this.destinationFolderBtn.Size = new System.Drawing.Size(88, 23);
            this.destinationFolderBtn.TabIndex = 3;
            this.destinationFolderBtn.Text = "Browse";
            this.destinationFolderBtn.UseSelectable = true;
            this.destinationFolderBtn.Click += new System.EventHandler(this.SaveFolderBtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Silver;
            this.metroLabel2.Location = new System.Drawing.Point(6, 78);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Save Directory";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.metroPanel2, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(514, 165);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.sourceLogTxtB);
            this.metroPanel1.Controls.Add(this.metroTile1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(247, 144);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // sourceLogTxtB
            // 
            // 
            // 
            // 
            this.sourceLogTxtB.CustomButton.Image = null;
            this.sourceLogTxtB.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.sourceLogTxtB.CustomButton.Name = "";
            this.sourceLogTxtB.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.sourceLogTxtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sourceLogTxtB.CustomButton.TabIndex = 1;
            this.sourceLogTxtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sourceLogTxtB.CustomButton.UseSelectable = true;
            this.sourceLogTxtB.CustomButton.Visible = false;
            this.sourceLogTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceLogTxtB.Lines = new string[0];
            this.sourceLogTxtB.Location = new System.Drawing.Point(0, 44);
            this.sourceLogTxtB.MaxLength = 32767;
            this.sourceLogTxtB.Multiline = true;
            this.sourceLogTxtB.Name = "sourceLogTxtB";
            this.sourceLogTxtB.PasswordChar = '\0';
            this.sourceLogTxtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sourceLogTxtB.SelectedText = "";
            this.sourceLogTxtB.SelectionLength = 0;
            this.sourceLogTxtB.SelectionStart = 0;
            this.sourceLogTxtB.ShortcutsEnabled = true;
            this.sourceLogTxtB.Size = new System.Drawing.Size(247, 100);
            this.sourceLogTxtB.TabIndex = 3;
            this.sourceLogTxtB.UseSelectable = true;
            this.sourceLogTxtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sourceLogTxtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Black;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(247, 44);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Source";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.destinationLogTxtB);
            this.metroPanel2.Controls.Add(this.metroTile2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(260, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(249, 144);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // destinationLogTxtB
            // 
            // 
            // 
            // 
            this.destinationLogTxtB.CustomButton.Image = null;
            this.destinationLogTxtB.CustomButton.Location = new System.Drawing.Point(151, 2);
            this.destinationLogTxtB.CustomButton.Name = "";
            this.destinationLogTxtB.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.destinationLogTxtB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.destinationLogTxtB.CustomButton.TabIndex = 1;
            this.destinationLogTxtB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.destinationLogTxtB.CustomButton.UseSelectable = true;
            this.destinationLogTxtB.CustomButton.Visible = false;
            this.destinationLogTxtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationLogTxtB.Lines = new string[0];
            this.destinationLogTxtB.Location = new System.Drawing.Point(0, 44);
            this.destinationLogTxtB.MaxLength = 32767;
            this.destinationLogTxtB.Multiline = true;
            this.destinationLogTxtB.Name = "destinationLogTxtB";
            this.destinationLogTxtB.PasswordChar = '\0';
            this.destinationLogTxtB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.destinationLogTxtB.SelectedText = "";
            this.destinationLogTxtB.SelectionLength = 0;
            this.destinationLogTxtB.SelectionStart = 0;
            this.destinationLogTxtB.ShortcutsEnabled = true;
            this.destinationLogTxtB.Size = new System.Drawing.Size(249, 100);
            this.destinationLogTxtB.TabIndex = 3;
            this.destinationLogTxtB.UseSelectable = true;
            this.destinationLogTxtB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.destinationLogTxtB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.Black;
            this.metroTile2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile2.ForeColor = System.Drawing.Color.White;
            this.metroTile2.Location = new System.Drawing.Point(0, 0);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(249, 44);
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Destination";
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(919, 490);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Log";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // PenguinFileMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 703);
            this.Controls.Add(this.mainmetroTabCtrl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PenguinFileMonitorForm";
            this.Text = "Penguin Files Monitor App";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.PenguinFileMonitorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainmetroTabCtrl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton startMonitoringtoolStripBtn;
        private MetroFramework.Controls.MetroTabControl mainmetroTabCtrl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTextBox logPageTxtB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroTextBox mainPagelogTxt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox sourceLogTxtB;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox destinationLogTxtB;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton wactcherFolderBtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton destinationFolderBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel monitoringStatustoolStripLbl;
        private System.Windows.Forms.ToolStripButton monitoringStatustoolStripBtn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


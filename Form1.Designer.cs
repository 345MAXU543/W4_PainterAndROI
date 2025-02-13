namespace W4_PainterAndROI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            stpStatus = new StatusStrip();
            stpTool = new ToolStrip();
            btnToolStpNew = new ToolStripButton();
            btnStpOpenFile = new ToolStripButton();
            儲存SToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            btnStpPen = new ToolStripButton();
            btnStpEraser = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCanvaSize = new ToolStripButton();
            btnPanSize = new ToolStripButton();
            stpMenu = new MenuStrip();
            檔案FToolStripMenuItem = new ToolStripMenuItem();
            btnToolStpMenuNEW = new ToolStripMenuItem();
            開啟OToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            儲存SToolStripMenuItem = new ToolStripMenuItem();
            另存新檔AToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            列印PToolStripMenuItem = new ToolStripMenuItem();
            預覽列印VToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            結束XToolStripMenuItem = new ToolStripMenuItem();
            編輯EToolStripMenuItem = new ToolStripMenuItem();
            復原UToolStripMenuItem = new ToolStripMenuItem();
            取消復原RToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            剪下TToolStripMenuItem = new ToolStripMenuItem();
            複製CToolStripMenuItem = new ToolStripMenuItem();
            貼上PToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            全選AToolStripMenuItem = new ToolStripMenuItem();
            工具TToolStripMenuItem = new ToolStripMenuItem();
            自訂CToolStripMenuItem = new ToolStripMenuItem();
            選項OToolStripMenuItem = new ToolStripMenuItem();
            itmCanvaSize = new ToolStripMenuItem();
            說明HToolStripMenuItem = new ToolStripMenuItem();
            內容CToolStripMenuItem = new ToolStripMenuItem();
            索引IToolStripMenuItem = new ToolStripMenuItem();
            搜尋SToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            關於AToolStripMenuItem = new ToolStripMenuItem();
            imgPicbox = new PictureBox();
            ctrlTab = new TabControl();
            tabCanvaSize = new TabPage();
            txtSizeheigh = new TextBox();
            txtSizeWidth = new TextBox();
            label2 = new Label();
            lblW = new Label();
            tabPanSetting = new TabPage();
            llblSize100 = new Label();
            llblSize0 = new Label();
            btnGreenColor = new Button();
            btnBlueColor = new Button();
            btnOringeColor = new Button();
            btnRedColor = new Button();
            btnYellowColor = new Button();
            txtPanSize = new TextBox();
            barPanSize = new TrackBar();
            lblPanSize = new Label();
            btnPanColor1 = new Button();
            tabShape = new TabPage();
            button4 = new Button();
            btnShapeRetangle = new Button();
            btnShapeTrigle = new Button();
            btnShapeCircle = new Button();
            stpTool.SuspendLayout();
            stpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPicbox).BeginInit();
            ctrlTab.SuspendLayout();
            tabCanvaSize.SuspendLayout();
            tabPanSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)barPanSize).BeginInit();
            tabShape.SuspendLayout();
            SuspendLayout();
            // 
            // stpStatus
            // 
            stpStatus.ImageScalingSize = new Size(24, 24);
            stpStatus.Location = new Point(0, 352);
            stpStatus.Name = "stpStatus";
            stpStatus.Padding = new Padding(1, 0, 9, 0);
            stpStatus.Size = new Size(802, 22);
            stpStatus.TabIndex = 1;
            stpStatus.Text = "statusStrip1";
            // 
            // stpTool
            // 
            stpTool.ImageScalingSize = new Size(24, 24);
            stpTool.Items.AddRange(new ToolStripItem[] { btnToolStpNew, btnStpOpenFile, 儲存SToolStripButton, toolStripSeparator, btnStpPen, btnStpEraser, toolStripSeparator1, btnCanvaSize, btnPanSize });
            stpTool.Location = new Point(0, 24);
            stpTool.Name = "stpTool";
            stpTool.Size = new Size(802, 31);
            stpTool.TabIndex = 2;
            stpTool.Text = "toolStrip1";
            // 
            // btnToolStpNew
            // 
            btnToolStpNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStpNew.Image = (Image)resources.GetObject("btnToolStpNew.Image");
            btnToolStpNew.ImageTransparentColor = Color.Magenta;
            btnToolStpNew.Name = "btnToolStpNew";
            btnToolStpNew.Size = new Size(28, 28);
            btnToolStpNew.Text = "新增(&N)";
            btnToolStpNew.Click += btnToolStpNew_Click;
            // 
            // btnStpOpenFile
            // 
            btnStpOpenFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStpOpenFile.Image = (Image)resources.GetObject("btnStpOpenFile.Image");
            btnStpOpenFile.ImageTransparentColor = Color.Magenta;
            btnStpOpenFile.Name = "btnStpOpenFile";
            btnStpOpenFile.Size = new Size(28, 28);
            btnStpOpenFile.Text = "開啟(&O)";
            btnStpOpenFile.Click += btnStpOpenFile_Click;
            // 
            // 儲存SToolStripButton
            // 
            儲存SToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            儲存SToolStripButton.Image = (Image)resources.GetObject("儲存SToolStripButton.Image");
            儲存SToolStripButton.ImageTransparentColor = Color.Magenta;
            儲存SToolStripButton.Name = "儲存SToolStripButton";
            儲存SToolStripButton.Size = new Size(28, 28);
            儲存SToolStripButton.Text = "儲存(&S)";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 31);
            // 
            // btnStpPen
            // 
            btnStpPen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStpPen.Image = Properties.Resources.pen;
            btnStpPen.ImageTransparentColor = Color.Magenta;
            btnStpPen.Name = "btnStpPen";
            btnStpPen.Size = new Size(28, 28);
            btnStpPen.Text = "toolStripButton1";
            btnStpPen.Click += btnStpPen_Click;
            // 
            // btnStpEraser
            // 
            btnStpEraser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnStpEraser.Image = Properties.Resources.eraser;
            btnStpEraser.ImageTransparentColor = Color.Magenta;
            btnStpEraser.Name = "btnStpEraser";
            btnStpEraser.Size = new Size(28, 28);
            btnStpEraser.Text = "toolStripButton2";
            btnStpEraser.Click += btnStpEraser_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnCanvaSize
            // 
            btnCanvaSize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCanvaSize.Image = Properties.Resources.canva;
            btnCanvaSize.ImageTransparentColor = Color.Magenta;
            btnCanvaSize.Name = "btnCanvaSize";
            btnCanvaSize.Size = new Size(28, 28);
            btnCanvaSize.Text = "toolStripButton1";
            btnCanvaSize.Click += btnCanvaSize_Click;
            // 
            // btnPanSize
            // 
            btnPanSize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnPanSize.Image = Properties.Resources.pen___複製;
            btnPanSize.ImageTransparentColor = Color.Magenta;
            btnPanSize.Name = "btnPanSize";
            btnPanSize.Size = new Size(28, 28);
            btnPanSize.Text = "toolStripButton2";
            btnPanSize.Click += btnPanSize_Click;
            // 
            // stpMenu
            // 
            stpMenu.ImageScalingSize = new Size(24, 24);
            stpMenu.Items.AddRange(new ToolStripItem[] { 檔案FToolStripMenuItem, 編輯EToolStripMenuItem, 工具TToolStripMenuItem, 說明HToolStripMenuItem });
            stpMenu.Location = new Point(0, 0);
            stpMenu.Name = "stpMenu";
            stpMenu.Padding = new Padding(4, 1, 0, 1);
            stpMenu.Size = new Size(802, 24);
            stpMenu.TabIndex = 3;
            stpMenu.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            檔案FToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { btnToolStpMenuNEW, 開啟OToolStripMenuItem, toolStripSeparator2, 儲存SToolStripMenuItem, 另存新檔AToolStripMenuItem, toolStripSeparator3, 列印PToolStripMenuItem, 預覽列印VToolStripMenuItem, toolStripSeparator4, 結束XToolStripMenuItem });
            檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            檔案FToolStripMenuItem.Size = new Size(57, 22);
            檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // btnToolStpMenuNEW
            // 
            btnToolStpMenuNEW.Image = (Image)resources.GetObject("btnToolStpMenuNEW.Image");
            btnToolStpMenuNEW.ImageTransparentColor = Color.Magenta;
            btnToolStpMenuNEW.Name = "btnToolStpMenuNEW";
            btnToolStpMenuNEW.ShortcutKeys = Keys.Control | Keys.N;
            btnToolStpMenuNEW.Size = new Size(161, 22);
            btnToolStpMenuNEW.Text = "新增(&N)";
            btnToolStpMenuNEW.Click += btnToolStpMenuNEW_Click;
            // 
            // 開啟OToolStripMenuItem
            // 
            開啟OToolStripMenuItem.Image = (Image)resources.GetObject("開啟OToolStripMenuItem.Image");
            開啟OToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            開啟OToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            開啟OToolStripMenuItem.Size = new Size(161, 22);
            開啟OToolStripMenuItem.Text = "開啟(&O)";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(158, 6);
            // 
            // 儲存SToolStripMenuItem
            // 
            儲存SToolStripMenuItem.Image = (Image)resources.GetObject("儲存SToolStripMenuItem.Image");
            儲存SToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            儲存SToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            儲存SToolStripMenuItem.Size = new Size(161, 22);
            儲存SToolStripMenuItem.Text = "儲存(&S)";
            // 
            // 另存新檔AToolStripMenuItem
            // 
            另存新檔AToolStripMenuItem.Name = "另存新檔AToolStripMenuItem";
            另存新檔AToolStripMenuItem.Size = new Size(161, 22);
            另存新檔AToolStripMenuItem.Text = "另存新檔(&A)";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(158, 6);
            // 
            // 列印PToolStripMenuItem
            // 
            列印PToolStripMenuItem.Image = (Image)resources.GetObject("列印PToolStripMenuItem.Image");
            列印PToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
            列印PToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            列印PToolStripMenuItem.Size = new Size(161, 22);
            列印PToolStripMenuItem.Text = "列印(&P)";
            // 
            // 預覽列印VToolStripMenuItem
            // 
            預覽列印VToolStripMenuItem.Image = (Image)resources.GetObject("預覽列印VToolStripMenuItem.Image");
            預覽列印VToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            預覽列印VToolStripMenuItem.Name = "預覽列印VToolStripMenuItem";
            預覽列印VToolStripMenuItem.Size = new Size(161, 22);
            預覽列印VToolStripMenuItem.Text = "預覽列印(&V)";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(158, 6);
            // 
            // 結束XToolStripMenuItem
            // 
            結束XToolStripMenuItem.Name = "結束XToolStripMenuItem";
            結束XToolStripMenuItem.Size = new Size(161, 22);
            結束XToolStripMenuItem.Text = "結束(&X)";
            // 
            // 編輯EToolStripMenuItem
            // 
            編輯EToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 復原UToolStripMenuItem, 取消復原RToolStripMenuItem, toolStripSeparator5, 剪下TToolStripMenuItem, 複製CToolStripMenuItem, 貼上PToolStripMenuItem, toolStripSeparator6, 全選AToolStripMenuItem });
            編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            編輯EToolStripMenuItem.Size = new Size(58, 22);
            編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // 復原UToolStripMenuItem
            // 
            復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
            復原UToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            復原UToolStripMenuItem.Size = new Size(180, 22);
            復原UToolStripMenuItem.Text = "復原(&U)";
            // 
            // 取消復原RToolStripMenuItem
            // 
            取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            取消復原RToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            取消復原RToolStripMenuItem.Size = new Size(180, 22);
            取消復原RToolStripMenuItem.Text = "取消復原(&R)";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(177, 6);
            // 
            // 剪下TToolStripMenuItem
            // 
            剪下TToolStripMenuItem.Image = (Image)resources.GetObject("剪下TToolStripMenuItem.Image");
            剪下TToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            剪下TToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            剪下TToolStripMenuItem.Size = new Size(180, 22);
            剪下TToolStripMenuItem.Text = "剪下(&T)";
            // 
            // 複製CToolStripMenuItem
            // 
            複製CToolStripMenuItem.Image = (Image)resources.GetObject("複製CToolStripMenuItem.Image");
            複製CToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            複製CToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            複製CToolStripMenuItem.Size = new Size(180, 22);
            複製CToolStripMenuItem.Text = "複製(&C)";
            // 
            // 貼上PToolStripMenuItem
            // 
            貼上PToolStripMenuItem.Image = (Image)resources.GetObject("貼上PToolStripMenuItem.Image");
            貼上PToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            貼上PToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            貼上PToolStripMenuItem.Size = new Size(180, 22);
            貼上PToolStripMenuItem.Text = "貼上(&P)";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(177, 6);
            // 
            // 全選AToolStripMenuItem
            // 
            全選AToolStripMenuItem.Name = "全選AToolStripMenuItem";
            全選AToolStripMenuItem.Size = new Size(180, 22);
            全選AToolStripMenuItem.Text = "全選(&A)";
            // 
            // 工具TToolStripMenuItem
            // 
            工具TToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 自訂CToolStripMenuItem, 選項OToolStripMenuItem, itmCanvaSize });
            工具TToolStripMenuItem.Name = "工具TToolStripMenuItem";
            工具TToolStripMenuItem.Size = new Size(58, 22);
            工具TToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自訂CToolStripMenuItem
            // 
            自訂CToolStripMenuItem.Name = "自訂CToolStripMenuItem";
            自訂CToolStripMenuItem.Size = new Size(146, 22);
            自訂CToolStripMenuItem.Text = "自訂(&C)";
            // 
            // 選項OToolStripMenuItem
            // 
            選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            選項OToolStripMenuItem.Size = new Size(146, 22);
            選項OToolStripMenuItem.Text = "選項(&O)";
            // 
            // itmCanvaSize
            // 
            itmCanvaSize.Name = "itmCanvaSize";
            itmCanvaSize.Size = new Size(146, 22);
            itmCanvaSize.Text = "調整畫布大小";
            itmCanvaSize.Click += itmCanvaSize_Click;
            // 
            // 說明HToolStripMenuItem
            // 
            說明HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 內容CToolStripMenuItem, 索引IToolStripMenuItem, 搜尋SToolStripMenuItem, toolStripSeparator7, 關於AToolStripMenuItem });
            說明HToolStripMenuItem.Name = "說明HToolStripMenuItem";
            說明HToolStripMenuItem.Size = new Size(60, 22);
            說明HToolStripMenuItem.Text = "說明(&H)";
            // 
            // 內容CToolStripMenuItem
            // 
            內容CToolStripMenuItem.Name = "內容CToolStripMenuItem";
            內容CToolStripMenuItem.Size = new Size(123, 22);
            內容CToolStripMenuItem.Text = "內容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            索引IToolStripMenuItem.Size = new Size(123, 22);
            索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜尋SToolStripMenuItem
            // 
            搜尋SToolStripMenuItem.Name = "搜尋SToolStripMenuItem";
            搜尋SToolStripMenuItem.Size = new Size(123, 22);
            搜尋SToolStripMenuItem.Text = "搜尋(&S)";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(120, 6);
            // 
            // 關於AToolStripMenuItem
            // 
            關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            關於AToolStripMenuItem.Size = new Size(123, 22);
            關於AToolStripMenuItem.Text = "關於(&A)...";
            // 
            // imgPicbox
            // 
            imgPicbox.BorderStyle = BorderStyle.FixedSingle;
            imgPicbox.Image = Properties.Resources.Wbackground__小_1;
            imgPicbox.Location = new Point(4, 44);
            imgPicbox.Margin = new Padding(2);
            imgPicbox.Name = "imgPicbox";
            imgPicbox.Size = new Size(613, 482);
            imgPicbox.SizeMode = PictureBoxSizeMode.AutoSize;
            imgPicbox.TabIndex = 4;
            imgPicbox.TabStop = false;
            imgPicbox.MouseDown += imgPicbox_MouseDown;
            imgPicbox.MouseEnter += imgPicbox_MouseEnter;
            imgPicbox.MouseMove += imgPicbox_MouseMove;
            imgPicbox.MouseUp += imgPicbox_MouseUp;
            // 
            // ctrlTab
            // 
            ctrlTab.Controls.Add(tabCanvaSize);
            ctrlTab.Controls.Add(tabPanSetting);
            ctrlTab.Controls.Add(tabShape);
            ctrlTab.Location = new Point(552, 44);
            ctrlTab.Margin = new Padding(2);
            ctrlTab.Name = "ctrlTab";
            ctrlTab.SelectedIndex = 0;
            ctrlTab.Size = new Size(251, 313);
            ctrlTab.TabIndex = 5;
            // 
            // tabCanvaSize
            // 
            tabCanvaSize.Controls.Add(txtSizeheigh);
            tabCanvaSize.Controls.Add(txtSizeWidth);
            tabCanvaSize.Controls.Add(label2);
            tabCanvaSize.Controls.Add(lblW);
            tabCanvaSize.Location = new Point(4, 24);
            tabCanvaSize.Margin = new Padding(2);
            tabCanvaSize.Name = "tabCanvaSize";
            tabCanvaSize.Padding = new Padding(2);
            tabCanvaSize.Size = new Size(243, 285);
            tabCanvaSize.TabIndex = 0;
            tabCanvaSize.Text = "畫布大小";
            tabCanvaSize.UseVisualStyleBackColor = true;
            // 
            // txtSizeheigh
            // 
            txtSizeheigh.Location = new Point(113, 112);
            txtSizeheigh.Margin = new Padding(2);
            txtSizeheigh.Name = "txtSizeheigh";
            txtSizeheigh.Size = new Size(97, 23);
            txtSizeheigh.TabIndex = 3;
            txtSizeheigh.KeyDown += txtSizeheigh_KeyDown;
            // 
            // txtSizeWidth
            // 
            txtSizeWidth.Location = new Point(113, 62);
            txtSizeWidth.Margin = new Padding(2);
            txtSizeWidth.Name = "txtSizeWidth";
            txtSizeWidth.Size = new Size(97, 23);
            txtSizeWidth.TabIndex = 2;
            txtSizeWidth.KeyDown += txtSizeWidth_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "高度";
            // 
            // lblW
            // 
            lblW.AutoSize = true;
            lblW.Location = new Point(59, 62);
            lblW.Margin = new Padding(2, 0, 2, 0);
            lblW.Name = "lblW";
            lblW.Size = new Size(31, 15);
            lblW.TabIndex = 0;
            lblW.Text = "寬度";
            // 
            // tabPanSetting
            // 
            tabPanSetting.Controls.Add(llblSize100);
            tabPanSetting.Controls.Add(llblSize0);
            tabPanSetting.Controls.Add(btnGreenColor);
            tabPanSetting.Controls.Add(btnBlueColor);
            tabPanSetting.Controls.Add(btnOringeColor);
            tabPanSetting.Controls.Add(btnRedColor);
            tabPanSetting.Controls.Add(btnYellowColor);
            tabPanSetting.Controls.Add(txtPanSize);
            tabPanSetting.Controls.Add(barPanSize);
            tabPanSetting.Controls.Add(lblPanSize);
            tabPanSetting.Controls.Add(btnPanColor1);
            tabPanSetting.Location = new Point(4, 24);
            tabPanSetting.Margin = new Padding(2);
            tabPanSetting.Name = "tabPanSetting";
            tabPanSetting.Padding = new Padding(2);
            tabPanSetting.Size = new Size(243, 285);
            tabPanSetting.TabIndex = 1;
            tabPanSetting.Text = "筆畫設定";
            tabPanSetting.UseVisualStyleBackColor = true;
            // 
            // llblSize100
            // 
            llblSize100.AutoSize = true;
            llblSize100.Location = new Point(202, 94);
            llblSize100.Margin = new Padding(2, 0, 2, 0);
            llblSize100.Name = "llblSize100";
            llblSize100.Size = new Size(28, 15);
            llblSize100.TabIndex = 6;
            llblSize100.Text = "100";
            // 
            // llblSize0
            // 
            llblSize0.AutoSize = true;
            llblSize0.Location = new Point(20, 94);
            llblSize0.Margin = new Padding(2, 0, 2, 0);
            llblSize0.Name = "llblSize0";
            llblSize0.Size = new Size(14, 15);
            llblSize0.TabIndex = 5;
            llblSize0.Text = "1";
            // 
            // btnGreenColor
            // 
            btnGreenColor.BackColor = Color.Lime;
            btnGreenColor.Location = new Point(143, 211);
            btnGreenColor.Margin = new Padding(2);
            btnGreenColor.Name = "btnGreenColor";
            btnGreenColor.Size = new Size(43, 44);
            btnGreenColor.TabIndex = 4;
            btnGreenColor.UseVisualStyleBackColor = false;
            // 
            // btnBlueColor
            // 
            btnBlueColor.BackColor = Color.Cyan;
            btnBlueColor.Location = new Point(185, 211);
            btnBlueColor.Margin = new Padding(2);
            btnBlueColor.Name = "btnBlueColor";
            btnBlueColor.Size = new Size(43, 44);
            btnBlueColor.TabIndex = 4;
            btnBlueColor.UseVisualStyleBackColor = false;
            // 
            // btnOringeColor
            // 
            btnOringeColor.BackColor = Color.FromArgb(255, 128, 0);
            btnOringeColor.Location = new Point(57, 211);
            btnOringeColor.Margin = new Padding(2);
            btnOringeColor.Name = "btnOringeColor";
            btnOringeColor.Size = new Size(43, 44);
            btnOringeColor.TabIndex = 4;
            btnOringeColor.UseVisualStyleBackColor = false;
            // 
            // btnRedColor
            // 
            btnRedColor.BackColor = Color.Red;
            btnRedColor.Location = new Point(15, 211);
            btnRedColor.Margin = new Padding(2);
            btnRedColor.Name = "btnRedColor";
            btnRedColor.Size = new Size(43, 44);
            btnRedColor.TabIndex = 4;
            btnRedColor.UseVisualStyleBackColor = false;
            // 
            // btnYellowColor
            // 
            btnYellowColor.BackColor = Color.Yellow;
            btnYellowColor.Location = new Point(100, 211);
            btnYellowColor.Margin = new Padding(2);
            btnYellowColor.Name = "btnYellowColor";
            btnYellowColor.Size = new Size(43, 44);
            btnYellowColor.TabIndex = 4;
            btnYellowColor.UseVisualStyleBackColor = false;
            // 
            // txtPanSize
            // 
            txtPanSize.Location = new Point(188, 48);
            txtPanSize.Margin = new Padding(2);
            txtPanSize.Name = "txtPanSize";
            txtPanSize.Size = new Size(41, 23);
            txtPanSize.TabIndex = 3;
            txtPanSize.Text = "1";
            // 
            // barPanSize
            // 
            barPanSize.BackColor = Color.White;
            barPanSize.Location = new Point(15, 71);
            barPanSize.Margin = new Padding(2);
            barPanSize.Maximum = 100;
            barPanSize.Minimum = 1;
            barPanSize.Name = "barPanSize";
            barPanSize.Size = new Size(213, 45);
            barPanSize.TabIndex = 2;
            barPanSize.TickStyle = TickStyle.None;
            barPanSize.Value = 1;
            barPanSize.Scroll += barPanSize_Scroll;
            // 
            // lblPanSize
            // 
            lblPanSize.AutoSize = true;
            lblPanSize.Font = new Font("Microsoft JhengHei UI", 15F);
            lblPanSize.Location = new Point(15, 42);
            lblPanSize.Margin = new Padding(2, 0, 2, 0);
            lblPanSize.Name = "lblPanSize";
            lblPanSize.Size = new Size(52, 25);
            lblPanSize.TabIndex = 1;
            lblPanSize.Text = "粗細";
            // 
            // btnPanColor1
            // 
            btnPanColor1.Location = new Point(15, 153);
            btnPanColor1.Margin = new Padding(2);
            btnPanColor1.Name = "btnPanColor1";
            btnPanColor1.Size = new Size(213, 53);
            btnPanColor1.TabIndex = 0;
            btnPanColor1.UseVisualStyleBackColor = true;
            btnPanColor1.Click += btnPanColor1_Click;
            // 
            // tabShape
            // 
            tabShape.Controls.Add(button4);
            tabShape.Controls.Add(btnShapeRetangle);
            tabShape.Controls.Add(btnShapeTrigle);
            tabShape.Controls.Add(btnShapeCircle);
            tabShape.Location = new Point(4, 24);
            tabShape.Name = "tabShape";
            tabShape.Padding = new Padding(3);
            tabShape.Size = new Size(243, 285);
            tabShape.TabIndex = 2;
            tabShape.Text = "圖形";
            tabShape.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(123, 130);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 0;
            button4.Text = "button1";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnShapeRetangle
            // 
            btnShapeRetangle.BackgroundImage = Properties.Resources.iconRetangle;
            btnShapeRetangle.BackgroundImageLayout = ImageLayout.Stretch;
            btnShapeRetangle.Location = new Point(19, 130);
            btnShapeRetangle.Name = "btnShapeRetangle";
            btnShapeRetangle.Size = new Size(100, 100);
            btnShapeRetangle.TabIndex = 0;
            btnShapeRetangle.UseVisualStyleBackColor = true;
            // 
            // btnShapeTrigle
            // 
            btnShapeTrigle.BackgroundImage = Properties.Resources.iconTritangle;
            btnShapeTrigle.BackgroundImageLayout = ImageLayout.Stretch;
            btnShapeTrigle.Location = new Point(123, 26);
            btnShapeTrigle.Name = "btnShapeTrigle";
            btnShapeTrigle.Size = new Size(100, 100);
            btnShapeTrigle.TabIndex = 0;
            btnShapeTrigle.UseVisualStyleBackColor = true;
            // 
            // btnShapeCircle
            // 
            btnShapeCircle.BackgroundImage = Properties.Resources.iconCircle;
            btnShapeCircle.BackgroundImageLayout = ImageLayout.Stretch;
            btnShapeCircle.Location = new Point(19, 26);
            btnShapeCircle.Name = "btnShapeCircle";
            btnShapeCircle.Size = new Size(100, 100);
            btnShapeCircle.TabIndex = 0;
            btnShapeCircle.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 374);
            Controls.Add(ctrlTab);
            Controls.Add(stpTool);
            Controls.Add(stpStatus);
            Controls.Add(stpMenu);
            Controls.Add(imgPicbox);
            MainMenuStrip = stpMenu;
            Margin = new Padding(2);
            Name = "frmMain";
            Text = "Painter";
            stpTool.ResumeLayout(false);
            stpTool.PerformLayout();
            stpMenu.ResumeLayout(false);
            stpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPicbox).EndInit();
            ctrlTab.ResumeLayout(false);
            tabCanvaSize.ResumeLayout(false);
            tabCanvaSize.PerformLayout();
            tabPanSetting.ResumeLayout(false);
            tabPanSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)barPanSize).EndInit();
            tabShape.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip stpStatus;
        private ToolStrip stpTool;
        private MenuStrip stpMenu;
        private ToolStripButton btnToolStpNew;
        private ToolStripButton btnStpOpenFile;
        private ToolStripButton 儲存SToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 檔案FToolStripMenuItem;
        private ToolStripMenuItem btnToolStpMenuNEW;
        private ToolStripMenuItem 開啟OToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 儲存SToolStripMenuItem;
        private ToolStripMenuItem 另存新檔AToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem 列印PToolStripMenuItem;
        private ToolStripMenuItem 預覽列印VToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem 結束XToolStripMenuItem;
        private ToolStripMenuItem 編輯EToolStripMenuItem;
        private ToolStripMenuItem 復原UToolStripMenuItem;
        private ToolStripMenuItem 取消復原RToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem 剪下TToolStripMenuItem;
        private ToolStripMenuItem 複製CToolStripMenuItem;
        private ToolStripMenuItem 貼上PToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem 全選AToolStripMenuItem;
        private ToolStripMenuItem 工具TToolStripMenuItem;
        private ToolStripMenuItem 自訂CToolStripMenuItem;
        private ToolStripMenuItem 選項OToolStripMenuItem;
        private ToolStripMenuItem 說明HToolStripMenuItem;
        private ToolStripMenuItem 內容CToolStripMenuItem;
        private ToolStripMenuItem 索引IToolStripMenuItem;
        private ToolStripMenuItem 搜尋SToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem 關於AToolStripMenuItem;
        private PictureBox imgPicbox;
        private TabControl ctrlTab;
        private TabPage tabCanvaSize;
        private TabPage tabPanSetting;
        private TextBox txtSizeheigh;
        private TextBox txtSizeWidth;
        private Label label2;
        private Label lblW;
        private ToolStripMenuItem itmCanvaSize;
        private Button btnPanColor1;
        private Label lblPanSize;
        private TrackBar barPanSize;
        private Button btnRedColor;
        private Button btnYellowColor;
        private TextBox txtPanSize;
        private Button btnGreenColor;
        private Button btnBlueColor;
        private Button btnOringeColor;
        private Label llblSize100;
        private Label llblSize0;
        private ToolStripButton btnCanvaSize;
        private ToolStripButton btnPanSize;
        private ToolStripButton btnStpPen;
        private ToolStripButton btnStpEraser;
        private TabPage tabShape;
        private Button btnShapeCircle;
        private Button button4;
        private Button btnShapeRetangle;
        private Button btnShapeTrigle;
    }
}

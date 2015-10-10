namespace Ntag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFileFromTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagFromFilenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.COMsearch = new System.Windows.Forms.ToolStripComboBox();
            this.BTNlocalsearch = new System.Windows.Forms.ToolStripButton();
            this.BTNaddimage = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BTNcopy = new System.Windows.Forms.Button();
            this.BTNdeletetag = new System.Windows.Forms.Button();
            this.BTNsavetag = new System.Windows.Forms.Button();
            this.RDOver2 = new System.Windows.Forms.RadioButton();
            this.RDOver1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNsearchimage = new System.Windows.Forms.Button();
            this.BTNloadimage = new System.Windows.Forms.Button();
            this.LABimage = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TXTfilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBtrack = new System.Windows.Forms.ComboBox();
            this.CMByear = new System.Windows.Forms.ComboBox();
            this.CMBcomment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CMBgenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBtitle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CMBartist = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBalbum = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LSVsearch = new System.Windows.Forms.ListView();
            this.COLid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLartist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.COLalbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.CMBpageno = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TXTsearch = new System.Windows.Forms.TextBox();
            this.CMBsearchtype = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNsqlist = new System.Windows.Forms.Button();
            this.treeView = new System.Windows.Forms.TreeView();
            this.musicListStore = new System.Windows.Forms.ListView();
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pathname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tagcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titlecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.artistcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.albumcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Trackcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yearcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genrecol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Commentscol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1021, 718);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFolderToolStripMenuItem,
            this.openDatabaseToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addFolderToolStripMenuItem
            // 
            this.addFolderToolStripMenuItem.Name = "addFolderToolStripMenuItem";
            this.addFolderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addFolderToolStripMenuItem.Text = "Open Folder";
            this.addFolderToolStripMenuItem.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Last";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameFileFromTagsToolStripMenuItem,
            this.tagFromFilenameToolStripMenuItem,
            this.addImageToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // renameFileFromTagsToolStripMenuItem
            // 
            this.renameFileFromTagsToolStripMenuItem.Name = "renameFileFromTagsToolStripMenuItem";
            this.renameFileFromTagsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.renameFileFromTagsToolStripMenuItem.Text = "Rename file from Tags";
            this.renameFileFromTagsToolStripMenuItem.Click += new System.EventHandler(this.renameFileFromTagsToolStripMenuItem_Click);
            // 
            // tagFromFilenameToolStripMenuItem
            // 
            this.tagFromFilenameToolStripMenuItem.Name = "tagFromFilenameToolStripMenuItem";
            this.tagFromFilenameToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tagFromFilenameToolStripMenuItem.Text = "Tag from Filename";
            this.tagFromFilenameToolStripMenuItem.Click += new System.EventHandler(this.tagFromFilenameToolStripMenuItem_Click);
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addImageToolStripMenuItem.Text = "Add Image";
            this.addImageToolStripMenuItem.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.COMsearch,
            this.BTNlocalsearch,
            this.BTNaddimage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1021, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Open Music Folder";
            this.toolStripButton1.Click += new System.EventHandler(this.addFolderToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Open Last Folder";
            this.toolStripButton2.Click += new System.EventHandler(this.openDatabaseToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 27);
            this.toolStripLabel1.Text = "Search";
            // 
            // COMsearch
            // 
            this.COMsearch.AutoToolTip = true;
            this.COMsearch.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.COMsearch.Items.AddRange(new object[] {
            "Artist =",
            "Album =",
            "Title =",
            "No Tag",
            "V1 Tags Only",
            "V2 Tags Only",
            "V1/V2 Tags",
            "Artist is blank",
            "Album is blank",
            "Title is blank"});
            this.COMsearch.Name = "COMsearch";
            this.COMsearch.Size = new System.Drawing.Size(200, 30);
            this.COMsearch.ToolTipText = "Local Search";
            // 
            // BTNlocalsearch
            // 
            this.BTNlocalsearch.AutoSize = false;
            this.BTNlocalsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNlocalsearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNlocalsearch.Image = ((System.Drawing.Image)(resources.GetObject("BTNlocalsearch.Image")));
            this.BTNlocalsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNlocalsearch.Name = "BTNlocalsearch";
            this.BTNlocalsearch.Size = new System.Drawing.Size(30, 30);
            this.BTNlocalsearch.Text = "toolStripButton3";
            this.BTNlocalsearch.ToolTipText = "Local Search";
            this.BTNlocalsearch.Click += new System.EventHandler(this.BTNlocalsearch_Click);
            // 
            // BTNaddimage
            // 
            this.BTNaddimage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNaddimage.Image = ((System.Drawing.Image)(resources.GetObject("BTNaddimage.Image")));
            this.BTNaddimage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNaddimage.Name = "BTNaddimage";
            this.BTNaddimage.Size = new System.Drawing.Size(23, 27);
            this.BTNaddimage.Text = "toolStripButton3";
            this.BTNaddimage.ToolTipText = "Image Search";
            this.BTNaddimage.Click += new System.EventHandler(this.addImageToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 696);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(150, 16);
            this.toolStripProgressBar.Step = 1;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.musicListStore);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 627);
            this.splitContainer1.SplitterDistance = 416;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 601);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tags";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BTNcopy);
            this.splitContainer2.Panel1.Controls.Add(this.BTNdeletetag);
            this.splitContainer2.Panel1.Controls.Add(this.BTNsavetag);
            this.splitContainer2.Panel1.Controls.Add(this.RDOver2);
            this.splitContainer2.Panel1.Controls.Add(this.RDOver1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.TXTfilename);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.CMBtrack);
            this.splitContainer2.Panel2.Controls.Add(this.CMByear);
            this.splitContainer2.Panel2.Controls.Add(this.CMBcomment);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.CMBgenre);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.CMBtitle);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.CMBartist);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.CMBalbum);
            this.splitContainer2.Size = new System.Drawing.Size(402, 595);
            this.splitContainer2.SplitterDistance = 68;
            this.splitContainer2.TabIndex = 0;
            // 
            // BTNcopy
            // 
            this.BTNcopy.Location = new System.Drawing.Point(276, 10);
            this.BTNcopy.Name = "BTNcopy";
            this.BTNcopy.Size = new System.Drawing.Size(75, 23);
            this.BTNcopy.TabIndex = 4;
            this.BTNcopy.Text = "Copy";
            this.BTNcopy.UseVisualStyleBackColor = true;
            this.BTNcopy.Click += new System.EventHandler(this.BTNcopy_Click);
            // 
            // BTNdeletetag
            // 
            this.BTNdeletetag.Location = new System.Drawing.Point(185, 10);
            this.BTNdeletetag.Name = "BTNdeletetag";
            this.BTNdeletetag.Size = new System.Drawing.Size(75, 23);
            this.BTNdeletetag.TabIndex = 3;
            this.BTNdeletetag.Text = "Delete Tag";
            this.BTNdeletetag.UseVisualStyleBackColor = true;
            this.BTNdeletetag.Click += new System.EventHandler(this.BTNdeletetag_Click);
            // 
            // BTNsavetag
            // 
            this.BTNsavetag.Location = new System.Drawing.Point(97, 10);
            this.BTNsavetag.Name = "BTNsavetag";
            this.BTNsavetag.Size = new System.Drawing.Size(75, 23);
            this.BTNsavetag.TabIndex = 2;
            this.BTNsavetag.Text = "Save Tag";
            this.BTNsavetag.UseVisualStyleBackColor = true;
            this.BTNsavetag.Click += new System.EventHandler(this.BTNsavetag_Click);
            // 
            // RDOver2
            // 
            this.RDOver2.AutoSize = true;
            this.RDOver2.Checked = true;
            this.RDOver2.Location = new System.Drawing.Point(22, 36);
            this.RDOver2.Name = "RDOver2";
            this.RDOver2.Size = new System.Drawing.Size(55, 17);
            this.RDOver2.TabIndex = 1;
            this.RDOver2.TabStop = true;
            this.RDOver2.Text = "ID3V2";
            this.RDOver2.UseVisualStyleBackColor = true;
            this.RDOver2.Click += new System.EventHandler(this.RDOver2_Click);
            // 
            // RDOver1
            // 
            this.RDOver1.AutoSize = true;
            this.RDOver1.Location = new System.Drawing.Point(22, 13);
            this.RDOver1.Name = "RDOver1";
            this.RDOver1.Size = new System.Drawing.Size(55, 17);
            this.RDOver1.TabIndex = 0;
            this.RDOver1.Text = "ID3V1";
            this.RDOver1.UseVisualStyleBackColor = true;
            this.RDOver1.Click += new System.EventHandler(this.RDOver1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BTNsearchimage);
            this.groupBox1.Controls.Add(this.BTNloadimage);
            this.groupBox1.Controls.Add(this.LABimage);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 213);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // BTNsearchimage
            // 
            this.BTNsearchimage.Location = new System.Drawing.Point(224, 144);
            this.BTNsearchimage.Name = "BTNsearchimage";
            this.BTNsearchimage.Size = new System.Drawing.Size(75, 23);
            this.BTNsearchimage.TabIndex = 68;
            this.BTNsearchimage.Text = "Search";
            this.BTNsearchimage.UseVisualStyleBackColor = true;
            this.BTNsearchimage.Click += new System.EventHandler(this.BTNsearchimage_Click);
            // 
            // BTNloadimage
            // 
            this.BTNloadimage.Location = new System.Drawing.Point(224, 178);
            this.BTNloadimage.Name = "BTNloadimage";
            this.BTNloadimage.Size = new System.Drawing.Size(75, 23);
            this.BTNloadimage.TabIndex = 67;
            this.BTNloadimage.Text = "Load";
            this.BTNloadimage.UseVisualStyleBackColor = true;
            this.BTNloadimage.Click += new System.EventHandler(this.BTNloadimage_Click);
            // 
            // LABimage
            // 
            this.LABimage.AutoSize = true;
            this.LABimage.Location = new System.Drawing.Point(221, 20);
            this.LABimage.Name = "LABimage";
            this.LABimage.Size = new System.Drawing.Size(35, 13);
            this.LABimage.TabIndex = 66;
            this.LABimage.Text = "label9";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(16, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(179, 182);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 65;
            this.pictureBox.TabStop = false;
            // 
            // TXTfilename
            // 
            this.TXTfilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTfilename.Location = new System.Drawing.Point(12, 22);
            this.TXTfilename.Name = "TXTfilename";
            this.TXTfilename.Size = new System.Drawing.Size(362, 20);
            this.TXTfilename.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Filename";
            // 
            // CMBtrack
            // 
            this.CMBtrack.FormattingEnabled = true;
            this.CMBtrack.Items.AddRange(new object[] {
            "#Keep#"});
            this.CMBtrack.Location = new System.Drawing.Point(93, 201);
            this.CMBtrack.Name = "CMBtrack";
            this.CMBtrack.Size = new System.Drawing.Size(72, 21);
            this.CMBtrack.TabIndex = 62;
            // 
            // CMByear
            // 
            this.CMByear.FormattingEnabled = true;
            this.CMByear.Items.AddRange(new object[] {
            "#Keep#"});
            this.CMByear.Location = new System.Drawing.Point(12, 201);
            this.CMByear.Name = "CMByear";
            this.CMByear.Size = new System.Drawing.Size(75, 21);
            this.CMByear.TabIndex = 61;
            // 
            // CMBcomment
            // 
            this.CMBcomment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBcomment.FormattingEnabled = true;
            this.CMBcomment.Location = new System.Drawing.Point(12, 247);
            this.CMBcomment.Name = "CMBcomment";
            this.CMBcomment.Size = new System.Drawing.Size(362, 21);
            this.CMBcomment.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(14, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Comment";
            // 
            // CMBgenre
            // 
            this.CMBgenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBgenre.FormattingEnabled = true;
            this.CMBgenre.Items.AddRange(new object[] {
            "#Keep#"});
            this.CMBgenre.Location = new System.Drawing.Point(176, 201);
            this.CMBgenre.Name = "CMBgenre";
            this.CMBgenre.Size = new System.Drawing.Size(97, 21);
            this.CMBgenre.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Title";
            // 
            // CMBtitle
            // 
            this.CMBtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBtitle.FormattingEnabled = true;
            this.CMBtitle.Items.AddRange(new object[] {
            "#Keep#"});
            this.CMBtitle.Location = new System.Drawing.Point(9, 64);
            this.CMBtitle.Name = "CMBtitle";
            this.CMBtitle.Size = new System.Drawing.Size(365, 21);
            this.CMBtitle.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Artist";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(173, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 277);
            this.label7.TabIndex = 57;
            this.label7.Text = "Genre";
            // 
            // CMBartist
            // 
            this.CMBartist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBartist.FormattingEnabled = true;
            this.CMBartist.Items.AddRange(new object[] {
            "#Keep#"});
            this.CMBartist.Location = new System.Drawing.Point(9, 110);
            this.CMBartist.Name = "CMBartist";
            this.CMBartist.Size = new System.Drawing.Size(365, 21);
            this.CMBartist.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(86, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 277);
            this.label6.TabIndex = 56;
            this.label6.Text = "Track";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 53;
            this.label4.Text = "Album";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(14, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 277);
            this.label5.TabIndex = 55;
            this.label5.Text = "Year";
            // 
            // CMBalbum
            // 
            this.CMBalbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBalbum.FormattingEnabled = true;
            this.CMBalbum.Items.AddRange(new object[] {
            "#Keep#"});
            this.CMBalbum.Location = new System.Drawing.Point(9, 155);
            this.CMBalbum.Name = "CMBalbum";
            this.CMBalbum.Size = new System.Drawing.Size(365, 21);
            this.CMBalbum.TabIndex = 54;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 601);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GNU DB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.LSVsearch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 595);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // LSVsearch
            // 
            this.LSVsearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.COLid,
            this.COLartist,
            this.COLalbum});
            this.LSVsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSVsearch.FullRowSelect = true;
            this.LSVsearch.Location = new System.Drawing.Point(3, 123);
            this.LSVsearch.Name = "LSVsearch";
            this.LSVsearch.Size = new System.Drawing.Size(396, 469);
            this.LSVsearch.TabIndex = 6;
            this.LSVsearch.UseCompatibleStateImageBehavior = false;
            this.LSVsearch.View = System.Windows.Forms.View.Details;
            this.LSVsearch.SelectedIndexChanged += new System.EventHandler(this.LSVsearch_SelectedIndexChanged);
            // 
            // COLid
            // 
            this.COLid.Text = "ID";
            // 
            // COLartist
            // 
            this.COLartist.Text = "Artist";
            // 
            // COLalbum
            // 
            this.COLalbum.Text = "Album";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.CMBpageno);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.BTNsearch);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.TXTsearch);
            this.panel1.Controls.Add(this.CMBsearchtype);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 114);
            this.panel1.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(258, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Page No";
            // 
            // CMBpageno
            // 
            this.CMBpageno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBpageno.FormattingEnabled = true;
            this.CMBpageno.Location = new System.Drawing.Point(313, 71);
            this.CMBpageno.Name = "CMBpageno";
            this.CMBpageno.Size = new System.Drawing.Size(47, 21);
            this.CMBpageno.TabIndex = 15;
            this.CMBpageno.SelectedIndexChanged += new System.EventHandler(this.CMBpageno_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(72, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Search";
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(146, 71);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(75, 23);
            this.BTNsearch.TabIndex = 13;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(72, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Text";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Search Type";
            // 
            // TXTsearch
            // 
            this.TXTsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTsearch.Location = new System.Drawing.Point(146, 45);
            this.TXTsearch.Name = "TXTsearch";
            this.TXTsearch.Size = new System.Drawing.Size(214, 20);
            this.TXTsearch.TabIndex = 10;
            // 
            // CMBsearchtype
            // 
            this.CMBsearchtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBsearchtype.FormattingEnabled = true;
            this.CMBsearchtype.Items.AddRange(new object[] {
            "GNUDB"});
            this.CMBsearchtype.Location = new System.Drawing.Point(146, 14);
            this.CMBsearchtype.Name = "CMBsearchtype";
            this.CMBsearchtype.Size = new System.Drawing.Size(214, 21);
            this.CMBsearchtype.TabIndex = 9;
            this.CMBsearchtype.Text = "GNUDB";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(408, 601);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.treeView, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(408, 601);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTNsqlist);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 34);
            this.panel2.TabIndex = 0;
            // 
            // BTNsqlist
            // 
            this.BTNsqlist.Location = new System.Drawing.Point(8, 6);
            this.BTNsqlist.Name = "BTNsqlist";
            this.BTNsqlist.Size = new System.Drawing.Size(75, 23);
            this.BTNsqlist.TabIndex = 0;
            this.BTNsqlist.Text = "List";
            this.BTNsqlist.UseVisualStyleBackColor = true;
            this.BTNsqlist.Click += new System.EventHandler(this.BTNsqlist_Click);
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(3, 43);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(402, 555);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.Enter += new System.EventHandler(this.treeView_Enter);
            // 
            // musicListStore
            // 
            this.musicListStore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filename,
            this.Pathname,
            this.Tagcol,
            this.Titlecol,
            this.artistcol,
            this.albumcol,
            this.Trackcol,
            this.Yearcol,
            this.Genrecol,
            this.Commentscol});
            this.musicListStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicListStore.FullRowSelect = true;
            this.musicListStore.GridLines = true;
            this.musicListStore.Location = new System.Drawing.Point(0, 0);
            this.musicListStore.Name = "musicListStore";
            this.musicListStore.Size = new System.Drawing.Size(595, 627);
            this.musicListStore.TabIndex = 1;
            this.musicListStore.UseCompatibleStateImageBehavior = false;
            this.musicListStore.View = System.Windows.Forms.View.Details;
            this.musicListStore.SelectedIndexChanged += new System.EventHandler(this.musicListStore_SelectedIndexChanged);
            // 
            // Filename
            // 
            this.Filename.Text = "Filename";
            this.Filename.Width = 120;
            // 
            // Pathname
            // 
            this.Pathname.Text = "Path";
            this.Pathname.Width = 160;
            // 
            // Tagcol
            // 
            this.Tagcol.Text = "Tag";
            this.Tagcol.Width = 150;
            // 
            // Titlecol
            // 
            this.Titlecol.Text = "Title";
            // 
            // artistcol
            // 
            this.artistcol.Text = "Artist";
            // 
            // albumcol
            // 
            this.albumcol.Text = "Album";
            // 
            // Trackcol
            // 
            this.Trackcol.Text = "Track";
            // 
            // Yearcol
            // 
            this.Yearcol.Text = "Year";
            // 
            // Genrecol
            // 
            this.Genrecol.Text = "Genre";
            // 
            // Commentscol
            // 
            this.Commentscol.Text = "Comments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 718);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ntag mp3 tagger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox CMBtrack;
        private System.Windows.Forms.ComboBox CMByear;
        private System.Windows.Forms.ComboBox CMBcomment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CMBgenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBtitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CMBartist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CMBalbum;
        private System.Windows.Forms.ListView musicListStore;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Pathname;
        private System.Windows.Forms.ColumnHeader Tagcol;
        private System.Windows.Forms.ColumnHeader Titlecol;
        private System.Windows.Forms.ColumnHeader artistcol;
        private System.Windows.Forms.ColumnHeader albumcol;
        private System.Windows.Forms.ColumnHeader Trackcol;
        private System.Windows.Forms.ColumnHeader Yearcol;
        private System.Windows.Forms.ColumnHeader Genrecol;
        private System.Windows.Forms.ColumnHeader Commentscol;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button BTNdeletetag;
        private System.Windows.Forms.Button BTNsavetag;
        private System.Windows.Forms.RadioButton RDOver2;
        private System.Windows.Forms.RadioButton RDOver1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox TXTfilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView LSVsearch;
        private System.Windows.Forms.ColumnHeader COLid;
        private System.Windows.Forms.ColumnHeader COLartist;
        private System.Windows.Forms.ColumnHeader COLalbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CMBpageno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXTsearch;
        private System.Windows.Forms.ComboBox CMBsearchtype;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNsqlist;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button BTNcopy;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox COMsearch;
        private System.Windows.Forms.ToolStripButton BTNlocalsearch;
        private System.Windows.Forms.ToolStripMenuItem renameFileFromTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagFromFilenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LABimage;
        private System.Windows.Forms.Button BTNloadimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.Button BTNsearchimage;
        private System.Windows.Forms.ToolStripButton BTNaddimage;
    }
}


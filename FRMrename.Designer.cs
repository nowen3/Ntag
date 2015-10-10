namespace Ntag
{
    partial class FRMrename
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LSVbefore = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNupdate = new System.Windows.Forms.Button();
            this.BTNfname = new System.Windows.Forms.Button();
            this.TXTpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.COMBrename = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXTrepafter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTrepbefore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LSVafter = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.BTNsave = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.LSVbefore, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LSVbefore
            // 
            this.LSVbefore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LSVbefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSVbefore.Location = new System.Drawing.Point(3, 103);
            this.LSVbefore.Name = "LSVbefore";
            this.LSVbefore.Size = new System.Drawing.Size(392, 282);
            this.LSVbefore.TabIndex = 3;
            this.LSVbefore.UseCompatibleStateImageBehavior = false;
            this.LSVbefore.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Filename";
            this.columnHeader2.Width = 228;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNupdate);
            this.panel1.Controls.Add(this.BTNfname);
            this.panel1.Controls.Add(this.TXTpath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.COMBrename);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 94);
            this.panel1.TabIndex = 0;
            // 
            // BTNupdate
            // 
            this.BTNupdate.Location = new System.Drawing.Point(354, 13);
            this.BTNupdate.Name = "BTNupdate";
            this.BTNupdate.Size = new System.Drawing.Size(31, 23);
            this.BTNupdate.TabIndex = 11;
            this.BTNupdate.Text = "button1";
            this.BTNupdate.UseVisualStyleBackColor = true;
            this.BTNupdate.Click += new System.EventHandler(this.BTNupdate_Click);
            // 
            // BTNfname
            // 
            this.BTNfname.Location = new System.Drawing.Point(354, 42);
            this.BTNfname.Name = "BTNfname";
            this.BTNfname.Size = new System.Drawing.Size(31, 23);
            this.BTNfname.TabIndex = 10;
            this.BTNfname.Text = "...";
            this.BTNfname.UseVisualStyleBackColor = true;
            this.BTNfname.Click += new System.EventHandler(this.BTNfname_Click);
            // 
            // TXTpath
            // 
            this.TXTpath.Location = new System.Drawing.Point(76, 42);
            this.TXTpath.Name = "TXTpath";
            this.TXTpath.Size = new System.Drawing.Size(273, 20);
            this.TXTpath.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Path";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rename Format";
            // 
            // COMBrename
            // 
            this.COMBrename.FormattingEnabled = true;
            this.COMBrename.Items.AddRange(new object[] {
            "%TRACKNUMBER%-%ARTIST%-%ALBUM%",
            "%TRACKNUMBER%-%ARTIST%-%TITLE%",
            "%TRACKNUMBER%-%TITLE%",
            "%FILENAME%"});
            this.COMBrename.Location = new System.Drawing.Point(79, 15);
            this.COMBrename.Name = "COMBrename";
            this.COMBrename.Size = new System.Drawing.Size(273, 21);
            this.COMBrename.TabIndex = 6;
            this.COMBrename.Text = "%TRACKNUMBER%-%ARTIST%-%TITLE%";
            this.COMBrename.SelectedIndexChanged += new System.EventHandler(this.COMBrename_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(401, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 94);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TXTrepafter);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TXTrepbefore);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(409, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 94);
            this.panel3.TabIndex = 2;
            // 
            // TXTrepafter
            // 
            this.TXTrepafter.Location = new System.Drawing.Point(17, 65);
            this.TXTrepafter.Name = "TXTrepafter";
            this.TXTrepafter.Size = new System.Drawing.Size(57, 20);
            this.TXTrepafter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "With";
            // 
            // TXTrepbefore
            // 
            this.TXTrepbefore.Location = new System.Drawing.Point(17, 18);
            this.TXTrepbefore.Name = "TXTrepbefore";
            this.TXTrepbefore.Size = new System.Drawing.Size(62, 20);
            this.TXTrepbefore.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Replace String";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LSVafter);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(409, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 282);
            this.panel4.TabIndex = 4;
            // 
            // LSVafter
            // 
            this.LSVafter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.LSVafter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSVafter.Location = new System.Drawing.Point(0, 0);
            this.LSVafter.Name = "LSVafter";
            this.LSVafter.Size = new System.Drawing.Size(392, 282);
            this.LSVafter.TabIndex = 3;
            this.LSVafter.UseCompatibleStateImageBehavior = false;
            this.LSVafter.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Path";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "New Filename";
            this.columnHeader6.Width = 278;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.BTNsave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(409, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 31);
            this.panel5.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button5.Location = new System.Drawing.Point(232, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BTNsave
            // 
            this.BTNsave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNsave.Location = new System.Drawing.Point(313, 4);
            this.BTNsave.Name = "BTNsave";
            this.BTNsave.Size = new System.Drawing.Size(75, 23);
            this.BTNsave.TabIndex = 2;
            this.BTNsave.Text = "Rename";
            this.BTNsave.UseVisualStyleBackColor = true;
            // 
            // FRMrename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FRMrename";
            this.Text = "Rename Files";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView LSVbefore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNupdate;
        private System.Windows.Forms.Button BTNfname;
        private System.Windows.Forms.TextBox TXTpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMBrename;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView LSVafter;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BTNsave;
        private System.Windows.Forms.TextBox TXTrepafter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTrepbefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
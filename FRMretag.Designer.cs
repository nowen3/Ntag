namespace Ntag
{
    partial class FRMretag
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNok = new System.Windows.Forms.Button();
            this.BTNcancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LSVnewtrack = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.LSVtrack = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.BTNdown = new System.Windows.Forms.Button();
            this.BTNup = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTcomment = new System.Windows.Forms.TextBox();
            this.CMBgenre = new System.Windows.Forms.ComboBox();
            this.TXTyear = new System.Windows.Forms.TextBox();
            this.TXTalbum = new System.Windows.Forms.TextBox();
            this.TXTartist = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTNok);
            this.panel1.Controls.Add(this.BTNcancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(399, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 35);
            this.panel1.TabIndex = 0;
            // 
            // BTNok
            // 
            this.BTNok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNok.Location = new System.Drawing.Point(217, 4);
            this.BTNok.Name = "BTNok";
            this.BTNok.Size = new System.Drawing.Size(68, 23);
            this.BTNok.TabIndex = 8;
            this.BTNok.Text = "OK";
            this.BTNok.UseVisualStyleBackColor = true;
            // 
            // BTNcancel
            // 
            this.BTNcancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNcancel.Location = new System.Drawing.Point(302, 4);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(68, 23);
            this.BTNcancel.TabIndex = 7;
            this.BTNcancel.Text = "Cancel";
            this.BTNcancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LSVnewtrack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 270);
            this.panel2.TabIndex = 1;
            // 
            // LSVnewtrack
            // 
            this.LSVnewtrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LSVnewtrack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LSVnewtrack.FullRowSelect = true;
            this.LSVnewtrack.Location = new System.Drawing.Point(24, 3);
            this.LSVnewtrack.Name = "LSVnewtrack";
            this.LSVnewtrack.Size = new System.Drawing.Size(353, 264);
            this.LSVnewtrack.TabIndex = 19;
            this.LSVnewtrack.UseCompatibleStateImageBehavior = false;
            this.LSVnewtrack.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Track";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 240;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LSVtrack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(399, 175);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 270);
            this.panel3.TabIndex = 2;
            // 
            // LSVtrack
            // 
            this.LSVtrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LSVtrack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.LSVtrack.FullRowSelect = true;
            this.LSVtrack.Location = new System.Drawing.Point(14, 3);
            this.LSVtrack.Name = "LSVtrack";
            this.LSVtrack.Size = new System.Drawing.Size(356, 264);
            this.LSVtrack.TabIndex = 5;
            this.LSVtrack.UseCompatibleStateImageBehavior = false;
            this.LSVtrack.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Track";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Title";
            this.columnHeader4.Width = 160;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BTNdown);
            this.panel4.Controls.Add(this.BTNup);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(790, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(61, 270);
            this.panel4.TabIndex = 3;
            // 
            // BTNdown
            // 
            this.BTNdown.Location = new System.Drawing.Point(3, 43);
            this.BTNdown.Name = "BTNdown";
            this.BTNdown.Size = new System.Drawing.Size(49, 35);
            this.BTNdown.TabIndex = 5;
            this.BTNdown.Text = "Move Down";
            this.BTNdown.UseVisualStyleBackColor = true;
            this.BTNdown.Click += new System.EventHandler(this.BTNdown_Click);
            // 
            // BTNup
            // 
            this.BTNup.Location = new System.Drawing.Point(0, 3);
            this.BTNup.Name = "BTNup";
            this.BTNup.Size = new System.Drawing.Size(52, 34);
            this.BTNup.TabIndex = 4;
            this.BTNup.Text = "Move Up";
            this.BTNup.UseVisualStyleBackColor = true;
            this.BTNup.Click += new System.EventHandler(this.BTNup_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.TXTcomment);
            this.panel5.Controls.Add(this.CMBgenre);
            this.panel5.Controls.Add(this.TXTyear);
            this.panel5.Controls.Add(this.TXTalbum);
            this.panel5.Controls.Add(this.TXTartist);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 166);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Comments";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Artist";
            // 
            // TXTcomment
            // 
            this.TXTcomment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTcomment.Location = new System.Drawing.Point(104, 128);
            this.TXTcomment.Name = "TXTcomment";
            this.TXTcomment.Size = new System.Drawing.Size(244, 20);
            this.TXTcomment.TabIndex = 21;
            // 
            // CMBgenre
            // 
            this.CMBgenre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMBgenre.FormattingEnabled = true;
            this.CMBgenre.Location = new System.Drawing.Point(104, 100);
            this.CMBgenre.Name = "CMBgenre";
            this.CMBgenre.Size = new System.Drawing.Size(244, 21);
            this.CMBgenre.TabIndex = 20;
            // 
            // TXTyear
            // 
            this.TXTyear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTyear.Location = new System.Drawing.Point(104, 73);
            this.TXTyear.Name = "TXTyear";
            this.TXTyear.Size = new System.Drawing.Size(244, 20);
            this.TXTyear.TabIndex = 19;
            // 
            // TXTalbum
            // 
            this.TXTalbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTalbum.Location = new System.Drawing.Point(104, 46);
            this.TXTalbum.Name = "TXTalbum";
            this.TXTalbum.Size = new System.Drawing.Size(244, 20);
            this.TXTalbum.TabIndex = 18;
            // 
            // TXTartist
            // 
            this.TXTartist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTartist.Location = new System.Drawing.Point(104, 19);
            this.TXTartist.Name = "TXTartist";
            this.TXTartist.Size = new System.Drawing.Size(244, 20);
            this.TXTartist.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BTNsearch);
            this.panel6.Controls.Add(this.pictureBox);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(399, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(385, 166);
            this.panel6.TabIndex = 5;
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(113, 41);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(75, 23);
            this.BTNsearch.TabIndex = 2;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox.Location = new System.Drawing.Point(217, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(168, 166);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMretag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FRMretag";
            this.Text = "Retag";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTNok;
        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView LSVnewtrack;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView LSVtrack;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BTNdown;
        private System.Windows.Forms.Button BTNup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTcomment;
        private System.Windows.Forms.ComboBox CMBgenre;
        private System.Windows.Forms.TextBox TXTyear;
        private System.Windows.Forms.TextBox TXTalbum;
        private System.Windows.Forms.TextBox TXTartist;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BTNsearch;
    }
}
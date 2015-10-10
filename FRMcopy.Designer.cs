namespace Ntag
{
    partial class FRMcopy
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
            this.label1 = new System.Windows.Forms.Label();
            this.CMBgenre = new System.Windows.Forms.ComboBox();
            this.RBv2 = new System.Windows.Forms.RadioButton();
            this.RBv1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTNcancel = new System.Windows.Forms.Button();
            this.BTNcopy = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.50704F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.69343F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.30657F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 105);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CMBgenre);
            this.panel1.Controls.Add(this.RBv2);
            this.panel1.Controls.Add(this.RBv1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genre";
            // 
            // CMBgenre
            // 
            this.CMBgenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBgenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CMBgenre.FormattingEnabled = true;
            this.CMBgenre.Location = new System.Drawing.Point(196, 9);
            this.CMBgenre.Name = "CMBgenre";
            this.CMBgenre.Size = new System.Drawing.Size(160, 21);
            this.CMBgenre.Sorted = true;
            this.CMBgenre.TabIndex = 2;
            // 
            // RBv2
            // 
            this.RBv2.AutoSize = true;
            this.RBv2.Location = new System.Drawing.Point(18, 32);
            this.RBv2.Name = "RBv2";
            this.RBv2.Size = new System.Drawing.Size(88, 17);
            this.RBv2.TabIndex = 1;
            this.RBv2.TabStop = true;
            this.RBv2.Text = "Copy V2 tags";
            this.RBv2.UseVisualStyleBackColor = true;
            this.RBv2.CheckedChanged += new System.EventHandler(this.RBv2_CheckedChanged);
            // 
            // RBv1
            // 
            this.RBv1.AutoSize = true;
            this.RBv1.Location = new System.Drawing.Point(18, 9);
            this.RBv1.Name = "RBv1";
            this.RBv1.Size = new System.Drawing.Size(91, 17);
            this.RBv1.TabIndex = 0;
            this.RBv1.TabStop = true;
            this.RBv1.Text = "Copy V1 tags ";
            this.RBv1.UseVisualStyleBackColor = true;
            this.RBv1.CheckedChanged += new System.EventHandler(this.RBv1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BTNcancel);
            this.panel2.Controls.Add(this.BTNcopy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 31);
            this.panel2.TabIndex = 1;
            // 
            // BTNcancel
            // 
            this.BTNcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNcancel.Location = new System.Drawing.Point(63, 3);
            this.BTNcancel.Name = "BTNcancel";
            this.BTNcancel.Size = new System.Drawing.Size(75, 23);
            this.BTNcancel.TabIndex = 1;
            this.BTNcancel.Text = "Cancel";
            this.BTNcancel.UseVisualStyleBackColor = true;
            // 
            // BTNcopy
            // 
            this.BTNcopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTNcopy.Location = new System.Drawing.Point(144, 3);
            this.BTNcopy.Name = "BTNcopy";
            this.BTNcopy.Size = new System.Drawing.Size(75, 23);
            this.BTNcopy.TabIndex = 0;
            this.BTNcopy.Text = "Copy";
            this.BTNcopy.UseVisualStyleBackColor = true;
            // 
            // FRMcopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 105);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FRMcopy";
            this.Text = "Copy Tags";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBv2;
        private System.Windows.Forms.RadioButton RBv1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTNcancel;
        private System.Windows.Forms.Button BTNcopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBgenre;
    }
}
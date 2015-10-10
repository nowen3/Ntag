namespace Ntag
{
    partial class FRMImage
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
            this.TXTimagepath = new System.Windows.Forms.TextBox();
            this.BTNopenimage = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.TXTartist = new System.Windows.Forms.TextBox();
            this.TXTalbum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTimagepath
            // 
            this.TXTimagepath.Location = new System.Drawing.Point(105, 60);
            this.TXTimagepath.Name = "TXTimagepath";
            this.TXTimagepath.Size = new System.Drawing.Size(295, 20);
            this.TXTimagepath.TabIndex = 0;
            // 
            // BTNopenimage
            // 
            this.BTNopenimage.Location = new System.Drawing.Point(24, 60);
            this.BTNopenimage.Name = "BTNopenimage";
            this.BTNopenimage.Size = new System.Drawing.Size(75, 23);
            this.BTNopenimage.TabIndex = 1;
            this.BTNopenimage.Text = "Open Image";
            this.BTNopenimage.UseVisualStyleBackColor = true;
            this.BTNopenimage.Click += new System.EventHandler(this.BTNopenimage_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(422, 11);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 126);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(487, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(24, 104);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(75, 23);
            this.BTNsearch.TabIndex = 4;
            this.BTNsearch.Text = "Search Image";
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // TXTartist
            // 
            this.TXTartist.Location = new System.Drawing.Point(106, 104);
            this.TXTartist.Name = "TXTartist";
            this.TXTartist.Size = new System.Drawing.Size(221, 20);
            this.TXTartist.TabIndex = 5;
            // 
            // TXTalbum
            // 
            this.TXTalbum.Location = new System.Drawing.Point(106, 140);
            this.TXTalbum.Name = "TXTalbum";
            this.TXTalbum.Size = new System.Drawing.Size(221, 20);
            this.TXTalbum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Album";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(398, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FRMImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 187);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTalbum);
            this.Controls.Add(this.TXTartist);
            this.Controls.Add(this.BTNsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.BTNopenimage);
            this.Controls.Add(this.TXTimagepath);
            this.Name = "FRMImage";
            this.Text = "Add Image";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTimagepath;
        private System.Windows.Forms.Button BTNopenimage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.TextBox TXTartist;
        private System.Windows.Forms.TextBox TXTalbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
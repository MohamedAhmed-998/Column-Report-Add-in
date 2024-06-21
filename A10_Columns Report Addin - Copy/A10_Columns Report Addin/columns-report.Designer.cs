using System;

namespace generalsolution
{
    partial class columns_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(columns_report));
            this.Browsing = new System.Windows.Forms.Button();
            this.exporting = new System.Windows.Forms.Button();
            this.closing = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Browsing
            // 
            this.Browsing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browsing.Location = new System.Drawing.Point(693, 119);
            this.Browsing.Name = "Browsing";
            this.Browsing.Size = new System.Drawing.Size(84, 39);
            this.Browsing.TabIndex = 0;
            this.Browsing.Text = "Browse";
            this.Browsing.UseVisualStyleBackColor = true;
            this.Browsing.Click += new System.EventHandler(this.Browsing_Click);
            // 
            // exporting
            // 
            this.exporting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exporting.Location = new System.Drawing.Point(175, 340);
            this.exporting.Name = "exporting";
            this.exporting.Size = new System.Drawing.Size(109, 37);
            this.exporting.TabIndex = 1;
            this.exporting.Text = "Export";
            this.exporting.UseVisualStyleBackColor = true;
            this.exporting.Click += new System.EventHandler(this.exporting_Click);
            // 
            // closing
            // 
            this.closing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closing.Location = new System.Drawing.Point(439, 340);
            this.closing.Name = "closing";
            this.closing.Size = new System.Drawing.Size(103, 37);
            this.closing.TabIndex = 2;
            this.closing.Text = "Close";
            this.closing.UseVisualStyleBackColor = true;
            this.closing.Click += new System.EventHandler(this.closing_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report Location:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(693, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // columns_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.closing);
            this.Controls.Add(this.exporting);
            this.Controls.Add(this.Browsing);
            this.Name = "columns_report";
            this.Text = "columns_report";
            this.Load += new System.EventHandler(this.columns_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        private void linkbt_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button closing;
        public System.Windows.Forms.Button exporting;
        public System.Windows.Forms.Button Browsing;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
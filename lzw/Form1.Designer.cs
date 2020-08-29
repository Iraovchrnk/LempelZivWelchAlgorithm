namespace lzw
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
            this.btn_compress = new System.Windows.Forms.Button();
            this.btn_decompress = new System.Windows.Forms.Button();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.txtbox_filepath = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.newfilename = new System.Windows.Forms.TextBox();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_compress
            // 
            this.btn_compress.Location = new System.Drawing.Point(194, 11);
            this.btn_compress.Name = "btn_compress";
            this.btn_compress.Size = new System.Drawing.Size(140, 32);
            this.btn_compress.TabIndex = 0;
            this.btn_compress.Text = "Compress";
            this.btn_compress.UseVisualStyleBackColor = true;
            this.btn_compress.Click += new System.EventHandler(this.btn_compress_Click);
            // 
            // btn_decompress
            // 
            this.btn_decompress.Location = new System.Drawing.Point(340, 12);
            this.btn_decompress.Name = "btn_decompress";
            this.btn_decompress.Size = new System.Drawing.Size(133, 32);
            this.btn_decompress.TabIndex = 1;
            this.btn_decompress.Text = "Decompress";
            this.btn_decompress.UseVisualStyleBackColor = true;
            this.btn_decompress.Click += new System.EventHandler(this.btn_decompress_Click);
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(479, 12);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(124, 32);
            this.btn_openfile.TabIndex = 2;
            this.btn_openfile.Text = "Open file";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // txtbox_filepath
            // 
            this.txtbox_filepath.Location = new System.Drawing.Point(82, 49);
            this.txtbox_filepath.Name = "txtbox_filepath";
            this.txtbox_filepath.Size = new System.Drawing.Size(391, 20);
            this.txtbox_filepath.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 75);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(591, 331);
            this.webBrowser1.TabIndex = 4;
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_path.Location = new System.Drawing.Point(41, 53);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(38, 16);
            this.lbl_path.TabIndex = 5;
            this.lbl_path.Text = "Path:";
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(479, 46);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(59, 23);
            this.btn_left.TabIndex = 6;
            this.btn_left.Text = "<<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(544, 46);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(59, 23);
            this.btn_right.TabIndex = 7;
            this.btn_right.Text = ">>";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // newfilename
            // 
            this.newfilename.Location = new System.Drawing.Point(82, 23);
            this.newfilename.Name = "newfilename";
            this.newfilename.Size = new System.Drawing.Size(106, 20);
            this.newfilename.TabIndex = 8;
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filename.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_filename.Location = new System.Drawing.Point(12, 27);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(67, 16);
            this.lbl_filename.TabIndex = 9;
            this.lbl_filename.Text = "Filename:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(619, 418);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.newfilename);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtbox_filepath);
            this.Controls.Add(this.btn_openfile);
            this.Controls.Add(this.btn_decompress);
            this.Controls.Add(this.btn_compress);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "lzw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_compress;
        private System.Windows.Forms.Button btn_decompress;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.TextBox txtbox_filepath;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.TextBox newfilename;
        private System.Windows.Forms.Label lbl_filename;
    }
}


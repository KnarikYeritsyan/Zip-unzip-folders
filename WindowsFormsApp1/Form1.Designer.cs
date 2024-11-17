namespace WindowsFormsApp1
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
            this.folderzip = new System.Windows.Forms.Label();
            this.textfolderzip = new System.Windows.Forms.TextBox();
            this.btnfolderzip = new System.Windows.Forms.Button();
            this.btnzipfolder = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.folderunzip = new System.Windows.Forms.Label();
            this.textfolderunzip = new System.Windows.Forms.TextBox();
            this.btnfolderunzip = new System.Windows.Forms.Button();
            this.btnunzipfolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // folderzip
            // 
            this.folderzip.AutoSize = true;
            this.folderzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderzip.Location = new System.Drawing.Point(20, 53);
            this.folderzip.Name = "folderzip";
            this.folderzip.Size = new System.Drawing.Size(54, 17);
            this.folderzip.TabIndex = 0;
            this.folderzip.Text = "Folder";
            this.folderzip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textfolderzip
            // 
            this.textfolderzip.Location = new System.Drawing.Point(80, 50);
            this.textfolderzip.Name = "textfolderzip";
            this.textfolderzip.Size = new System.Drawing.Size(251, 20);
            this.textfolderzip.TabIndex = 1;
            this.textfolderzip.TextChanged += new System.EventHandler(this.textfolderzip_TextChanged);
            // 
            // btnfolderzip
            // 
            this.btnfolderzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfolderzip.Location = new System.Drawing.Point(337, 50);
            this.btnfolderzip.Name = "btnfolderzip";
            this.btnfolderzip.Size = new System.Drawing.Size(41, 20);
            this.btnfolderzip.TabIndex = 2;
            this.btnfolderzip.Text = "...";
            this.btnfolderzip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfolderzip.UseVisualStyleBackColor = true;
            this.btnfolderzip.Click += new System.EventHandler(this.btnfolderzip_Click);
            // 
            // btnzipfolder
            // 
            this.btnzipfolder.Location = new System.Drawing.Point(384, 48);
            this.btnzipfolder.Name = "btnzipfolder";
            this.btnzipfolder.Size = new System.Drawing.Size(75, 23);
            this.btnzipfolder.TabIndex = 3;
            this.btnzipfolder.Text = "Zip";
            this.btnzipfolder.UseVisualStyleBackColor = true;
            this.btnzipfolder.Click += new System.EventHandler(this.btnzipfolder_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(80, 142);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(298, 26);
            this.progressBar.TabIndex = 8;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // folderunzip
            // 
            this.folderunzip.AutoSize = true;
            this.folderunzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderunzip.Location = new System.Drawing.Point(20, 100);
            this.folderunzip.Name = "folderunzip";
            this.folderunzip.Size = new System.Drawing.Size(54, 17);
            this.folderunzip.TabIndex = 4;
            this.folderunzip.Text = "Folder";
            this.folderunzip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textfolderunzip
            // 
            this.textfolderunzip.Location = new System.Drawing.Point(80, 97);
            this.textfolderunzip.Name = "textfolderunzip";
            this.textfolderunzip.Size = new System.Drawing.Size(251, 20);
            this.textfolderunzip.TabIndex = 5;
            // 
            // btnfolderunzip
            // 
            this.btnfolderunzip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfolderunzip.Location = new System.Drawing.Point(337, 97);
            this.btnfolderunzip.Name = "btnfolderunzip";
            this.btnfolderunzip.Size = new System.Drawing.Size(41, 20);
            this.btnfolderunzip.TabIndex = 6;
            this.btnfolderunzip.Text = "...";
            this.btnfolderunzip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnfolderunzip.UseVisualStyleBackColor = true;
            this.btnfolderunzip.Click += new System.EventHandler(this.btnfolderunzip_Click);
            // 
            // btnunzipfolder
            // 
            this.btnunzipfolder.Location = new System.Drawing.Point(384, 95);
            this.btnunzipfolder.Name = "btnunzipfolder";
            this.btnunzipfolder.Size = new System.Drawing.Size(75, 23);
            this.btnunzipfolder.TabIndex = 7;
            this.btnunzipfolder.Text = "unZip";
            this.btnunzipfolder.UseVisualStyleBackColor = true;
            this.btnunzipfolder.Click += new System.EventHandler(this.btnunzipfolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 198);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnunzipfolder);
            this.Controls.Add(this.btnfolderunzip);
            this.Controls.Add(this.textfolderunzip);
            this.Controls.Add(this.folderunzip);
            this.Controls.Add(this.btnzipfolder);
            this.Controls.Add(this.btnfolderzip);
            this.Controls.Add(this.textfolderzip);
            this.Controls.Add(this.folderzip);
            this.Name = "Form1";
            this.Text = "Zip&unZip";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label folderzip;
        private System.Windows.Forms.TextBox textfolderzip;
        private System.Windows.Forms.Button btnfolderzip;
        private System.Windows.Forms.Button btnzipfolder;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label folderunzip;
        private System.Windows.Forms.TextBox textfolderunzip;
        private System.Windows.Forms.Button btnfolderunzip;
        private System.Windows.Forms.Button btnunzipfolder;
    }
}


namespace NetFileCreateLinkList
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
            this.fileFolderButton = new System.Windows.Forms.Button();
            this.fileFolderTextbox = new System.Windows.Forms.TextBox();
            this.domainTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.getFilesButton = new System.Windows.Forms.Button();
            this.makeIndexButton = new System.Windows.Forms.Button();
            this.zipFilesButton = new System.Windows.Forms.Button();
            this.destFolderButton = new System.Windows.Forms.Button();
            this.copyContentButton = new System.Windows.Forms.Button();
            this.destFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileFolderButton
            // 
            this.fileFolderButton.Location = new System.Drawing.Point(12, 12);
            this.fileFolderButton.Name = "fileFolderButton";
            this.fileFolderButton.Size = new System.Drawing.Size(90, 23);
            this.fileFolderButton.TabIndex = 0;
            this.fileFolderButton.Text = "File folder";
            this.fileFolderButton.UseVisualStyleBackColor = true;
            this.fileFolderButton.Click += new System.EventHandler(this.fileFolderButton_Click);
            // 
            // fileFolderTextbox
            // 
            this.fileFolderTextbox.Location = new System.Drawing.Point(113, 14);
            this.fileFolderTextbox.Name = "fileFolderTextbox";
            this.fileFolderTextbox.Size = new System.Drawing.Size(382, 20);
            this.fileFolderTextbox.TabIndex = 1;
            // 
            // domainTextbox
            // 
            this.domainTextbox.Location = new System.Drawing.Point(113, 50);
            this.domainTextbox.Name = "domainTextbox";
            this.domainTextbox.Size = new System.Drawing.Size(382, 20);
            this.domainTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Domain:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 325);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // getFilesButton
            // 
            this.getFilesButton.Location = new System.Drawing.Point(12, 126);
            this.getFilesButton.Name = "getFilesButton";
            this.getFilesButton.Size = new System.Drawing.Size(108, 23);
            this.getFilesButton.TabIndex = 5;
            this.getFilesButton.Text = "Make Link List";
            this.getFilesButton.UseVisualStyleBackColor = true;
            this.getFilesButton.Click += new System.EventHandler(this.getFilesButton_Click);
            // 
            // makeIndexButton
            // 
            this.makeIndexButton.Location = new System.Drawing.Point(126, 126);
            this.makeIndexButton.Name = "makeIndexButton";
            this.makeIndexButton.Size = new System.Drawing.Size(108, 23);
            this.makeIndexButton.TabIndex = 6;
            this.makeIndexButton.Text = "Make index.htm";
            this.makeIndexButton.UseVisualStyleBackColor = true;
            this.makeIndexButton.Click += new System.EventHandler(this.makeIndexButton_Click);
            // 
            // zipFilesButton
            // 
            this.zipFilesButton.Location = new System.Drawing.Point(240, 126);
            this.zipFilesButton.Name = "zipFilesButton";
            this.zipFilesButton.Size = new System.Drawing.Size(108, 23);
            this.zipFilesButton.TabIndex = 7;
            this.zipFilesButton.Text = "Zip files";
            this.zipFilesButton.UseVisualStyleBackColor = true;
            this.zipFilesButton.Click += new System.EventHandler(this.zipFilesButton_Click);
            // 
            // destFolderButton
            // 
            this.destFolderButton.Location = new System.Drawing.Point(12, 83);
            this.destFolderButton.Name = "destFolderButton";
            this.destFolderButton.Size = new System.Drawing.Size(90, 23);
            this.destFolderButton.TabIndex = 8;
            this.destFolderButton.Text = "Dest folder";
            this.destFolderButton.UseVisualStyleBackColor = true;
            this.destFolderButton.Click += new System.EventHandler(this.destFolderButton_Click);
            // 
            // copyContentButton
            // 
            this.copyContentButton.Location = new System.Drawing.Point(354, 126);
            this.copyContentButton.Name = "copyContentButton";
            this.copyContentButton.Size = new System.Drawing.Size(108, 23);
            this.copyContentButton.TabIndex = 7;
            this.copyContentButton.Text = "Content copy";
            this.copyContentButton.UseVisualStyleBackColor = true;
            this.copyContentButton.Click += new System.EventHandler(this.copyContentButton_Click);
            // 
            // destFolderTextBox
            // 
            this.destFolderTextBox.Location = new System.Drawing.Point(189, 85);
            this.destFolderTextBox.Name = "destFolderTextBox";
            this.destFolderTextBox.Size = new System.Drawing.Size(306, 20);
            this.destFolderTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 508);
            this.Controls.Add(this.destFolderButton);
            this.Controls.Add(this.copyContentButton);
            this.Controls.Add(this.zipFilesButton);
            this.Controls.Add(this.makeIndexButton);
            this.Controls.Add(this.getFilesButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destFolderTextBox);
            this.Controls.Add(this.domainTextbox);
            this.Controls.Add(this.fileFolderTextbox);
            this.Controls.Add(this.fileFolderButton);
            this.Name = "Form1";
            this.Text = "NetFileCreateLinkList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileFolderButton;
        private System.Windows.Forms.TextBox fileFolderTextbox;
        private System.Windows.Forms.TextBox domainTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button getFilesButton;
        private System.Windows.Forms.Button makeIndexButton;
        private System.Windows.Forms.Button zipFilesButton;
        private System.Windows.Forms.Button destFolderButton;
        private System.Windows.Forms.Button copyContentButton;
        private System.Windows.Forms.TextBox destFolderTextBox;
        private System.Windows.Forms.Label label2;
    }
}


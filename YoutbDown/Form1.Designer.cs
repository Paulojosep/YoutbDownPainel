namespace YoutbDown
{
    partial class Form1
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
            btnDownload = new Button();
            textUrl = new TextBox();
            label1 = new Label();
            checkMP3 = new CheckBox();
            txtInfo = new Label();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(224, 232);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(132, 38);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += button1_Click;
            // 
            // textUrl
            // 
            textUrl.Location = new Point(224, 64);
            textUrl.Name = "textUrl";
            textUrl.Size = new Size(381, 27);
            textUrl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 71);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite a URL";
            // 
            // checkMP3
            // 
            checkMP3.AutoSize = true;
            checkMP3.Location = new Point(227, 122);
            checkMP3.Name = "checkMP3";
            checkMP3.Size = new Size(162, 24);
            checkMP3.TabIndex = 3;
            checkMP3.Text = "Converter para MP3";
            checkMP3.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            txtInfo.AutoSize = true;
            txtInfo.Location = new Point(197, 182);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(0, 20);
            txtInfo.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 293);
            Controls.Add(txtInfo);
            Controls.Add(checkMP3);
            Controls.Add(label1);
            Controls.Add(textUrl);
            Controls.Add(btnDownload);
            Name = "Form1";
            Text = "YoutubeDown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private TextBox textUrl;
        private Label label1;
        private CheckBox checkMP3;
        private Label txtInfo;
    }
}
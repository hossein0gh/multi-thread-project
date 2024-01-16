using System.Reflection.Emit;

namespace OS_Project
{
    partial class OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OS));
            this.musicBtn = new System.Windows.Forms.Button();
            this.mp3Name = new System.Windows.Forms.TextBox();
            this.time_txtbox = new System.Windows.Forms.TextBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.fileBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.ConvertorFormBtn = new System.Windows.Forms.Button();
            this.massConvertorFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musicBtn
            // 
            this.musicBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.musicBtn.Location = new System.Drawing.Point(23, 64);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(190, 33);
            this.musicBtn.TabIndex = 0;
            this.musicBtn.Text = "Choose music:";
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Click += new System.EventHandler(this.test_Click_1);
            // 
            // mp3Name
            // 
            this.mp3Name.BackColor = System.Drawing.Color.SkyBlue;
            this.mp3Name.Location = new System.Drawing.Point(23, 103);
            this.mp3Name.Multiline = true;
            this.mp3Name.Name = "mp3Name";
            this.mp3Name.ReadOnly = true;
            this.mp3Name.Size = new System.Drawing.Size(190, 45);
            this.mp3Name.TabIndex = 1;
            // 
            // time_txtbox
            // 
            this.time_txtbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.time_txtbox.BackColor = System.Drawing.Color.Aquamarine;
            this.time_txtbox.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_txtbox.Location = new System.Drawing.Point(370, 5);
            this.time_txtbox.Name = "time_txtbox";
            this.time_txtbox.ReadOnly = true;
            this.time_txtbox.Size = new System.Drawing.Size(161, 28);
            this.time_txtbox.TabIndex = 2;
            this.time_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.Color.Lime;
            this.PlayBtn.Location = new System.Drawing.Point(23, 154);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(190, 31);
            this.PlayBtn.TabIndex = 3;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // fileBtn
            // 
            this.fileBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.fileBtn.Location = new System.Drawing.Point(23, 242);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(190, 33);
            this.fileBtn.TabIndex = 4;
            this.fileBtn.Text = "Choose Text file:";
            this.fileBtn.UseVisualStyleBackColor = false;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(23, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 183);
            this.textBox1.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.Aquamarine;
            this.Name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(12, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(173, 24);
            this.Name.TabIndex = 6;
            this.Name.Text = "Hossein Gholizade";
            this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertorFormBtn
            // 
            this.ConvertorFormBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.ConvertorFormBtn.Location = new System.Drawing.Point(271, 127);
            this.ConvertorFormBtn.Name = "ConvertorFormBtn";
            this.ConvertorFormBtn.Size = new System.Drawing.Size(235, 85);
            this.ConvertorFormBtn.TabIndex = 7;
            this.ConvertorFormBtn.Text = "Open Length convertor form";
            this.ConvertorFormBtn.UseVisualStyleBackColor = false;
            this.ConvertorFormBtn.Click += new System.EventHandler(this.ConvertorFormBtn_Click);
            // 
            // massConvertorFormBtn
            // 
            this.massConvertorFormBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.massConvertorFormBtn.Location = new System.Drawing.Point(271, 249);
            this.massConvertorFormBtn.Name = "massConvertorFormBtn";
            this.massConvertorFormBtn.Size = new System.Drawing.Size(235, 85);
            this.massConvertorFormBtn.TabIndex = 8;
            this.massConvertorFormBtn.Text = "Open Mass convertor form";
            this.massConvertorFormBtn.UseVisualStyleBackColor = false;
            this.massConvertorFormBtn.Click += new System.EventHandler(this.massConvertorFormBtn_Click);
            // 
            // OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(534, 485);
            this.Controls.Add(this.massConvertorFormBtn);
            this.Controls.Add(this.ConvertorFormBtn);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.time_txtbox);
            this.Controls.Add(this.mp3Name);
            this.Controls.Add(this.musicBtn);
            this.Font = new System.Drawing.Font("DejaVu Sans Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.Name = "OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Thread OS Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.TextBox mp3Name;
        private System.Windows.Forms.TextBox time_txtbox;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button ConvertorFormBtn;
        private System.Windows.Forms.Button massConvertorFormBtn;
    }
}


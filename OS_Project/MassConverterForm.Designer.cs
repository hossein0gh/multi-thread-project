namespace OS_Project
{
    partial class MassConverterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.convertBtn = new System.Windows.Forms.Button();
            this.lblGrams = new System.Windows.Forms.Label();
            this.lblOunces = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "mass in kilograms:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.MistyRose;
            this.input.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.input.Location = new System.Drawing.Point(18, 83);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(174, 29);
            this.input.TabIndex = 3;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.Indigo;
            this.convertBtn.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertBtn.Location = new System.Drawing.Point(18, 127);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(174, 56);
            this.convertBtn.TabIndex = 4;
            this.convertBtn.Text = "convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // lblGrams
            // 
            this.lblGrams.AutoSize = true;
            this.lblGrams.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrams.Location = new System.Drawing.Point(209, 143);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(79, 25);
            this.lblGrams.TabIndex = 8;
            this.lblGrams.Text = "Grams:";
            this.lblGrams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOunces
            // 
            this.lblOunces.AutoSize = true;
            this.lblOunces.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOunces.Location = new System.Drawing.Point(209, 96);
            this.lblOunces.Name = "lblOunces";
            this.lblOunces.Size = new System.Drawing.Size(87, 25);
            this.lblOunces.TabIndex = 7;
            this.lblOunces.Text = "Ounces:";
            this.lblOunces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPounds.Location = new System.Drawing.Point(209, 46);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(89, 25);
            this.lblPounds.TabIndex = 6;
            this.lblPounds.Text = "Pounds:";
            this.lblPounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MassConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.lblGrams);
            this.Controls.Add(this.lblOunces);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label1);
            this.Name = "MassConverterForm";
            this.Text = "MassConverterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label lblGrams;
        private System.Windows.Forms.Label lblOunces;
        private System.Windows.Forms.Label lblPounds;
    }
}
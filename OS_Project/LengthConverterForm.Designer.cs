namespace OS_Project
{
    partial class LengthConverterForm
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
            this.convertBtn = new System.Windows.Forms.Button();
            this.lblFeet = new System.Windows.Forms.Label();
            this.lblInches = new System.Windows.Forms.Label();
            this.lblCentimeters = new System.Windows.Forms.Label();
            this.lblYards = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "length in meter:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertBtn
            // 
            this.convertBtn.BackColor = System.Drawing.Color.Indigo;
            this.convertBtn.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.convertBtn.Location = new System.Drawing.Point(12, 132);
            this.convertBtn.Name = "convertBtn";
            this.convertBtn.Size = new System.Drawing.Size(162, 56);
            this.convertBtn.TabIndex = 2;
            this.convertBtn.Text = "convert";
            this.convertBtn.UseVisualStyleBackColor = false;
            this.convertBtn.Click += new System.EventHandler(this.convertBtn_Click);
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeet.Location = new System.Drawing.Point(194, 29);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(63, 25);
            this.lblFeet.TabIndex = 3;
            this.lblFeet.Text = "Feet:";
            this.lblFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInches
            // 
            this.lblInches.AutoSize = true;
            this.lblInches.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInches.Location = new System.Drawing.Point(194, 79);
            this.lblInches.Name = "lblInches";
            this.lblInches.Size = new System.Drawing.Size(78, 25);
            this.lblInches.TabIndex = 4;
            this.lblInches.Text = "Inches:";
            this.lblInches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCentimeters
            // 
            this.lblCentimeters.AutoSize = true;
            this.lblCentimeters.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentimeters.Location = new System.Drawing.Point(194, 126);
            this.lblCentimeters.Name = "lblCentimeters";
            this.lblCentimeters.Size = new System.Drawing.Size(137, 25);
            this.lblCentimeters.TabIndex = 5;
            this.lblCentimeters.Text = "Centimeters:";
            this.lblCentimeters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYards
            // 
            this.lblYards.AutoSize = true;
            this.lblYards.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYards.Location = new System.Drawing.Point(194, 172);
            this.lblYards.Name = "lblYards";
            this.lblYards.Size = new System.Drawing.Size(64, 25);
            this.lblYards.TabIndex = 6;
            this.lblYards.Text = "Yard:";
            this.lblYards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.MistyRose;
            this.input.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.input.Location = new System.Drawing.Point(12, 79);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(162, 29);
            this.input.TabIndex = 7;
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LengthConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.Controls.Add(this.input);
            this.Controls.Add(this.lblYards);
            this.Controls.Add(this.lblCentimeters);
            this.Controls.Add(this.lblInches);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.convertBtn);
            this.Controls.Add(this.label1);
            this.Name = "LengthConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LengthConverterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button convertBtn;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.Label lblInches;
        private System.Windows.Forms.Label lblCentimeters;
        private System.Windows.Forms.Label lblYards;
        private System.Windows.Forms.TextBox input;
    }
}
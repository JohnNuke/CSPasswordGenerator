
namespace PasswordGen
{
    partial class PG
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LengthBar = new System.Windows.Forms.TrackBar();
            this.passWordLengthLabel = new System.Windows.Forms.Label();
            this.upperCheck = new System.Windows.Forms.CheckBox();
            this.numCheck = new System.Windows.Forms.CheckBox();
            this.specialCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBar)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(68, 165);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(525, 53);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "PassWord Generator";
            // 
            // LengthBar
            // 
            this.LengthBar.Location = new System.Drawing.Point(137, 255);
            this.LengthBar.Maximum = 16;
            this.LengthBar.Minimum = 6;
            this.LengthBar.Name = "LengthBar";
            this.LengthBar.Size = new System.Drawing.Size(362, 56);
            this.LengthBar.TabIndex = 3;
            this.LengthBar.Value = 11;
            this.LengthBar.Scroll += new System.EventHandler(this.LengthBar_Scroll);
            // 
            // passWordLengthLabel
            // 
            this.passWordLengthLabel.AutoSize = true;
            this.passWordLengthLabel.Location = new System.Drawing.Point(307, 232);
            this.passWordLengthLabel.Name = "passWordLengthLabel";
            this.passWordLengthLabel.Size = new System.Drawing.Size(24, 17);
            this.passWordLengthLabel.TabIndex = 4;
            this.passWordLengthLabel.Text = "10";
            // 
            // upperCheck
            // 
            this.upperCheck.AutoSize = true;
            this.upperCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCheck.Location = new System.Drawing.Point(68, 111);
            this.upperCheck.Name = "upperCheck";
            this.upperCheck.Size = new System.Drawing.Size(89, 33);
            this.upperCheck.TabIndex = 6;
            this.upperCheck.Text = "A - Z";
            this.upperCheck.UseVisualStyleBackColor = true;
            // 
            // numCheck
            // 
            this.numCheck.AutoSize = true;
            this.numCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCheck.Location = new System.Drawing.Point(284, 111);
            this.numCheck.Name = "numCheck";
            this.numCheck.Size = new System.Drawing.Size(86, 33);
            this.numCheck.TabIndex = 7;
            this.numCheck.Text = "0 - 9";
            this.numCheck.UseVisualStyleBackColor = true;
            // 
            // specialCheck
            // 
            this.specialCheck.AutoSize = true;
            this.specialCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCheck.Location = new System.Drawing.Point(492, 111);
            this.specialCheck.Name = "specialCheck";
            this.specialCheck.Size = new System.Drawing.Size(101, 33);
            this.specialCheck.TabIndex = 8;
            this.specialCheck.Text = "?:@!#";
            this.specialCheck.UseVisualStyleBackColor = true;
            // 
            // PG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(661, 423);
            this.Controls.Add(this.specialCheck);
            this.Controls.Add(this.numCheck);
            this.Controls.Add(this.upperCheck);
            this.Controls.Add(this.passWordLengthLabel);
            this.Controls.Add(this.LengthBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PG";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LengthBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar LengthBar;
        private System.Windows.Forms.Label passWordLengthLabel;
        private System.Windows.Forms.CheckBox upperCheck;
        private System.Windows.Forms.CheckBox numCheck;
        private System.Windows.Forms.CheckBox specialCheck;
    }
}


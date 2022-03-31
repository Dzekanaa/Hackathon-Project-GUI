
namespace Hackathon_Project_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // webBrowser1

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
            this.settingsButton = new System.Windows.Forms.Button();
            this.emergencyButton = new System.Windows.Forms.Button();
            this.igriceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(522, 12);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(53, 39);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // emergencyButton
            // 
            this.emergencyButton.Location = new System.Drawing.Point(438, 12);
            this.emergencyButton.Name = "emergencyButton";
            this.emergencyButton.Size = new System.Drawing.Size(68, 39);
            this.emergencyButton.TabIndex = 1;
            this.emergencyButton.Text = "emergency";
            this.emergencyButton.UseVisualStyleBackColor = true;
            // 
            // igriceButton
            // 
            this.igriceButton.Location = new System.Drawing.Point(108, 351);
            this.igriceButton.Name = "igriceButton";
            this.igriceButton.Size = new System.Drawing.Size(97, 111);
            this.igriceButton.TabIndex = 2;
            this.igriceButton.Text = "igrice";
            this.igriceButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 500);
            this.Controls.Add(this.igriceButton);
            this.Controls.Add(this.emergencyButton);
            this.Controls.Add(this.settingsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button emergencyButton;
        private System.Windows.Forms.Button igriceButton;
    }
}


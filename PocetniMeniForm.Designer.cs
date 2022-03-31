
namespace Hackathon_Project_GUI
{
    partial class PocetniMeniForm
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
            this.mestaButton = new System.Windows.Forms.Button();
            this.pomocButton = new System.Windows.Forms.Button();
            this.lokacijeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(650, 10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(60, 60);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // emergencyButton
            // 
            this.emergencyButton.Location = new System.Drawing.Point(650, 80);
            this.emergencyButton.Name = "emergencyButton";
            this.emergencyButton.Size = new System.Drawing.Size(60, 60);
            this.emergencyButton.TabIndex = 1;
            this.emergencyButton.Text = "emergency";
            this.emergencyButton.UseVisualStyleBackColor = true;
            // 
            // igriceButton
            // 
            this.igriceButton.Location = new System.Drawing.Point(135, 575);
            this.igriceButton.Name = "igriceButton";
            this.igriceButton.Size = new System.Drawing.Size(180, 180);
            this.igriceButton.TabIndex = 2;
            this.igriceButton.Text = "igrice";
            this.igriceButton.UseVisualStyleBackColor = true;
            this.igriceButton.Click += new System.EventHandler(this.igriceButton_Click);
            // 
            // mestaButton
            // 
            this.mestaButton.Location = new System.Drawing.Point(135, 305);
            this.mestaButton.Name = "mestaButton";
            this.mestaButton.Size = new System.Drawing.Size(180, 180);
            this.mestaButton.TabIndex = 3;
            this.mestaButton.Text = "mesta";
            this.mestaButton.UseVisualStyleBackColor = true;
            // 
            // pomocButton
            // 
            this.pomocButton.Location = new System.Drawing.Point(405, 305);
            this.pomocButton.Name = "pomocButton";
            this.pomocButton.Size = new System.Drawing.Size(180, 180);
            this.pomocButton.TabIndex = 4;
            this.pomocButton.Text = "pomoc";
            this.pomocButton.UseVisualStyleBackColor = true;
            // 
            // lokacijeButton
            // 
            this.lokacijeButton.Location = new System.Drawing.Point(405, 575);
            this.lokacijeButton.Name = "lokacijeButton";
            this.lokacijeButton.Size = new System.Drawing.Size(180, 180);
            this.lokacijeButton.TabIndex = 5;
            this.lokacijeButton.Text = "lokacije";
            this.lokacijeButton.UseVisualStyleBackColor = true;
            // 
            // PocetniMeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 1041);
            this.Controls.Add(this.lokacijeButton);
            this.Controls.Add(this.pomocButton);
            this.Controls.Add(this.mestaButton);
            this.Controls.Add(this.igriceButton);
            this.Controls.Add(this.emergencyButton);
            this.Controls.Add(this.settingsButton);
            this.Name = "PocetniMeniForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button emergencyButton;
        private System.Windows.Forms.Button igriceButton;
        private System.Windows.Forms.Button mestaButton;
        private System.Windows.Forms.Button pomocButton;
        private System.Windows.Forms.Button lokacijeButton;
    }
}


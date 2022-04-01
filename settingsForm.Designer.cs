
namespace Hackathon_Project_GUI
{
    partial class settingsForm
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
            this.ugasiMuzikuButton = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            this.muzika1Button = new System.Windows.Forms.Button();
            this.muzika2button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ugasiMuzikuButton
            // 
            this.ugasiMuzikuButton.BackColor = System.Drawing.Color.LawnGreen;
            this.ugasiMuzikuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ugasiMuzikuButton.Location = new System.Drawing.Point(120, 40);
            this.ugasiMuzikuButton.Name = "ugasiMuzikuButton";
            this.ugasiMuzikuButton.Size = new System.Drawing.Size(119, 42);
            this.ugasiMuzikuButton.TabIndex = 0;
            this.ugasiMuzikuButton.Text = "Ugasi muziku";
            this.ugasiMuzikuButton.UseVisualStyleBackColor = false;
            this.ugasiMuzikuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(12, 298);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(75, 23);
            this.nazadButton.TabIndex = 1;
            this.nazadButton.Text = "nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // muzika1Button
            // 
            this.muzika1Button.Location = new System.Drawing.Point(120, 98);
            this.muzika1Button.Name = "muzika1Button";
            this.muzika1Button.Size = new System.Drawing.Size(119, 41);
            this.muzika1Button.TabIndex = 2;
            this.muzika1Button.Text = "muzika 1";
            this.muzika1Button.UseVisualStyleBackColor = true;
            this.muzika1Button.Click += new System.EventHandler(this.muzika1Button_Click);
            // 
            // muzika2button
            // 
            this.muzika2button.Location = new System.Drawing.Point(120, 154);
            this.muzika2button.Name = "muzika2button";
            this.muzika2button.Size = new System.Drawing.Size(119, 41);
            this.muzika2button.TabIndex = 3;
            this.muzika2button.Text = "muzika 2";
            this.muzika2button.UseVisualStyleBackColor = true;
            this.muzika2button.Click += new System.EventHandler(this.muzika2button_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 333);
            this.Controls.Add(this.muzika2button);
            this.Controls.Add(this.muzika1Button);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.ugasiMuzikuButton);
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ugasiMuzikuButton;
        private System.Windows.Forms.Button nazadButton;
        private System.Windows.Forms.Button muzika1Button;
        private System.Windows.Forms.Button muzika2button;
    }
}
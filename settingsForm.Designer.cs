
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
            this.SuspendLayout();
            // 
            // ugasiMuzikuButton
            // 
            this.ugasiMuzikuButton.Location = new System.Drawing.Point(114, 70);
            this.ugasiMuzikuButton.Name = "ugasiMuzikuButton";
            this.ugasiMuzikuButton.Size = new System.Drawing.Size(106, 37);
            this.ugasiMuzikuButton.TabIndex = 0;
            this.ugasiMuzikuButton.Text = "ugasi muziku";
            this.ugasiMuzikuButton.UseVisualStyleBackColor = true;
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
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 333);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.ugasiMuzikuButton);
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ugasiMuzikuButton;
        private System.Windows.Forms.Button nazadButton;
    }
}
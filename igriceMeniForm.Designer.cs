
namespace Hackathon_Project_GUI
{
    partial class igriceMeniForm
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
            this.igrica1Button = new System.Windows.Forms.Button();
            this.igrica2Button = new System.Windows.Forms.Button();
            this.igrica3Button = new System.Windows.Forms.Button();
            this.nazadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // igrica1Button
            // 
            this.igrica1Button.Location = new System.Drawing.Point(52, 287);
            this.igrica1Button.Name = "igrica1Button";
            this.igrica1Button.Size = new System.Drawing.Size(110, 43);
            this.igrica1Button.TabIndex = 0;
            this.igrica1Button.Text = "igrica 1";
            this.igrica1Button.UseVisualStyleBackColor = true;
            this.igrica1Button.Click += new System.EventHandler(this.igrica1Button_Click);
            // 
            // igrica2Button
            // 
            this.igrica2Button.Location = new System.Drawing.Point(294, 286);
            this.igrica2Button.Name = "igrica2Button";
            this.igrica2Button.Size = new System.Drawing.Size(109, 43);
            this.igrica2Button.TabIndex = 1;
            this.igrica2Button.Text = "igrica 2";
            this.igrica2Button.UseVisualStyleBackColor = true;
            this.igrica2Button.Click += new System.EventHandler(this.igrica2Button_Click);
            // 
            // igrica3Button
            // 
            this.igrica3Button.Location = new System.Drawing.Point(524, 288);
            this.igrica3Button.Name = "igrica3Button";
            this.igrica3Button.Size = new System.Drawing.Size(103, 42);
            this.igrica3Button.TabIndex = 2;
            this.igrica3Button.Text = "igrica 3";
            this.igrica3Button.UseVisualStyleBackColor = true;
            this.igrica3Button.Click += new System.EventHandler(this.igrica3Button_Click);
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(12, 479);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(75, 23);
            this.nazadButton.TabIndex = 3;
            this.nazadButton.Text = "nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.nazadButton_Click);
            // 
            // igriceMeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 540);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.igrica3Button);
            this.Controls.Add(this.igrica2Button);
            this.Controls.Add(this.igrica1Button);
            this.Name = "igriceMeniForm";
            this.Text = "igriceMeniForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button igrica1Button;
        private System.Windows.Forms.Button igrica2Button;
        private System.Windows.Forms.Button igrica3Button;
        private System.Windows.Forms.Button nazadButton;
    }
}
﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetniMeniForm));
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
            this.igriceButton.BackColor = System.Drawing.Color.Transparent;
            this.igriceButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("igriceButton.BackgroundImage")));
            this.igriceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.igriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.igriceButton.ForeColor = System.Drawing.Color.Transparent;
            this.igriceButton.Location = new System.Drawing.Point(147, 487);
            this.igriceButton.Name = "igriceButton";
            this.igriceButton.Size = new System.Drawing.Size(158, 135);
            this.igriceButton.TabIndex = 2;
            this.igriceButton.UseVisualStyleBackColor = false;
            this.igriceButton.Click += new System.EventHandler(this.igriceButton_Click);
            // 
            // mestaButton
            // 
            this.mestaButton.BackColor = System.Drawing.Color.Transparent;
            this.mestaButton.BackgroundImage = global::Hackathon_Project_GUI.Properties.Resources.mesta_dugme21;
            this.mestaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mestaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mestaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mestaButton.ForeColor = System.Drawing.Color.Transparent;
            this.mestaButton.Location = new System.Drawing.Point(119, 279);
            this.mestaButton.Name = "mestaButton";
            this.mestaButton.Size = new System.Drawing.Size(205, 135);
            this.mestaButton.TabIndex = 3;
            this.mestaButton.UseVisualStyleBackColor = false;
            this.mestaButton.Click += new System.EventHandler(this.mestaButton_Click);
            // 
            // pomocButton
            // 
            this.pomocButton.BackColor = System.Drawing.Color.Transparent;
            this.pomocButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pomocButton.BackgroundImage")));
            this.pomocButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pomocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pomocButton.ForeColor = System.Drawing.Color.Transparent;
            this.pomocButton.Location = new System.Drawing.Point(405, 279);
            this.pomocButton.Name = "pomocButton";
            this.pomocButton.Size = new System.Drawing.Size(158, 135);
            this.pomocButton.TabIndex = 4;
            this.pomocButton.UseVisualStyleBackColor = false;
            // 
            // lokacijeButton
            // 
            this.lokacijeButton.BackColor = System.Drawing.Color.Transparent;
            this.lokacijeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lokacijeButton.BackgroundImage")));
            this.lokacijeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lokacijeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lokacijeButton.Location = new System.Drawing.Point(405, 487);
            this.lokacijeButton.Name = "lokacijeButton";
            this.lokacijeButton.Size = new System.Drawing.Size(158, 135);
            this.lokacijeButton.TabIndex = 5;
            this.lokacijeButton.UseVisualStyleBackColor = false;
            this.lokacijeButton.Click += new System.EventHandler(this.lokacijeButton_Click);
            // 
            // PocetniMeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 681);
            this.Controls.Add(this.lokacijeButton);
            this.Controls.Add(this.pomocButton);
            this.Controls.Add(this.mestaButton);
            this.Controls.Add(this.igriceButton);
            this.Controls.Add(this.emergencyButton);
            this.Controls.Add(this.settingsButton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "PocetniMeniForm";
            this.Text = " ";
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



namespace Hackathon_Project_GUI
{
    partial class igrica1Form
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
            this.objekat = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.objekat2 = new System.Windows.Forms.PictureBox();
            this.objekat3 = new System.Windows.Forms.PictureBox();
            this.objekat4 = new System.Windows.Forms.PictureBox();
            this.objekat5 = new System.Windows.Forms.PictureBox();
            this.objekat6 = new System.Windows.Forms.PictureBox();
            this.objekat7 = new System.Windows.Forms.PictureBox();
            this.objekat8 = new System.Windows.Forms.PictureBox();
            this.objekat9 = new System.Windows.Forms.PictureBox();
            this.objekat10 = new System.Windows.Forms.PictureBox();
            this.objekat11 = new System.Windows.Forms.PictureBox();
            this.objekat12 = new System.Windows.Forms.PictureBox();
            this.nazadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objekat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat12)).BeginInit();
            this.SuspendLayout();
            // 
            // objekat
            // 
            this.objekat.BackColor = System.Drawing.Color.Red;
            this.objekat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.objekat.Location = new System.Drawing.Point(440, 106);
            this.objekat.Name = "objekat";
            this.objekat.Size = new System.Drawing.Size(95, 49);
            this.objekat.TabIndex = 0;
            this.objekat.TabStop = false;
            this.objekat.Tag = "objekat";
            this.objekat.UseWaitCursor = true;
            this.objekat.Click += new System.EventHandler(this.objekat_Click);
            this.objekat.MouseLeave += new System.EventHandler(this.progres1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(1, 356);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 240);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.progres3);
            this.pictureBox2.DragLeave += new System.EventHandler(this.progres1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox3.Location = new System.Drawing.Point(306, 356);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(305, 240);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.DragLeave += new System.EventHandler(this.progres2);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox4.Location = new System.Drawing.Point(605, 356);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(305, 240);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DragOver += new System.Windows.Forms.DragEventHandler(this.progres3);
            this.pictureBox4.DragLeave += new System.EventHandler(this.progres3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Proveri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // objekat2
            // 
            this.objekat2.BackColor = System.Drawing.Color.Red;
            this.objekat2.Location = new System.Drawing.Point(174, 267);
            this.objekat2.Name = "objekat2";
            this.objekat2.Size = new System.Drawing.Size(95, 49);
            this.objekat2.TabIndex = 6;
            this.objekat2.TabStop = false;
            this.objekat2.Tag = "objekat";
            this.objekat2.UseWaitCursor = true;
            this.objekat2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KRETANJE);
            this.objekat2.MouseLeave += new System.EventHandler(this.progres1);
            // 
            // objekat3
            // 
            this.objekat3.BackColor = System.Drawing.Color.Red;
            this.objekat3.Location = new System.Drawing.Point(109, 292);
            this.objekat3.Name = "objekat3";
            this.objekat3.Size = new System.Drawing.Size(95, 49);
            this.objekat3.TabIndex = 7;
            this.objekat3.TabStop = false;
            this.objekat3.UseWaitCursor = true;
            this.objekat3.MouseLeave += new System.EventHandler(this.progres1);
            // 
            // objekat4
            // 
            this.objekat4.BackColor = System.Drawing.Color.Red;
            this.objekat4.Location = new System.Drawing.Point(256, 56);
            this.objekat4.Name = "objekat4";
            this.objekat4.Size = new System.Drawing.Size(95, 49);
            this.objekat4.TabIndex = 8;
            this.objekat4.TabStop = false;
            this.objekat4.UseWaitCursor = true;
            this.objekat4.MouseLeave += new System.EventHandler(this.progres1);
            // 
            // objekat5
            // 
            this.objekat5.BackColor = System.Drawing.Color.Yellow;
            this.objekat5.Location = new System.Drawing.Point(592, 216);
            this.objekat5.Name = "objekat5";
            this.objekat5.Size = new System.Drawing.Size(95, 49);
            this.objekat5.TabIndex = 9;
            this.objekat5.TabStop = false;
            this.objekat5.UseWaitCursor = true;
            this.objekat5.MouseLeave += new System.EventHandler(this.progres2);
            // 
            // objekat6
            // 
            this.objekat6.BackColor = System.Drawing.Color.Yellow;
            this.objekat6.Location = new System.Drawing.Point(654, 143);
            this.objekat6.Name = "objekat6";
            this.objekat6.Size = new System.Drawing.Size(95, 49);
            this.objekat6.TabIndex = 10;
            this.objekat6.TabStop = false;
            this.objekat6.UseWaitCursor = true;
            this.objekat6.MouseLeave += new System.EventHandler(this.progres2);
            // 
            // objekat7
            // 
            this.objekat7.BackColor = System.Drawing.Color.Yellow;
            this.objekat7.Location = new System.Drawing.Point(238, 204);
            this.objekat7.Name = "objekat7";
            this.objekat7.Size = new System.Drawing.Size(95, 49);
            this.objekat7.TabIndex = 11;
            this.objekat7.TabStop = false;
            this.objekat7.UseWaitCursor = true;
            this.objekat7.MouseLeave += new System.EventHandler(this.progres2);
            // 
            // objekat8
            // 
            this.objekat8.BackColor = System.Drawing.Color.Yellow;
            this.objekat8.Location = new System.Drawing.Point(564, 88);
            this.objekat8.Name = "objekat8";
            this.objekat8.Size = new System.Drawing.Size(95, 49);
            this.objekat8.TabIndex = 12;
            this.objekat8.TabStop = false;
            this.objekat8.UseWaitCursor = true;
            this.objekat8.MouseLeave += new System.EventHandler(this.progres2);
            // 
            // objekat9
            // 
            this.objekat9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.objekat9.Location = new System.Drawing.Point(303, 125);
            this.objekat9.Name = "objekat9";
            this.objekat9.Size = new System.Drawing.Size(95, 49);
            this.objekat9.TabIndex = 13;
            this.objekat9.TabStop = false;
            this.objekat9.UseWaitCursor = true;
            // 
            // objekat10
            // 
            this.objekat10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.objekat10.Location = new System.Drawing.Point(158, 125);
            this.objekat10.Name = "objekat10";
            this.objekat10.Size = new System.Drawing.Size(95, 49);
            this.objekat10.TabIndex = 14;
            this.objekat10.TabStop = false;
            this.objekat10.UseWaitCursor = true;
            this.objekat10.Click += new System.EventHandler(this.objekat10_Click);
            this.objekat10.MouseLeave += new System.EventHandler(this.progres3);
            // 
            // objekat11
            // 
            this.objekat11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.objekat11.Location = new System.Drawing.Point(63, 180);
            this.objekat11.Name = "objekat11";
            this.objekat11.Size = new System.Drawing.Size(95, 49);
            this.objekat11.TabIndex = 15;
            this.objekat11.TabStop = false;
            this.objekat11.UseWaitCursor = true;
            this.objekat11.MouseLeave += new System.EventHandler(this.progres3);
            // 
            // objekat12
            // 
            this.objekat12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.objekat12.Location = new System.Drawing.Point(664, 125);
            this.objekat12.Name = "objekat12";
            this.objekat12.Size = new System.Drawing.Size(95, 49);
            this.objekat12.TabIndex = 16;
            this.objekat12.TabStop = false;
            this.objekat12.UseWaitCursor = true;
            this.objekat12.MouseLeave += new System.EventHandler(this.progres3);
            // 
            // nazadButton
            // 
            this.nazadButton.Location = new System.Drawing.Point(10, 10);
            this.nazadButton.Name = "nazadButton";
            this.nazadButton.Size = new System.Drawing.Size(75, 23);
            this.nazadButton.TabIndex = 17;
            this.nazadButton.Text = "Nazad";
            this.nazadButton.UseVisualStyleBackColor = true;
            this.nazadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // igrica1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 635);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nazadButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.objekat12);
            this.Controls.Add(this.objekat11);
            this.Controls.Add(this.objekat10);
            this.Controls.Add(this.objekat9);
            this.Controls.Add(this.objekat8);
            this.Controls.Add(this.objekat7);
            this.Controls.Add(this.objekat6);
            this.Controls.Add(this.objekat5);
            this.Controls.Add(this.objekat4);
            this.Controls.Add(this.objekat3);
            this.Controls.Add(this.objekat2);
            this.Controls.Add(this.objekat);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "igrica1Form";
            this.Text = "Igrica1Form";
            ((System.ComponentModel.ISupportInitialize)(this.objekat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objekat12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox objekat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progres;
        private System.Windows.Forms.PictureBox objekat2;
        private System.Windows.Forms.PictureBox objekat3;
        private System.Windows.Forms.PictureBox objekat4;
        private System.Windows.Forms.PictureBox objekat5;
        private System.Windows.Forms.PictureBox objekat6;
        private System.Windows.Forms.PictureBox objekat7;
        private System.Windows.Forms.PictureBox objekat8;
        private System.Windows.Forms.PictureBox objekat9;
        private System.Windows.Forms.PictureBox objekat10;
        private System.Windows.Forms.PictureBox objekat11;
        private System.Windows.Forms.PictureBox objekat12;
        private System.Windows.Forms.Button nazadButton;
    }
}

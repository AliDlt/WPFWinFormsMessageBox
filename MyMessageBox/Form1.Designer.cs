namespace MyMessageBox
{
    partial class Messagebox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnyes = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.picicon = new System.Windows.Forms.PictureBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 256);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.panel2.Location = new System.Drawing.Point(516, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 261);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.panel3.Location = new System.Drawing.Point(-1, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 12);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(61)))), ((int)(((byte)(153)))));
            this.panel4.Location = new System.Drawing.Point(-1, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 15);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(103)))), ((int)(((byte)(148)))));
            this.panel5.Controls.Add(this.btnyes);
            this.panel5.Controls.Add(this.btnok);
            this.panel5.Controls.Add(this.btnno);
            this.panel5.Controls.Add(this.btncancel);
            this.panel5.Location = new System.Drawing.Point(12, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 54);
            this.panel5.TabIndex = 4;
            // 
            // btnyes
            // 
            this.btnyes.BackColor = System.Drawing.SystemColors.Info;
            this.btnyes.FlatAppearance.BorderSize = 0;
            this.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnyes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnyes.Image = global::MyMessageBox.Properties.Resources.ButtonOK;
            this.btnyes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnyes.Location = new System.Drawing.Point(144, 13);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(90, 27);
            this.btnyes.TabIndex = 12;
            this.btnyes.Text = "بله";
            this.btnyes.UseVisualStyleBackColor = false;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.SystemColors.Info;
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnok.Image = global::MyMessageBox.Properties.Resources.ButtonOK;
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnok.Location = new System.Drawing.Point(144, 13);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(90, 27);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "تایید";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.SystemColors.Info;
            this.btnno.FlatAppearance.BorderSize = 0;
            this.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnno.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnno.Image = global::MyMessageBox.Properties.Resources.ButtonCancel;
            this.btnno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnno.Location = new System.Drawing.Point(300, 13);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(90, 27);
            this.btnno.TabIndex = 11;
            this.btnno.Text = "خیر";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.Info;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btncancel.Image = global::MyMessageBox.Properties.Resources.ButtonCancel;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.Location = new System.Drawing.Point(300, 13);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 27);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "انصراف";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.panel7.Controls.Add(this.lbltitle);
            this.panel7.Location = new System.Drawing.Point(2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(521, 35);
            this.panel7.TabIndex = 8;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbltitle.Location = new System.Drawing.Point(212, 7);
            this.lbltitle.MinimumSize = new System.Drawing.Size(100, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(100, 21);
            this.lbltitle.TabIndex = 11;
            this.lbltitle.Text = "پیام";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picicon
            // 
            this.picicon.Location = new System.Drawing.Point(15, 69);
            this.picicon.Name = "picicon";
            this.picicon.Size = new System.Drawing.Size(101, 98);
            this.picicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picicon.TabIndex = 9;
            this.picicon.TabStop = false;
            // 
            // lblmsg
            // 
            this.lblmsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblmsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblmsg.Location = new System.Drawing.Point(119, 48);
            this.lblmsg.MinimumSize = new System.Drawing.Size(212, 5);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(391, 139);
            this.lblmsg.TabIndex = 10;
            this.lblmsg.Text = "سلام";
            this.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Messagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(524, 256);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.picicon);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messagebox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picicon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox picicon;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btncancel;
    }
}


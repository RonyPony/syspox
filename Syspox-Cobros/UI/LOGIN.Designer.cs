namespace Syspox_Cobros.UI
{
    partial class LOGIN
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.boton1 = new Syspox_Cobros.controls.boton();
            this.boton2 = new Syspox_Cobros.controls.boton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.LinkLabel();
            this.srv = new System.Windows.Forms.GroupBox();
            this.boton3 = new Syspox_Cobros.controls.boton();
            this.TXTSERVER = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.srv.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(481, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(481, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "CLAVE";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(621, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 30);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Green;
            this.textBox2.Location = new System.Drawing.Point(621, 312);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '▬';
            this.textBox2.Size = new System.Drawing.Size(238, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // boton1
            // 
            this.boton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton1.BackColor = System.Drawing.Color.Green;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.White;
            this.boton1.Location = new System.Drawing.Point(511, 388);
            this.boton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(158, 50);
            this.boton1.TabIndex = 5;
            this.boton1.Text = "ENTRAR";
            this.boton1.texto = "ENTRAR";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            this.boton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boton1_MouseClick);
            // 
            // boton2
            // 
            this.boton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton2.BackColor = System.Drawing.Color.Green;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.White;
            this.boton2.Location = new System.Drawing.Point(681, 388);
            this.boton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(133, 51);
            this.boton2.TabIndex = 6;
            this.boton2.Text = "SALIR";
            this.boton2.texto = "SALIR";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            this.boton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boton2_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Syspox_Cobros.Properties.Resources.Group_19;
            this.pictureBox2.Location = new System.Drawing.Point(166, 247);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 191);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU-ExtB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(682, 80);
            this.label5.TabIndex = 8;
            this.label5.Text = "SYSPOX SYSTEMS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 29);
            this.label6.TabIndex = 9;
            this.label6.TabStop = true;
            this.label6.Text = "PRODUCT INFO";
            this.label6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label6_LinkClicked);
            // 
            // srv
            // 
            this.srv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.srv.Controls.Add(this.boton3);
            this.srv.Controls.Add(this.TXTSERVER);
            this.srv.ForeColor = System.Drawing.Color.White;
            this.srv.Location = new System.Drawing.Point(166, 489);
            this.srv.Name = "srv";
            this.srv.Size = new System.Drawing.Size(724, 100);
            this.srv.TabIndex = 10;
            this.srv.TabStop = false;
            this.srv.Text = "SERVER";
            this.srv.Visible = false;
            // 
            // boton3
            // 
            this.boton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton3.BackColor = System.Drawing.Color.Green;
            this.boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.ForeColor = System.Drawing.Color.White;
            this.boton3.Location = new System.Drawing.Point(526, 33);
            this.boton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(158, 50);
            this.boton3.TabIndex = 6;
            this.boton3.Text = "APLICAR";
            this.boton3.texto = "APLICAR";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // TXTSERVER
            // 
            this.TXTSERVER.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXTSERVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSERVER.ForeColor = System.Drawing.Color.Green;
            this.TXTSERVER.Location = new System.Drawing.Point(28, 44);
            this.TXTSERVER.Name = "TXTSERVER";
            this.TXTSERVER.Size = new System.Drawing.Size(475, 30);
            this.TXTSERVER.TabIndex = 4;
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 639);
            this.Controls.Add(this.srv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.boton1, 0);
            this.Controls.SetChildIndex(this.boton2, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.srv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.srv.ResumeLayout(false);
            this.srv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private controls.boton boton1;
        private controls.boton boton2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel label6;
        private System.Windows.Forms.GroupBox srv;
        private controls.boton boton3;
        private System.Windows.Forms.TextBox TXTSERVER;
    }
}
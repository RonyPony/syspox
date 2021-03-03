namespace Syspox_Cobros.UI
{
    partial class nuevopago
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
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.ComboBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblmonto = new System.Windows.Forms.Label();
            this.boton1 = new Syspox_Cobros.controls.boton();
            this.boton2 = new Syspox_Cobros.controls.boton();
            this.boton3 = new Syspox_Cobros.controls.boton();
            this.lbldireccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "CEDULA";
            // 
            // txtcedula
            // 
            this.txtcedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.ForeColor = System.Drawing.Color.Green;
            this.txtcedula.Location = new System.Drawing.Point(234, 98);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(188, 30);
            this.txtcedula.TabIndex = 2;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Green;
            this.txtnombre.Location = new System.Drawing.Point(234, 143);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(188, 30);
            this.txtnombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOMBRE";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 58);
            this.label5.TabIndex = 5;
            this.label5.Text = "CORRESP.\r\nAL MES";
            // 
            // txtmonto
            // 
            this.txtmonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonto.ForeColor = System.Drawing.Color.Green;
            this.txtmonto.Location = new System.Drawing.Point(234, 268);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(188, 30);
            this.txtmonto.TabIndex = 8;
            this.txtmonto.TextChanged += new System.EventHandler(this.txtmonto_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(93, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "MONTO";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Green;
            this.txtdireccion.Location = new System.Drawing.Point(254, 323);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(188, 30);
            this.txtdireccion.TabIndex = 10;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "DIRECCION";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(97, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 58);
            this.label8.TabIndex = 11;
            this.label8.Text = "FECHA\r\nDEL PAGO";
            // 
            // txtmes
            // 
            this.txtmes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtmes.ForeColor = System.Drawing.Color.Green;
            this.txtmes.FormattingEnabled = true;
            this.txtmes.Location = new System.Drawing.Point(234, 206);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(194, 33);
            this.txtmes.TabIndex = 13;
            // 
            // txtfecha
            // 
            this.txtfecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfecha.CalendarForeColor = System.Drawing.Color.Green;
            this.txtfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfecha.Location = new System.Drawing.Point(258, 447);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(345, 30);
            this.txtfecha.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Syspox_Cobros.Properties.Resources.payments_24px;
            this.pictureBox2.Location = new System.Drawing.Point(479, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblmonto
            // 
            this.lblmonto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmonto.AutoSize = true;
            this.lblmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonto.ForeColor = System.Drawing.Color.White;
            this.lblmonto.Location = new System.Drawing.Point(428, 268);
            this.lblmonto.Name = "lblmonto";
            this.lblmonto.Size = new System.Drawing.Size(193, 29);
            this.lblmonto.TabIndex = 18;
            this.lblmonto.Text = "RESTANTE: 00";
            // 
            // boton1
            // 
            this.boton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton1.BackColor = System.Drawing.Color.Green;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.White;
            this.boton1.Location = new System.Drawing.Point(127, 529);
            this.boton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(170, 51);
            this.boton1.TabIndex = 19;
            this.boton1.Text = "GUARDAR";
            this.boton1.texto = "GUARDAR";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click_1);
            // 
            // boton2
            // 
            this.boton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton2.BackColor = System.Drawing.Color.Green;
            this.boton2.FlatAppearance.BorderSize = 0;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.White;
            this.boton2.Location = new System.Drawing.Point(349, 529);
            this.boton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(172, 51);
            this.boton2.TabIndex = 20;
            this.boton2.Text = "CANCELAR";
            this.boton2.texto = "CANCELAR";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton3.BackColor = System.Drawing.Color.Green;
            this.boton3.Enabled = false;
            this.boton3.FlatAppearance.BorderSize = 0;
            this.boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.boton3.ForeColor = System.Drawing.Color.White;
            this.boton3.Location = new System.Drawing.Point(451, 326);
            this.boton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(139, 30);
            this.boton3.TabIndex = 39;
            this.boton3.Text = "SELECCIONAR";
            this.boton3.texto = "SELECCIONAR";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // lbldireccion
            // 
            this.lbldireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(97, 383);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(130, 29);
            this.lbldireccion.TabIndex = 41;
            this.lbldireccion.Text = "-------------";
            // 
            // nuevopago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 606);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.lblmonto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "nuevopago";
            this.Text = "nuevopago";
            this.Load += new System.EventHandler(this.nuevopago_Load);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtcedula, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtmonto, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.txtmes, 0);
            this.Controls.SetChildIndex(this.txtfecha, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.lblmonto, 0);
            this.Controls.SetChildIndex(this.boton1, 0);
            this.Controls.SetChildIndex(this.boton2, 0);
            this.Controls.SetChildIndex(this.boton3, 0);
            this.Controls.SetChildIndex(this.lbldireccion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox txtmes;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblmonto;
        private controls.boton boton1;
        private controls.boton boton2;
        private controls.boton boton3;
        private System.Windows.Forms.Label lbldireccion;
    }
}
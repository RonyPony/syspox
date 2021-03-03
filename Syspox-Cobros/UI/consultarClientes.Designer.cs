namespace Syspox_Cobros.UI
{
    partial class consultarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boton2 = new Syspox_Cobros.controls.boton();
            this.boton1 = new Syspox_Cobros.controls.boton();
            this.boton3 = new Syspox_Cobros.controls.boton();
            this.boton4 = new Syspox_Cobros.controls.boton();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.boton5 = new Syspox_Cobros.controls.boton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(776, 343);
            this.dataGridView1.TabIndex = 23;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.Green;
            this.txtdireccion.Location = new System.Drawing.Point(245, 163);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(188, 30);
            this.txtdireccion.TabIndex = 22;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "DIRECCION";
            // 
            // txtnombre
            // 
            this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.Green;
            this.txtnombre.Location = new System.Drawing.Point(225, 116);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(188, 30);
            this.txtnombre.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "NOMBRE";
            // 
            // txtcedula
            // 
            this.txtcedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcedula.ForeColor = System.Drawing.Color.Green;
            this.txtcedula.Location = new System.Drawing.Point(225, 71);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(188, 30);
            this.txtcedula.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "CEDULA";
            // 
            // boton2
            // 
            this.boton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton2.BackColor = System.Drawing.Color.Green;
            this.boton2.FlatAppearance.BorderSize = 0;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.White;
            this.boton2.Location = new System.Drawing.Point(603, 94);
            this.boton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(151, 51);
            this.boton2.TabIndex = 14;
            this.boton2.Text = "BUSCAR";
            this.boton2.texto = "BUSCAR";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton1
            // 
            this.boton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton1.BackColor = System.Drawing.Color.Green;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.ForeColor = System.Drawing.Color.White;
            this.boton1.Location = new System.Drawing.Point(305, 656);
            this.boton1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(159, 51);
            this.boton1.TabIndex = 24;
            this.boton1.Text = "CERRAR";
            this.boton1.texto = "CERRAR";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton3
            // 
            this.boton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton3.BackColor = System.Drawing.Color.Green;
            this.boton3.FlatAppearance.BorderSize = 0;
            this.boton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.boton3.ForeColor = System.Drawing.Color.White;
            this.boton3.Location = new System.Drawing.Point(442, 163);
            this.boton3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(139, 30);
            this.boton3.TabIndex = 40;
            this.boton3.Text = "SELECCIONAR";
            this.boton3.texto = "SELECCIONAR";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton4
            // 
            this.boton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton4.BackColor = System.Drawing.Color.Green;
            this.boton4.FlatAppearance.BorderSize = 0;
            this.boton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.boton4.ForeColor = System.Drawing.Color.White;
            this.boton4.Location = new System.Drawing.Point(615, 596);
            this.boton4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(139, 30);
            this.boton4.TabIndex = 41;
            this.boton4.Text = "MODIFICAR";
            this.boton4.texto = "MODIFICAR";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // lbldireccion
            // 
            this.lbldireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.ForeColor = System.Drawing.Color.White;
            this.lbldireccion.Location = new System.Drawing.Point(84, 204);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(130, 29);
            this.lbldireccion.TabIndex = 42;
            this.lbldireccion.Text = "-------------";
            // 
            // boton5
            // 
            this.boton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boton5.BackColor = System.Drawing.Color.Green;
            this.boton5.FlatAppearance.BorderSize = 0;
            this.boton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.boton5.ForeColor = System.Drawing.Color.White;
            this.boton5.Location = new System.Drawing.Point(422, 74);
            this.boton5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(139, 30);
            this.boton5.TabIndex = 43;
            this.boton5.Text = "SELECCIONAR";
            this.boton5.texto = "SELECCIONAR";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // consultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boton2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "consultarClientes";
            this.Text = "consultarClientes";
            this.Load += new System.EventHandler(this.consultarClientes_Load);
            this.Controls.SetChildIndex(this.boton2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtcedula, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.boton1, 0);
            this.Controls.SetChildIndex(this.boton3, 0);
            this.Controls.SetChildIndex(this.boton4, 0);
            this.Controls.SetChildIndex(this.lbldireccion, 0);
            this.Controls.SetChildIndex(this.boton5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label3;
        private controls.boton boton2;
        private controls.boton boton1;
        private controls.boton boton3;
        private controls.boton boton4;
        private System.Windows.Forms.Label lbldireccion;
        private controls.boton boton5;
    }
}
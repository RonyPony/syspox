namespace Syspox_Cobros.UI
{
    partial class settings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.boton2 = new Syspox_Cobros.controls.boton();
            this.txtpagoscedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtpagoscedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GENERAL";
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.Green;
            this.boton2.FlatAppearance.BorderSize = 0;
            this.boton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.ForeColor = System.Drawing.Color.White;
            this.boton2.Location = new System.Drawing.Point(186, 436);
            this.boton2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(443, 51);
            this.boton2.TabIndex = 2;
            this.boton2.Text = "IMPRIMIR PAGO DE UN CLIENTE";
            this.boton2.texto = "IMPRIMIR PAGO DE UN CLIENTE";
            this.boton2.UseVisualStyleBackColor = false;
            // 
            // txtpagoscedula
            // 
            this.txtpagoscedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagoscedula.ForeColor = System.Drawing.Color.Green;
            this.txtpagoscedula.Location = new System.Drawing.Point(38, 75);
            this.txtpagoscedula.Name = "txtpagoscedula";
            this.txtpagoscedula.Size = new System.Drawing.Size(303, 30);
            this.txtpagoscedula.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "NOMBRE DEL NEGOCIO";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boton2);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private controls.boton boton2;
        private System.Windows.Forms.TextBox txtpagoscedula;
        private System.Windows.Forms.Label label3;
    }
}
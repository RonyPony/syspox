namespace Syspox_Cobros.controls
{
    partial class boton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // boton
            // 
            this.BackColor = System.Drawing.Color.Green;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Size = new System.Drawing.Size(115, 51);
            this.UseVisualStyleBackColor = false;
            this.Click += new System.EventHandler(this.boton_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.boton_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boton_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.boton_MouseUp);
            
            this.ResumeLayout(false);

        }

        #endregion
    }
}

namespace Ovelar_Primer_Parcial
{
    partial class FormProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesor));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMicuenta = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido, Profesor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMicuenta
            // 
            this.btnMicuenta.Location = new System.Drawing.Point(32, 350);
            this.btnMicuenta.Name = "btnMicuenta";
            this.btnMicuenta.Size = new System.Drawing.Size(87, 23);
            this.btnMicuenta.TabIndex = 4;
            this.btnMicuenta.Text = "Mi Cuenta";
            this.btnMicuenta.UseVisualStyleBackColor = true;
            this.btnMicuenta.Click += new System.EventHandler(this.btnMicuenta_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(555, 350);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(93, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 385);
            this.Controls.Add(this.btnMicuenta);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.label1);
            this.Name = "FormProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfesor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProfesor_FormClosing);
            this.Load += new System.EventHandler(this.FormProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMicuenta;
        private Button btnCerrarSesion;
    }
}
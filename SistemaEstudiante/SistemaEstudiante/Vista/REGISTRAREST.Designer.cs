namespace SistemaEstudiante.Vista
{
    partial class REGISTRAREST
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblNombreEstu = new System.Windows.Forms.Label();
            this.txtNombreEstu = new System.Windows.Forms.TextBox();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.txtContraEstu = new System.Windows.Forms.TextBox();
            this.lblContraEst = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(506, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblNombreEstu
            // 
            this.lblNombreEstu.AutoSize = true;
            this.lblNombreEstu.Location = new System.Drawing.Point(42, 77);
            this.lblNombreEstu.Name = "lblNombreEstu";
            this.lblNombreEstu.Size = new System.Drawing.Size(91, 14);
            this.lblNombreEstu.TabIndex = 1;
            this.lblNombreEstu.Text = "Nombre Completo";
            // 
            // txtNombreEstu
            // 
            this.txtNombreEstu.Location = new System.Drawing.Point(45, 95);
            this.txtNombreEstu.Name = "txtNombreEstu";
            this.txtNombreEstu.Size = new System.Drawing.Size(235, 21);
            this.txtNombreEstu.TabIndex = 2;
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(45, 162);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(235, 21);
            this.txtNombreU.TabIndex = 4;
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(42, 145);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(100, 14);
            this.lblNombreU.TabIndex = 3;
            this.lblNombreU.Text = "Nombre de Usuario";
            // 
            // txtContraEstu
            // 
            this.txtContraEstu.Location = new System.Drawing.Point(45, 230);
            this.txtContraEstu.Name = "txtContraEstu";
            this.txtContraEstu.Size = new System.Drawing.Size(235, 21);
            this.txtContraEstu.TabIndex = 6;
            // 
            // lblContraEst
            // 
            this.lblContraEst.AutoSize = true;
            this.lblContraEst.Location = new System.Drawing.Point(42, 213);
            this.lblContraEst.Name = "lblContraEst";
            this.lblContraEst.Size = new System.Drawing.Size(128, 14);
            this.lblContraEst.TabIndex = 5;
            this.lblContraEst.Text = "Contraseña de Estudiante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "INGRESAR ESTUDIANTE";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(399, 93);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(399, 190);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "NUEVO";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // REGISTRAREST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 289);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraEstu);
            this.Controls.Add(this.lblContraEst);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.txtNombreEstu);
            this.Controls.Add(this.lblNombreEstu);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Perpetua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REGISTRAREST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRAREST";
            this.Load += new System.EventHandler(this.REGISTRAREST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblNombreEstu;
        private System.Windows.Forms.TextBox txtNombreEstu;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.TextBox txtContraEstu;
        private System.Windows.Forms.Label lblContraEst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
namespace SistemaEstudiante.Vista
{
    partial class VERESTUDIANTE
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
            this.dtvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtContraEstu = new System.Windows.Forms.TextBox();
            this.lblContraEst = new System.Windows.Forms.Label();
            this.txtNombreU = new System.Windows.Forms.TextBox();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.txtNombreEstu = new System.Windows.Forms.TextBox();
            this.lblNombreEstu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Perpetua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(563, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(36, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Menu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dtvUsuarios
            // 
            this.dtvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvUsuarios.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUsuarios.Location = new System.Drawing.Point(12, 107);
            this.dtvUsuarios.Name = "dtvUsuarios";
            this.dtvUsuarios.Size = new System.Drawing.Size(588, 217);
            this.dtvUsuarios.TabIndex = 15;
            this.dtvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvUsuarios_CellClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(487, 77);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 23);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtContraEstu
            // 
            this.txtContraEstu.Location = new System.Drawing.Point(378, 31);
            this.txtContraEstu.Name = "txtContraEstu";
            this.txtContraEstu.Size = new System.Drawing.Size(131, 21);
            this.txtContraEstu.TabIndex = 31;
            // 
            // lblContraEst
            // 
            this.lblContraEst.AutoSize = true;
            this.lblContraEst.Location = new System.Drawing.Point(375, 13);
            this.lblContraEst.Name = "lblContraEst";
            this.lblContraEst.Size = new System.Drawing.Size(128, 14);
            this.lblContraEst.TabIndex = 30;
            this.lblContraEst.Text = "Contraseña de Estudiante";
            // 
            // txtNombreU
            // 
            this.txtNombreU.Location = new System.Drawing.Point(233, 30);
            this.txtNombreU.Name = "txtNombreU";
            this.txtNombreU.Size = new System.Drawing.Size(123, 21);
            this.txtNombreU.TabIndex = 29;
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(230, 13);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(100, 14);
            this.lblNombreU.TabIndex = 28;
            this.lblNombreU.Text = "Nombre de Usuario";
            // 
            // txtNombreEstu
            // 
            this.txtNombreEstu.Location = new System.Drawing.Point(22, 31);
            this.txtNombreEstu.Name = "txtNombreEstu";
            this.txtNombreEstu.Size = new System.Drawing.Size(191, 21);
            this.txtNombreEstu.TabIndex = 27;
            // 
            // lblNombreEstu
            // 
            this.lblNombreEstu.AutoSize = true;
            this.lblNombreEstu.Location = new System.Drawing.Point(19, 13);
            this.lblNombreEstu.Name = "lblNombreEstu";
            this.lblNombreEstu.Size = new System.Drawing.Size(91, 14);
            this.lblNombreEstu.TabIndex = 26;
            this.lblNombreEstu.Text = "Nombre Completo";
            // 
            // VERESTUDIANTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 338);
            this.Controls.Add(this.txtContraEstu);
            this.Controls.Add(this.lblContraEst);
            this.Controls.Add(this.txtNombreU);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.txtNombreEstu);
            this.Controls.Add(this.lblNombreEstu);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dtvUsuarios);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Perpetua", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VERESTUDIANTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VERESTUDIANTE";
            this.Load += new System.EventHandler(this.VERESTUDIANTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dtvUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtContraEstu;
        private System.Windows.Forms.Label lblContraEst;
        private System.Windows.Forms.TextBox txtNombreU;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.TextBox txtNombreEstu;
        private System.Windows.Forms.Label lblNombreEstu;
    }
}
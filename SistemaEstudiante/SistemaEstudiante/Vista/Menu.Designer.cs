namespace SistemaEstudiante.Vista
{
    partial class Menu
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.registrarEstudianteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(430, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEstudiantesToolStripMenuItem,
            this.ingresarNotaToolStripMenuItem,
            this.ingresarMateriaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // verEstudiantesToolStripMenuItem
            // 
            this.verEstudiantesToolStripMenuItem.Name = "verEstudiantesToolStripMenuItem";
            this.verEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verEstudiantesToolStripMenuItem.Text = "Ver Estudiantes";
            this.verEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.verEstudiantesToolStripMenuItem_Click);
            // 
            // ingresarNotaToolStripMenuItem
            // 
            this.ingresarNotaToolStripMenuItem.Name = "ingresarNotaToolStripMenuItem";
            this.ingresarNotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarNotaToolStripMenuItem.Text = "Ingresar Nota";
            this.ingresarNotaToolStripMenuItem.Click += new System.EventHandler(this.ingresarNotaToolStripMenuItem_Click);
            // 
            // ingresarMateriaToolStripMenuItem
            // 
            this.ingresarMateriaToolStripMenuItem.Name = "ingresarMateriaToolStripMenuItem";
            this.ingresarMateriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresarMateriaToolStripMenuItem.Text = "Ingresar Materia";
            this.ingresarMateriaToolStripMenuItem.Click += new System.EventHandler(this.ingresarMateriaToolStripMenuItem_Click);
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.registrarEstudianteToolStripMenuItem.Text = "Registrar Estudiante";
            this.registrarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.registrarEstudianteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDO";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarMateriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstudiantesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}
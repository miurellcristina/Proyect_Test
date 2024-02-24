namespace Proyect_Test
{
    partial class menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_A_alumnos = new System.Windows.Forms.Button();
            this.BT_A_materias = new System.Windows.Forms.Button();
            this.BT_A_maestros = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // BT_A_alumnos
            // 
            this.BT_A_alumnos.Location = new System.Drawing.Point(505, 384);
            this.BT_A_alumnos.Name = "BT_A_alumnos";
            this.BT_A_alumnos.Size = new System.Drawing.Size(255, 64);
            this.BT_A_alumnos.TabIndex = 1;
            this.BT_A_alumnos.Text = "Alumnos";
            this.BT_A_alumnos.UseVisualStyleBackColor = true;
            this.BT_A_alumnos.Click += new System.EventHandler(this.BT_A_alumnos_Click);
            // 
            // BT_A_materias
            // 
            this.BT_A_materias.Location = new System.Drawing.Point(866, 384);
            this.BT_A_materias.Name = "BT_A_materias";
            this.BT_A_materias.Size = new System.Drawing.Size(255, 64);
            this.BT_A_materias.TabIndex = 2;
            this.BT_A_materias.Text = "Materias";
            this.BT_A_materias.UseVisualStyleBackColor = true;
            this.BT_A_materias.Click += new System.EventHandler(this.BT_A_materias_Click);
            // 
            // BT_A_maestros
            // 
            this.BT_A_maestros.Location = new System.Drawing.Point(101, 384);
            this.BT_A_maestros.Name = "BT_A_maestros";
            this.BT_A_maestros.Size = new System.Drawing.Size(255, 64);
            this.BT_A_maestros.TabIndex = 4;
            this.BT_A_maestros.Text = "Maestros";
            this.BT_A_maestros.UseVisualStyleBackColor = true;
            this.BT_A_maestros.Click += new System.EventHandler(this.BT_A_maestros_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.BT_A_maestros);
            this.Controls.Add(this.BT_A_materias);
            this.Controls.Add(this.BT_A_alumnos);
            this.Name = "menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BT_A_alumnos;
        private System.Windows.Forms.Button BT_A_materias;
        private System.Windows.Forms.Button BT_A_maestros;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


namespace Proyect_Test
{
    partial class F_alta_materia
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cconexionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BT_agregarMateria = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_nom_materia = new System.Windows.Forms.TextBox();
            this.cconexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cconexionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cconexionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // cconexionBindingSource1
            // 
            this.cconexionBindingSource1.DataSource = typeof(Proyect_Test.Clases.C_conexion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materias Registradas";
            // 
            // BT_agregarMateria
            // 
            this.BT_agregarMateria.Location = new System.Drawing.Point(912, 489);
            this.BT_agregarMateria.Name = "BT_agregarMateria";
            this.BT_agregarMateria.Size = new System.Drawing.Size(306, 40);
            this.BT_agregarMateria.TabIndex = 56;
            this.BT_agregarMateria.Text = "Agregar";
            this.BT_agregarMateria.UseVisualStyleBackColor = true;
            this.BT_agregarMateria.Click += new System.EventHandler(this.BT_agregarMateria_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(39, 500);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 29);
            this.label18.TabIndex = 55;
            this.label18.Text = "Nueva materia:";
            // 
            // TB_nom_materia
            // 
            this.TB_nom_materia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_nom_materia.Location = new System.Drawing.Point(255, 494);
            this.TB_nom_materia.Name = "TB_nom_materia";
            this.TB_nom_materia.Size = new System.Drawing.Size(487, 35);
            this.TB_nom_materia.TabIndex = 54;
            // 
            // cconexionBindingSource
            // 
            this.cconexionBindingSource.DataSource = typeof(Proyect_Test.Clases.C_conexion);
            // 
            // F_alta_materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.BT_agregarMateria);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TB_nom_materia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_alta_materia";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.F_alta_materia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cconexionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cconexionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_agregarMateria;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_nom_materia;
        private System.Windows.Forms.BindingSource cconexionBindingSource;
        private System.Windows.Forms.BindingSource cconexionBindingSource1;
    }
}
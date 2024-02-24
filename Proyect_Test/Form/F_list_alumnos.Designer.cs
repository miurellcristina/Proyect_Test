namespace Proyect_Test
{
    partial class F_list_alumnos
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
            this.BT_RegistrarC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BT_agregarA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_RegistrarC
            // 
            this.BT_RegistrarC.Location = new System.Drawing.Point(625, 539);
            this.BT_RegistrarC.Name = "BT_RegistrarC";
            this.BT_RegistrarC.Size = new System.Drawing.Size(306, 40);
            this.BT_RegistrarC.TabIndex = 61;
            this.BT_RegistrarC.Text = "Registrar calificacion";
            this.BT_RegistrarC.UseVisualStyleBackColor = true;
            this.BT_RegistrarC.Click += new System.EventHandler(this.BT_RegistrarC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 58;
            this.label1.Text = "Alumnos activos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 393);
            this.dataGridView1.TabIndex = 57;
            // 
            // BT_agregarA
            // 
            this.BT_agregarA.Location = new System.Drawing.Point(243, 539);
            this.BT_agregarA.Name = "BT_agregarA";
            this.BT_agregarA.Size = new System.Drawing.Size(306, 40);
            this.BT_agregarA.TabIndex = 62;
            this.BT_agregarA.Text = "Agregar alumno";
            this.BT_agregarA.UseVisualStyleBackColor = true;
            this.BT_agregarA.Click += new System.EventHandler(this.BT_agregarA_Click);
            // 
            // F_list_alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.BT_agregarA);
            this.Controls.Add(this.BT_RegistrarC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "F_list_alumnos";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_RegistrarC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BT_agregarA;
    }
}
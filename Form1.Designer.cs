namespace simulacroparcial1by
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboEstudiante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTaller = new System.Windows.Forms.ComboBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.listBoxReporte = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante";
            // 
            // comboEstudiante
            // 
            this.comboEstudiante.FormattingEnabled = true;
            this.comboEstudiante.Location = new System.Drawing.Point(157, 46);
            this.comboEstudiante.Name = "comboEstudiante";
            this.comboEstudiante.Size = new System.Drawing.Size(121, 24);
            this.comboEstudiante.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taller";
            // 
            // comboTaller
            // 
            this.comboTaller.FormattingEnabled = true;
            this.comboTaller.Location = new System.Drawing.Point(157, 103);
            this.comboTaller.Name = "comboTaller";
            this.comboTaller.Size = new System.Drawing.Size(121, 24);
            this.comboTaller.TabIndex = 3;
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(56, 180);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(75, 23);
            this.btnInscribir.TabIndex = 4;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(56, 235);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(130, 22);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Mostrar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(56, 299);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 6;
            this.btnOrdenar.Text = "Ordenar por taller";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(56, 363);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Total inscritos";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // listBoxReporte
            // 
            this.listBoxReporte.FormattingEnabled = true;
            this.listBoxReporte.ItemHeight = 16;
            this.listBoxReporte.Location = new System.Drawing.Point(319, 154);
            this.listBoxReporte.Name = "listBoxReporte";
            this.listBoxReporte.Size = new System.Drawing.Size(120, 84);
            this.listBoxReporte.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxReporte);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.comboTaller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEstudiante);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTaller;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.ListBox listBoxReporte;
    }
}


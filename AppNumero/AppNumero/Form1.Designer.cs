namespace AppNumero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumeroMayor = new System.Windows.Forms.Label();
            this.lblNumeroMenor = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.rtbMostrarRango = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroMayor
            // 
            this.lblNumeroMayor.AutoSize = true;
            this.lblNumeroMayor.Location = new System.Drawing.Point(13, 13);
            this.lblNumeroMayor.Name = "lblNumeroMayor";
            this.lblNumeroMayor.Size = new System.Drawing.Size(76, 13);
            this.lblNumeroMayor.TabIndex = 0;
            this.lblNumeroMayor.Text = "Numero Mayor";
            // 
            // lblNumeroMenor
            // 
            this.lblNumeroMenor.AutoSize = true;
            this.lblNumeroMenor.Location = new System.Drawing.Point(13, 47);
            this.lblNumeroMenor.Name = "lblNumeroMenor";
            this.lblNumeroMenor.Size = new System.Drawing.Size(77, 13);
            this.lblNumeroMenor.TabIndex = 1;
            this.lblNumeroMenor.Text = "Numero Menor";
            // 
            // txtMayor
            // 
            this.txtMayor.Location = new System.Drawing.Point(106, 10);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(100, 20);
            this.txtMayor.TabIndex = 2;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(106, 44);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMenor.TabIndex = 3;
            // 
            // rtbMostrarRango
            // 
            this.rtbMostrarRango.Location = new System.Drawing.Point(36, 70);
            this.rtbMostrarRango.Name = "rtbMostrarRango";
            this.rtbMostrarRango.Size = new System.Drawing.Size(207, 96);
            this.rtbMostrarRango.TabIndex = 4;
            this.rtbMostrarRango.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(106, 172);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtbMostrarRango);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.txtMayor);
            this.Controls.Add(this.lblNumeroMenor);
            this.Controls.Add(this.lblNumeroMayor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMayor;
        private System.Windows.Forms.Label lblNumeroMenor;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.RichTextBox rtbMostrarRango;
        private System.Windows.Forms.Button btnCalcular;
    }
}


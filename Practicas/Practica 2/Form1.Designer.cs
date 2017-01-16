namespace Practica_2
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
            this.lbl_Base = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Area = new System.Windows.Forms.Label();
            this.lbl_Perimetro = new System.Windows.Forms.Label();
            this.txt_Base = new System.Windows.Forms.TextBox();
            this.txt_Altura = new System.Windows.Forms.TextBox();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.txt_Perimetro = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Base
            // 
            this.lbl_Base.AutoSize = true;
            this.lbl_Base.Location = new System.Drawing.Point(55, 28);
            this.lbl_Base.Name = "lbl_Base";
            this.lbl_Base.Size = new System.Drawing.Size(31, 13);
            this.lbl_Base.TabIndex = 0;
            this.lbl_Base.Text = "Base";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(52, 54);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_Altura.TabIndex = 1;
            this.lbl_Altura.Text = "Altura";
            // 
            // lbl_Area
            // 
            this.lbl_Area.AutoSize = true;
            this.lbl_Area.Location = new System.Drawing.Point(52, 80);
            this.lbl_Area.Name = "lbl_Area";
            this.lbl_Area.Size = new System.Drawing.Size(29, 13);
            this.lbl_Area.TabIndex = 2;
            this.lbl_Area.Text = "Area";
            // 
            // lbl_Perimetro
            // 
            this.lbl_Perimetro.AutoSize = true;
            this.lbl_Perimetro.Location = new System.Drawing.Point(42, 106);
            this.lbl_Perimetro.Name = "lbl_Perimetro";
            this.lbl_Perimetro.Size = new System.Drawing.Size(51, 13);
            this.lbl_Perimetro.TabIndex = 3;
            this.lbl_Perimetro.Text = "Perimetro";
            // 
            // txt_Base
            // 
            this.txt_Base.Location = new System.Drawing.Point(99, 25);
            this.txt_Base.Name = "txt_Base";
            this.txt_Base.Size = new System.Drawing.Size(100, 20);
            this.txt_Base.TabIndex = 4;
            // 
            // txt_Altura
            // 
            this.txt_Altura.Location = new System.Drawing.Point(99, 51);
            this.txt_Altura.Name = "txt_Altura";
            this.txt_Altura.Size = new System.Drawing.Size(100, 20);
            this.txt_Altura.TabIndex = 5;
            // 
            // txt_Area
            // 
            this.txt_Area.Location = new System.Drawing.Point(99, 77);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(100, 20);
            this.txt_Area.TabIndex = 6;
            // 
            // txt_Perimetro
            // 
            this.txt_Perimetro.Location = new System.Drawing.Point(99, 103);
            this.txt_Perimetro.Name = "txt_Perimetro";
            this.txt_Perimetro.Size = new System.Drawing.Size(100, 20);
            this.txt_Perimetro.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(86, 129);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 163);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Perimetro);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.txt_Altura);
            this.Controls.Add(this.txt_Base);
            this.Controls.Add(this.lbl_Perimetro);
            this.Controls.Add(this.lbl_Area);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.lbl_Base);
            this.Name = "Form1";
            this.Text = "Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Base;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Area;
        private System.Windows.Forms.Label lbl_Perimetro;
        private System.Windows.Forms.TextBox txt_Base;
        private System.Windows.Forms.TextBox txt_Altura;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.TextBox txt_Perimetro;
        private System.Windows.Forms.Button btn_Calcular;
    }
}


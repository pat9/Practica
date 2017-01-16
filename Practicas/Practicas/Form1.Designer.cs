namespace Practicas
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
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.lbl_Suma = new System.Windows.Forms.Label();
            this.lbl_Resta = new System.Windows.Forms.Label();
            this.lbl_Mult = new System.Windows.Forms.Label();
            this.lbl_Div = new System.Windows.Forms.Label();
            this.lbl_Residuo = new System.Windows.Forms.Label();
            this.txt_Suma = new System.Windows.Forms.TextBox();
            this.txt_Resta = new System.Windows.Forms.TextBox();
            this.txt_Mult = new System.Windows.Forms.TextBox();
            this.txt_Div = new System.Windows.Forms.TextBox();
            this.txt_Residuo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(72, 20);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(100, 20);
            this.txt_Num1.TabIndex = 0;
            this.txt_Num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num1_KeyPress);
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(74, 58);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(100, 20);
            this.txt_Num2.TabIndex = 1;
            this.txt_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num2_KeyPress);
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Location = new System.Drawing.Point(12, 61);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(56, 13);
            this.lbl_Num2.TabIndex = 2;
            this.lbl_Num2.Text = "Numero 2:";
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Location = new System.Drawing.Point(12, 23);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(56, 13);
            this.lbl_Num1.TabIndex = 3;
            this.lbl_Num1.Text = "Numero 1:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(65, 84);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // lbl_Suma
            // 
            this.lbl_Suma.AutoSize = true;
            this.lbl_Suma.Location = new System.Drawing.Point(12, 126);
            this.lbl_Suma.Name = "lbl_Suma";
            this.lbl_Suma.Size = new System.Drawing.Size(34, 13);
            this.lbl_Suma.TabIndex = 5;
            this.lbl_Suma.Text = "Suma";
            // 
            // lbl_Resta
            // 
            this.lbl_Resta.AutoSize = true;
            this.lbl_Resta.Location = new System.Drawing.Point(71, 126);
            this.lbl_Resta.Name = "lbl_Resta";
            this.lbl_Resta.Size = new System.Drawing.Size(35, 13);
            this.lbl_Resta.TabIndex = 6;
            this.lbl_Resta.Text = "Resta";
            // 
            // lbl_Mult
            // 
            this.lbl_Mult.AutoSize = true;
            this.lbl_Mult.Location = new System.Drawing.Point(133, 126);
            this.lbl_Mult.Name = "lbl_Mult";
            this.lbl_Mult.Size = new System.Drawing.Size(71, 13);
            this.lbl_Mult.TabIndex = 7;
            this.lbl_Mult.Text = "Multiplicación";
            // 
            // lbl_Div
            // 
            this.lbl_Div.AutoSize = true;
            this.lbl_Div.Location = new System.Drawing.Point(9, 174);
            this.lbl_Div.Name = "lbl_Div";
            this.lbl_Div.Size = new System.Drawing.Size(44, 13);
            this.lbl_Div.TabIndex = 8;
            this.lbl_Div.Text = "División";
            // 
            // lbl_Residuo
            // 
            this.lbl_Residuo.AutoSize = true;
            this.lbl_Residuo.Location = new System.Drawing.Point(71, 174);
            this.lbl_Residuo.Name = "lbl_Residuo";
            this.lbl_Residuo.Size = new System.Drawing.Size(46, 13);
            this.lbl_Residuo.TabIndex = 9;
            this.lbl_Residuo.Text = "Residuo";
            // 
            // txt_Suma
            // 
            this.txt_Suma.Location = new System.Drawing.Point(12, 142);
            this.txt_Suma.Name = "txt_Suma";
            this.txt_Suma.Size = new System.Drawing.Size(56, 20);
            this.txt_Suma.TabIndex = 10;
            // 
            // txt_Resta
            // 
            this.txt_Resta.Location = new System.Drawing.Point(74, 142);
            this.txt_Resta.Name = "txt_Resta";
            this.txt_Resta.Size = new System.Drawing.Size(56, 20);
            this.txt_Resta.TabIndex = 11;
            // 
            // txt_Mult
            // 
            this.txt_Mult.Location = new System.Drawing.Point(136, 142);
            this.txt_Mult.Name = "txt_Mult";
            this.txt_Mult.Size = new System.Drawing.Size(68, 20);
            this.txt_Mult.TabIndex = 12;
            // 
            // txt_Div
            // 
            this.txt_Div.Location = new System.Drawing.Point(12, 190);
            this.txt_Div.Name = "txt_Div";
            this.txt_Div.Size = new System.Drawing.Size(56, 20);
            this.txt_Div.TabIndex = 13;
            // 
            // txt_Residuo
            // 
            this.txt_Residuo.Location = new System.Drawing.Point(74, 190);
            this.txt_Residuo.Name = "txt_Residuo";
            this.txt_Residuo.Size = new System.Drawing.Size(56, 20);
            this.txt_Residuo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 227);
            this.Controls.Add(this.txt_Residuo);
            this.Controls.Add(this.txt_Div);
            this.Controls.Add(this.txt_Mult);
            this.Controls.Add(this.txt_Resta);
            this.Controls.Add(this.txt_Suma);
            this.Controls.Add(this.lbl_Residuo);
            this.Controls.Add(this.lbl_Div);
            this.Controls.Add(this.lbl_Mult);
            this.Controls.Add(this.lbl_Resta);
            this.Controls.Add(this.lbl_Suma);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.lbl_Num1);
            this.Controls.Add(this.lbl_Num2);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label lbl_Suma;
        private System.Windows.Forms.Label lbl_Resta;
        private System.Windows.Forms.Label lbl_Mult;
        private System.Windows.Forms.Label lbl_Div;
        private System.Windows.Forms.Label lbl_Residuo;
        private System.Windows.Forms.TextBox txt_Suma;
        private System.Windows.Forms.TextBox txt_Resta;
        private System.Windows.Forms.TextBox txt_Mult;
        private System.Windows.Forms.TextBox txt_Div;
        private System.Windows.Forms.TextBox txt_Residuo;
    }
}


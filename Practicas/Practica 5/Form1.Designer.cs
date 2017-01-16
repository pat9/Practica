namespace Practica_5
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SalAnt = new System.Windows.Forms.TextBox();
            this.txt_Inc = new System.Windows.Forms.TextBox();
            this.txt_SalAct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(93, 107);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 0;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salario Anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Incremento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salario Actual";
            // 
            // txt_SalAnt
            // 
            this.txt_SalAnt.Location = new System.Drawing.Point(116, 18);
            this.txt_SalAnt.Name = "txt_SalAnt";
            this.txt_SalAnt.Size = new System.Drawing.Size(100, 20);
            this.txt_SalAnt.TabIndex = 4;
            // 
            // txt_Inc
            // 
            this.txt_Inc.Location = new System.Drawing.Point(116, 44);
            this.txt_Inc.Name = "txt_Inc";
            this.txt_Inc.Size = new System.Drawing.Size(100, 20);
            this.txt_Inc.TabIndex = 5;
            // 
            // txt_SalAct
            // 
            this.txt_SalAct.Location = new System.Drawing.Point(116, 70);
            this.txt_SalAct.Name = "txt_SalAct";
            this.txt_SalAct.Size = new System.Drawing.Size(100, 20);
            this.txt_SalAct.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 151);
            this.Controls.Add(this.txt_SalAct);
            this.Controls.Add(this.txt_Inc);
            this.Controls.Add(this.txt_SalAnt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calcular);
            this.Name = "Form1";
            this.Text = "Calcular Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SalAnt;
        private System.Windows.Forms.TextBox txt_Inc;
        private System.Windows.Forms.TextBox txt_SalAct;
    }
}


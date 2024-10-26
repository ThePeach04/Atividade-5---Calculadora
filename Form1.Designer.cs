namespace Atividade_5___Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnSubtrair = new Button();
            btnSomar = new Button();
            lblResultado = new Label();
            txtValor2 = new TextBox();
            label2 = new Label();
            txtValor1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDividir);
            groupBox1.Controls.Add(btnMultiplicar);
            groupBox1.Controls.Add(btnSubtrair);
            groupBox1.Controls.Add(btnSomar);
            groupBox1.Controls.Add(lblResultado);
            groupBox1.Controls.Add(txtValor2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtValor1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(5, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnDividir_Click
            // 
            btnDividir.Location = new Point(249, 146);
            btnDividir.Name = "btnDividir_Click";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar_Click
            // 
            btnMultiplicar.Location = new Point(168, 146);
            btnMultiplicar.Name = "btnMultiplicar_Click";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnSubtrair_Click
            // 
            btnSubtrair.Location = new Point(87, 146);
            btnSubtrair.Name = "btnSubtrair_Click";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 6;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnSomar_Click
            // 
            btnSomar.Location = new Point(6, 146);
            btnSomar.Name = "btnSomar_Click";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 5;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(124, 215);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(94, 25);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(102, 69);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(228, 23);
            txtValor2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 72);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite Valor 2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(102, 16);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(228, 23);
            txtValor1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite Valor 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 327);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtValor2;
        private Label label2;
        private TextBox txtValor1;
        private Label label1;
        private Label lblResultado;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnSubtrair;
        private Button btnSomar;
    }
}

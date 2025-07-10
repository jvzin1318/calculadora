namespace calculadora
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
            res = new RichTextBox();
            botao1 = new Button();
            botao2 = new Button();
            botao3 = new Button();
            botao4 = new Button();
            botao5 = new Button();
            botao6 = new Button();
            botao7 = new Button();
            botao8 = new Button();
            botao9 = new Button();
            botao0 = new Button();
            botaovirgula = new Button();
            botaoresultado = new Button();
            botaosomar = new Button();
            botaosubtrair = new Button();
            botaomultiplicar = new Button();
            botaodividir = new Button();
            botaoapagar = new Button();
            SuspendLayout();
            // 
            // res
            // 
            res.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            res.Location = new Point(12, 39);
            res.Name = "res";
            res.RightToLeft = RightToLeft.Yes;
            res.Size = new Size(438, 144);
            res.TabIndex = 0;
            res.Text = "";
            res.TextChanged += richTextBox1_TextChanged;
            // 
            // botao1
            // 
            botao1.Location = new Point(28, 293);
            botao1.Name = "botao1";
            botao1.Size = new Size(76, 34);
            botao1.TabIndex = 1;
            botao1.Text = "1";
            botao1.UseVisualStyleBackColor = true;
            botao1.Click += botao1_Click;
            // 
            // botao2
            // 
            botao2.Location = new Point(110, 293);
            botao2.Name = "botao2";
            botao2.Size = new Size(76, 34);
            botao2.TabIndex = 2;
            botao2.Text = "2";
            botao2.UseVisualStyleBackColor = true;
            botao2.Click += botao2_Click;
            // 
            // botao3
            // 
            botao3.Location = new Point(192, 293);
            botao3.Name = "botao3";
            botao3.Size = new Size(76, 34);
            botao3.TabIndex = 3;
            botao3.Text = "3";
            botao3.UseVisualStyleBackColor = true;
            botao3.Click += botao3_Click;
            // 
            // botao4
            // 
            botao4.Location = new Point(28, 333);
            botao4.Name = "botao4";
            botao4.Size = new Size(76, 34);
            botao4.TabIndex = 4;
            botao4.Text = "4";
            botao4.UseVisualStyleBackColor = true;
            botao4.Click += botao4_Click;
            // 
            // botao5
            // 
            botao5.Location = new Point(110, 333);
            botao5.Name = "botao5";
            botao5.Size = new Size(76, 34);
            botao5.TabIndex = 5;
            botao5.Text = "5";
            botao5.UseVisualStyleBackColor = true;
            botao5.Click += botao5_Click;
            // 
            // botao6
            // 
            botao6.Location = new Point(192, 333);
            botao6.Name = "botao6";
            botao6.Size = new Size(76, 34);
            botao6.TabIndex = 6;
            botao6.Text = "6";
            botao6.UseVisualStyleBackColor = true;
            botao6.Click += botao6_Click;
            // 
            // botao7
            // 
            botao7.Location = new Point(28, 373);
            botao7.Name = "botao7";
            botao7.Size = new Size(76, 34);
            botao7.TabIndex = 7;
            botao7.Text = "7";
            botao7.UseVisualStyleBackColor = true;
            botao7.Click += botao7_Click;
            // 
            // botao8
            // 
            botao8.Location = new Point(110, 373);
            botao8.Name = "botao8";
            botao8.Size = new Size(76, 34);
            botao8.TabIndex = 8;
            botao8.Text = "8";
            botao8.UseVisualStyleBackColor = true;
            botao8.Click += botao8_Click;
            // 
            // botao9
            // 
            botao9.Location = new Point(192, 373);
            botao9.Name = "botao9";
            botao9.Size = new Size(76, 34);
            botao9.TabIndex = 9;
            botao9.Text = "9";
            botao9.UseVisualStyleBackColor = true;
            botao9.Click += botao9_Click;
            // 
            // botao0
            // 
            botao0.Location = new Point(110, 413);
            botao0.Name = "botao0";
            botao0.Size = new Size(76, 34);
            botao0.TabIndex = 10;
            botao0.Text = "0";
            botao0.UseVisualStyleBackColor = true;
            botao0.Click += botao0_Click;
            // 
            // botaovirgula
            // 
            botaovirgula.Location = new Point(192, 413);
            botaovirgula.Name = "botaovirgula";
            botaovirgula.Size = new Size(76, 34);
            botaovirgula.TabIndex = 11;
            botaovirgula.Text = ",";
            botaovirgula.UseVisualStyleBackColor = true;
            // 
            // botaoresultado
            // 
            botaoresultado.Location = new Point(274, 413);
            botaoresultado.Name = "botaoresultado";
            botaoresultado.Size = new Size(76, 34);
            botaoresultado.TabIndex = 13;
            botaoresultado.Text = "=";
            botaoresultado.UseVisualStyleBackColor = true;
            botaoresultado.Click += botaoresultado_Click;
            // 
            // botaosomar
            // 
            botaosomar.Location = new Point(274, 373);
            botaosomar.Name = "botaosomar";
            botaosomar.Size = new Size(76, 34);
            botaosomar.TabIndex = 14;
            botaosomar.Text = "+";
            botaosomar.UseVisualStyleBackColor = true;
            botaosomar.Click += botaosomar_Click;
            // 
            // botaosubtrair
            // 
            botaosubtrair.Location = new Point(274, 333);
            botaosubtrair.Name = "botaosubtrair";
            botaosubtrair.Size = new Size(76, 34);
            botaosubtrair.TabIndex = 15;
            botaosubtrair.Text = "-";
            botaosubtrair.UseVisualStyleBackColor = true;
            // 
            // botaomultiplicar
            // 
            botaomultiplicar.Location = new Point(274, 293);
            botaomultiplicar.Name = "botaomultiplicar";
            botaomultiplicar.Size = new Size(76, 34);
            botaomultiplicar.TabIndex = 16;
            botaomultiplicar.Text = "x";
            botaomultiplicar.UseVisualStyleBackColor = true;
            // 
            // botaodividir
            // 
            botaodividir.Location = new Point(276, 253);
            botaodividir.Name = "botaodividir";
            botaodividir.Size = new Size(76, 34);
            botaodividir.TabIndex = 17;
            botaodividir.Text = "/";
            botaodividir.UseVisualStyleBackColor = true;
            // 
            // botaoapagar
            // 
            botaoapagar.Location = new Point(274, 213);
            botaoapagar.Name = "botaoapagar";
            botaoapagar.Size = new Size(76, 34);
            botaoapagar.TabIndex = 18;
            botaoapagar.Text = "AC";
            botaoapagar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 546);
            Controls.Add(botaoapagar);
            Controls.Add(botaodividir);
            Controls.Add(botaomultiplicar);
            Controls.Add(botaosubtrair);
            Controls.Add(botaosomar);
            Controls.Add(botaoresultado);
            Controls.Add(botaovirgula);
            Controls.Add(botao0);
            Controls.Add(botao9);
            Controls.Add(botao8);
            Controls.Add(botao7);
            Controls.Add(botao6);
            Controls.Add(botao5);
            Controls.Add(botao4);
            Controls.Add(botao3);
            Controls.Add(botao2);
            Controls.Add(botao1);
            Controls.Add(res);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox res;
        private Button botao1;
        private Button botao2;
        private Button botao3;
        private Button botao4;
        private Button botao5;
        private Button botao6;
        private Button botao7;
        private Button botao8;
        private Button botao9;
        private Button botao0;
        private Button botaovirgula;
        private Button botaoresultado;
        private Button botaosomar;
        private Button botaosubtrair;
        private Button botaomultiplicar;
        private Button botaodividir;
        private Button botaoapagar;
    }
}

namespace FinEasy
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
            button_Calc = new Button();
            button_Aposento = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            text_ValorIni = new TextBox();
            text_Investimento = new TextBox();
            text_taxa = new TextBox();
            text_Infla = new TextBox();
            text_AposentoIni = new TextBox();
            label6 = new Label();
            text_AposentoTempo = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label_ValorFinal = new Label();
            label8 = new Label();
            label_ResultApo = new Label();
            text_Periodo = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // button_Calc
            // 
            button_Calc.Location = new Point(471, 6);
            button_Calc.Name = "button_Calc";
            button_Calc.Size = new Size(109, 23);
            button_Calc.TabIndex = 0;
            button_Calc.Text = "Calcular";
            button_Calc.UseVisualStyleBackColor = true;
            button_Calc.Click += button_Calc_Click;
            // 
            // button_Aposento
            // 
            button_Aposento.Location = new Point(471, 200);
            button_Aposento.Name = "button_Aposento";
            button_Aposento.Size = new Size(109, 23);
            button_Aposento.TabIndex = 1;
            button_Aposento.Text = "Aposentadoria";
            button_Aposento.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 2;
            label1.Text = "Valor Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Investimento Mensal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 4;
            label3.Text = "Taxa Anual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 128);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Inflação";
            // 
            // text_ValorIni
            // 
            text_ValorIni.Location = new Point(179, 6);
            text_ValorIni.Name = "text_ValorIni";
            text_ValorIni.Size = new Size(254, 23);
            text_ValorIni.TabIndex = 6;
            // 
            // text_Investimento
            // 
            text_Investimento.Location = new Point(179, 34);
            text_Investimento.Name = "text_Investimento";
            text_Investimento.Size = new Size(254, 23);
            text_Investimento.TabIndex = 7;
            // 
            // text_taxa
            // 
            text_taxa.Location = new Point(179, 93);
            text_taxa.Name = "text_taxa";
            text_taxa.Size = new Size(254, 23);
            text_taxa.TabIndex = 8;
            // 
            // text_Infla
            // 
            text_Infla.Location = new Point(179, 122);
            text_Infla.Name = "text_Infla";
            text_Infla.Size = new Size(254, 23);
            text_Infla.TabIndex = 9;
            // 
            // text_AposentoIni
            // 
            text_AposentoIni.Location = new Point(179, 201);
            text_AposentoIni.Name = "text_AposentoIni";
            text_AposentoIni.Size = new Size(254, 23);
            text_AposentoIni.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 204);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor Inicial";
            // 
            // text_AposentoTempo
            // 
            text_AposentoTempo.Location = new Point(179, 232);
            text_AposentoTempo.Name = "text_AposentoTempo";
            text_AposentoTempo.Size = new Size(254, 23);
            text_AposentoTempo.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 235);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "Tempo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 150);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 16;
            label5.Text = "Valor Final:";
            // 
            // label_ValorFinal
            // 
            label_ValorFinal.AutoSize = true;
            label_ValorFinal.Location = new Point(82, 150);
            label_ValorFinal.Name = "label_ValorFinal";
            label_ValorFinal.Size = new Size(59, 15);
            label_ValorFinal.TabIndex = 17;
            label_ValorFinal.Text = "Resultado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 282);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 18;
            label8.Text = "Investimento mensal";
            // 
            // label_ResultApo
            // 
            label_ResultApo.AutoSize = true;
            label_ResultApo.Location = new Point(135, 282);
            label_ResultApo.Name = "label_ResultApo";
            label_ResultApo.Size = new Size(59, 15);
            label_ResultApo.TabIndex = 19;
            label_ResultApo.Text = "Resultado";
            // 
            // text_Periodo
            // 
            text_Periodo.Location = new Point(179, 64);
            text_Periodo.Name = "text_Periodo";
            text_Periodo.Size = new Size(254, 23);
            text_Periodo.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 67);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 20;
            label9.Text = "Tempo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 320);
            Controls.Add(text_Periodo);
            Controls.Add(label9);
            Controls.Add(label_ResultApo);
            Controls.Add(label8);
            Controls.Add(label_ValorFinal);
            Controls.Add(label5);
            Controls.Add(text_AposentoTempo);
            Controls.Add(label7);
            Controls.Add(text_AposentoIni);
            Controls.Add(label6);
            Controls.Add(text_Infla);
            Controls.Add(text_taxa);
            Controls.Add(text_Investimento);
            Controls.Add(text_ValorIni);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Aposento);
            Controls.Add(button_Calc);
            Name = "Form1";
            Text = "FinEasy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Calc;
        private Button button_Aposento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox text_ValorIni;
        private TextBox text_Investimento;
        private TextBox text_taxa;
        private TextBox text_Infla;
        private TextBox text_AposentoIni;
        private Label label6;
        private TextBox text_AposentoTempo;
        private Label label7;
        private Label label5;
        private Label label_ValorFinal;
        private Label label8;
        private Label label_ResultApo;
        private TextBox text_Periodo;
        private Label label9;
    }
}

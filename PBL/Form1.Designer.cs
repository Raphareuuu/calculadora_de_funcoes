namespace PBL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFuncao = new System.Windows.Forms.TextBox();
            this.txtPontoInicial = new System.Windows.Forms.TextBox();
            this.txtPontoFinal = new System.Windows.Forms.TextBox();
            this.txtDivisoes = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFuncao
            // 
            this.txtFuncao.Location = new System.Drawing.Point(80, 99);
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.Size = new System.Drawing.Size(232, 26);
            this.txtFuncao.TabIndex = 1;
            // 
            // txtPontoInicial
            // 
            this.txtPontoInicial.Location = new System.Drawing.Point(51, 178);
            this.txtPontoInicial.Name = "txtPontoInicial";
            this.txtPontoInicial.Size = new System.Drawing.Size(133, 26);
            this.txtPontoInicial.TabIndex = 1;
            // 
            // txtPontoFinal
            // 
            this.txtPontoFinal.Location = new System.Drawing.Point(217, 178);
            this.txtPontoFinal.Name = "txtPontoFinal";
            this.txtPontoFinal.Size = new System.Drawing.Size(121, 26);
            this.txtPontoFinal.TabIndex = 1;
            // 
            // txtDivisoes
            // 
            this.txtDivisoes.Location = new System.Drawing.Point(88, 260);
            this.txtDivisoes.Name = "txtDivisoes";
            this.txtDivisoes.Size = new System.Drawing.Size(203, 26);
            this.txtDivisoes.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Orange;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(78, 333);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(234, 69);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(56, 722);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(399, 107);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite a função:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ponto inicial";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Orange;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ponto Final";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Orange;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero de divisões";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(75, 23);
            this.plotView1.TabIndex = 6;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView2
            // 
            this.plotView2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.plotView2.Location = new System.Drawing.Point(525, 145);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(868, 711);
            this.plotView2.TabIndex = 7;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.txtFuncao);
            this.panel1.Controls.Add(this.txtPontoInicial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDivisoes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPontoFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(61, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 462);
            this.panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Lavender;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Exponencial - Exp(x)",
            "Seno - Sin(x)",
            "Cosseno - Cos(x)",
            "Quadrática - Para x^2, use Pow (x,2)",
            "Cúbica - Para x^3, use Pow (x,3)"});
            this.comboBox1.Location = new System.Drawing.Point(61, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(394, 36);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Funções, como usar:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1496, 84);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calculadora Gráfica de Integração por Trapézios";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1496, 920);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFuncao;
        private System.Windows.Forms.TextBox txtPontoInicial;
        private System.Windows.Forms.TextBox txtPontoFinal;
        private System.Windows.Forms.TextBox txtDivisoes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}


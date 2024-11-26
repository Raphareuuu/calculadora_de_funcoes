using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace PBL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string funcao = txtFuncao.Text;
                double a = double.Parse(txtPontoInicial.Text);
                double b = double.Parse(txtPontoFinal.Text);
                int n = int.Parse(txtDivisoes.Text);

                List<double> pontosX = new List<double>();
                List<double> valoresFX = new List<double>();
                double area = IntegracaoTrapezios(funcao, a, b, n, pontosX, valoresFX);

                lblResultado.Text = $"A Área sob a curva é: {area}";

                CriarGrafico(funcao, a, b, pontosX, valoresFX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private double IntegracaoTrapezios(string funcao, double a, double b, int n, List<double> pontosX, List<double> valoresFX)
        {
            double h = (b - a) / n;
            double soma = 0;

            for (int i = 0; i <= n; i++)
            {
                double x = a + i * h;
                double y = AvaliarFuncao(funcao, x);
                pontosX.Add(x);
                valoresFX.Add(y);

                Console.WriteLine($"x: {x}, f(x): {y}");

                if (i == 0 || i == n)
                    soma += y;
                else
                    soma += 2 * y;
            }
            return (h / 2) * soma;
        }
        private double AvaliarFuncao(string funcao, double x)
        {
            if (string.IsNullOrWhiteSpace(funcao))
            {
                MessageBox.Show("A função não pode estar vazia.");
                return double.NaN;
            }
            try
            {
                Expression expressao = new Expression(funcao);
                expressao.Parameters["x"] = x;
                var resultado = expressao.Evaluate();

                if (resultado is double valor)
                {
                    return valor;
                }
                MessageBox.Show("A avaliação da função não retornou um número válido.");
                return double.NaN;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao avaliar a função '{funcao}' com x = {x}: {ex.Message}");
                return double.NaN;
            }
        }
        private void CriarGrafico(string funcao, double a, double b, List<double> pontosX, List<double> valoresFX)
        {
            var model = new PlotModel { Title = "Gráfico da Função e Trapézios" };

            var seriesLinha = new LineSeries
            {
                Title = "Função f(x)",
                Color = OxyColors.DarkBlue,
                StrokeThickness = 2,
                MarkerType = MarkerType.None
            };

            for (int i = 0; i < pontosX.Count; i++)
            {
                seriesLinha.Points.Add(new DataPoint(pontosX[i], valoresFX[i]));
            }

            // Adicionar as áreas dos trapézios
            foreach (var i in Enumerable.Range(0, pontosX.Count - 1))
            {
                // Preenchimento dos trapézios
                var polygon = new PolygonAnnotation
                {
                    Fill = OxyColor.FromAColor(100, OxyColors.Orange),
                    Layer = AnnotationLayer.BelowSeries
                };

                polygon.Points.Add(new DataPoint(pontosX[i], valoresFX[i]));
                polygon.Points.Add(new DataPoint(pontosX[i + 1], valoresFX[i + 1]));
                polygon.Points.Add(new DataPoint(pontosX[i + 1], 0));
                polygon.Points.Add(new DataPoint(pontosX[i], 0));

                model.Annotations.Add(polygon);

                // Adicionar as bordas dos trapézios
                var seriesTrapezio = new LineSeries
                {
                    Color = OxyColors.Black,
                    StrokeThickness = 1,
                    LineStyle = LineStyle.Solid
                };

                seriesTrapezio.Points.Add(new DataPoint(pontosX[i], valoresFX[i]));
                seriesTrapezio.Points.Add(new DataPoint(pontosX[i + 1], valoresFX[i + 1]));
                seriesTrapezio.Points.Add(new DataPoint(pontosX[i + 1], 0));
                seriesTrapezio.Points.Add(new DataPoint(pontosX[i], 0));
                seriesTrapezio.Points.Add(new DataPoint(pontosX[i], valoresFX[i])); // Fechar o contorno

                model.Series.Add(seriesTrapezio);
            }

            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "X", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "f(x)", MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot });

            model.Series.Add(seriesLinha);

            plotView2.Model = model;
        }
    }
}
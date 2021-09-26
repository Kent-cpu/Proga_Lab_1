using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Prog_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zedGraphControl1.GraphPane.Title.Text = "f(x)";
        }

        private double calculateValuePoint(double value)
        {
            double result = 0;
            try
            {
                var variables = new Dictionary<string, FloatingPoint> { { "x", value } };
                var formula = Infix.ParseOrThrow(formulaField.Text);
                result = Evaluate.Evaluate(variables, formula).RealValue;
            }catch(Exception ex)
            {
                errorMessage.Text = ex.Message;
                zedGraphControl1.GraphPane.CurveList.Clear();
                answerField.Text = "";
            }


            return result;

        }

        private void расчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorMessage.Text = "";
            if (double.TryParse(bottomBorderField.Text, out double bottomBorder) && double.TryParse(topBorderField.Text, out double topBorder)
                && double.TryParse(accuracyField.Text, out double accuracy)){

                if(bottomBorder >= topBorder)
                {
                    errorMessage.Text = "Значение a должно быть меньше значения b";
                    return;
                }else if(accuracy <= 0)
                {
                    errorMessage.Text = "Точность должна быть больше 0";
                    return;
                }

               
                int decimalPlaces = 0;


                for(double i = accuracy; i < 1; i *= 10)
                {
                    ++decimalPlaces;
                }

                


         
                PointPairList list = new PointPairList();

                GraphPane mypane = zedGraphControl1.GraphPane;
                mypane.CurveList.Clear();
                


                mypane.XAxis.MajorGrid.IsVisible = true;
                mypane.XAxis.MinorGrid.IsVisible = true;
                mypane.YAxis.MajorGrid.IsVisible = true;

                mypane.XAxis.Scale.Min = bottomBorder;
                mypane.XAxis.Scale.Max = topBorder;

                // По оси Y установим автоматический подбор масштаба
                mypane.YAxis.Scale.MinAuto = true;
                mypane.YAxis.Scale.MaxAuto = true;
                mypane.IsBoundedRanges = true;

                for (double x = bottomBorder; x < topBorder; x += accuracy)
                {
                    try
                    {
                        list.Add(x, calculateValuePoint(x));
                    }
                    catch (Exception ex)
                    {
                        errorMessage.Text = "Слишком большая точность или интервал";
                    }
                   
                }

               
                double minPoint = 0;


                while (topBorder - bottomBorder >= accuracy)
                {
                    double center = Math.Round((topBorder + bottomBorder) / 2, decimalPlaces);
                    double left = center - accuracy;
                    double right = center + accuracy;


                    if (Math.Round(calculateValuePoint(left), decimalPlaces) < Math.Round(calculateValuePoint(right), 2))
                    {
                        topBorder = center;
                    }
                    else
                    {
                        bottomBorder = center;
                    }


                    minPoint = center;
                }
               

                LineItem myCurve = mypane.AddCurve("f(x)", list, Color.Blue, SymbolType.None);
                LineItem minPointCurve = mypane.AddCurve("Min point", new double[] { minPoint }, new double[] { calculateValuePoint(minPoint) }, Color.DarkRed, SymbolType.Circle);
                minPointCurve.Symbol.Fill.Type = FillType.Solid;


                // Вызываем метод AxisChange (), чтобы обновить данные об осях.
                // В противном случае на рисунке будет показана только часть графика,
                // которая умещается в интервалы по осям, установленные по умолчанию
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();
                answerField.Text = "x: " + minPoint.ToString() + " y: " + calculateValuePoint(minPoint).ToString();
            }
            else
            {
                errorMessage.Text = "Неверные входные данные";
            }
       


        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control element in Controls)
            {
                if (element is TextBox)
                {
                    ((TextBox) element).Text = null;
                }
                
            }
                

        }




    }
}

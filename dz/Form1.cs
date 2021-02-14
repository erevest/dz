using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "";
      // Вывод строки в многострочный редактор
      richTextBox1.Text = "Практическая работа №2 Карпусенко А.В.";
      richTextBox1.Text += Environment.NewLine + "Рассчитать значение выражения y, из задания 10";

    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Считывание значения X
      double x = double.Parse(textBox1.Text);
      // Вывод значения X в окно
      richTextBox1.Text += Environment.NewLine +
      "При x = " + x.ToString();
      // Вычисляем арифметическое выражение
      double y = Math.Abs(1+Math.Cos(Math.Sqrt(x))-(Math.Pow(Math.Log(1),2)*2*x))/((Math.Sqrt(3*x+4))-(Math.Pow(2, 0.5*x-1)));

      // Выводим результат в окно
      richTextBox1.Text += Environment.NewLine +
      "Результат y = " + y.ToString();
    }
  }
}

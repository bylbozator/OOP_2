using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "3,251";
            // Начальное значение Y
            textBox2.Text = "0,325";
            // Начальное значение Z
            textBox3.Text = "0,0000466";
            // Начальное значение c
            // textBox4.Text = "4,025";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox5.Text += Environment.NewLine +
            "X = " + x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox5.Text += Environment.NewLine +
            "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox5.Text += Environment.NewLine +
            "Z = " + z.ToString();

            double c = Math.Pow(2, Math.Pow(y, x)) + Math.Pow(3, Math.Pow(x, y)) - ((y * (Math.Atan(z) - (Math.PI / 6)) / ((Math.Abs(x) + (1 / (Math.Pow(y, 2) + 1))))));
            // Выводим результат в окно
            textBox5.Text += Environment.NewLine +
            "Результат C = " + c.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
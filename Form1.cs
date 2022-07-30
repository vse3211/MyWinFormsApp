using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; // Данная зависимость серого цвета, не используемая в коде
using System.Threading.Tasks;
using System.Windows.Forms; // Данная зависимость белого цвета используется в коде

namespace MyWinFormsApp
{
    public partial class Form1 : Form // : Form - наследование класса Form
    {
        public Form1()
        {
            // Инициализация формы. Находится в Form1.Designer.cs файле
            InitializeComponent();
            button1.Text = 0.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = (Convert.ToInt32(((Button)sender).Text) + 1).ToString();
        }
    }
}

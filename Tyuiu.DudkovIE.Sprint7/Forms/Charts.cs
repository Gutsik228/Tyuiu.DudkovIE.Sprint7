using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.DudkovIE.Sprint7.Forms
{
    public partial class Charts : Form
    {
        int[] arrayPrice;

        public Charts(int[] Price)
        {
            InitializeComponent();

            arrayPrice = Price;
        }

        private void button_ShowCharts_DIE_Click(object sender, EventArgs e)
        {
            chart_PriceProduct_DIE.Series[0].Points.DataBindY(arrayPrice);
        }
    }
}

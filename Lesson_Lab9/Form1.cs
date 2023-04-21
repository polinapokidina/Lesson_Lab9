using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int NumberSymbols(string stroka, char symbol)
        {
            int k = 0;
            for (int i = 0; i < stroka.Length; i++)
            {
                if (stroka[i] == symbol) 
                {
                    k += 1;
                }
            }
            return k;
        }

        private int NumberSymbolsSamost(string stroka, string symbol)
        {
            int k = 0;
            k = (txtString.Text.Length - txtString.Text.Replace(symbol, "").Length) / symbol.Length;
            return k;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtKolvo.Text = NumberSymbols(txtString.Text, 'а').ToString();

            txtKolvoSymbols.Text = NumberSymbolsSamost(txtString.Text, txtSymbols.Text).ToString();
        }
    }
}

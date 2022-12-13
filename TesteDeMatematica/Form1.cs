using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeMatematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Random randomize = new Random();

            //Cálculo soma
            int addend1 = randomize.Next(51);
            int addend2 = randomize.Next(51);

            lblL1.Text = addend1.ToString();
            lblL1b.Text = addend2.ToString();
            numericUpDown1.Value = 0;

            //Cálculo subtração
            int minuendo = randomize.Next(1, 101);
            int subtraendo = randomize.Next(1, minuendo);

            lblL2.Text = minuendo.ToString();
            lblL2b.Text = subtraendo.ToString();
            numericUpDown2.Value = 0;

            //Cálculo multiplicação
            int multiplicando = randomize.Next(2, 11);
            int multiplicador = randomize.Next(2, 11);

            lblL3.Text = multiplicando.ToString();
            lblL3b.Text = multiplicador.ToString();
            numericUpDown3.Value = 0;

            //Cálculo multiplicação
            int divisor = randomize.Next(2, 11);
            int quocienteTemporario = randomize.Next(2, 11);
            int dividendo = randomize.Next(2, 11);

            lblL4.Text = divisor.ToString();
            lblL4b.Text = dividendo.ToString();
            numericUpDown4.Value = 0;

            int tempoRestante;

        }

        /*public bool ChecarResposta()
        {
            if ((addend1 + addend2 == numericUpDown1.Value) &&
                (minuendo - subtraendo == numericUpDown2.Value) &&
                (multiplicando * multiplicador == numericUpDown3) &&
                (dividendo / divisor == numericUpDown4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/


    }
}

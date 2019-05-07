using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncom
{
    public partial class Form1 : Form
    {
        string var1;
        string var2;

        string vara;
        string varb;
        
        bool esBinomio;
        bool esBinomio2;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void butPolar_Click(object sender, EventArgs e)
        {
            
            double M1 = obtenerModulo();
            double ARG1 = obtenerArgumento();
            if (esBinomio == true)
            {

                lblPolar.Text = "|Z1|:" + M1 + " ARG(Z1):" + ARG1;
            }
            else
            {
                lblPolar.Text = " El numero ya esta en forma polar!";
            }
              
        }

        private void ButBinomic_Click(object sender, EventArgs e)
        {
            if (esBinomio == false)
            {

                obtenerVariables1();
                double R1 = Double.Parse(var1);
                double R2 = Double.Parse(var2);
                double af = Math.Round(obtenerReal(R1, R2), 3);
                double bf = Math.Round(obtenerImg(R1, R2), 3);
                if (bf >= 0)
                {
                    lblPolar.Text = af + " + " + bf + " i";
                }
                else
                {
                    lblPolar.Text = af + " - " + Math.Abs(bf) + " i";
                }

            }
            else
            {
                lblPolar.Text = " El numero ya esta en forma binomica! ";
            }



        }
     
        public double obtenerModulo()
        {
            obtenerVariables1();
          
            double R1 = Double.Parse(var1);
            double IM1 = Double.Parse(var2);



            double M1 = Math.Sqrt(Math.Pow(R1, 2) + Math.Pow(IM1, 2));


            return M1;
        }
        public double obtenerArgumento()
        {
            obtenerVariables1();
            double R1 = Double.Parse(var1);
            double IM1 = Double.Parse(var2);
            double ARG1;
            double complemento = Math.PI;
            if (R1 >= 0)
                {
                //ARG1 = Math.Round(Math.Atan(IM1 / R1), 2);
                ARG1 = Math.Atan(IM1 / R1);
                }
            else
                {
                //ARG1 = Math.Round((Math.Atan(IM1 / R1)) + complemento, 2);
                ARG1 = (Math.Atan(IM1 / R1) + complemento);
                }
            return ARG1;
        }       
       

        private void ButSuma_Click(object sender, EventArgs e)
        {
            obtenerVariables1();
            obtenerVariables2();
            if (esBinomio == true & esBinomio2 == true)
            {


                double R1 = Double.Parse(var1);
                double IM1 = Double.Parse(var2);
                double R2 = Double.Parse(vara);
                double IM2 = Double.Parse(varb);
                Double Resultado1 = Math.Round(R1 + R2, 4);
                Double Resultado2 = Math.Round(IM1 + IM2, 4);

                if (Resultado2 >= 0)
                {
                    lblResul.Text = Resultado1 + " + " + Resultado2 + " i";
                }
                else
                {
                    lblResul.Text = Resultado1 + " - " + Math.Abs(Resultado2) + " i";
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese los numeros en el formato binomico para la suma", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButResta_Click(object sender, EventArgs e)
        {
            obtenerVariables1();
            obtenerVariables2();

            if (esBinomio == true & esBinomio2)
            {


                double R1 = Double.Parse(var1);
                double IM1 = Double.Parse(var2);
                double R2 = Double.Parse(vara);
                double IM2 = Double.Parse(varb);
                Double Resultado1 = Math.Round(R1 - R2, 4);
                Double Resultado2 = Math.Round(IM1 - IM2, 4);

                if (Resultado2 >= 0)
                {
                    lblResul.Text = Resultado1 + " + " + Resultado2 + " i";
                }
                else
                {
                    lblResul.Text = Resultado1 + " - " + Math.Abs(Resultado2) + " i";
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese los numeros en el formato binomico para la resta", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ButMultiplic_Click(object sender, EventArgs e)
        {
            obtenerVariables1();
            obtenerVariables2();
            if (esBinomio == true & esBinomio2 == true)
            {
                double R1 = Double.Parse(var1);
                double IM1 = Double.Parse(var2);
                double R2 = Double.Parse(vara);
                double IM2 = Double.Parse(varb);
                Double Resultado1 = Math.Round((R1 * R2) + (IM1 * IM2 * (-1)), 4);
                Double Resultado2 = Math.Round((R1 * IM2) + (IM1 * R2), 4);

                if (Resultado2 >= 0)
                {
                    lblResul.Text = Resultado1 + " + " + Resultado2 + " i";
                }
                else
                {
                    lblResul.Text = Resultado1 + " - " + Math.Abs(Resultado2) + " i";
                }
            }
            else
            {
                if (esBinomio == false & esBinomio2 == false)
                {
                    double A = Double.Parse(var1);
                    double B = Double.Parse(var2);
                    double A2 = Double.Parse(vara);
                    double B2 = Double.Parse(varb);
                    Double Resultado1 = Math.Round((A * A2), 4);
                    Double Resultado2 = Math.Round(B + B2, 4);
                    lblResul.Text = "[ " + Resultado1 + " ;" + Resultado2 + " ]";

                }
                else
                {
                    MessageBox.Show("Por favor ingrese los numeros en el mismo formato para la multiplicación", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ButDivision_Click(object sender, EventArgs e)
        {
            obtenerVariables1();
            obtenerVariables2();
            if (esBinomio == true & esBinomio2 == true)
            {
                
                double R1 = Double.Parse(var1);
                double IM1 = Double.Parse(var2);
                double R2 = Double.Parse(vara);
                double IM2 = Double.Parse(varb);
                Double numreal1 = Math.Round((R1 * R2) + (IM1 * IM2), 4);
                Double numim2 = Math.Round((R2 * IM1) - (R1 * IM2), 4);
                Double denominador = Math.Round(Math.Pow(R2, 2) + Math.Pow(IM2, 2), 4);
                String partereal = numreal1 + " / " + denominador;
                String parteim = numim2 + " / " + denominador;

                if (denominador == 0)
                {

                    lblResul.Text = "Denominador es 0, no valido ";

                }
                else
                {
                    lblResul.Text = "(" + partereal + ")" + " + " + "(" + parteim + ")" + " i ";
                }
            }
            else
            {
                if (esBinomio2==false & esBinomio==false)
                {
                    double A = Double.Parse(var1);
                    double B = Double.Parse(var2);
                    double A2 = Double.Parse(vara);
                    double B2 = Double.Parse(varb);
                    Double Resultado1 = Math.Round((A / A2), 4);
                    Double Resultado2 = Math.Round(B - B2, 4);
                    lblResul.Text = "[ " + Resultado1 + " ;" + Resultado2 + " ]";
                }
                else
                {
                    MessageBox.Show("Por favor ingrese los numeros en el mismo formato para la division", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        public void obtenerVariables1()
        {
            string entrada = txtEntrada.Text;
            int largo = entrada.Length - 1;
            if (entrada[0] == '(' & entrada[largo] == ')')
            {
                esBinomio = true;
                entrada = entrada.TrimStart('(').TrimEnd(')');

            }
            else
            {
                if (entrada[0] == '[' & entrada[largo] == ']')
                {
                    esBinomio = false;
                    entrada = entrada.TrimStart('[').TrimEnd(']');
                }
                else
                {
                   MessageBox.Show("Por favor ingrese el numero en el formato", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                 
            }

            string[] entradasplit = entrada.Split(';');
            var1 = entradasplit[0];
            var2 = entradasplit[1];

        }

        public void obtenerVariables2()
        {
            string entrada2 = txtEntrada2.Text;
            int largo = entrada2.Length - 1;
            if (entrada2[0] == '(' & entrada2[largo] == ')')
            {
                esBinomio2 = true;
                entrada2 = entrada2.TrimStart('(').TrimEnd(')');

            }
            else
            {
                if (entrada2[0] == '[' & entrada2[largo] == ']')
                {
                    esBinomio2 = false;
                    entrada2 = entrada2.TrimStart('[').TrimEnd(']');
                }
                else
                {
                   MessageBox.Show("Por favor ingrese el numero en el formato", "Error en formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                 
            }

            string[] entradasplit2 = entrada2.Split(';');
            vara = entradasplit2[0];
            varb = entradasplit2[1];

        }
        public double obtenerReal(double a, double b)
        {
            double R = a * (Math.Cos(b));
            return R;
        }
        public double obtenerImg(double a, double b)
        {
            double I = a * (Math.Sin(b));
            return I;
        }

     
    }
}

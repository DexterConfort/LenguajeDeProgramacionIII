using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Proyecto
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void CalcularButton_Click(object sender, EventArgs e)
        {
                if (NumeroTextBox.Text == "") {
                    PosibleErrorProvider.SetError(NumeroTextBox, "Ingrese un Número");
                    return;}

            PosibleErrorProvider.Clear();
            decimal numero = Convert.ToInt32(NumeroTextBox.Text);
            ParOImpar(numero);
            Signo(numero);
            string estado = "", signo;

                if (ParOImpar(numero) == true) { estado = "Par"; }
                else estado = "Impar";

                if (Signo(numero) == true) { signo = "Positivo"; }
                else signo = "Negativo";

                if (numero == 0)
                {MessageBox.Show($"El número es Neutro {estado} ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);}
                else
                {MessageBox.Show($"El número es {signo} {estado} ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);}
        }
        private Boolean ParOImpar(decimal numero)
        {
            Boolean temp;
            if ((numero % 2) == 0)
            { temp = true; }
            else { temp = false; }
            return temp;
        }
        private Boolean Signo(decimal numero)
        {
            Boolean temp;
            if (numero > 0)
            { temp = true; }
            else { temp = false; }
            return temp;
        }
    }
}
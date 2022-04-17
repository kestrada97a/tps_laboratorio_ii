using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            

        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            char[] array = {' ', '+', '-', '*', '/' };
            cmbOperador.DataSource = array;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            string auxiliar = txtNumero1.Text + cmbOperador.Text + txtNumero2.Text + "=" + lblResultado.Text;
            lstOperaciones.Items.Add(auxiliar);
            

            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            
            return Calculadora.Operar(num1, num2, char.Parse(operador));

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar ==',')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }
    }
}

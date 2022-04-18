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

        /// <summary>
        /// carga los valores que van a ester en el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            char[] array = {' ', '+', '-', '*', '/' };
            cmbOperador.DataSource = array;

        }


        /// <summary>
        /// refleja el resultado q recibio como parametro en el label text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            string auxiliar = txtNumero1.Text + cmbOperador.Text + txtNumero2.Text + "=" + lblResultado.Text;
            if(cmbOperador.Text==" ")
            {
                auxiliar = txtNumero1.Text + "+" + txtNumero2.Text + "=" + lblResultado.Text;
            }
            lstOperaciones.Items.Add(auxiliar);
            

            
            
        }
        /// <summary>
        /// utiliza el limpiar() y limpia al presionar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        /// <summary>
        /// realiza las operaciones matematicas entre los parametros
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns> el resultado de las operaciones</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            
            return Calculadora.Operar(num1, num2, char.Parse(operador));

        }

        /// <summary>
        /// cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// evita que se escriban letras o caracteres no permitidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || e.KeyChar ==',' || e.KeyChar == '-')
            {

            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        /// <summary>
        /// Borra los valores de los texts, label y del combobox
        /// </summary>
        private void limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperador.Text = " ";
            
        }

        /// <summary>
        /// pregunta si esta seguro que desea cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// muestra el valor resultado de la operacion hecha convertido a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            
            lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// muestra el valor resultado de la operacion hecha convertido a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

            lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
        }
    }
}

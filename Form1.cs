using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textNumero1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textNumero2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtResultado.Text = " ";  // Inicializa o campo de texto com um espaço em branco
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja fechar ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Sair == DialogResult.Yes)
            {
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Operação cancelada");
            }

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = 0;  //Criando as variaveis para converter depois 
            double num2 = 0;

            num1 = Convert.ToDouble(textNumero1.Text);  // Converte o texto para double
            num2 = Convert.ToDouble(textNumero2.Text);

            switch (CboCalc.SelectedItem.ToString())  // Usei Switch para não usar várias IF / Else. Agrada mais os olhos.
            {
                case "Soma":
                    TxtResultado.Text = Convert.ToString(num1 + num2);
                    break;

                case "Subtração":
                    TxtResultado.Text = Convert.ToString(num1 - num2);
                    break;

                case "Multiplicação":
                    TxtResultado.Text = Convert.ToString(num1 * num2);
                    break;

                case "Divisão":
                    TxtResultado.Text = Convert.ToString(num1 / num2);
                    break;



                    
                    
            }
        }
        private void TextResultado_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {    
           
            textNumero1.Text = string.Empty;  // Limpa o campo
            textNumero2.Text = string.Empty;

            TxtResultado.Text = string.Empty;
            
        }

        private void TxtResultado_Click(object sender, EventArgs e)
        {

        }

        private void textNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere pressionado não é um número e não é o caractere de controle (backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Por favor, insira apenas números.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Impede que o caractere seja inserido na TextBox
                e.Handled = true;
            }
        }

        private void textNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere pressionado não é um número e não é o caractere de controle (backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Exibe uma mensagem de erro
                MessageBox.Show("Por favor, insira apenas números.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Impede que o caractere seja inserido na TextBox
                e.Handled = true;
            }
        }
    }


    

}




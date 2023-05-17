using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doceria
{
    public partial class FormValores : Form
    {
        Thread t2;
        Thread t3;
        Thread t4;
        public FormValores()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Cria uma lista de produtos com seus valores
            List<(string, double)> produtos = new List<(string, double)>
{
     ("Amargo", 39.90),
     ("Branco", 29.90),
     ("aoLeite", 34.90),
     ("Avela", 44.90),
     ("Salgado", 39.90)
    };



            // Soma apenas os produtos que foram selecionados
            double ValorFinal = 0.0;
            foreach ((string produto, double valor) in produtos)
            {
                // Obtém o valor da TextBox correspondente ao produto
                TextBox txtProduto = (TextBox)Controls.Find("txt" + produto, true)[0];
                double quantidade = Convert.ToDouble(txtProduto.Text);



                // Se a quantidade for maior que zero, adiciona o valor do produto à soma
                if (quantidade > 0)
                {
                    ValorFinal += quantidade * valor;
                }
            }



            // Exibe o valor final
            txtValor.Text = "Olá " + txtUsuario.Text + ", Sua compra ficou: R$" + ValorFinal.ToString();


        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormValores_Load(object sender, EventArgs e)
        {

        }

        private void txtAmargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFinal_Click(object sender, EventArgs e)
        {

        }

        private void btnFaleConosco_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(FaleConosco);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
        private void FaleConosco(object obj)
        {
            Application.Run(new FaleConosco());
        }

        private void btnPromocoes_Click(object sender, EventArgs e)
        {

        }

        private void btnServiços_Click(object sender, EventArgs e)
        
            {
                this.Close();
                t4 = new Thread(Servicos);
                t4.SetApartmentState(ApartmentState.STA);
                t4.Start();
            }
            private void Servicos(object obj)
            {
                Application.Run(new Servicos());
            }
        

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            t3 = new Thread(FormInicial);
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();
        }
        private void FormInicial(object obj)
        {
            Application.Run(new FormInicial());
        }

    }
}

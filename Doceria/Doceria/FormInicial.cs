using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Doceria
{
    public partial class FormInicial : Form
    {
        Thread t1 ;
        Thread t2 ;
        Thread t3 ;
        Thread t4 ;
        
        public FormInicial()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPromocoes_Click(object sender, EventArgs e)
        {

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
          this.Close();
            t1 = new Thread(produtos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void produtos(object obj)
        {
            Application.Run(new FormValores());
        }

        
    }
}

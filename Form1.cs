using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptografaDados
{
    public partial class Form1 : Form
    {
        string valorCriptografado;
        string valorCriptografado2;
        public Form1()
        {
            InitializeComponent();
        }

        public void CriptografaDados()
        {
            Criptografia c = new Criptografia(SHA512.Create());

            valorCriptografado = c.CriptografarSenha(txtTexto.Text);    
            lblResultado.Text = valorCriptografado;
            
        }

        public void testaDados()
        {
            Criptografia c = new Criptografia(SHA512.Create());

            bool resultado = c.VerificarSenha(txtAuxiliar.Text, valorCriptografado.ToString());   
            //MessageBox.Show(resultado.ToString());

            if (resultado)
            {
                MessageBox.Show("Senhas são iguais!");
            }
            else
            {
                MessageBox.Show("Senhas não são iguais!");
            }

        }

        private void btnCriptografa_Click(object sender, EventArgs e)
        {
            CriptografaDados();
        }

        private void btnDecriptografar_Click(object sender, EventArgs e)
        {
            testaDados();
        }
    }
}

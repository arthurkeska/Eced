using Eced.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarNota_Click(object sender, EventArgs e)
        {
            //1 função no BAL que recebe o nome de todos os alunos
            int result = Controller.VerificaInputs(txtAssuntoNota.Text, txtNota.Text);
            if (result == 1)
            {
                MessageBox.Show("Nota adicionada!");
            }
            else if (result == -1)
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
            }
            else
            {                
                MessageBox.Show("Nota inserida incorretamente!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbMateriaNota.Items.Add("Alemão");
            cbMateriaNota.Items.Add("Artes");
            cbMateriaNota.Items.Add("Ciências");
            cbMateriaNota.Items.Add("Educação Física");
            cbMateriaNota.Items.Add("Ensino Religioso");
            cbMateriaNota.Items.Add("Inglês");
            cbMateriaNota.Items.Add("Geografia");
            cbMateriaNota.Items.Add("História");
            cbMateriaNota.Items.Add("Matemática");
            cbMateriaNota.Items.Add("Português");
            cbMateriaNota.Text = "Português";
        }
    }
}

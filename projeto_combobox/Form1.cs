using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(txtTexto.Text);

            lblQtde.Text = cboLista.Items.Count.ToString();
            txtTexto.Clear();
            txtTexto.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cboLista.Sorted = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                txtConteudo.Text = cboLista.SelectedItem.ToString();
                txtIndice.Text = cboLista.SelectedIndex.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cboLista.SelectedIndex != -1)
            {
                cboLista.Items.RemoveAt(cboLista.SelectedIndex);
                lblQtde.Text = cboLista.Items.Count.ToString();
                cboLista.ResetText();
            }
        }
    }
}

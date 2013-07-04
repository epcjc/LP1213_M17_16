using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.professoresTableAdapter.Insert(this.textBox1.Text);       
                MessageBox.Show("Inserido com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void professoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Preencher Professor");
            }
            else
            {
                errorProvider1.Dispose();
                MessageBox.Show("Inserido com Sucesso");
            }
        }
    }
}

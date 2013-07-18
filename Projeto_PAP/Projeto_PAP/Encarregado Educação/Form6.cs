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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            //this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            // TODO: This line of code loads data into the 'database1DataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet.Turmas);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                //this.alunoTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text, Convert.ToInt16(this.comboBox1.SelectedValue));
                MessageBox.Show("Inserido com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Preencher Aluno");
            }
            else
            {
                errorProvider1.Dispose();
                MessageBox.Show("Inserido com Sucesso");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider2.SetError(textBox1, "Preencher Encarregado de Educação");
            }
            else
            {
                errorProvider2.Dispose();
                MessageBox.Show("Inserido com Sucesso");
            }
        }

                
    }
}

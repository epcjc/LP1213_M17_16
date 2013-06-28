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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.DataTable3' table. You can move, or remove it, as needed.
            this.dataTable3TableAdapter.FillAluno_DT(this.database1DataSet.DataTable3);
            // TODO: This line of code loads data into the 'database1DataSet.Enc_Educação' table. You can move, or remove it, as needed.
            this.enc_EducaçãoTableAdapter.FillEncEducação(this.database1DataSet.Enc_Educação);
             // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
            // TODO: This line of code loads data into the 'database1DataSet.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.Fill(this.database1DataSet.Ocorrencia);
            
        }

        private void ocorrenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ocorrenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ocorrenciaTableAdapter.Insert(Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), this.textBox2.Text, this.textBox3.Text, Convert.ToInt16(this.comboBox3.SelectedValue), Convert.ToInt16(this.comboBox4.SelectedValue), Convert.ToDateTime(this.textBox1.Text), this.textBox4.Text);
                MessageBox.Show("Inserido com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

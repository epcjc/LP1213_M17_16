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
            // TODO: This line of code loads data into the 'database1DataSet.Medida_Disciplinar' table. You can move, or remove it, as needed.
            this.medida_DisciplinarTableAdapter.Fill(this.database1DataSet.Medida_Disciplinar);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno_Enc' table. You can move, or remove it, as needed.
            this.aluno_EncTableAdapter.FillAlunoEncEduc(this.database1DataSet.Aluno_Enc);
            // TODO: This line of code loads data into the 'database1DataSet.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet.Aluno);
            // TODO: This line of code loads data into the 'database1DataSet.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.Fill(this.database1DataSet.Ocorrencia);
            // TODO: This line of code loads data into the 'database1DataSet.TurmaDT' table. You can move, or remove it, as needed.
            this.turmaDTTableAdapter.FillTurmaDT(this.database1DataSet.TurmaDT);
            // TODO: This line of code loads data into the 'database1DataSet.Professores' table. You can move, or remove it, as needed.
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);
            // TODO: This line of code loads data into the 'database1DataSet.Faltas' table. You can move, or remove it, as needed.
            this.faltasTableAdapter.FillOcorrência(this.database1DataSet.Faltas);
            // TODO: This line of code loads data into the 'database1DataSet.Faltas' table. You can move, or remove it, as needed.
            this.faltasTableAdapter.FillOcorrência(this.database1DataSet.Faltas);
            // TODO: This line of code loads data into the 'database1DataSet.Faltas' table. You can move, or remove it, as needed.
            this.faltasTableAdapter.FillOcorrência(this.database1DataSet.Faltas);
            this.professoresTableAdapter.Fill(this.database1DataSet.Professores);
            
        }

        private void ocorrenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.ocorrenciaTableAdapter.Insert(this.textBox6.Text, this.textBox7.Text, Convert.ToInt16(this.comboBox5.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), this.textBox10.Text, this.textBox1.Text, Convert.ToInt16(this.comboBox4.SelectedValue), Convert.ToDateTime(this.textBox2.Text), Convert.ToDateTime(this.textBox11.Text), this.textBox8.Text, Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox6.SelectedValue));
             
                MessageBox.Show("Inserido com Sucesso");
                this.Close();
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

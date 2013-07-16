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
                
                //this.faltasTableAdapter.Insert(this.textBox1.Text, Convert.ToInt16(this.comboBox3.SelectedValue), this.textBox3.Text, this.textBox4.Text, this.textBox5.Text, Convert.ToInt16(this.comboBox1.SelectedValue), Convert.ToInt16(this.comboBox2.SelectedValue), this.textBox6.Text, this.textBox7.Text, Convert.ToDateTime(this.textBox2.Text), this.textBox8.Text);
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

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
    public partial class CriarOcorrência : Form
    {
        public CriarOcorrência()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CriarOcorrência_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Ocorrencia' table. You can move, or remove it, as needed.
            this.ocorrenciaTableAdapter.Fill(this.database1DataSet1.Ocorrencia);
            // TODO: This line of code loads data into the 'database1DataSet1.Aluno' table. You can move, or remove it, as needed.
            this.alunoTableAdapter.Fill(this.database1DataSet1.Aluno);
            // TODO: This line of code loads data into the 'database1DataSet1.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.database1DataSet1.Turmas);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox3.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ndias = 0;
                if (radioButton1.Checked == true)
                {
                    ndias = Convert.ToInt16(this.textBox3.Text);
                }

                this.ocorrenciaTableAdapter.Insert(Convert.ToInt16(this.listBox1.SelectedValue),
                    null,
                    null,
                    textBox2.Text,
                    this.dateTimePicker1.Value,
                    this.textBox5.Text,
                    null,
                    null,
                    null,
                    ndias,
                    "aberta");


                this.Close();
            }
            catch
            {
                MessageBox.Show("ERRO");
            }
                

        }

        
       

            }
}

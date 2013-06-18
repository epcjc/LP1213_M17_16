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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

                private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Turma_DiretorTurma' table. You can move, or remove it, as needed.
            this.turma_DiretorTurmaTableAdapter.FillDiretorTurma(this.database1DataSet.Turma_DiretorTurma);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //this.turma_DiretorTurmaTableAdapter.Insert(this.textBox1.Text, this.textBox2.Text);
                MessageBox.Show("Inserido com Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        



        
    }
}

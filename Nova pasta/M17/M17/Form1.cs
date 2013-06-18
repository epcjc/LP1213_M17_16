using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet.Diretor_Turma' table. You can move, or remove it, as needed.
            //this.diretor_TurmaTableAdapter.Fill(this.baseDadosDataSet.Diretor_Turma);
            // TODO: This line of code loads data into the 'baseDadosDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.baseDadosDataSet.Turmas);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.diretor_TurmaTableAdapter.Fill(this.baseDadosDataSet.Diretor_Turma);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

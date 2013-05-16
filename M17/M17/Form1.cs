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
            // TODO: This line of code loads data into the 'baseDadosDataSet.Turmas' table. You can move, or remove it, as needed.
            this.turmasTableAdapter.Fill(this.baseDadosDataSet.Turmas);
            // TODO: This line of code loads data into the 'baseDadosDataSet._Turma_DiretorTurma' table. You can move, or remove it, as needed.
            this.turma_DiretorTurmaTableAdapter.FillDiretorTurma(this.baseDadosDataSet._Turma_DiretorTurma);
        

        }

        
    }
}

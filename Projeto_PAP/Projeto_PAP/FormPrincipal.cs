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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pesquisa_DiretorTurma frm = new Pesquisa_DiretorTurma();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOcorrenciasAbertas frm = new frmOcorrenciasAbertas();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CriarOcorrência frm = new CriarOcorrência();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Relatórios frm = new Relatórios();
            frm.ShowDialog();
        }

         private void button9_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ajuda.chm");
        }

        

        
        
        

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PAP
{
    public partial class Form2 : Form
    {
        


        
        
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.ShowDialog();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Apagar_DiretorTurma frm = new Apagar_DiretorTurma();
            frm.ShowDialog();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pesquisa_DiretorTurma frm = new Pesquisa_DiretorTurma();
            frm.ShowDialog();
           
        }


       

       

       

        

        
    }
}

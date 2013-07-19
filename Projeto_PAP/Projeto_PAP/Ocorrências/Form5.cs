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

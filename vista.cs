using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonReiniciar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
               
           String entrada = textBox1.Text;
           AnalizadorLexico lex = new Se();
                LinkedList<Token> ltokens = lex.escanear(entrada);
                buttonReiniciar.Enabled = true;
                buttonReiniciar.BackColor = Color.Blue;
                textBox1.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            buttonIniciar.Enabled = true;
            buttonReiniciar.Enabled = false;

        }
    }
}

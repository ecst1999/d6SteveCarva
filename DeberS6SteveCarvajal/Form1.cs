using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeberS6SteveCarvajal.Models;

namespace DeberS6SteveCarvajal
{
    public partial class Form1 : Form
    {
        DBConection<Estudiante> bd = new DBConection<Estudiante>("bdEst.json");
        public Form1()
        {
            InitializeComponent();
            bd.Cargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estudiante e1 = new Estudiante(comboBox1.Text, textBox1.Text);
            e1.registarAsistencia();
            bd.Actualizar(x => x.Identificacion == comboBox1.Text.ToString(), e1);
            //bd.Insertar(e1);

            richTextBox1.AppendText(e1.Nombres + " " + e1.Identificacion + " " + e1.FechaAsistencia[0] + "\n");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {      
            if (comboBox1.Text == "0123456789")
            {
                textBox1.Text = "Steve Carvajal".ToString();
            }else if(comboBox1.Text == "3216549870")
            {
                textBox1.Text = "Hernesto Suarez".ToString();
            }else if(comboBox1.Text == "6549873210")
            {
                textBox1.Text = "Juan Perez".ToString();
            }else if(comboBox1.Text == "3021654987")
            {
                textBox1.Text = "Carmen Acosta".ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

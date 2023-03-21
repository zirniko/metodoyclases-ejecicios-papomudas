using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetodosYclasesEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsumar_Click(object sender, EventArgs e)
        {
            try
            {
                //coloco el nombre de la clase y las valiables en este caso es 'op'
                Operaciones op = new Operaciones();
                MessageBox.Show("La suma es: " + op.Sumar(Convert.ToInt32(txtnum1.Text),
                                                         Convert.ToInt32(txtnum2.Text)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Btnmultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones op = new Operaciones();
                MessageBox.Show("La Multiplicasion es: " + op.Multiplicar(Convert.ToInt32(txtnum1.Text),
                                                         Convert.ToInt32(txtnum2.Text)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones op = new Operaciones();
                MessageBox.Show("La Resta es: " + op.Restar(Convert.ToInt32(txtnum1.Text),
                                                         Convert.ToInt32(txtnum2.Text)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BtnDivicion_Click(object sender, EventArgs e)
        {
            try
            {
                Operaciones op = new Operaciones();
                MessageBox.Show("La Divicion es: " + op.Divicion(Convert.ToInt32(txtnum1.Text),
                                                         Convert.ToInt32(txtnum2.Text)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}


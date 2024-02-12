using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Presupuesto_Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_distribuir_Click(object sender, EventArgs e)
        {
            Double porcentaje, emergencia, cirugia, suministros, administraccion, laboratorio, imagenes_diagnosticas;



            porcentaje = Double.Parse(txt_porcentaje.Text);

            emergencia = (porcentaje * 30) / 100;
            cirugia = (porcentaje * 15) / 100;
            suministros = (porcentaje * 25) / 100;
            administraccion = (porcentaje * 18) / 100;
            laboratorio = (porcentaje * 5) / 100;
            imagenes_diagnosticas = (porcentaje * 7) / 100;


            txt_emergencia.Text = emergencia.ToString();
            txt_cirugia.Text = cirugia.ToString();
            txt_suministros.Text = suministros.ToString();
            txt_administraccion.Text = administraccion.ToString();
            txt_laboratorio.Text = laboratorio.ToString();
            txt_imagenes_diagnosticas.Text = imagenes_diagnosticas.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_emergencia.Clear();
            txt_cirugia.Clear();
            txt_suministros.Clear();
            txt_administraccion.Clear();
            txt_laboratorio.Clear();
            txt_imagenes_diagnosticas.Clear();
            txt_porcentaje.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}

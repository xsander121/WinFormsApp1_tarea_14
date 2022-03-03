using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_mostrar_Click(object sender, EventArgs e)
        {
            //Perro
            Perro perro = new Perro();
            perro.Nombre = "Fido";
            perro.Edad = 4;
            perro.Nro_patas = 4;
            perro.Altura = 31.5;
            perro.Raza = "Bulldog";
            perro.Color = "Cafe";

            //Gato
            Gato gato = new Gato();
            gato.Nombre = "Figaro";
            gato.Edad = 2;
            gato.Nro_patas = 4;
            gato.Tamaño_bigote = 3.2;
            gato.Pelo = "Corto";
            gato.Garra = "Retractiles";

            //Canario
            Canario canario = new Canario();
            canario.Nombre = "Piolin";
            canario.Edad = 3;
            canario.Nro_patas = 2;
            canario.Pico = "Corto punteagudo";
            canario.Plumaje = "Amarillo";

            mostrar_perro(perro);
            mostrar_gato(gato);
            mostrar_canario(canario);
        }

        public void mostrar_perro(Perro perro) {
            txtBx_salida.AppendText(
                "---Perro---" +
                "\r\nNombre: " + perro.Nombre +
                "\r\nEdad: " + perro.Edad +
                "\r\nNro de Patas: " + perro.Nro_patas +
                "\r\nAltura: " + perro.Altura +
                "\r\nRaza: " + perro.Raza +
                "\r\nColor: " + perro.Color + "\r\n");
        }

        public void mostrar_gato(Gato gato) {
            txtBx_salida.AppendText(
                "---Gato---" +
                "\r\nNombre: " + gato.Nombre +
                "\r\nEdad: " + gato.Edad +
                "\r\nNro de Patas: " + gato.Nro_patas +
                "\r\nTamaño del bigote: " + gato.Tamaño_bigote +
                "\r\nPelo: " + gato.Pelo +
                "\r\nGarra: " + gato.Garra + "\r\n");
        }

        public void mostrar_canario(Canario canario)
        {
            txtBx_salida.AppendText(
                "---Canario---" +
                "\r\nNombre: " + canario.Nombre +
                "\r\nEdad: " + canario.Edad +
                "\r\nNro de Patas: " + canario.Nro_patas +
                "\r\nPico: " + canario.Pico+
                "\r\nPlumaje: " + canario.Plumaje + "\r\n");
        }

        private void txtBx_salida_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de salida no puede recibir valores.
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
    }
}

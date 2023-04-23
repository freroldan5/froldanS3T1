using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace froldanS2T1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //declaracion de variables
            double datoseg1, datoexa1, ns1, ne1, parcial1, datoseg2, datoexa2, ns2, ne2, parcial2, notafinal;
            //intentar convertir los valores ingresados en los cuadros de texto a valores numéricos
            if (double.TryParse(txtNotaSeg1.Text, out datoseg1) && double.TryParse(txtExa1.Text, out datoexa1) && double.TryParse(txtNotaSeg2.Text, out datoseg2) && double.TryParse(txtExa2.Text, out datoexa2))
            {
                //Validar datos ingresados entre 0.1 a 10
                if (datoseg1 >= 0.1 && datoseg1 <= 10 && datoexa1 >= 0.1 && datoexa1 <= 10 && datoseg2 >= 0.1 && datoseg2 <= 10 && datoexa2 >= 0.1 && datoexa2 <= 10)
                {
                    ns1 = datoseg1 * 0.3;
                    ne1 = datoexa1 * 0.2;
                    parcial1 = ns1 + ne1;

                    ns2 = datoseg2 * 0.3;
                    ne2 = datoexa2 * 0.2;
                    parcial2 = ns2 + ne2;

                    notafinal = parcial1 + parcial2;

                    txtDatoresultado.Text = notafinal.ToString();

                    string mensaje;

                    //comparacion para el mensaje
                    if (notafinal >= 7)
                    {
                        mensaje = "Aprobado";
                    }
                    else if (notafinal >= 5 && notafinal <= 6.9)
                    {
                        mensaje = "Complementario";
                    }
                    else
                    {
                        mensaje = "Reprobado";
                    }

                    DisplayAlert("Estado de Calificación", "Su nota es: "+ notafinal +" "+ mensaje, "cerrar");
                }
                else
                {
                    DisplayAlert("Error", "Los números ingresados deben estar en el rango de 0.1 a 10", "cerrar");
                }
            }
            else
            {
                DisplayAlert("Error", "Ingrese números válidos en todos los campos", "cerrar");
            }
        }
        //Limpiar datos
        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNotaSeg1.Text = "";
            txtExa1.Text = "";
            txtNotaSeg2.Text = "";
            txtExa2.Text = "";
            txtDatoresultado.Text = "";
        }
    }
}
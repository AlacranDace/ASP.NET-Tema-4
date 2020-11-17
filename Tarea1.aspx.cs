using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tema4
{
    public partial class Tarea1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddButton_Click(object sender, EventArgs e)
        {
            int solucion;
            string operacion;
            //Comprobamos que el formato de los campos sea un numero entero
            int a = 0;
            string  valorA = valor1.Value;
            bool resultA = int.TryParse(valorA, out a);

            int b = 0;
            string valorB = valor2.Value;
            bool resultB = int.TryParse(valorB, out b);

            //Recogemos el valor de la operación a realizar
            operacion = DropDownList1.SelectedValue;

            //Si todos los numeros son enteros realizaremos la operacion, sino lo son mostraremos un mensaje
            if (resultA & resultB)
            {

                switch (operacion)
                {
                    case "Sumar":
                        //solucion = Convert.ToInt32(a) + Convert.ToInt32(b); No es necesario pues ya comprobamos antes
                        solucion = a + b;
                        break;
                    case "Restar":
                        solucion = a - b;
                        break;
                    case "Multiplicar":
                        solucion = a * b;
                        break;
                    default: //Si no lo ponía me daba un error. No debería entrar nunca aqui porque siempre está seleccionada una opcion
                        solucion = 0;
                        break;
                }

                resultado.Text = "El resultado de la operación es: " + Convert.ToString(solucion);

            } else {
                resultado.Text = "Se deben introducir solamente números enteros";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tema4
{
    public partial class JuegoCalculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Nuevo_Click(object sender, EventArgs e)
        {
            Sumando1.Text = "";
            Sumando2.Text = "";
            Resultado.Text = "";
            Mensaje.Text = "";

            Random rnd = new Random();
            int sum1 = rnd.Next(1, 20);
            int sum2 = rnd.Next(1, 20);

            Sumando1.Text = sum1.ToString();
            Sumando2.Text = sum2.ToString();


        }

        protected void Comprobar_Click(object sender, EventArgs e)
        {
            string sum1string = Sumando1.Text;
            string sum2string = Sumando2.Text;
            string resultadoString = Resultado.Text;


            //Comprobamos que el formato de los campos sea un numero entero
            int sum1 = 0;
            string valor1 = sum1string;
            bool result1 = int.TryParse(valor1, out sum1);

            int sum2 = 0;
            string valor2 = sum2string;
            bool result2 = int.TryParse(valor2, out sum2);

            int resultado = 0;
            bool resultadoBien = int.TryParse(resultadoString, out resultado);

            //Si todos los numeros son enteros realizaremos la operacion, sino lo son mostraremos un mensaje
            if (result1 & result2 & resultadoBien)
            {
                int resultadoComprobado = sum1 + sum2;
                if (resultado == resultadoComprobado)
                {
                    Mensaje.Text = "Resultado correcto enhorabuena";
                } else
                {
                    Mensaje.Text = resultado+"!!! Resultado incorreto, el resultado correcto era: "+ resultadoComprobado;
                }
            }
            else
            {
                Mensaje.Text = "Se deben introducir solamente números enteros";
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricaCEAPE.Vistas;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace FabricaCEAPE.Clases
{
    class Validacion 
    {
        public static bool esNumero(Control mitextbox)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esCadena(Control mitextbox)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-]+[^ ]$"); //@"^[^ ][a-zA-Z ]+[^ ]$"
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esCadenaNumero(Control mitextbox)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-ZàáâäãåąčćęèéêëėįìíîïłńòóôöõøùúûüųūÿýżźñçčšžÀÁÂÄÃÅĄĆČĖĘÈÉÊËÌÍÎÏĮŁŃÒÓÔÖÕØÙÚÛÜŲŪŸÝŻŹÑßÇŒÆČŠŽ∂ð ,.'-°: 0-9]+[^ ]$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esTiempo(Control mitextbox)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-Z 0-9:]+[^ ]$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esCadenaNumeroPunto(Control mitextbox)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\s\,\.\''\-]*$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esTelefono(Control mitextbox)
        {
            Regex regex = new Regex(@"^\+?\d{1,3}?[- .]?\(?(?:\d{2,3})\)?[- .]?\d\d\d[- .]?\d\d\d\d$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esDecimal(Control mitextbox)
        {
            Regex regex = new Regex(@"^[0-9]{1,9}([\.\,][0-9]{1,3})?$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esUrl(Control mitextbox)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esEmail(Control mitextbox)
        {
            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esNombreUsuario(Control mitextbox)
        {
            Regex regex = new Regex(@"^[a-z\d_]{4,15}$");
            return regex.IsMatch(mitextbox.Text);
        }

        public static bool esContrasena(Control mitextbox)
        {
            Regex regex = new Regex(@"^.{4,8}$");
            return regex.IsMatch(mitextbox.Text);
        }             
    }
}

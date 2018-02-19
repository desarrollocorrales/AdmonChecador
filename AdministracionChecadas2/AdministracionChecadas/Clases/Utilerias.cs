using DescargarChecadas.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionChecadas.Clases
{
    public class Utilerias
    {
        Validador validador = new Validador();
        public bool teclapresionda(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = true;
                if (Char.IsLetter(tecla.KeyChar))
                    resultado = true;
                //tecla.Handled = true;
                if ((Char.IsNumber(tecla.KeyChar) || Char.IsPunctuation(tecla.KeyChar)) || tecla.KeyChar.ToString() == "\b")
                    resultado = false;

                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool teclaNumero(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = false;
                if (!validador.EsNumeroEntero(tecla.KeyChar.ToString()) && tecla.KeyChar.ToString() != "\b")
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool teclaEnter(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = false;
                if ((int)tecla.KeyChar == (int)Keys.Enter)
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

    }


    public class Seguridad
    {
        /// Performs the ROT13 character rotation.
        public string Transform(string valor)
        {
            char[] array = valor.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        // Codificar cadena a Base64
        public string Base64Encode(string valor)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(valor);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        // Decodificar cadena a Base64
        public string Base64Decode(string valor)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(valor);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }



}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cheques
{
    internal class HelperMethods
    {
        public static void placeholderController(TextBox label, string placeholer)
        {
            if (label.Text.Equals(placeholer))
            {
                if (label.Text.ToLower().Contains("contraseña")) label.UseSystemPasswordChar = true;
                label.Text = "";
                label.ForeColor = Color.Black;
                return;
            }
            if (label.Text.Equals(""))
            {
                placeholderDesign(label, placeholer);
                if (label.Text.ToLower().Contains("contraseña")) label.UseSystemPasswordChar = false;
            }
        }

        public static void placeholderDesign(TextBox label, string text)
        {
            label.Text = text;
            label.ForeColor = Color.DimGray;
        }

        public static bool IsNumeric(string str)
        {
            bool isNumeric = str.All(char.IsDigit);
            return isNumeric;
        }
    }
}

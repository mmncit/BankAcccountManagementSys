using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicAccount
{
    public static class Validator
	{
		private static string title = "Entry Error";
        
        public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsPositive(TextBox textBox) {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number > 0.0m)
                return true;
            else
            {
                MessageBox.Show(textBox.Tag + " must be a positive value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsGreaterThanEq(TextBox textBox, int min)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number >= min)
                return true;
            else
            {
                MessageBox.Show(textBox.Tag + " be greater than or equal to " + min + ".", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, float min, float max)
		{
			float number = (float) Convert.ToDouble(textBox.Text);
			if (number <= min || number >= max) // range is exclusive
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}
	}
}

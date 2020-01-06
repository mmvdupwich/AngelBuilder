using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngelBuilder
{
    public class Functions
    {
        public void Intmaker(int input)
        {
			try
			{
				Convert.ToInt32(input);
			}
			catch (FormatException)
			{

				MessageBox.Show("You didn't put in a valid number.");
				
			}
        }
    }
}

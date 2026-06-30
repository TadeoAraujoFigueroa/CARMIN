

using CARMIN___APP.Controls.CARMIN.UI.Controls;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace CARMIN___BLL.Helper
{
    public static class ValidationHelper
    {
        public static bool TextBoxAreEmpty(Control parent)
        {
            return GetAllControls(parent).OfType<CyberTextBox>().Any(textBox => string.IsNullOrWhiteSpace(textBox.TextButton));
        }

        private static List<Control> GetAllControls(Control parent)
        {
            try
            {
                List<Control> totalControls = new List<Control>();

                foreach (Control control in parent.Controls) 
                { 
                    totalControls.Add(control);

                    if (control.HasChildren)
                    {
                        totalControls.AddRange(GetAllControls(control));
                    }

                }

                return totalControls;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}

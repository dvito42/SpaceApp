using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image7.AlternateText = "Uranus";
        }
        protected void Timer7_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label7.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image7.ImageUrl = "Images/Uranus/PIA18182_small.jpg";
                    break;
                case 2:
                    Image7.ImageUrl = "Images/Uranus/PIA02963_small.jpg";
                    break;
                case 3:
                    Image7.ImageUrl = "Images/Uranus/PIA01280_orig.jpg";
                    break;
                case 4:
                    Image7.ImageUrl = "Images/Uranus/PIA00370_small.jpg";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label7.Text = textSwitch;
            }
        }
    
    }
}
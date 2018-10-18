using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image9.AlternateText = "Pluto";
        }
        protected void Timer9_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label9.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image9.ImageUrl = "Images/Pluto/PIA21965_orig.jpg";
                    break;
                case 2:
                    Image9.ImageUrl = "Images/Pluto/PIA20155_small.jpg";
                    break;
                case 3:
                    Image9.ImageUrl = "Images/Pluto/PIA20543_orig.jpg";
                    break;
                case 4:
                    Image9.ImageUrl = "Images/Pluto/PIA20732_small.jpg";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label9.Text = textSwitch;
            }
        }
    
    }
}
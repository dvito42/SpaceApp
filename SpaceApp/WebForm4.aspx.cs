using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image4.AlternateText = "Venus";
        }
        protected void Timer4_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label4.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image4.ImageUrl = "Images/Venus/PIA00072_small.jpg";
                    break;
                case 2:
                    Image4.ImageUrl = "Images/Venus/PIA00270_small.jpg";
                    break;
                case 3:
                    Image4.ImageUrl = "Images/Venus/PIA00109_small.jpg";
                    break;
                case 4:
                    Image4.ImageUrl = "Images/Venus/PIA00234_small.jpg";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label4.Text = textSwitch;
            }
        }
    
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image6.AlternateText = "Saturn";
        }
        protected void Timer6_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label6.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image6.ImageUrl = "Images/Saturn/PIA01482_small.jpg";
                    break;
                case 2:
                    Image6.ImageUrl = "Images/Saturn/PIA01966_small.jpg";
                    break;
                case 3:
                    Image6.ImageUrl = "Images/Saturn/PIA06423_small.jpg";
                    break;
                case 4:
                    Image6.ImageUrl = "Images/Saturn/PIA14946_small.jpg";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label6.Text = textSwitch;
            }
        }
    
    }
}

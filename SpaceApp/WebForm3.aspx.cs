using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class WebForm31 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image3.AlternateText = "Mercury";
        }
        protected void Timer3_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label3.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image3.ImageUrl = "Images/Mercury/PIA11360_small.jpg";
                    break;
                case 2:
                    Image3.ImageUrl = "Images/Mercury/PIA16549_small.jpg";
                    break;
                case 3:
                    Image3.ImageUrl = "Images/Mercury/PIA10635_orig.jpg";
                    break;
                case 4:
                    Image3.ImageUrl = "Images/Mercury/PIA15862_small.jpg";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label3.Text = textSwitch;
            }
        }
    }
}
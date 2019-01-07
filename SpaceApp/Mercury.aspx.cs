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
                    Image3.ImageUrl = "Images/Mercury/PIA17622_small.png";
                    LabelMercury.Text = "Crescent Mercury: This image was acquired as part of the MDIS's (Mercury Dual Imaging System) limb imaging campaign.";
                    break;
                case 2:
                    Image3.ImageUrl = "Images/Mercury/PIA11360_small.png";
                    LabelMercury.Text = "Mercury Through Time: This image shows a northern portion of Mercury’s surface, looking at the terminator.";
                    break;
                case 3:
                    Image3.ImageUrl = "Images/Mercury/PIA10635_small.png";
                    LabelMercury.Text = "“The Spider” – Radial Troughs within Caloris on Mercury.";
                    break;
                case 4:
                    Image3.ImageUrl = "Images/Mercury/PIA15862_small.png";
                    LabelMercury.Text = "Mickey Mouse Spotted on Mercury! This scene is to the northwest of the recently named crater Magritte, in Mercury's south.";
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
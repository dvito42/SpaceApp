using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Uranus : System.Web.UI.Page
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
                    Image7U.ImageUrl = "Images/Uranus/PIA18182_small.jpg";
                    LabelUranus.Text = "Uranus as seen by NASA's Voyager 2.";
                    break;
                case 2:
                    Image7U.ImageUrl = "Images/Uranus/PIA02963_small.jpg";
                    LabelUranus.Text = "NASA Hubble Space Telescope view reveals Uranus surrounded by its four major rings and by 10 of its 17 known satellites. ";
                    break;
                case 3:
                    Image7U.ImageUrl = "Images/Uranus/PIA01280_orig.jpg";
                    LabelUranus.Text = "Hubble captures detailed image of Uranus' atmosphere.";
                    break;
                case 4:
                    Image7U.ImageUrl = "Images/Uranus/PIA00370_small.jpg";
                    LabelUranus.Text = "False-color picture of Uranus from NASA's Voyager shows a discrete cloud seen as a bright streak near the planet's limb.";
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
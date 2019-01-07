using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Pluto : System.Web.UI.Page
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
                    Image9P.ImageUrl = "Images/Pluto/PIA21965_orig.jpg";
                    LabelPluto.Text = "Pluto's bladed terrain as seen from NASA's New Horizons during its July 2015 flyby.";
                    break;
                case 2:
                    Image9P.ImageUrl = "Images/Pluto/PIA20155_small.jpg";
                    LabelPluto.Text = "NASA's New Horizons scientists believe that the informally named features Wright Mons and Piccard Mons could have been formed by the 'cryovolcanic' eruption of ices from beneath Pluto's surface.";
                    break;
                case 3:
                    Image9P.ImageUrl = "Images/Pluto/PIA20543_orig.jpg";
                    LabelPluto.Text = "This feature appears to be a frozen, former lake of liquid nitrogen, located in a mountain range just north of Pluto's informally named Sputnik Planum.";
                    break;
                case 4:
                    Image9P.ImageUrl = "Images/Pluto/PIA20732_small.jpg";
                    LabelPluto.Text = "NASA's New Horizons spacecraft image of the southeastern portion of Pluto's great ice plains.";
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
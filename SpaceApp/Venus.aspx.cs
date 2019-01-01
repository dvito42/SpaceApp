using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Venus : System.Web.UI.Page
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
                    Image4.ImageUrl = "Images/Venus/PIA00072_small480.png";
                    LabelVenus.Text = "Venus Cloud Patterns (colorized and filtered): This picture of Venus was taken by the Galileo spacecrafts Solid State Imaging System.";
                    break;
                case 2:
                    Image4.ImageUrl = "Images/Venus/PIA00270_small480.png";
                    LabelVenus.Text = "Venus - Computer Simulated Global View Centered at 90 Degrees East Longitude based on Magellan radar mapping.";
                    break;
                case 3:
                    Image4.ImageUrl = "Images/Venus/PIA00109_small480.png";
                    LabelVenus.Text = "3-D Perspective View of Idem-Kuva: A corona is displayed in this computer-simulated view of the surface of Venus.";
                    break;
                case 4:
                    Image4.ImageUrl = "Images/Venus/PIA00234_small480.png";
                    LabelVenus.Text = "Venus - 3-D Perspective View of Gula Mons ";
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
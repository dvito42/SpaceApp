using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
  public partial class Moon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          Image1.AlternateText = "The earth and the moon.";
        }

        //Timer1_Tick will cycle through 5 pictures every 5 seconds
        //Label1.Text contains the number of the picture. 
        //Label1.Text needs to be numeric or the slideshow breaks.

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label1.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            switch (caseSwitch)
            {
            // Set the next picture and set n to the next number
                case 1:
                    Image1.ImageUrl = "Images/Moon/6901249_small.jpg";
                    LabelMoon.Text = "Detailed view of the back side of Moon taken during the Apollo 11 mission.";
                    break;
                case 2:
                    Image1.ImageUrl = "Images/Moon/AS12-46-6728_small.jpg";
                    LabelMoon.Text = "Astronaut Alan L. Bean climbing down the ladder of the Lunar Module (LM).";
                    break;
                case 3:
                    Image1.ImageUrl = "Images/Moon/apollo_16_small.png";
                    LabelMoon.Text = "Astronaut John Young leaps from lunar surface to salute flag.";
                    break;
                case 4:
                    Image1.ImageUrl = "Images/Moon/as11-44-6551_small.jpg";
                    LabelMoon.Text = "View of Earth rising over Moon's horizon taken from Apollo 11 spacecraft.";
                    break;
                default:
                    break;
            }

            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                Label1.Text = caseSwitch.ToString();
                //Label1.Text = textSwitch;
            }
        }
  }
}
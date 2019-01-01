using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SpaceApp
{
    public partial class Jupiter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ImageJ5.AlternateText = "Jupiter";
        }
        protected void Timer5_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label5.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    ImageJ5.ImageUrl = "Images/Jupiter/PIA02972_orig.png";
                    LabelJupiter.Text = "Color image of Jupiter taken by NASA's Cassini spacecraft from 81.3 million kilometers (50.5 million miles) away.";
                    break;
                case 2:
                    ImageJ5.ImageUrl = "Images/Jupiter/PIA02860_small.png";
                    LabelJupiter.Text = "Image of Galilean satellite Io in front of Jupiter taken by NASA's Cassini spacecraft.";
                    break;
                case 3:
                    ImageJ5.ImageUrl = "Images/Jupiter/PIA01527_small.jpg";
                    LabelJupiter.Text = "Image of Jupiter's Violent Storms including the Great Red Spot taken by NASA's Voyager 2.";
                    break;
                case 4:
                    ImageJ5.ImageUrl = "Images/Jupiter/PIA02879_small.jpg";
                    LabelJupiter.Text = "The Galilean satellite Io floats above the cloudtops of Jupiter in this image captured by NASA's Cassini orbiter.";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label5.Text = textSwitch;
            }
        }
    
    }
}
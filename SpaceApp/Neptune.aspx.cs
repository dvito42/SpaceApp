using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Neptune : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image8.AlternateText = "Neptune";
        }
        protected void Timer8_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label8.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image8N.ImageUrl = "Images/Neptune/PIA01492_small.jpg";
                    LabelNeptune.Text = "NASA's Voyager 2 image of Neptune shows the Great Dark Spot and its companion bright smudge.";
                    break;
                case 2:
                    Image8N.ImageUrl = "Images/Neptune/PIA01142_small.jpg";
                    LabelNeptune.Text = "Voyager image showing Neptune's Great Dark Spot, the bright feature nicknamed Scooter, and Dark Spot 2 which has a bright core.";
                    break;
                case 3:
                    Image8N.ImageUrl = "Images/Neptune/PIA00058_orig.jpg";
                    LabelNeptune.Text = "Neptune clouds showing vertical relief.";
                    break;
                case 4:
                    Image8N.ImageUrl = "Images/Neptune/PIA00051_small.jpg";
                    LabelNeptune.Text = "Neptune in false color.";
                    break;
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label8.Text = textSwitch;
            }
        }
    
    }
}
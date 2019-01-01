using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
//1
{
    public partial class Mars : System.Web.UI.Page
    //2
    {
        protected void Page_Load(object sender, EventArgs e)
        //3
        {
            Image2.AlternateText = "Mars.";
            //3 close
        }
        //2 close

        protected void Timer2_Tick(object sender, EventArgs e)
        //4
        {
            string textSwitch = Label2.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            //5
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image2.ImageUrl = "Images/Mars/PIA04272_small.jpg";
                    LabelMars.Text = "Mars in Early Northern Spring from Mars Global Surveyor (MGS) Mars Orbiter Camera (MOC) daily global images.";
                    break;
                case 2:
                    Image2.ImageUrl = "Images/Mars/PIA10682_small.jpg";
                    LabelMars.Text = "Icy, Patterned Ground on Mars near NASA's Phoenix Mars Lander.";
                    break;
                case 3:
                    Image2.ImageUrl = "Images/Mars/PIA01120_small.png";
                    LabelMars.Text = "Pathfinder on Mars.";
                    break;
                case 4:
                    Image2.ImageUrl = "Images/Mars/PIA11132_small.jpg";
                    LabelMars.Text = "Bluish-white frost on the Martian surface near NASA's Phoenix Mars Lander.";
                    break;
                default:
                    break;
                //5 close
            }
            if (caseSwitch < 5)
            //6
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label2.Text = textSwitch;
                //6 close
            }


            //4 close
        }
    }
}
    //1 close


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SpaceApp
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image5.AlternateText = "Jupiter";
        }
        protected void Timer5_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label5.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
            {
                // Set the next picture and set n to the next number
                case 1:
                    Image5.ImageUrl = "Images/Jupiter/PIA02972_orig.jpg";
                    break;
                case 2:
                    Image5.ImageUrl = "Images/Jupiter/PIA02860_small.jpg";
                    break;
                case 3:
                    Image5.ImageUrl = "Images/Jupiter/PIA01527_small.jpg";
                    break;
                case 4:
                    Image5.ImageUrl = "Images/Jupiter/PIA02879_small.jpg";
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
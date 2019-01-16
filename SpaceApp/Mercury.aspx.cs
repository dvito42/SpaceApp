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
            // Manually register the event-handling method for
            // the Click event of the Button control.
            MercuryPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            MercuryNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*******************************************************************************************************
        //Timer3_Tick will cycle through 5 pictures every 5 seconds
        //Label3.Text contains the number of the picture. 
        //Label3.Text needs to be numeric or the slideshow breaks.
        //*******************************************************************************************************

        protected void Timer3_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label3.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function to populate the desired picture
            setPicture(caseSwitch);

            //Update label with the new number
            Label3.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label3.Text;
            int casePSwitch = Convert.ToInt32(textPSwitch);

            //Decrement case switch until it reaches 1 then set it back to 5
            
            if (casePSwitch < 2)
            {
                casePSwitch = 5;
            }
            else
            {
                casePSwitch--;
            }

            //Call setPicture function to populate the desired picture
            setPicture(casePSwitch);

            //Update Label3.Text with the new value
            Label3.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label3.Text;
            int caseNSwitch = Convert.ToInt32(textNSwitch);

            //Increment case switch until it reaches 5 then set it back to 1
            if (caseNSwitch < 5)
            {
                caseNSwitch++;
            }
            else
            {
                caseNSwitch = 1;
            }

            //Call setPicture function to populate the desired picture
            setPicture(caseNSwitch);

            //Update Label3.Text with the new value
            Label3.Text = caseNSwitch.ToString();

        }

        //*******************************************************************************************************
        //Make function to switch pictures and description based on Label3.Text value (caseSwitch)
        //*******************************************************************************************************

        protected void setPicture(int parmSwitch)
        {
            switch (parmSwitch)
            {
                // Set the next picture and description
                // Set the next picture and set n to the next number
                case 1:
                    Image3.ImageUrl = "Images/Mercury/PIA12262_small.png";
                    LabelMercury.Text = "Hello, Mercury! Spacecraft Messenger took this picture approaching Mercury.";
                    break;
                case 2:
                    Image3.ImageUrl = "Images/Mercury/PIA17622_small.png";
                    LabelMercury.Text = "Crescent Mercury: This image was acquired as part of the MDIS's (Mercury Dual Imaging System) limb imaging campaign.";
                    break;
                case 3:
                    Image3.ImageUrl = "Images/Mercury/PIA11360_small.png";
                    LabelMercury.Text = "Mercury Through Time: This image shows a northern portion of Mercury’s surface, looking at the terminator.";
                    break;
                case 4:
                    Image3.ImageUrl = "Images/Mercury/PIA10635_small.png";
                    LabelMercury.Text = "“The Spider” – Radial Troughs within Caloris on Mercury.";
                    break;
                case 5:
                    Image3.ImageUrl = "Images/Mercury/PIA15862_small.png";
                    LabelMercury.Text = "Mickey Mouse Spotted on Mercury! This scene is to the northwest of the recently named crater Magritte, in Mercury's south.";
                    break;
                default:
                    break;
            }
        }
    }
}
    
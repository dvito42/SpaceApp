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
            // Manually register the event-handling method for
            // the Click event of the Button control.
            MoonPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            MoonNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //Timer1_Tick will cycle through 5 pictures every 5 seconds
        //Label1.Text contains the number of the picture. 
        //Label1.Text needs to be numeric or the slideshow breaks.
        

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label1.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

           //Update label with the new number
            Label1.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {
  
            string textPSwitch = Label1.Text;
            int casePSwitch = Convert.ToInt32(textPSwitch);
         
            //Decrement case switch until it reaches 1 then set it back to 5
            //Update Label1.Text with the new value
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

            Label1.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label1.Text;
            int caseNSwitch = Convert.ToInt32(textNSwitch);
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

            //Increment case switch until it reaches 5 then set it back to 1
            //Update Label1.Text with the new value
            
            Label1.Text = caseNSwitch.ToString();

        }

        //Make function to switch pictures and description based on Label1.Text value (caseSwitch)
        protected void setPicture(int parmSwitch)
        {
            switch (parmSwitch)
            {
                // Set the next picture and description
                case 1:
                    Image1.ImageUrl = "Images/Moon/as11-44-6667_small.jpg";
                    LabelMoon.Text = "View of a full Moon photographed from Apollo 11 spacecraft.";
                    break;
                case 2:
                    Image1.ImageUrl = "Images/Moon/6901249_small.jpg";
                    LabelMoon.Text = "Detailed view of the back side of Moon taken during the Apollo 11 mission.";
                    break;
                case 3:
                    Image1.ImageUrl = "Images/Moon/AS12-46-6728_small.jpg";
                    LabelMoon.Text = "Astronaut Alan L. Bean climbing down the ladder of the Lunar Module (LM).";
                    break;
                case 4:
                    Image1.ImageUrl = "Images/Moon/apollo_16_small.png";
                    LabelMoon.Text = "Astronaut John Young leaps from lunar surface to salute flag.";
                    break;
                case 5:
                    Image1.ImageUrl = "Images/Moon/as11-44-6551_small.jpg";
                    LabelMoon.Text = "View of Earth rising over Moon's horizon taken from Apollo 11 spacecraft.";
                    break;
                default:
                    break;
            }
        }
    }
}
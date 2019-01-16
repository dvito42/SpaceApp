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
            // Manually register the event-handling method for the Click event of the Button control.
            JupiterPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            JupiterNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*****************************************************************************************************
        //Timer5_Tick will cycle through 5 pictures every 5 seconds
        //Label5.Text contains the number of the picture. 
        //Label5.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************
        protected void Timer5_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label5.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label5.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label5.Text;
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

            //Update Label5.Text with the new value
            Label5.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label5.Text;
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

           
            //Update Label5.Text with the new value
            Label5.Text = caseNSwitch.ToString();

        }


        //********************************************************************************************
        //Make function to switch pictures and description based on Label1.Text value (caseSwitch)
        //********************************************************************************************
        protected void setPicture(int parmSwitch)
            {
                switch (parmSwitch)
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
                case 5:
                    ImageJ5.ImageUrl = "Images/Jupiter/PIA01481_full.png";
                    LabelJupiter.Text = "Collage of photographs of Jupiter and its four planet-size moons, called the Galilean satellites, taken by NASA's Voyager 1.";
                    break;
                default:
                    break;
            }

        }
    
    }
}
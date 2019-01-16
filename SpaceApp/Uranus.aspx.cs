using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Uranus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image7U.AlternateText = "Uranus";
            // Manually register the event-handling method for the Click event of the Button control.
            UranusPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            UranusNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*****************************************************************************************************
        //Timer7_Tick will cycle through 5 pictures every 5 seconds
        //Label7.Text contains the number of the picture. 
        //Label7.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************
        protected void Timer7_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label7.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label7.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label7.Text;
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

            //Update Label1.Text with the new value
            Label7.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label7.Text;
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

            //Update Label1.Text with the new value
            Label7.Text = caseNSwitch.ToString();

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
                    Image7U.ImageUrl = "Images/Uranus/PIA18182_small.jpg";
                    LabelUranus.Text = "Uranus as seen by NASA's Voyager 2.";
                    break;
                case 2:
                    Image7U.ImageUrl = "Images/Uranus/PIA02963_small.jpg";
                    LabelUranus.Text = "NASA Hubble Space Telescope view reveals Uranus surrounded by its four major rings and by 10 of its 17 known satellites. ";
                    break;
                case 3:
                    Image7U.ImageUrl = "Images/Uranus/PIA01280_orig.jpg";
                    LabelUranus.Text = "Hubble captures detailed image of Uranus' atmosphere.";
                    break;
                case 4:
                    Image7U.ImageUrl = "Images/Uranus/PIA00370_small.jpg";
                    LabelUranus.Text = "False-color picture of Uranus from NASA's Voyager shows a discrete cloud seen as a bright streak near the planet's limb.";
                    break;
                case 5:
                    Image7U.ImageUrl = "Images/Uranus/PIA01391_small2.png";
                    LabelUranus.Text = "A sliver of Uranus is seen by NASA's Voyager 2.";
                    break;
                default:
                    break;
            }
          
        }
    
    }
}
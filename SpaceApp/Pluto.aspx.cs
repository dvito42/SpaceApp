using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Pluto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image9P.AlternateText = "Pluto";
            // Manually register the event-handling method for the Click event of the Button control.
            PlutoPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            PlutoNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*****************************************************************************************************
        //Timer9_Tick will cycle through 5 pictures every 5 seconds
        //Label9.Text contains the number of the picture. 
        //Label9.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************
        protected void Timer9_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label9.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label9.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label9.Text;
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
            Label9.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label9.Text;
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
            Label9.Text = caseNSwitch.ToString();

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
                    Image9P.ImageUrl = "Images/Pluto/PIA21965_orig.jpg";
                    LabelPluto.Text = "Pluto's bladed terrain as seen from NASA's New Horizons during its July 2015 flyby.";
                    break;
                case 2:
                    Image9P.ImageUrl = "Images/Pluto/PIA20155_small.jpg";
                    LabelPluto.Text = "NASA's New Horizons scientists believe that the informally named features Wright Mons and Piccard Mons could have been formed by the 'cryovolcanic' eruption of ices from beneath Pluto's surface.";
                    break;
                case 3:
                    Image9P.ImageUrl = "Images/Pluto/PIA20543_orig.jpg";
                    LabelPluto.Text = "This feature appears to be a frozen, former lake of liquid nitrogen, located in a mountain range just north of Pluto's informally named Sputnik Planum.";
                    break;
                case 4:
                    Image9P.ImageUrl = "Images/Pluto/PIA20732_small.jpg";
                    LabelPluto.Text = "NASA's New Horizons spacecraft image of the southeastern portion of Pluto's great ice plains.";
                    break;
                case 5:
                    Image9P.ImageUrl = "Images/Pluto/PIA19952_small.jpg";
                    LabelPluto.Text = "NASA's New Horizons spacecraft high-resolution enhanced color view of Pluto.";
                    break;
                default:
                    break;
            }
        }
    
    }
}
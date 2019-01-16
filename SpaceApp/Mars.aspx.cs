using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Mars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image2.AlternateText = "Mars.";

            // Manually register the event-handling method for the Click event of the Button control.
            MarsPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            MarsNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*****************************************************************************************************
        //Timer2_Tick will cycle through 5 pictures every 5 seconds
        //Label2.Text contains the number of the picture. 
        //Label2.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************
        protected void Timer2_Tick(object sender, EventArgs e)
        //4
        {
            string textSwitch = Label2.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label2.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender, EventArgs e)
        {

            string textPSwitch = Label2.Text;
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

            //Update Label2.Text with the new value
            Label2.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label2.Text;
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

            //Update Label2.Text with the new value

            Label2.Text = caseNSwitch.ToString();

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
                case 5:
                    Image2.ImageUrl = "Images/Mars/PIA04591_small.png";
                    LabelMars.Text = "View of Mars assembled from the Mars Global Surveyor(MGS) Mars Orbiter Camera(MOC) daily global images.";
                    break;
                default:
                    break;
            }
        }
    }
}


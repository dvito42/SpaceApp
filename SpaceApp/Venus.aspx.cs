using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Venus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image4.AlternateText = "Venus";
            // Manually register the event-handling method for the Click event of the Button control.
            // 
            VenusPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            VenusNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*****************************************************************************************************
        //Timer4_Tick will cycle through 5 pictures every 5 seconds
        //Label4.Text contains the number of the picture. 
        //Label4.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************
        protected void Timer4_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label4.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label4.Text = caseSwitch.ToString();

        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label4.Text;
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

            //Update Label4.Text with the new value
            Label4.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label4.Text;
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

            //Update Label4.Text with the new value

            Label4.Text = caseNSwitch.ToString();

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
                    Image4.ImageUrl = "Images/Venus/PIA00072_small480.png";
                    LabelVenus.Text = "Venus Cloud Patterns (colorized and filtered): This picture of Venus was taken by the Galileo spacecrafts Solid State Imaging System.";
                    break;
                case 2:
                    Image4.ImageUrl = "Images/Venus/PIA00270_small480.png";
                    LabelVenus.Text = "Venus - Computer Simulated Global View Centered at 90 Degrees East Longitude based on Magellan radar mapping.";
                    break;
                case 3:
                    Image4.ImageUrl = "Images/Venus/PIA00109_small480.png";
                    LabelVenus.Text = "3-D Perspective View of Idem-Kuva: A corona is displayed in this computer-simulated view of the surface of Venus.";
                    break;
                case 4:
                    Image4.ImageUrl = "Images/Venus/PIA00234_small480.png";
                    LabelVenus.Text = "Venus - 3-D Perspective View of Gula Mons ";
                    break;
                case 5:
                    Image4.ImageUrl = "Images/Venus/PIA10124_small480.png";
                    LabelVenus.Text = "Approaching Venus: The planet is enshrouded by a global layer of clouds that obscures its surface to the MESSENGER Dual Imaging System(MDIS) cameras. ";
                    break;
                default:
                    break;
            }
        }
    }
}

 

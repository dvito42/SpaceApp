using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Saturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image6S.AlternateText = "Saturn";

            // Manually register the event-handling method for the Click event of the Button control.
            SaturnPrevButton.Click += new EventHandler(this.PrevBtn_Click);
            SaturnNextButton.Click += new EventHandler(this.NextBtn_Click);
        }

        //*****************************************************************************************************
        //Timer6_Tick will cycle through 5 pictures every 5 seconds
        //Label6.Text contains the number of the picture. 
        //Label6.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************

        protected void Timer6_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label6.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label6.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label6.Text;
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
            Label6.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label6.Text;
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
            Label6.Text = caseNSwitch.ToString();

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
                    Image6S.ImageUrl = "Images/Saturn/PIA01482_small.jpg";
                    LabelSaturn.Text = "Saturn system montage prepared from NASA's Voyager 1 spacecraft images.";
                    break;
                case 2:
                    Image6S.ImageUrl = "Images/Saturn/PIA01966_small.jpg";
                    LabelSaturn.Text = "View of Saturn and its ring system taken by NASA's Voyager 2.";
                    break;
                case 3:
                    Image6S.ImageUrl = "Images/Saturn/PIA06423_small.jpg";
                    LabelSaturn.Text = "NASA's Cassini spacecraft image of Saturn's atmosphere with the rings and moons Mimas and Enceladus.";
                    break;
                case 4:
                    Image6S.ImageUrl = "Images/Saturn/PIA14946_small.jpg";
                    LabelSaturn.Text = "False-color image from NASA's Cassini mission shows the fast-moving hexagonal jet stream framing the storms at Saturn's north pole.";
                    break;
                case 5:
                    Image6S.ImageUrl = "Images/Saturn/PIA14946_small.jpg";
                    LabelSaturn.Text = "False-color image from NASA's Cassini mission shows the fast-moving hexagonal jet stream framing the storms at Saturn's north pole.";
                    break;
                default:
                    break;
            }
          
        }
    
    }
}

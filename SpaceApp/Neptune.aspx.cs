using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
    public partial class Neptune : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image8N.AlternateText = "Neptune";
            // Manually register the event-handling method for the Click event of the Button control.
            NeptunePrevButton.Click += new EventHandler(this.PrevBtn_Click);
            NeptuneNextButton.Click += new EventHandler(this.NextBtn_Click);

        }

        //*****************************************************************************************************
        //Timer8_Tick will cycle through 5 pictures every 5 seconds
        //Label8.Text contains the number of the picture. 
        //Label8.Text needs to be numeric or the slideshow breaks.
        //*****************************************************************************************************
        protected void Timer8_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label8.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);

            //Increment caseSwitch if it is less than 5 - the slide show stops on the 5th picture
            if (caseSwitch < 5)
            {
                caseSwitch++;
            }

            //Call setPicture function
            setPicture(caseSwitch);

            //Update label with the new number
            Label8.Text = caseSwitch.ToString();
        }

        //*******************************************************************************************************
        // When the "Previous" button is clicked, change the image and description.
        //*******************************************************************************************************
        protected void PrevBtn_Click(Object sender,
                          EventArgs e)
        {

            string textPSwitch = Label8.Text;
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
            Label8.Text = casePSwitch.ToString();
        }

        //************************************************************************************************************
        // When the Next button is clicked, change the image and description.
        //************************************************************************************************************
        protected void NextBtn_Click(Object sender,
                          EventArgs e)
        {
            string textNSwitch = Label8.Text;
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
            Label8.Text = caseNSwitch.ToString();

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
                    Image8N.ImageUrl = "Images/Neptune/PIA01492_small.jpg";
                    LabelNeptune.Text = "NASA's Voyager 2 image of Neptune shows the Great Dark Spot and its companion bright smudge.";
                    break;
                case 2:
                    Image8N.ImageUrl = "Images/Neptune/PIA01142_small.jpg";
                    LabelNeptune.Text = "Voyager image showing Neptune's Great Dark Spot, the bright feature nicknamed Scooter, and Dark Spot 2 which has a bright core.";
                    break;
                case 3:
                    Image8N.ImageUrl = "Images/Neptune/PIA00058_orig.jpg";
                    LabelNeptune.Text = "Neptune clouds showing vertical relief.";
                    break;
                case 4:
                    Image8N.ImageUrl = "Images/Neptune/PIA00051_small.jpg";
                    LabelNeptune.Text = "Neptune in false color.";
                    break;
                case 5:
                    Image8N.ImageUrl = "Images/Neptune/PIA00340_small.jpg";
                    LabelNeptune.Text = "This computer generated NASA's Voyager 2 images montage shows Neptune as it would appear from a spacecraft approaching Triton, Neptune's largest moon.";
                    break;
                default:
                    break;
            }
 
        }
    
    }
}
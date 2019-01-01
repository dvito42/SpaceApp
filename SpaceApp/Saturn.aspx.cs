﻿using System;
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
            Image6.AlternateText = "Saturn";
        }
        protected void Timer6_Tick(object sender, EventArgs e)
        {
            string textSwitch = Label6.Text;
            int caseSwitch = Convert.ToInt32(textSwitch);
            switch (caseSwitch)
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
                default:
                    break;
            }
            if (caseSwitch < 5)
            {
                caseSwitch = caseSwitch + 1;
                textSwitch = caseSwitch.ToString();
                Label6.Text = textSwitch;
            }
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaceApp
{
  public partial class WebForm1 : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
{
          Image1.AlternateText = "The earth and the moon.";
}

    protected void Timer1_Tick(object sender, EventArgs e)
  {
    string textSwitch = Label1.Text;
  int caseSwitch = Convert.ToInt32(textSwitch);
switch (caseSwitch)
 {
 // Set the next picture and set n to the next number
   case 1:
     Image1.ImageUrl = "Images/Moon/6901249_small.jpg";
   break;
case 2:
  Image1.ImageUrl = "Images/Moon/AS12-46-6728_small.jpg";
break;
case 3:
 Image1.ImageUrl = "Images/Moon/6900951_small.jpg";
break;
case 4:
  Image1.ImageUrl = "Images/Moon/as11-44-6551_small.jpg";
break;
default:
  break;
}
if (caseSwitch < 5)
{
   caseSwitch = caseSwitch + 1;
  textSwitch = caseSwitch.ToString();
 Label1.Text = textSwitch;
}
                 


}
}
}
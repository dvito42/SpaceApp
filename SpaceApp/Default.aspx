<%@ Page Title="Earth" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpaceApp.Mercury" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
    <div class="content-wrapper">
 <!--
 /**************************************************************************************
 * Program Name: SpaceApp
 * Author: Donna Vito
 * Date: 11/27/2018
 * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
 *      for the eight planets in our Solar System and Pluto.
 *
 * Default.aspx: Earth. I did not make a slide show for this page.
 ***************************************************************************************/
            
  Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
  -->
        <aside class="default-center">
                <q>Behold one of the more detailed images of the Earth yet created. 
                This Blue Marble Earth montage shown above -- created from photographs taken by the 
                Visible/Infrared Imager Radiometer Suite (VIIRS) instrument on board the new Suomi NPP 
                satellite -- shows many stunning details of our home planet. The Suomi NPP satellite was 
                launched last October and renamed last week after Verner Suomi, commonly deemed the father 
                of satellite meteorology. The composite was created from the data collected during four 
                orbits of the robotic satellite taken earlier this month and digitally projected onto the 
                globe. Many features of North America and the Western Hemisphere are particularly visible 
                on a high resolution version of the image.</q> 
                <p><cite>Source: JPL and NASA.</cite></p>
             <a href="https://nssdc.gsfc.nasa.gov/planetary/factsheet/earthfact.html">Link to NASA Earth Fact Sheet</a>
        </aside>
        <div class="text-center">
            <asp:Image ID="Image1" class="round-corners" runat="server" ImageUrl="Images/Earth/PIA18033_small.jpg" /><br />
            <asp:Label ID="LabelEarth" class="text-center" runat="server" Text="Label">Blue Marble Earth montage </asp:Label>
         </div>
        </div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <!-- Included link to images.nasa.gov in case someone wants to see more... -->
       <asp:HyperLink id="hyperlink2" 
                  NavigateUrl="https://images.nasa.gov"
                  Text="Link to images.nasa.gov"
                  Target="_new"
                  runat="server"/> 
        <br />
        <asp:HyperLink ID="hyperlinkPhoto"
            NavigateUrl="https://photojournal.jpl.nasa.gov"
            Text="Link to photojournal.jpl.nasa.gov"
            Target="_new"
            runat="server" />
        </p>
</asp:Content>

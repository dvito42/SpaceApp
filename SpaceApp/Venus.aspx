<%@ Page Title="Venus" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Venus.aspx.cs" Inherits="SpaceApp.Venus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <!--
     /**************************************************************************************
     * Program Name: SpaceApp
     * Author: Donna Vito
     * Date: 11/27/2018
     * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
     *      for the eight planets in our Solar System and Pluto.
     *
     * Venus.aspx: Slide show for Venus.
     ***************************************************************************************/
            
      Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
      -->   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">
            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
            <asp:UpdatePanel ID="UpdatePanel4" runat="server" cssStyle="alignCenter">

                <ContentTemplate>
                    <!-- Add link to NASA fact sheet -->
                    <aside class="default-center">
                        <asp:Label ID="LabelVenus" runat="server" Text="Approaching Venus: The planet is enshrouded by a global layer of clouds that obscures its surface to the MESSENGER Dual Imaging System (MDIS) cameras."></asp:Label><br />
                        <cite>Image credit: NASA</cite><br />
                        <asp:Label ID="Label4" runat="server" Text="1"></asp:Label><br />
                        <p>
                            <a href="https://nssdc.gsfc.nasa.gov/planetary/factsheet/venusfact.html">Link to NASA Venus Fact Sheet</a>
                            <br /><br />
                        </p>
                    </aside>

                    <div class="text-center">
                        <asp:Image ID="Image4" class="round-corners" runat="server" 
                            ImageUrl="Images/Venus/PIA10124_small480.png" /><br />
                    </div>
                    <!--
                    <img src="Images/Venus/PIA10124_small.jpg" />
                    <img src="Images/Venus/PIA01544_orig.jpg" />
                    <img src="Images/Venus/PIA00270_small.jpg" />
                    <img src="Images/Venus/PIA00109_small.jpg" />
                    <img src="Images/Venus/PIA00234_small.jpg" /> -->

                    <asp:Timer ID="Timer4" runat="server" Interval="5000" OnTick="Timer4_Tick"></asp:Timer>
                </ContentTemplate>
           </asp:UpdatePanel>
        </div>
    </section>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
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

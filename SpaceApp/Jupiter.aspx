<%@ Page Title="Jupiter" Language="C#" AutoEventWireup="true" CodeBehind="Jupiter.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.Jupiter" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <!--
     /**************************************************************************************
     * Program Name: SpaceApp
     * Author: Donna Vito
     * Date: 11/27/2018
     * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
     *      for the eight planets in our Solar System and Pluto.
     *
     * Jupiter.aspx: Slide show for Jupiter.
     ***************************************************************************************/
            
      Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
      -->        
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
            <asp:UpdatePanel ID="UpdatePanel5" runat="server" cssStyle="alignCenter">
                <ContentTemplate>
                    <!-- Add link to NASA fact sheet -->
                    <aside class="default-center">
                        <asp:Label ID="LabelJupiter" runat="server" 
                            Text="Collage of photographs of Jupiter and its four planet-size moons, 
                            called the Galilean satellites, taken by NASA's Voyager 1."></asp:Label><br />
                        <cite>Image credit: NASA</cite><br />
                        <asp:Label ID="Label5" runat="server" Text="1"></asp:Label><br />
                        <p>
                            <a href="https://nssdc.gsfc.nasa.gov/planetary/factsheet/jupiterfact.html">Link to NASA Jupiter Fact Sheet</a>
                            <br /><br />
                        </p>
                    </aside>
                    <!-- Set the first image of the slide show -->
                    <div class="text-center">
                        <asp:Image ID="ImageJ5" class="round-corners" runat="server" ImageUrl="Images/Jupiter/PIA01481_full.png"/>
                        <!-- 
                        <asp:ImageButton ID="Image5" runat="server" 
                            ImageUrl="Images/Jupiter/PIA01481_full.png" />
                            -->
                        <br />
                    </div>
                   
                    <asp:Timer ID="Timer5" runat="server" Interval="5000" OnTick="Timer5_Tick"></asp:Timer>
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


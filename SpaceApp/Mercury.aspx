<%@ Page Title="Mercury" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mercury.aspx.cs" Inherits="SpaceApp.WebForm31" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <!--
     /**************************************************************************************
     * Program Name: SpaceApp
     * Author: Donna Vito
     * Date: 11/27/2018
     * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
     *      for the eight planets in our Solar System and Pluto.
     *
     * Mercury.aspx: Slide show for Mercury.
     ***************************************************************************************/
            
      Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
     -->  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">        
            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server" CssStyle="alignCenter">
                <ContentTemplate>
                    <!-- Add link to NASA fact sheet -->
                    <aside class="default-center">
                        <asp:Label ID="LabelMercury" runat="server" 
                            Text="Hello, Mercury! Spacecraft Messenger took this picture approaching Mercury."></asp:Label>
                        <br />
                        <cite>Image credit: NASA</cite><br />
                        <asp:Label ID="Label3" runat="server" Text="1"></asp:Label><br />
                        <p>
                        <a href="https://nssdc.gsfc.nasa.gov/planetary/factsheet/mercuryfact.html">Link to NASA Mercury Fact Sheet</a>
                        </p>
                        <br /><br />
                    </aside>
                    <!-- Set the first image of the slide show -->
                    <div class="text-center">
                        <asp:Image ID="Image3" class="round-corners" runat="server" ImageUrl="Images/Mercury/PIA12262_small.png"  /><br />
                    </div>
                    <!--
                    <img src="Images/Mercury/PIA12262_small.jpg" />
                    <img src="Images/Mercury/PIA11360_small.jpg" />
                    <img src="Images/Mercury/PIA16549_small.jpg" />
                    <img src="Images/Mercury/PIA10635_orig.jpg" />
                    <img src="Images/Mercury/PIA15862_small.jpg" />
                    -->
                    <asp:Timer ID="Timer3" runat="server" Interval="5000" OnTick="Timer3_Tick"></asp:Timer>
                
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

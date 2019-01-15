
<%@ Page Title="Moon" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Moon.aspx.cs" Inherits="SpaceApp.Moon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <!--
     /**************************************************************************************
     * Program Name: SpaceApp
     * Author: Donna Vito
     * Date: 11/27/2018
     * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
     *      for the eight planets in our Solar System and Pluto.
     *
     * Moon.aspx: Slide show of 5 pictures for the Moon.
     ***************************************************************************************
     * Change log
     *
     * 12/2/2018    Added descriptions to pictures                              Donna Vito
     ***************************************************************************************/
            
      Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
      -->      
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">      
            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" CssStyle="alignCenter">

            <ContentTemplate>
                <!-- Add link to NASA fact sheet -->
                <aside class="default-center">
                    <asp:Label ID="LabelMoon" runat="server" Text="View of a full Moon photographed from Apollo 11 spacecraft."></asp:Label>
                    <br />
                    <cite>Image credit: NASA</cite>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>
                    <br />
                    
                    <p>
                        <a href= "https://nssdc.gsfc.nasa.gov/planetary/factsheet/moonfact.html">Link to NASA Moon Fact Sheet</a>
                    </p>
                    </aside>
                <!-- Set the first image of the slide show -->
                <!-- Add previous and next buttons to allow user to choose which picture to view-->
                <div>   
                    <asp:Button ID="MoonPrevButton" class="btn float-left margin-top25" runat="server" Text=" < Previous " />
                    <asp:Button ID="MoonNextButton" class="btn float-right margin-top25" runat="server" Text=" Next > " />
                    <asp:Image ID="Image1" class="round-corners alignCenter" runat="server" ImageUrl="Images/Moon/as11-44-6667_small.jpg" />
                    
                </div>
                <!-- Timer will run when the document loads. The picture will switch every 5 seconds until the 5th picture is set. -->     
                <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick"></asp:Timer>
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
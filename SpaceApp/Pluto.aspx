<%@ Page Title="Pluto" Language="C#" AutoEventWireup="true" CodeBehind="Pluto.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.Pluto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <!--
     /**************************************************************************************
     * Program Name: SpaceApp
     * Author: Donna Vito
     * Date: 11/27/2018
     * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
     *      for the eight planets in our Solar System and Pluto.
     *
     * Pluto.aspx: Slide show for Pluto.
     ***************************************************************************************/
            
      Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
      -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
            <asp:UpdatePanel ID="UpdatePanel9" runat="server" cssStyle="alignCenter">
                <ContentTemplate>
                    <!-- Add link to NASA fact sheet -->
                    <aside class="default-center">
                        <asp:Label ID="LabelPluto" runat="server" Text="NASA's New Horizons spacecraft high-resolution enhanced color view of Pluto."></asp:Label><br />
                        <cite>Image credit: NASA</cite><br />
                        <asp:Label ID="Label9" runat="server" Text="1"></asp:Label><br />
                        <p>
                            <a href="https://nssdc.gsfc.nasa.gov/planetary/factsheet/plutofact.html">Link to NASA Pluto Fact Sheet</a>
                            <br /><br />
                        </p>
                    </aside>     
                   
                    <div class="text-center">
                        <!-- Add previous and next buttons to allow user to choose which picture to view-->
                        <asp:Button ID="PlutoPrevButton" class="btn float-left margin-top25" runat="server" Text=" < Previous " />
                        <asp:Button ID="PlutoNextButton" class="btn float-right margin-top25" runat="server" Text=" Next > " />
                        <!-- Set the first image of the slide show -->
                        <asp:Image ID="Image9P" class="round-corners" runat="server" ImageUrl="Images/Pluto/PIA19952_small.jpg" />
                        <br />
                    </div>

                    <asp:Timer ID="Timer9" runat="server" Interval="5000" OnTick="Timer9_Tick"></asp:Timer>
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


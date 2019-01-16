<%@ Page Title="Saturn" Language="C#" AutoEventWireup="true" CodeBehind="Saturn.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.Saturn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<!--
 /**************************************************************************************
 * Program Name: SpaceApp
 * Author: Donna Vito
 * Date: 11/27/2018
 * Program Description: SpaceApp (Vito Space Flight) is a slide show of NASA images 
 *      for the eight planets in our Solar System and Pluto.
 *
 * Saturn.aspx: Slide show for Saturn.
 ***************************************************************************************/
            
  Note:These forms are using Site.Master. All content on these forms needs to be in a Content wrapper (asp:Content).
  -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
        <div class="content-wrapper">
            <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
            <asp:UpdatePanel ID="UpdatePanel6" runat="server" cssStyle="alignCenter">
                <ContentTemplate>
                    <!-- Add link to NASA fact sheet -->
                    <aside class="default-center">
                        <asp:Label ID="LabelSaturn" runat="server" Text="Natural color view of Saturn and five of its icy satellites taken by NASA's Cassini spacecraft."></asp:Label><br />
                        <cite>Image credit: NASA</cite><br />
                        <asp:Label ID="Label6" runat="server" Text="1"></asp:Label><br />
                        <p>
                            <a href="https://nssdc.gsfc.nasa.gov/planetary/factsheet/saturnfact.html">Link to NASA Saturn Fact Sheet</a>
                            <br /><br />
                        </p>
                    </aside>  
                    
                    <div class="text-center">
                        <!-- Add previous and next buttons to allow user to choose which picture to view-->
                        <asp:Button ID="SaturnPrevButton" class="btn float-left margin-top25" runat="server" Text=" < Previous " />
                        <asp:Button ID="SaturnNextButton" class="btn float-right margin-top25" runat="server" Text=" Next > " />
                        <!-- Set the first image of the slide show -->
                        <asp:Image ID="Image6S" class="round-corners" runat="server" ImageUrl="Images/Saturn/PIA04913_small.jpg" />
                        <br />

                    </div>

                    <asp:Timer ID="Timer6" runat="server" Interval="5000" OnTick="Timer6_Tick"></asp:Timer>
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

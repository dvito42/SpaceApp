<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SpaceApp.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %> Vito Space Flight:</h1>
        <h2>My Portfolio - Slide show of NASA images for the eight planets in our Solar System and Pluto.</h2>
    </hgroup>

    <article>
        
        <p> Vito Space Flight is not a real company. This is a website I created while I was studying Visual Studio ASP.Net C#. 
            It's a slide show with pictures of the main planets in our solar system copied from Nasa's image website. 
            It has on a timer on each page to make it cycle through 5 pictures and then stop. </p>
        <p> This site is not endorsed by NASA.</p>
        
    </article>

    <aside>
        <h3>Links</h3>
        <p>        
            Links to Home page, Contact page, and NASA's images website.
        </p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
            <li><a runat="server" href="https://images.nasa.gov">images.nasa.gov</a></li>
        </ul>
    </aside>
</asp:Content>
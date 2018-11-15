<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SpaceApp.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %> Vito Space Flight:</h1>
        <h2>Vito Space Flight is a slide show of NASA images for the eight planets in our Solar System and Pluto.</h2>
    </hgroup>

    <article>
        
        <p> This is a website I created a couple of years ago while I was studying Visual Studio ASP.Net C#. 
            It's a slide show with pictures of the main planets in our solar system copied from Nasa's image website. 
            I put on a timer on each page to make it cycle through 5 pictures and then stop. 
            This was not intended to be a live website. It's just something I created for my portfolio.</p>
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
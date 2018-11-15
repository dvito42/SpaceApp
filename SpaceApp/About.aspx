<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="SpaceApp.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %> SpaceApp:</h1>
        <h2>Space App is a slide show of NASA images for the eight planets in our Solar System and Pluto.</h2>
    </hgroup>

    <article>
        
        <p> Home is Earth. Earth does not have a slide show.  </p>
        <p> This site is not endorsed by NASA.</p>
        <p>This is a sample web site for my portfolio. </p>
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
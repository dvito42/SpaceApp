<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SpaceApp.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Vito Space Flight</h2>
    </hgroup>
<!-- 
    <address>
    Donna Vito<br />
    Jamesville, NY 13078<br />
    <abbr title="Phone">P:</abbr>
    315.572.5429
    </address>
    <address>
    <strong>Support:</strong>   <a href="mailto:donnavito42@gmail.com">donnavito42@gmail.com</a><br />
    </address>
    -->
    <section class="contact">
        <header>
            <h3>Phone:</h3>
        </header>
        <p>
            <span class="label">Main:</span>
            <span>315.572.5429</span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Email:</h3>
        </header>
        <p>
            <span class="label">General:</span>
            <span><a href="mailto:donnavito42@gmail.com">donnavito42@gmail.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>Address:</h3>
        </header>
        <p>
            Jamesville, NY 13078
        </p>
    </section>
</asp:Content>
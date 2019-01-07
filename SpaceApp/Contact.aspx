<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="SpaceApp.Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Vito Space Flight</h2>
    </hgroup>

<!-- add address, phone number and email -->

    <section class="contact">
        <p>
            <span class="label">Phone:</span>
            <span>315.572.5429</span>
        </p>
       
        <p>
            <span class="label">Email:</span>
            <span><a href="mailto:donnavito42@gmail.com">donnavito42@gmail.com</a></span>
        </p>
  
        <p>
            <span class="label">Address:</span>
            <span>Jamesville, NY 13078</span>
        </p>
    </section>
</asp:Content>
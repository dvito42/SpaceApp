<%@ Page Title="Earth" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpaceApp.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <section class="featured">
    <div class="content-wrapper">

        <div style="text-align:center"> 
                <asp:Image ID="ImageMain" runat="server" ImageUrl="Images/Earth/PIA18033_small.jpg" />
                <p>This site is not endorsed by NASA.</p>
        </div>
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
    </p>
</asp:Content>


<%@ Page Title="Moon" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SpaceApp.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">      
    
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" CssStyle="alignCenter">
            <ContentTemplate>
                
        <div style="text-align:center"> 
           <asp:Image ID="Image1" runat="server" ImageUrl="Images/Moon/as11-44-6667_small.jpg" />
           <asp:Label ID="Label1" runat="server" Text="1"></asp:Label>

            <!--
            <img src="Images/Moon/as11-44-6667_small.jpg" />
            <img src="Images/Moon/6901249_small.jpg" />
            <img src="Images/Moon/AS12-46-6728_small.jpg" />
            <img src="Images/Moon/6900951_small.jpg" />
            <img src="Images/Moon/as11-44-6551_small.jpg" />
            -->
             <p>This site is not endorsed by NASA.</p>
        </div> 
                     
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
        </p>
</asp:Content>
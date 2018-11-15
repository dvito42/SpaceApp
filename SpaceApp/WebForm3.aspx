<%@ Page Title="Mercury" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="SpaceApp.WebForm31" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">        
    
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" CssStyle="alignCenter">
            <ContentTemplate>
               
                <div style="text-align:center">
                <asp:Image ID="Image3" runat="server" ImageUrl="Images/Mercury/PIA12262_small.jpg"  />
                <asp:Label ID="Label3" runat="server" Text="1"></asp:Label>
                     <p>This site is not endorsed by NASA.</p>
                </div>
<!--
                <img src="Images/Mercury/PIA12262_small.jpg" />
                <img src="Images/Mercury/PIA11360_small.jpg" />
                <img src="Images/Mercury/PIA16549_small.jpg" />
                <img src="Images/Mercury/PIA10635_orig.jpg" />
                <img src="Images/Mercury/PIA15862_small.jpg" />
                -->
                <asp:Timer ID="Timer3" runat="server" Interval="5000" OnTick="Timer3_Tick"></asp:Timer>
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

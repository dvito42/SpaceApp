<%@ Page Title="Mars" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SpaceApp.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
      <section class="featured">
        <div class="content-wrapper">
           
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" CssStyle="alignCenter">
            <ContentTemplate>
                
                
       <div style="text-align:center">
           <asp:Image ID="Image2" runat="server" ImageUrl="Images/Mars/PIA04591_small.jpg" />
           <asp:Label ID="Label2" runat="server" Text="1"></asp:Label>
            <p>This site is not endorsed by NASA.</p>
      </div>

                <!--
                <img src="Images/Mars/PIA04591_orig.jpg" />
                <img src="Images/Mars/PIA04272_small.jpg" />
                <img src="Images/Mars/PIA10682_small.jpg" />
                <img src="Images/Mars/PIA01120_small.jpg" />
                <img src="Images/Mars/PIA11132_small.jpg" />
                -->
                

          <asp:Timer ID="Timer2" runat="server" Interval="5000" OnTick="Timer2_Tick"></asp:Timer>
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

<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">

     <section class="featured">
        <div class="content-wrapper">
            
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel6" runat="server" cssStyle="alignCenter">
            <ContentTemplate>
                
                <div style="text-align:center">
                    <asp:ImageButton ID="Image6" runat="server" ImageUrl="Images/Saturn/PIA04913_small.jpg" Width="60%" Height="60%" />
                    <asp:Label ID="Label6" runat="server" Text="1"></asp:Label>
                     <p>This site is not endorsed by NASA.</p>
                </div>
                <!--
                <img src="Images/Saturn/PIA04913_small.jpg" />
                <img src="Images/Saturn/PIA01482_small.jpg" />
                <img src="Images/Saturn/PIA01966_small.jpg" />
                <img src="Images/Saturn/PIA06423_small.jpg" />
                <img src="Images/Saturn/PIA14946_small.jpg" />
                -->
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
        </p>
</asp:Content>

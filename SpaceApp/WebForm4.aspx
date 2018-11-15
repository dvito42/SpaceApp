<%@ Page Title="Venus" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="SpaceApp.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">
    
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel4" runat="server" cssStyle="alignCenter">
            <ContentTemplate>
                
                <div style="text-align:center">
                    <asp:Image ID="Image4" runat="server" ImageUrl="Images/Venus/PIA10124_small.jpg" />
                    <asp:Label ID="Label4" runat="server" Text="1"></asp:Label>
                     <p>This site is not endorsed by NASA.</p>
                </div>
<!--
                <img src="Images/Venus/PIA10124_small.jpg" />
                <img src="Images/Venus/PIA01544_orig.jpg" />
                <img src="Images/Venus/PIA00270_small.jpg" />
                <img src="Images/Venus/PIA00109_small.jpg" />
                <img src="Images/Venus/PIA00234_small.jpg" /> -->

                <asp:Timer ID="Timer4" runat="server" Interval="5000" OnTick="Timer4_Tick"></asp:Timer>
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

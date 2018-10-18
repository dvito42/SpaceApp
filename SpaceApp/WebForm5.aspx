<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">
            
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel5" runat="server" cssStyle="alignCenter">
            <ContentTemplate>

                <div style="text-align:center">
                    <asp:ImageButton ID="Image5" runat="server" ImageUrl="Images/Jupiter/PIA01481_small.jpg" Width="60%" Height="60%"/>
                    <asp:Label ID="Label5" runat="server" Text="1"></asp:Label>
                     <p>This site is not endorsed by NASA.</p>
                </div>

                <!--
                <img src="Images/Jupiter/PIA01481_small.jpg" />
                <img src="Images/Jupiter/PIA02972_orig.jpg" />
                <img src="Images/Jupiter/PIA01324_orig.jpg" />
                <img src="Images/Jupiter/PIA01527_small.jpg" />
                <img src="Images/Jupiter/PIA02879_small.jpg" />
                
                -->
                <asp:Timer ID="Timer5" runat="server" Interval="5000" OnTick="Timer5_Tick"></asp:Timer>
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


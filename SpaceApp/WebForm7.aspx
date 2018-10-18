<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">

     <section class="featured">
        <div class="content-wrapper">
           

    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel7" runat="server" cssStyle="alignCenter">
            <ContentTemplate>
                
                <div style="text-align:center">
                    <asp:ImageButton ID="Image7" runat="server" ImageUrl="Images/Uranus/PIA01391_small.jpg" Width="60%" Height="60%"/>
                    <asp:Label ID="Label7" runat="server" Text="1"></asp:Label>
                     <p>This site is not endorsed by NASA.</p>
                </div>

                <!--
                <img src="Images/Uranus/PIA01391_small.jpg" />
                <img src="Images/Uranus/PIA18182_small.jpg" />
                <img src="Images/Uranus/PIA02963_small.jpg" />
                <img src="Images/Uranus/PIA01280_orig.jpg" />
                <img src="Images/Uranus/PIA00370_small.jpg" />
                -->

                <asp:Timer ID="Timer7" runat="server" Interval="5000" OnTick="Timer7_Tick"></asp:Timer>
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


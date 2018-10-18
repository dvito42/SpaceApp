<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" MasterPageFile="~/Site.Master" Inherits="SpaceApp.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
     <section class="featured">
        <div class="content-wrapper">
          
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>
        <asp:UpdatePanel ID="UpdatePanel8" runat="server" cssStyle="alignCenter">
            <ContentTemplate>
                
                <div style="text-align:center">
                 <asp:ImageButton ID="Image8" runat="server" ImageUrl="Images/Neptune/PIA00340_small.jpg"  Height="60%" Width="60%" />
           <asp:Label ID="Label8" runat="server" Text="1"></asp:Label>
                     <p>This site is not endorsed by NASA.</p>
                    </div>
                <!--
                <img src="Images/Neptune/PIA00340_small.jpg" />
                <img src="Images/Neptune/PIA01492_small.jpg" />
                <img src="Images/Neptune/PIA01142_small.jpg" />
                <img src="Images/Neptune/PIA00058_orig.jpg" />
                <img src="Images/Neptune/PIA00051_small.jpg" />
                -->
                <asp:Timer ID="Timer8" runat="server" Interval="5000" OnTick="Timer8_Tick"></asp:Timer>
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


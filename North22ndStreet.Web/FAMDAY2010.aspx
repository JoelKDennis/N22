<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="True" CodeBehind="FAMDAY2010.aspx.cs" Inherits="North22ndStreet.Web.FAMDAY2010" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="TopAdvertisement" runat="server">
    <div style="text-align:center; padding-top:5px;">
    <span style="font-family:Tahoma; font-size:12px; color:#FFF;">What's happening in our neighborhood? Read it here!</span>
    <br />
    <a href="AW/default.aspx">
    <img src="AW/Images/AWHeaderAD.gif" alt="Read Online!" title="Allegheny West Community News Journal" width="400px" />
    </a>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <span>The North 22nd Street Merchants Association Presents</span>
    <div style="font-family:Verdana;">
    <span class="FamDay">FAM DAY</span><br /><br />
    <span style="color:#FF9900; font-weight:bold;">
    Giveaways - Samples - Prizes - Tasting - Sidewalk Sales - Entertainment & Free Stuff
    </span><br /><br />
    Saturday, June 12th, 2010<br />
    2700, 2800, 2900, 3000 North 22nd Street<br /><br />
    <img src="Images/WayFindingMap.jpg" alt="North 22nd Street" title="North 22nd Street" />
    <br /><br />
    For more details, call 2672495205
    <br />
    <br />
    </div>

</asp:Content>

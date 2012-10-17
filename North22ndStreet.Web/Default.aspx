<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="North22ndStreet.Web.Default" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 264px;
        }
        .DiscountCardLink
        {
            height: 40px; background-color:#A50010; width:100%; vertical-align:middle; 
            display:table-cell; margin-left:auto; margin-right:auto;
        }
        a:link {
        COLOR: #FF0000; font-weight:bold; font-size:14px;
        }
        a:visited {
        COLOR: #FF0000; font-weight:bold; font-size:14px;
        }
        a:hover {
        COLOR: #000; font-weight:bold; font-size:14px;
        }
        a:active {
        COLOR: #FF0000; font-weight:bold; font-size:14px;
        }
    </style>
</asp:Content>
<asp:Content ID="TopAdvertisement" runat="server" ContentPlaceHolderID="TopAdvertisement">
    <div style="text-align:center; padding-top:5px;">
    <span style="font-family:Tahoma; font-size:12px; color:#FFF;">What's happening in our neighborhood? Read it here!</span>
    <br />
    <a href="AW/default.aspx">
    <img src="AW/Images/AWHeaderAD.gif" alt="Read Online!" title="Allegheny West Community News Journal" width="400px" />
    </a>
</div>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Styles/Styles.css" rel="stylesheet" type="text/css" />

<table class="Home" cellpadding="0" cellspacing="0">
<tr>
    <td colspan="3" align="center" class="style1">
    <br />
        <a href="RealEstate.aspx">
        <img src="Images/FrontPage_2011_08.jpg" />
        </a>
        <br />
        <span class="Header20">FREE STREET PARKING EVERY SATURDAY ALL DAY FROM 11 AM</span>
        <br />   
        
        <br /><br />
        
    </td>
</tr>

</table>

    
</asp:Content>

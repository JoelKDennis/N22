<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MerchantSearch.aspx.cs" Inherits="North22ndStreet.Web.Merchants._default" EnableViewStateMac="false" %>
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
<div style="text-align:center;border: Solid 1px #FF0000;padding: 2px 2px 2px 2px;background-color:#FFFFFF;">
<span class="Header20 gold">North 22nd Street Shopping Corridor</span> <br />
<table width="100%">
<tr>
    <td style="width:50%; font-family:Georgia; font-size:13px; vertical-align:top; text-align:justify; padding:10px 4px 4px 4px;">
        The North 22nd Street Commercial Corridor is one of the oldest business corridors in Philadelphia dating back to the 1930's. 
        Some of the businesses are still in existence form that era. Until 1971 it was the home of the Philadelphia Phillies at Connie Mack Stadium at 21st and Lehigh. 
        In addition the Philadelphia A's, now the Oakland A's played at the same stadium until the early 50's. 
        The business district was surrounded in a one mile radius by a large corporate industrial base which employed more than 10,000 people. Business bustled.
        <br /><br />
        Things have changed since then, however North 22nd street is now the home of 95 businesses with a diverse ethnic ownership and business mix serving 39 different business categories listed on this website. 
        It has been the largest predominantly black owned business district in the city since the 70's. 
        Plans are underway for a Banquet Hall/Theatre with a breakfast lunch restaurant and a Marketplace designed like a miniature Reading Terminal which will house 8 to 10 retail businesses.
        <br /><br />
        For more information call 215 221 8836 or email us at n22st@yahoo.com.
        <br /><br />
        To search for a specific business, please use the directory to the right or the drop down list below.
    </td>
    <td>
        <img alt="North 22nd Street Shopping corridor" title="North 22nd Street Shopping corridor" src="Merchants/Images/MapMarked.jpg" />
    </td>
</tr>
</table>
<br />    
    <telerik:RadComboBox ID="cmbMerchants" runat="server" Width="250px" AutoPostBack="true" ZIndex="10000"
        onselectedindexchanged="cmbMerchants_SelectedIndexChanged">
    </telerik:RadComboBox>
</div>    
</asp:Content>

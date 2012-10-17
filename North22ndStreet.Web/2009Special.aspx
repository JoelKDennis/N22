<%@ Page Title="Holiday Sale Specials on North 22nd Street" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="2009Special.aspx.cs" Inherits="North22ndStreet.Web._009Special" EnableViewStateMac="false" %>
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
    <div style="text-align:center">
    <div style="width:560px;text-align:center; margin-left:auto; margin-right:auto;" class="semiTrans">
    <telerik:RadComboBox ID="cmbMerchants" runat="server" Width="300px" AutoPostBack="true" ZIndex="10000"
        onselectedindexchanged="cmbMerchants_SelectedIndexChanged">
    </telerik:RadComboBox>
    </div>   
</div>
    
<div class="spacer"></div>

<div style="text-align:center">
    <div style="background-color:#C40000; margin-left:auto; margin-right:auto; width:580px;" id="divTitle" runat="server">
        <asp:Label ID="lblStoreName" runat="server" CssClass="MerchantLabel1 white"></asp:Label>
        &nbsp;
        <asp:Label ID="lblStoreAddress" runat="server" CssClass="MerchantLabel3 white"></asp:Label>
    </div>
</div>

<div class="spacer" id="divSpacer" runat="server"></div>
<div style="width:100%;text-align:center;">

<asp:PlaceHolder ID="phSpecial" runat="server"></asp:PlaceHolder>


</div>
</asp:Content>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" Inherits="North22ndStreet.Web.Merchants.CategoryList" %>

<asp:PlaceHolder ID="phStyleSheet" runat="server">
</asp:PlaceHolder>
<div style="text-align:center">
<div runat="server" id="storelist" style="width:580px; height:900px; background-image:url('Merchants/BackgroundLinear.jpg');color:#FFF; text-align:center;margin-left:auto;margin-right:auto;">

<br /><br />
<br />
<div style="position:relative;left:145px;width:300px;padding:5px 5px 5px 5px;">
    <asp:PlaceHolder ID="phMerchantList" runat="server">
    </asp:PlaceHolder>
</div>
</div>
</div>
<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.Master" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="North22Admin.Web.Administration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style="text-align:right;">
    <asp:LinkButton ID="btnLogout" runat="server" Text="logout" 
        onclick="btnLogout_Click"></asp:LinkButton>
</div>
<br /><br /><br /><br />
Administration
<br /><br /><br /><br /><br /><br />
</asp:Content>

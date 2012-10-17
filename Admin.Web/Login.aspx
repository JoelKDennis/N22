<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.Master" AutoEventWireup="True" CodeBehind="Login.aspx.cs" Inherits="North22Admin.Web.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;">
<br /><br />
    
    <table width="400px" cellpadding="0"  cellspacing="0" style="margin-left:auto;margin-right:auto;">
        <tr>
            <td class="UpperLeftMaroon"></td>
            <td class="UpperCenterMaroon">login</td>
            <td class="UpperRightMaroon"></td>
        </tr>
    </table>
    <div class="OuterEntryBox">
        <div class="EntryBox">        
            <table width="100%" cellpadding="0"  cellspacing="0">            
                <tr>
                    <td colspan="2" style="height:25px;">&nbsp;</td>
                </tr>
                <tr>
                    <td style="width:50%; height:40px;">username</td>
                    <td style="width:50%; height:40px;">
                        <asp:TextBox ID="txtUsername" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width:50%; height:40px;">password</td>
                    <td style="width:50%; height:40px;">
                        <asp:TextBox ID="txtPassword" runat="server" Width="150px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                    <br />
                        <asp:Button ID="btnSubmit" runat="server" Text="submit" CssClass="buttonMaroon" 
                            onclick="btnSubmit_Click" />
                    </td>
                </tr>            
            </table>
            <br /><br />
            <asp:Label ID="lblErrorMessage" runat="server" Visible="false"></asp:Label>
        </div>
    </div>    
<br /><br />
</div>
</asp:Content>

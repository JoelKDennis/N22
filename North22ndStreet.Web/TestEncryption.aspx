<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestEncryption.aspx.cs" Inherits="North22ndStreet.Web.TestEncryption" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnEncrypt" runat="server" Text="Encrypt" 
            onclick="btnEncrypt_Click" />
    <asp:Button ID="btnDecrypt" runat="server" Text="Decrypt" 
            onclick="btnDecrypt_Click" />
    <br />
    <asp:TextBox ID="txtOutput" runat="server"></asp:TextBox>    
    </div>
    </form>
</body>
</html>

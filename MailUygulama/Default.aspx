<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MailUygulama.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <table>
    <form id="form1" runat="server">
        <tr>
            <td>Ad Soyad:</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>    
        </tr>
        <tr>
            <td>Email:</td>      
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Konu:</td>      
            <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> </td>
        </tr>
         <tr>
            <td>Mesaj:</td>      
            <td><asp:TextBox ID="TextBox4" runat="server" Height="140px" Width="188px" TextMode="MultiLine"></asp:TextBox> </td>
        </tr>
        <tr>
        <td>&nbsp;</td>
        <td>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </td>
        </tr>
        <tr>
        <td>&nbsp;</td>
        <td>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Gönder" />
        </td>
        </tr>
    </form>
    </table>
        </center>
</body>
</html>

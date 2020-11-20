<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nhập A:"></asp:Label>
        <asp:TextBox ID="txtA" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nhập B:"></asp:Label>
        <asp:TextBox ID="txtB" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nhập C:"></asp:Label>
        <asp:TextBox ID="txtC" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nhập D:"></asp:Label>
        <asp:TextBox ID="txtD" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Nhập E:"></asp:Label>
        <asp:TextBox ID="txtE" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnA" runat="server" OnClick="btnA_Click" Text="Câu A" />
&nbsp;&nbsp;
        <asp:Button ID="btnB" runat="server" OnClick="btnB_Click" Text="Câu B" />
&nbsp;&nbsp;
        <asp:Button ID="btnC" runat="server" OnClick="btnC_Click" Text="Câu C" />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Kết quả:"></asp:Label>
        <asp:Label ID="txtketqua" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>

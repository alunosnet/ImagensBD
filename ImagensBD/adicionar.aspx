<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adicionar.aspx.cs" Inherits="ImagensBD.adicionar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tb_texto" runat="server" />
            <br />
            <asp:FileUpload ID="fu_foto" runat="server" />
            <br />
            <asp:Button ID="bt_enviar" Text="Enviar" runat="server" OnClick="bt_enviar_Click" />
        </div>
    </form>
</body>
</html>

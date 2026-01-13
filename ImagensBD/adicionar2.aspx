<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adicionar2.aspx.cs" Inherits="ImagensBD.adicionar2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload runat="server" ID="fu_foto" />
            <asp:Button runat="server" ID="btn" Text="Enviar" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>

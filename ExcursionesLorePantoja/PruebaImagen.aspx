<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PruebaImagen.aspx.cs" Inherits="ExcursionesLorePantoja.PruebaImagen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Image ID="pictureBox1" runat="server" />
        </p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnEscoger" runat="server" OnClick="btnEscoger_Click" Text="MOSTRAR" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnEnviar" runat="server" Text="ENVIAR" OnClick="btnEnviar_Click" />
        </p>
    </form>
</body>
</html>

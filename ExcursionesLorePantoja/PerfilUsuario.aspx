<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="ExcursionesLorePantoja.PerfilUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-7 offset-2" style="border-color:black; border:thin;">
                  <h4 class="col-12">Datos Perfil&nbsp;</h4><hr/>
                    <p><asp:Label ID="LblGuardar" runat="server"></asp:Label></p>
                    <p><i class="glyphicon glyphicon-user "></i> Nombre(s):</p>
                    <p><asp:TextBox ID="TxtNombre" runat="server"  CssClass="form-control" ></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-user"></i> Apellido(s):</p>
                    <p><asp:TextBox ID="Textapellidos" runat="server"  CssClass="form-control" ></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-phone"></i> Telefono:</p>
                    <p><asp:TextBox ID="TxtTelefono" runat="server" style="margin:0 auto" CssClass="form-control"></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-home"></i> Edad:</p>
                    <p><asp:TextBox ID="Txtedad" runat="server" style="margin:0 auto" CssClass="form-control"></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-home"></i> Correo:</p>
                    <p><asp:TextBox ID="Textcorreo" runat="server" style="margin:0 auto" CssClass="form-control"></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-home"></i> Direccion:</p>
                    <p><asp:TextBox ID="Txtdireccion" runat="server" style="margin:0 auto" CssClass="form-control"></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-home"></i> Usuario:</p>
                    <p><asp:TextBox ID="Txtusuario" runat="server" style="margin:0 auto" CssClass="form-control"></asp:TextBox></p>
                    <p><i class="glyphicon glyphicon-home"></i> Contraseña:</p>
                    <p><asp:TextBox ID="Txtcontrasena" runat="server" style="margin:0 auto" CssClass="form-control"></asp:TextBox></p>
                    <p><asp:Button ID="BtnGuardar" runat="server" CssClass="btn btn-primary" Text="Guardar Registro" OnClick="BtnGuardar_Click"/></p>
            </div>
        </div>
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

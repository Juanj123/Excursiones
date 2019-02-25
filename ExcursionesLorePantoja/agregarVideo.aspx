<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="agregarVideo.aspx.cs" Inherits="ExcursionesLorePantoja.agregarVideo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    
    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12">
        
        <div class="row">
            <div class="col-md-6 col-lg-6 col-sm-6 col-xl-6">
                <h2>Agregar Video</h2> 
                <br />
                <asp:Label runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                <asp:Label runat="server" Text="Link"></asp:Label>
                <asp:TextBox runat="server" ID="txtUrl" CssClass="form-control" placeholder="Link"></asp:TextBox>
                <asp:Label runat="server" Text="Estado"></asp:Label>
                <asp:DropDownList runat="server" ID="dplActivo" CssClass="form-control" >
                    <asp:ListItem>Activo</asp:ListItem>
                    <asp:ListItem>Inactivo</asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:Button runat="server" id="btnGuardar" CssClass="btn btn-success col-3 justify-content-center" Text="Guardar" OnClick="btnGuardar_Click"/>
                <asp:Button runat="server"  ID="btnCancelar" CssClass="btn btn-danger col-3 justify-content-center" Text="Cancelar" OnClick="btnCancelar_Click"/>

            </div>
        </div>

    </div>

   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

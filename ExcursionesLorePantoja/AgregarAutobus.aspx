<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="AgregarAutobus.aspx.cs" Inherits="ExcursionesLorePantoja.AgregarAutobus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Agregar Autobus</h2>
                <div class="form-group">
                    <asp:Label runat="server" Text="Nombre"></asp:Label>
                    <asp:DropDownList runat="server" ID="dpdlNombre" CssClass="form-control">
                        <asp:ListItem>Volvo</asp:ListItem>
                        <asp:ListItem>Irizar</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-control-file">
                    <asp:Label runat="server" Text="Numero de Asientos"></asp:Label>
                    <asp:TextBox runat="server" ID="txtAsientos" CssClass="form-control" placeholder="Numero de asientos"></asp:TextBox>
                </div>
                <div class="form-group col-12">
                    <div class="row">
                        <div class="form-group col-1">
                            <asp:Button runat="server" ID="btnAgregar" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
                        </div>
                        <div class="form-group col-1">
                            <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-secondary" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

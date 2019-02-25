<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="AgregarGaleria.aspx.cs" Inherits="ExcursionesLorePantoja.AgregarGaleria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12">

        <div class="row">
            <div class="col-md-6 col-lg-6 col-sm-6 col-xl-6">
                <h2>Agregar imagen</h2>
                <br />
                
                
                <div class="row col-12">

                    <div class="form-control-file">
                        <asp:Label runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                    </div>


                    <div class="form-control-file col-9">
                        <asp:Label runat="server" Text="Ruta"></asp:Label>
                        <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <%--<asp:TextBox runat="server" ID="txtUrl" CssClass="form-control col-12" placeholder="Ruta"></asp:TextBox>--%>
                    </div>


                    <div class="form-control-file col-3">
                        <br />
                        <%--<asp:Button runat="server" ID="btnRuta" Text="Buscar Imagen" CssClass="btn btn-primary" OnClick="btnRuta_Click" />--%>
                    </div>

                </div>


                <br />
                <br />

                <asp:Button runat="server" ID="btnGuardar" Text="Guardar Imagen" CssClass="btn btn-success" OnClick="btnGuardar_Click" />







            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

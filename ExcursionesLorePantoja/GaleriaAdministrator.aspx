<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="GaleriaAdministrator.aspx.cs" Inherits="ExcursionesLorePantoja.PrincipalGaleria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Galeria</h2>
                <br />
                <asp:Button runat="server" ID="btnAgregarImagen" CssClass="btn btn-primary" Text="Agregar imagen" OnClick="btnAgregarImagen_Click" />
                <br />
                <br />
                <table id="tableGaleria" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                    <thead class=" text-white" style="background-color: #c3497f;">
                        <tr>
                            <th scope="col">Titulo</th>
                            <th scope="col">Ruta</th>
                            <th scope="col">Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">   
    <script src="scripts/Galeria.js"></script>
</asp:Content>

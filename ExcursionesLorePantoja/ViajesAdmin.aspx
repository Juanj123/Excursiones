<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="ViajesAdmin.aspx.cs" Inherits="ExcursionesLorePantoja.ViajesAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Viajes</h2>
                <br />
                <asp:Button runat="server" ID="btnAgregarViaje" CssClass="btn btn-success" Text="Agregar Viaje" OnClick="btnAgregarViaje_Click" />
                <br />

                 <table id="tableViajes" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                    <thead class=" text-white" style="background-color: #c3497f;">

                        <tr>
                            <th scope="col">Destino</th>
                            <th scope="col">Hora</th>
                            <th scope="col">fecha</th>
                            <th scope="col">Costo</th>
                            <th scope="col">Descripcion</th>
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
    <script src="scripts/Viajes.js"></script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="Autobus.aspx.cs" Inherits="ExcursionesLorePantoja.Autobus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Autobus</h2>
                <br />
                <asp:Button runat="server" ID="btnAgregarAutobus" CssClass="btn btn-success" Text="Agregar Autobus" OnClick="btnAgregarAutobus_Click" />
                <br />

                 <table id="tableAutobus" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                    <thead class=" text-white" style="background-color: #c3497f;">

                        <tr>
                            <th scope="col">Numero de autobus</th>
                            <th scope="col">nombre</th>
                            <th scope="col">Numero de asientos</th>
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
    <script src="scripts/Autobus.js"></script>
</asp:Content>

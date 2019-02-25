<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="Clientes.aspx.cs" Inherits="ExcursionesLorePantoja.Clientes" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <link href="content/estiloClientes.css" rel="stylesheet" />

    <h1 class="text-center" id="titulo">Agenda de Clientes</h1>
    <br />
    <br />

    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                  <table id="tableClientes" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                    <thead class=" text-white" style="background-color: #c3497f;">

                        <tr>
                            <th scope="col">Nombres</th>
                            <th scope="col">Apellidos</th>
                            <th scope="col">Correo</th>
                            <th scope="col">Nombre de Usuario</th>
                            <th scope="col"></th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>

                 <!-- Modal -->
                <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLongTitle">Datos</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Nombres"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNombres" ReadOnly="true" CssClass="form-control" placeholder="Nombres"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Apellidos"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtApellidos" ReadOnly="true" CssClass="form-control" placeholder="Apellidos"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label runat="server" Text="Correo"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtCorreo" ReadOnly="true" CssClass="form-control" placeholder="Correo"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label runat="server" Text="Usuario"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtUsuario" ReadOnly="true" CssClass="form-control" placeholder="Usuario"></asp:TextBox>
                                </div>

                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="scripts/clientes.js"></script>
</asp:Content>

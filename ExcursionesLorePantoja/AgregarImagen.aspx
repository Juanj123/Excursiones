<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="AgregarImagen.aspx.cs" Inherits="ExcursionesLorePantoja.AgregarImagen" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Agregar Imagen</h2>
                <br />
                <table id="tableImagen" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
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

                <%--modal--%>
                <div class="modal fade" id="exampleModalCenter" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                    <div class="modal-dialog modal-dialog-centered" role="document">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLongTitle">Seleccionar Imagen</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Titulo"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtTitulo" ReadOnly="true" CssClass="form-control" placeholder="Titulo"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Ruta"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtRuta" ReadOnly="true" CssClass="form-control" placeholder="Ruta"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Descripción"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control col-12" TextMode="MultiLine" Rows="3" placeholder="Descripcion"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Estado"></asp:Label>
                                    <asp:DropDownList runat="server" ID="dplActivo" CssClass="form-control">
                                        <asp:ListItem>Activo</asp:ListItem>
                                        <asp:ListItem>Inactivo</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="form-group">

                                    <img id="imgGale" src="img/benches.jpg" style="width: 25%; height: 15%;" />
                                </div>
                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                                <button type="button" class="btn btn-primary" id="btnSeleccionar">Seleccionar</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="scripts/AgregarImagen.js"></script>
</asp:Content>

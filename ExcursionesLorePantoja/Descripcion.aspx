<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="Descripcion.aspx.cs" Inherits="ExcursionesLorePantoja.Descripcion" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <%--captura de descripcion--%>
            <h1>Descripcion de Imagenes</h1>
            <br />
            <br />
            <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control col-12" TextMode="MultiLine" Rows="3" placeholder="Descripcion"></asp:TextBox>


            <br />
            <br />


            <asp:Label runat="server" Text="Estado"></asp:Label>
            <asp:DropDownList runat="server" ID="dplActivo" CssClass="form-control">
                <asp:ListItem>Activo</asp:ListItem>
                <asp:ListItem>Inactivo</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button runat="server" ID="btnAgregar" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
            <br />
            <br />

            <table id="tableDescripcion" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                <thead class=" text-white" style="background-color: #c3497f;">

                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Descripcion</th>
                        <th scope="col">Estado</th>
                        <th scope="col">Acciones</th>
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
                                <h5 class="modal-title" id="exampleModalLongTitle">Actualizar Descripcion</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <asp:Label runat="server" Text="#"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNumero" ReadOnly="true" CssClass="form-control" placeholder="#"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Descripcion"></asp:Label>
                                     <asp:TextBox runat="server" ID="txtDescripcionM"  CssClass="form-control col-12" TextMode="MultiLine" Rows="3" placeholder="Descripcion"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label runat="server" Text="Estado"></asp:Label>
                                    <asp:DropDownList runat="server" ID="DropDownList1" CssClass="form-control">
                                        <asp:ListItem>Activo</asp:ListItem>
                                        <asp:ListItem>Inactivo</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <%--<div class="form-group">

                                </div>--%>


                               
                                <%--<asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-success col-3 justify-content-center" Text="Guardar" OnClick="btnGuardar_Click" />
                                <asp:Button runat="server" ID="btnCancelar" CssClass="btn btn-danger col-3 justify-content-center" Text="Cancelar" OnClick="btnCancelar_Click" />--%>

                            </div>
                            <div class="modal-footer">
                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Cancelar</button>
                                <button type="button" class="btn btn-primary" id="btnActualizar">Actualizar</button>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="scripts/Principal.js"></script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="AgregarPrincipalGaleria.aspx.cs" Inherits="ExcursionesLorePantoja.AgregarPrincipalGaleria" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <%--                <asp:Label runat="server" Text="Numero de descripcion"></asp:Label>
                <asp:DropDownList runat="server" ID="dpdlIdDescripcion">
                </asp:DropDownList>

                <br />
                <br />
                <asp:Label runat="server" Text="Direccion de imagen"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server"   />
                
                <br />
                <br />
                 <asp:Button runat="server" ID="btnGuardar" Text="Guardar Imagen" CssClass="btn btn-success" OnClick="btnGuardar_Click"/>--%>

                <table id="tablePrincipalGleria" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
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
                                    <img id="imgGale" src="#" alt="Second slide" style="width: 50%; height: 25%;" />
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
    <script src="scripts/agregarPrincipalGaleria.js"></script>
</asp:Content>

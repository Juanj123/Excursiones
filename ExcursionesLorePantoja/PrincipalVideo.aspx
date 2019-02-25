<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="PrincipalVideo.aspx.cs" Inherits="ExcursionesLorePantoja.PrincipalVideo" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Video</h2>
                <asp:Literal runat="server" ID="ltVideo" Text=""></asp:Literal>

                <br />


                <asp:Button runat="server" ID="btnAgregarVideo" CssClass="btn btn-primary" Text="Agregar Video" OnClick="btnAgregarVideo_Click" />

                <br />
                <br />
                <%--tabla jquery--%>
                <%--<asp:Literal runat="server" ID="ltTabla"></asp:Literal>--%>

                <table id="tableGroups" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                    <thead class=" text-white" style="background-color: #c3497f;">

                        <tr>
                            <th scope="col">Nombre</th>
                            <th scope="col">Estado</th>
                            <th scope="col">Ruta</th>
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
                                <h5 class="modal-title" id="exampleModalLongTitle">Actualizar Video</h5>
                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                    <span aria-hidden="true">&times;</span>
                                </button>
                            </div>
                            <div class="modal-body">
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Nombre"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNombre" ReadOnly="true" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:Label runat="server" Text="Link"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtUrl" ReadOnly="true" CssClass="form-control" placeholder="Link"></asp:TextBox>
                                </div>

                                <div class="form-group">
                                    <asp:Label runat="server" Text="Estado"></asp:Label>
                                    <asp:DropDownList runat="server" ID="dplActivo" CssClass="form-control">
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
    </div>



</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="scripts/video.js" type="text/javascript"></script>
</asp:Content>

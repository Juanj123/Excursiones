<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="PrincipalGaleria.aspx.cs" Inherits="ExcursionesLorePantoja.PrincipalGaleria1" ClientIDMode="Static" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
           

            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
                    <div class="carousel-inner">
                        <asp:Literal runat="server" ID="ltImg" Text=""></asp:Literal>
                    </div>
                    <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>

                <br />
                <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12" style="overflow: hidden; background-color: white; border-radius: 15px; box-shadow: 1px 1px 2px 1px #818181;">
                    
                    <asp:Literal runat="server" ID="ltParrafo" Text=""></asp:Literal>
                    
                       
                    
                </div>

                <br />
                <asp:Button runat="server" ID="btnDescripcion" Text="Agregar Descripción" CssClass="btn btn-success" OnClick="btnDescripcion_Click" />
                <br />
                <%--tabla de imagenes para el carousel--%>
                <h2>Imagenes del Carousel</h2>

                <asp:Button runat="server" ID="btnAgregarImg" CssClass="btn btn-primary"  Text="agregar Imagen" OnClick="btnAgregarImg_Click" />

                 <table id="tablePrincipalGleria" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                    <thead class=" text-white" style="background-color: #c3497f;">

                        <tr>
                            <th scope="col">Numero de imagen</th>
                            <th scope="col">Ruta de imagen</th>
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
    <script src="scripts/PrincipalGaleria.js"></script>
</asp:Content>

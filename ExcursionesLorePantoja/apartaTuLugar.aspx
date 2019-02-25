<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="apartaTuLugar.aspx.cs" Inherits="ExcursionesLorePantoja.apartaTuLugar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <link rel="stylesheet" href="content/animate.min.css">
    <link rel="stylesheet" href="content/apartaTuLugar.css" />
    <div id="tarjetaLugarViaje" style="position: absolute; margin-left: 50%">
        <h2 style="position: center">
            <asp:Literal ID="lblDestino" ClientIDMode="Static" runat="server" Mode="Transform">Guanajuato, Guanajuato</asp:Literal></h2>
        <div class="card" style="width: 25rem;">
            <img class="card-img-top" src="imgPrueba/pueblos-magicos-de-Guanajuato_Header.jpg" alt="Card image cap">
            <div class="card-body">
                <h4 class="card-text">Precios:</h4>
                <h5 class="card-text">Adulto:
                    <asp:Label ID="lblPrecioAdulto1" ClientIDMode="Static" runat="server" Mode="Transform"></asp:Label></h5>
                <h5 class="card-text">Niño:
                    <asp:Label ID="lblPrecioNino1" ClientIDMode="Static" runat="server" Mode="Transform"></asp:Label></h5>
                <asp:LinkButton CssClass="btn btn-success" runat="server"> <i class="fas fa-info"></i> Mas Informacion</asp:LinkButton>
            </div>
        </div>
    </div>
    <div class="card-deck mb-3 text-center">
        <div class="col-md-4" id="opcionesApartaTuLugar" style="margin-top: 3%; margin-left: 200px">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h4 class="my-0 font-weight-normal">Aparta Tu Lugar</h4>
                </div>
                <ul class="list-group list-group-flush">
                    <li class="list-group-item">
                        <div class="form-group col-md-4">
                            <label for="inputState">Adultos</label>
                            <select id="cmbAdultos" class="form-control">
                                <option selected>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                                <option>6</option>
                                <option>7</option>
                                <option>8</option>
                                <option>9</option>
                                <option>10</option>
                            </select>
                        </div>
                        
                        <label id="lblAdultos" style="position: absolute; margin-left: -50px; margin-top: -50px">Total a pagar</label>
                        <script>
                            function pagoAdulto() {
                                var n1 = document.getElementById('cmbAdultos').value;
                                var precio = document.getElementById('<%=lblPrecioAdulto1.ClientID%>').innerText;
                                var suma = parseInt(n1) * precio;
                                return suma;
                            }

                            function pagoNino() {
                                var precio = document.getElementById('<%=lblPrecioNino1.ClientID%>').innerText;
                                var n2 = document.getElementById('cmbNinos').value;
                                var suma = precio * parseInt(n2);
                                return suma;
                            }
                            $("#cmbAdultos").change(function () {
                                $("#txtTotal").val(Sumar());
                                $("#lblTotalAdultos1").html("$" + pagoAdulto().toString());
                            });
                            $("#cmbNinos").change(function () {
                                $("#txtTotal").val(Sumar());
                                $("#lblTotalNinos1").html("$" + pagoNino().toString());
                            });
                        </script>
                        <h1 id="lblTotalAdultos" style="position: absolute; margin-left: 250px; margin-top: -63px"></h1>
                        <div class="container">
                            <div class="well well-sm text-center">
                                <div class="btn-group" data-toggle="buttons">
                                    <label id="btnNiños" class="btn btn-success active">
                                        ¿Usted llevara niños Mayores de 6 Años?
				<input id="checkNiños" type="radio" name="options">
                                        <span class="glyphicon glyphicon-ok"></span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    </li>
                    <li class="list-group-item">
                        <div id="oculto" class="form-group col-md-4" style="display: none">
                            <label for="inputState">Niños</label>
                            <select id="cmbNinos" class="form-control">
                                <option selected>0</option>
                                <option>1</option>
                                <option>2</option>
                                <option>3</option>
                                <option>4</option>
                                <option>5</option>
                                <option>6</option>
                                <option>7</option>
                                <option>8</option>
                                <option>9</option>
                                <option>10</option>
                            </select>
                        </div>
                        <label id="lblNinos" style="position: absolute; margin-left: 130px; margin-top: -50px; display: none">Total a pagar</label>
                        <h1 id="lblTotalNinos" style="position: absolute; margin-left: 250px; margin-top: -65px; display: none"></h1>
                    </li>
                    <li class="list-group-item">
                        <h3 style="margin-left: -70px">Total de Asientos</h3>
                        <input class="form-control" id="txtTotal" readonly="readonly" type="text" style="position: inherit; width: 50px; height: 50px; text-align: center; margin-top: -45px; margin-left: 270px" />
                        <button type="button" class="btn btn-danger" id="btnSelectAsientos">Escoge tus asientos</button>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <div id="pegaAquiAutobus"></div>

    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="false" data-backdrop="static">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Confirmar Lugares</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-outline-danger" id="btnCerrar">Cancelar</button>
                    <asp:Button runat="server" CssClass="btn btn-outline-dark" ID="BtnEnviar" Text="Confirmar Lugares" OnClick="BtnEnviar_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="modal Reposo" tabindex="-1" role="dialog" id="ModalReposo">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header" style="background-color: black; color: white">
                    <h5 class="modal-title">Se excedio el numero de Lugares Seleccionados</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <p>¡Usted excedió el número de asientos válidos para las personas que selecciono anteriormente!</p>
                    <p><b>por favor ingrese el numero de personas correctas</b></p>
                    <div id="innecesario">
                        <p id="lblLugares"><b></b></p>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary" id="btnAceptarError">Aceptar</button>
                </div>
            </div>
        </div>
    </div>
    <asp:Literal Visible="false" runat="server" Mode="Transform" ID="litModal">
        <div class="modal" tabindex="-1" role="dialog" id="Validacion">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title">Validacion Edad</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
        <div class="demo">

    <label for="dia">Seleccione Dia</label>
    <select name="dia" id="cmbDia">
      <option>1</option>
      <option>2</option>
      <option>3</option>
      <option>4</option>
      <option>5</option>
      <option>6</option>
      <option>7</option>
      <option>8</option>
      <option>9</option>
      <option>10</option>
      <option>11</option>
      <option>12</option>
      <option>13</option>
      <option>14</option>
      <option>15</option>
      <option>16</option>
      <option>17</option>
      <option>18</option>
      <option>19</option>
      <option>20</option>
      <option>21</option>
      <option>22</option>
      <option>23</option>
      <option>24</option>
      <option>25</option>
      <option>26</option>
      <option>27</option>
      <option>28</option>
      <option>29</option>
      <option>30</option>
      <option>31</option>
    </select>
 
    <label for="mes">Seleccione Mes</label>
    <select name="mes" id="cmbMes">
      <option>1</option>
      <option>2</option>
      <option>3</option>
      <option>4</option>
      <option>5</option>
      <option>6</option>
      <option>7</option>
      <option>8</option>
      <option>9</option>
      <option>10</option>
      <option>11</option>
      <option>12</option>
    </select>
 
    <label for="año">Seleccione Año</label>
    <select name="año" id="cmbAño">
      <option>2003</option>
      <option>2002</option>
      <option>2001</option>
      <option>2000</option>
      <option>1999</option>
      <option>1998</option>
      <option>1997</option>
      <option>1996</option>
      <option>1995</option>
      <option>1994</option>
      <option>1993</option>
      <option>1992</option>
      <option>1991</option>
      <option>1990</option>
      <option>1989</option>
      <option>1988</option>
      <option>1987</option>
      <option>1986</option>
      <option>1985</option>
      <option>1984</option>
      <option>1983</option>
      <option>1982</option>
      <option>1981</option>
      <option>1980</option>
      <option>1979</option>
      <option>1978</option>
      <option>1977</option>
      <option>1976</option>
      <option>1975</option>
      <option>1974</option>
      <option>1973</option>
      <option>1972</option>
      <option>1971</option>
      <option>1970</option>
      <option>1969</option>
      <option>1968</option>
      <option>1967</option>
      <option>1966</option>
      <option>1965</option>
      <option>1964</option>
      <option>1963</option>
      <option>1962</option>
      <option>1961</option>
      <option>Otro</option>
    </select>
</div>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
        <button type="button" class="btn btn-primary">Guardar</button>
      </div>
    </div>
  </div>
</div>
    </asp:Literal>

    <script src="scripts/jquery-3.2.1.min.js"></script>
    <script src="scripts/internos/apartaTuLugar.js"></script>
    <script src="scripts/internos/Autobus.js"></script>
    <script src="scripts/bootbox.min.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

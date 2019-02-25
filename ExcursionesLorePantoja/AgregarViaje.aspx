<%@ Page Title="" Language="C#" MasterPageFile="~/HomeAdministrator.Master" AutoEventWireup="true" CodeBehind="AgregarViaje.aspx.cs" Inherits="ExcursionesLorePantoja.AgregarViaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <h2>Agregar Viaje</h2>
                <div class="form-group">
                    <asp:Label runat="server" Text="Numero De Autobus">
                    </asp:Label>
                    <asp:DropDownList runat="server" ID="dpdlAutobus" CssClass="form-control">
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Destino"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDestino" placeholder="Destino" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Hora de salida"></asp:Label>
                    <asp:TextBox runat="server" ID="txtHora" placeholder="Hora de salida" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Costo Adulto"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCosto" placeholder="Costo Adulto" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Costo mayores de 6 años"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCostoM" placeholder="Costo mayores de 6 años" CssClass="form-control"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <asp:Label runat="server" Text="Costo menores de 6 años"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCostoMen" placeholder="Costo menores de 6 años" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Descripcion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDescripcion" placeholder="Descripcion" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group col-12">
                    <asp:Label runat="server" Text="año"></asp:Label>
                    <div class="row">
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txtDia" placeholder="Día" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txtMes" placeholder="Mes" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="txtAnio" placeholder="Año" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" Text="Nota"></asp:Label>
                    <asp:TextBox runat="server" ID="txtNota" placeholder="Nota" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" Text="Itinerario"></asp:Label>
                    <asp:TextBox runat="server" ID="txtItinerario" placeholder="Itinerario" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
                </div>
                 <div class="form-control-file col-9">
                        <asp:Label runat="server" Text="Imagen"></asp:Label>
                        <br />
                        <asp:FileUpload ID="FileUpload1" runat="server" BorderStyle="None" CssClass="col-12"/>
                        <%--<asp:TextBox runat="server" ID="txtUrl" CssClass="form-control col-12" placeholder="Ruta"></asp:TextBox>--%>
                    </div>
                <br />
                <div class="form-group col-12">
                    <div class="row">
                        <div class="form-group col-1">
                            <asp:Button runat="server" ID="btnAgregar" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
                        </div>
                        <div class="form-group col-1">
                            <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-secondary" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

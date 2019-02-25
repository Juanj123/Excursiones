<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="ExcursionesLorePantoja.PerfilUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-xl-4 ">
                <h3 class="mt-3 pt-3 text-center">Datos Personales</h3>
            <div class="form-group">
                <asp:Label Text="Nombre(s):" runat="server" CssClass="control-label col-xl-12"/>
                <div class="col-xl-12">
                    <asp:TextBox ID="txtnombres" CssClass="form-control col-xl-12" TextMode="SingleLine" runat="server" />
                </div>
            </div>
              
            <div class="form-group">
                <asp:Label Text="Apellido(s):" runat="server" CssClass="control-label col-md-4"/>
                <div class="col-xl-12">
                    <asp:TextBox ID="txtapellidos" CssClass="form-control" TextMode="SingleLine" runat="server" />
                </div>
            </div>
                
            <div class="form-group">
                <asp:Label Text="Telefono:" runat="server" CssClass="control-label col-md-4"/>
                <div class="col-xl-12">
                    <asp:TextBox ID="txtTelefono" CssClass="form-control" TextMode="SingleLine" runat="server" />
                </div>
            </div>
               
            <div class="form-group">
                <asp:Label Text="Direccion:" runat="server" CssClass="control-label col-md-4"/>
                <div class="col-xl-12">
                    <asp:TextBox ID="txtDireccion" CssClass="form-control" TextMode="SingleLine" runat="server" />
                </div>
                </div>

            <div class="form-group">
                <asp:Label Text="Correo:" runat="server" CssClass="control-label col-md-4"/>
                <div class="col-xl-12">
                    <asp:TextBox ID="txtCorreo" CssClass="form-control" TextMode="SingleLine" runat="server" />
                </div>
              </div>
           
          </div>
    
    <div class="col-xl-8">
        
        <div class="container mt-5 pt-3">
            <table id="tableGroups" class="table table-bordered table-hover table-responsive-sm table-responsive-md text-center">
                <thead class="border-dark text-white" style="background-color: #c3497f;">
                    <tr>
                        <th scope="col">Control Viajes </th> 
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>Ixtapa 12/01/2018</td>
                       
                    </tr>
                    <tr>
                         <td>Mazatlan 12/01/2018</td>
                    </tr>
                    
                </tbody>
            </table>
        </div>
    
    </div>
    </div>
  </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="ViajesUsers.aspx.cs" Inherits="ExcursionesLorePantoja.ViajesUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
   
     <link href="content/estilosPrincipal.css" rel="stylesheet" />
    <br />
     <div class="container-fluid">
        <div class="row">
            <div class="col-1 text-center">
                 <asp:Label Text="Buscar" runat="server" CssClass="col-12 text-center" />
            </div>
            <div class="col-7">
                <asp:TextBox runat="server"  ID="txtbuscarviaje" CssClass="col-12 form-control" AutoPostBack="True" OnTextChanged="txtbuscarviaje_TextChanged"/>
            </div>
            <div class="col-4">
                <div class="container-fluid">
                    <div class="row">
                     <fieldset class="col-12">
                <asp:RadioButton ID="rbndestino" Text="Destino" runat="server" CssClass="col-6" GroupName="measurementSystem"/>&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbnmes" Text="Mes" runat="server" CssClass="col-6" GroupName="measurementSystem"/>&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="rbnano" Text="Año" runat="server" CssClass="col-6" GroupName="measurementSystem"/>
                <%--<asp:RadioButton Text="Destino" runat="server" CssClass="col-4" GroupName="measurementSystem"/>--%>
                </fieldset>
                </div>
                </div> 
            </div>
        </div>
        <br />
        <br />
      

        <div class="row col-12">
             <asp:Literal Text="" runat="server" ID="ltViajes" />
        </div>
    </div>
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="scripts/idviaje.js" type="text/javascript"></script>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="GaleriaUsers.aspx.cs" Inherits="ExcursionesLorePantoja.GaleriaUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <link href=" https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.css" rel="stylesheet" />
    <link href="content/estilosGaleria.css" rel="stylesheet" />
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <asp:DropDownList ID="combodestinos" runat="server" CssClass="form-control" AppendDataBoundItems="true" OnSelectedIndexChanged="combodestinos_SelectedIndexChanged">
                    <%--<asp:ListItem Value="0">&lt;Seleccione destino&gt;</asp:ListItem>--%>
                </asp:DropDownList>
            </div>
        </div>
        <div class="row">
            <div class="container gallery-container col-md-12 col-lg-12 col-sm-12 col-xl-12">
                <div class="tz-gallery">
                    <div class="row mb-3">
                <asp:Literal  runat="server" ID="ltimagenesgaleria"/>
                </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/baguettebox.js/1.8.1/baguetteBox.min.js"></script>
    <script>
    baguetteBox.run('.tz-gallery');
</script>
</asp:Content>

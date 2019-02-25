<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="PrincipalUsers.aspx.cs" Inherits="ExcursionesLorePantoja.PrincipalUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
     <link href="content/estilosPrincipal.css" rel="stylesheet" />

    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12">
        <div class="row">
            <div class="col-md-12 col-lg-12 col-sm-12 col-xl-12">

                <iframe class="d-block w-100" width="800" height="400" src="https://www.youtube.com/embed/znk2OICHbjY?controls=0" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
                
            
                
                <hr />
                <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12" style="overflow: hidden; background-color: white; border-radius: 15px; box-shadow: 1px 1px 2px 1px #818181;" id="conte1">
                    
                    <div class="col-4">
                        <h5>Fotos</h5>
                     
                            <div id="carouselExampleControls" class="carousel slide" data-ride="carousel" style="float:left; border-radius: 15px; width: 100%; height: 100%;">
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
                    
                    
                        </div>
                    
                    <div class="col-8"  id="texto" style=" overflow: hidden; float:left; border-radius: 20px;">
                        <asp:Literal runat="server" ID="ltParrafo" Text=""></asp:Literal>
                       <%-- <p class="text-justify e">
                            viéndole don Quijote de aquella manera, con muestras de tanta tristeza, le dijo: Sábete, Sancho, que no es un hombre más que otro si no hace más que otro. Todas estas borrascas que nos suceden son señales de que presto ha de serenar el tiempo y han de sucedernos bien las cosas; porque no es posible que el mal ni el bien sean durables, y de aquí se sigue que, habiendo durado mucho el mal, el bien está ya cerca. Así que, no debes congojarte por las desgracias que a mí me suceden, pues a ti no te cabe
                        </p>--%>
                    </div>
        
                </div>
            </div>
            
        </div>
         <hr />
        <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12" style="overflow:hidden; background-color:white; border-radius: 15px; box-shadow: 1px 1px 2px 1px #818181;" id="conte2">
            <h5>Fotos de Isla Mujeres</h5>
            <div class="col-8" style="float:left;">
                <p class="text-justify e">
                    Textosimulado
                    Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha, que estaba
                    a punto de escurrirse hasta el suelo. Numerosas patas, penosamente delgadas en comparación con el grosor
                    normal de sus piernas, se agitaban sin concierto. - ¿Qué me ha ocurrido? No estaba soñando. Su habitación, una
                     le hizo sentir una gran melancolía.
                </p>
                
            </div>
            <div class="col-4" style="float:left; border-radius: 15px;" id="im1">
                <img src="img/park.jpg"  style="width:90%; height:90%;"/>
            </div>
           
        </div>
         <hr />

        <h1>viajes cercanos</h1>
        <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12" style="overflow:hidden;">
            <div class="promo" style="float:left; overflow:hidden; ">
                <div class="imge" >
                    <img src="img/sunrise-1014712_640.jpg" style="  width: 400px; height: 200px;">
                </div>
                <h3>Guanajuato</h3>
                <div class="txt">
                     <p class="text-justify pe">
                    Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.
                    </p>
                </div>

                  <div class="pi" style="overflow: hidden;">
                    <h4 style="float:left">$200</h4>
                    <asp:LinkButton CssClass="btn btn-success" ID="LinkButton1" runat="server" Text="Reservar" style="float:right"><i class="fas fa-bus"></i> Reservar</asp:LinkButton>
                </div>
            </div>
            <div class="promo" style="float:left; overflow:hidden;">
         <div class="imge" >
                    <img src="img/benches.jpg" style="  width: 400px; height: 200px;">
                </div>
                <h3>Querétaro</h3>
                <div class="txt">
                     <p class="text-justify pe">
                    Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.
                    </p>
                </div>

                   <div class="pi" style="overflow: hidden;">
                    <h4 style="float:left">$200</h4>
                    <asp:LinkButton CssClass="btn btn-success" ID="Button1" runat="server" Text="Reservar" style="float:right"> <i class="fas fa-bus"></i> Reservar </asp:LinkButton>
                </div>
            </div>
            <div class="promo" style="float:left; overflow:hidden;"> 
                <div class="imge" >
                    <img src="img/bridge.jpg" style="  width: 400px; height: 200px;">
                </div>
                <h3>Isla Mujeres</h3>
                <div class="txt">
                     <p class="text-justify pe">
                         Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.
                    </p>
                </div>
                <div class="pi" style="overflow: hidden;">
                    <h4 style="float:left">$200</h4>
                    <asp:LinkButton CssClass="btn btn-success" ID="idReservar" runat="server" Text="Reservar" style="float:right"> <i class="fas fa-bus"></i> Reservar</asp:LinkButton>
                </div>
                
            </div>

              <div class="promo" style="float:left; overflow:hidden; ">
                <div class="imge" >
                    <img src="img/coast.jpg" style="  width: 400px; height: 200px;">
                </div>
                <h3>Guanajuato</h3>
                <div class="txt">
                     <p class="text-justify pe">
                    Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.
                    </p>
                </div>

                   <div class="pi" style="overflow: hidden;">
                    <h4 style="float:left">$200</h4>
                    <asp:LinkButton CssClass="btn btn-success" ID="Button3" runat="server" Text="Reservar" style="float:right"> <i class="fas fa-bus"></i> Reservar</asp:LinkButton>
                </div>
            </div>
            <div class="promo" style="float:left; overflow:hidden;">
         <div class="imge" >
                    <img src="img/rails.jpg" style="  width: 400px; height: 200px;">
                </div>
                <h3>Querétaro</h3>
                <div class="txt">
                     <p class="text-justify pe">
                    Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.
                    </p>
                </div>

                   <div class="pi" style="overflow: hidden;">
                    <h4 style="float:left">$200</h4>
                    <asp:LinkButton CssClass="btn btn-success" ID="Button4" runat="server" Text="Reservar" style="float:right"><i class="fas fa-bus"></i> Reservar</asp:LinkButton>
                </div>
            </div>
            <div class="promo" style="float:left; overflow:hidden;"> 
                <div class="imge" >
                    <img src="img/rocks.jpg" style="  width: 400px; height: 200px;">
                </div>
                <h3>Isla Mujeres</h3>
                <div class="txt">
                     <p class="text-justify pe">
                         Una mañana, tras un sueño intranquilo, Gregorio Samsa se despertó convertido en un monstruoso insecto.
                    Estaba echado de espaldas sobre un duro caparazón y, al alzar la cabeza, vio su vientre
                    convexo y oscuro, surcado por curvadas callosidades, sobre el que casi no se aguantaba la colcha.
                    </p>
                </div>
                <div class="pi" style="overflow: hidden;">
                    <h4 style="float:left">$200</h4>
                    <asp:LinkButton CssClass="btn btn-success" ID="Button5" runat="server" Text="Reservar" style="float:right"><i class="fas fa-bus"></i> Reservar</asp:LinkButton>
                </div>
                
            </div>
        </div>
    <hr />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

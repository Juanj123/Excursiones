<%@ Page Title="" Language="C#" MasterPageFile="~/HomeUsers.Master" AutoEventWireup="true" CodeBehind="ControlAbonosUsuarios.aspx.cs" Inherits="ExcursionesLorePantoja.ControlAbonosUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bod" runat="server">
    <link href="content/estilosControlAbonos.css" rel="stylesheet" />
    <h1 class="text-center" id="titulo">Control de abonos</h1>
    <br />
    <br />
    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12" id="c1">
        <div class="row justify-content-center">
            <div class="col-sm-10 col-md-3">
                <div class="card t">
                    <div class="card-header ch">3</div>
                        <div class="card-body alert">
                            <h5 class="card-title" >Personas
                                <i class="fas fa-users"></i>
                            </h5>
                            <p class="card-text">Número de personas que irán al viaje.</p>
                        </div>
                </div>
            </div>
            <div class="col-sm-10 col-md-3">
                <div class="card t">
                    <div class="card-header ch">2</div>
                        <div class="card-body">
                            <h5 class="card-title">Reservaciones
                                <i class="fas fa-suitcase"></i>
                            </h5>
                            
                                <ul>
                                    <li>Michoacán</li>
                                    <li>Guanajuato</li>
                                </ul>
                            
                        </div>
                </div>
            </div>
            <div class="col-sm-10 col-md-3">
                <div class="card t">
                    <div class="card-header ch">5</div>
                        <div class="card-body">
                            <h5 class="card-title">Pagos realizados
                                <i class="fas fa-money-bill-alt"></i>
                            </h5>
                            <p class="card-text">Realice sus pagos a tiempo.</p>
                            <a href="#" class="btn btn-success">Realizar pago</a>
                        </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    

    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12">
        <div class="row">          
                <div class="container col-md-12 col-lg-10 col-sm-12 col-xl-10 align-content-center" id="tabla">
                    <div class="container col-md-12 col-lg-12 col-sm-12 col-xl-12">
                    <br />                    
                    <div class="row justify-content-center">
                        
                        <div class="col-md-6 col-sm-12 offset-md-6">
                        <div class=" d-flex justify-content-end">
                        <div class="input-group">
                            <span class="input-group-label">
                                <button class="btn btn-success btn1" type="submit"> <i class="fas fa-search"></i></button>
                            </span>
                            <input class="form-control col-sm-7" type="search" placeholder="Buscar" aria-label="Search">
                            <select class="form-control col-sm-2" id="seleccionar">
                                <option value="">1</option>
                                <option value="">2</option>
                                <option value="">3</option>
                            </select>
                        </div>
                        </div>
                        </div>
                        

                        <br />
                        </div>
                    </div>

                    <br />
                    <br />
    
                    <div class="table-responsive">
                    <!--Table-->
                    <table class="table table-striped">

                    <!--Table head-->
                    <thead>
                        <tr id="eTabla">
                            <th>Fecha</th>
                            <th>Lugar</th>
                            <th>Monto</th>
                        </tr>
                    </thead>
                    <!--Table head-->

                    <!--Table body-->
                    <tbody>
                        <tr>
                            <th scope="row">13/02/2018</th>
                            <td>Guanajuato</td>
                            <td>$600</td>
                        </tr>
                        <tr>
                            <th scope="row">11/09/2018</th>
                            <td>Mazatlán</td>
                            <td>$5000</td>
                        </tr>
                        <tr>
                            <th scope="row">24/11/2018</th>
                            <td>Ixtapa</td>
                            <td>$3000</td>
                        </tr>
                    </tbody>
                    <!--Table body-->
                    
                    </table>
                    <!--Table-->
                    </div>
                    
                    <div>

                    </div>

                    </div>
            
            
                </div>
        <div class="row justify-content-center pag">
            
            <div class="col-sm-8 col-md-3">
                <ul class="pagination">
                    <li class="page-item"><a class="page-link" href="#"><<</a></li>
                    <li class="page-item"><a class="page-link" href="#">1</a></li>
                    <li class="page-item"><a class="page-link" href="#">2</a></li>
                    <li class="page-item"><a class="page-link" href="#">3</a></li>
                    <li class="page-item"><a class="page-link" href="#">>></a></li>
                </ul>
            </div>
            
        </div>
            </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
</asp:Content>

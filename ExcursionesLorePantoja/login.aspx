<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ExcursionesLorePantoja.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="content/Boostrap/bootstrap.min.css" rel="stylesheet" />
    <link href="scripts/bootstrap/bootstrap.js" rel="stylesheet" type="text/css" />
    <title>Login</title>
 <link rel="shortcut icon" href="img/Niña.png" />
    <style type="text/css">
        body {
            margin: 0;
            padding: 0;
            background: url(img/beach-1236581.jpg);
            width:100%;
            background-repeat: no-repeat;
            background-size:cover;
            font-family: sans-serif;
        }
        .login-box {
            width: 420px;
            height: 420px;
            background: rgba(0,0,0,0.5);
            color: #fff;
            top: 50%;
            left: 50%;
            position: absolute;
            transform: translate(-50%, -50%);
            box-sizing: border-box;
            padding: 70px 30px;
            border-color: fuchsia;
            border-style: groove;
        }
        .avatar {
            width: 100px;
            height: 100px;
            border-radius: 50%;
            position: absolute;
            top: -50px;
            left: 170px;
        }
        h1 {
            margin: 0px;
            padding: 0 0 20px;
            text-align:center;
            font-size: 22px;
        }
        .login-box p {
            margin: 0;
            padding: 0;
            font-weight: bold;
        }
        .campos {
            width: 100%;
            margin-bottom: 20px;
            border: none;
            border-bottom: 1px solid #fff;
            background: transparent;
            outline: none;
            height: 40px;
            color: #fff;
            font-size: 16px;
        }
        #entrar {
            width: 100%;
            margin-bottom: 20px;
            border: none;
            outline: none;
            height: 40px;
            background: #1c8adb;
            color: #fff;
            font-size: 18px;
            border-radius: 20px;
        }
        #entrar2 {
            width: 100%;
            margin-bottom: 20px;
            border: none;
            outline: none;
            height: 40px;
            background: #1c8adb;
            color: #fff;
            font-size: 18px;
            border-radius: 20px;
        }
        #entrar:hover {
            cursor: pointer;
            background: #39dc79;
            color: #000;
        }
        #entrar2:hover {
            cursor: pointer;
            background: #39dc79;
            color: #000;
        }
        .login-box a {
            text-decoration: none;
            font-size: 14px;
            color: #fff;
        }
    </style>
</head>
<body>
    
        <div class="login-box">
            <img src="img/Niña.png" alt="Logo" class="avatar"/>
            <form id="form1" runat="server">
                <h1>Login</h1>
                <p>Nombre Usuario</p>
                <asp:TextBox runat="server" ID="txtnombreusuario" Font-Names="nombreusuario" placeholder="Ingresa Nombre de usuario" CssClass="campos"></asp:TextBox>
                 <p>Contraseña</p>
                <asp:TextBox runat="server" Font-Names="contrasena" ID="txtcontrasena" placeholder="Ingresa contraseña" CssClass="campos"></asp:TextBox>
                <asp:Button runat="server" type="submit" value="Login" Text="Entrar" ID="entrar" OnClick="entrar_Click" />
                <a href="#">Olvidaste Contraseña?</a>
                 <asp:Button runat="server" type="submit" value="Login" Text="Registrar" ID="entrar2" />
            </form>
        </div>
    
</body>
</html>
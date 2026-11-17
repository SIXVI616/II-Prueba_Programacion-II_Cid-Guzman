<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="II_Prueba_Programacion_II_Cid_Guzman.CapaPresentacion.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu</title>

    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: Arial, sans-serif;
            background-color: #0A0A0A;
            color: white;
        }

        .header {
            background-color: #1E1E1E;
            color: white;
            padding: 18px 40px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            border-bottom: 2px solid #BB86FB;
        }

        .logo {
            font-size: 21px;
            font-weight: bold;
        }

        .menu {
            display: flex;
            gap: 10px;
        }

        .menu a {
            color: white;
            text-decoration: none;
            padding: 12px 18px;
            border-radius: 6px;
            transition: 0.3s;
        }

        .menu a:hover {
            background-color: #BB86FB;
            color: #0A0A0A;
        }

        .contenido {
            padding: 30px 40px;
            color: white;
        }

        h1 {
            color: #BB86FB;
            margin-bottom: 15px;
        }

        p {
            color: #CCCCCC;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <header class="header">

            <div class="logo">
                Sistema de Reparacion de Equipos
            </div>

            <nav class="menu">

                <a href="Menu.aspx">Menu</a>
                <a href="Usuarios.aspx">Usuarios</a>
                <a href="Tecnicos.aspx">Técnicos</a>

            </nav>

        </header>

        <main class="contenido">

            <h1>Bienvenido al sistema de reparacion de equipos</h1>
            <p>Seleccione una opcion de la barra superior de la pagina.</p>

        </main>

    </form>
</body>
</html>

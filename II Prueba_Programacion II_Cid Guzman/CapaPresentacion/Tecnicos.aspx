<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tecnicos.aspx.cs" Inherits="II_Prueba_Programacion_II_Cid_Guzman.CapaPresentacion.Tecnicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gestion de Tecnicos</title>

    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: Arial, sans-serif;
            background-color: #0A0A0A;
            color: #FFFFFF;
        }

        .header {
            background-color: #1E1E1E;
            color: white;
            padding: 20px 35px;
            display: flex;
            justify-content: space-between;
            align-items: center;
            border-bottom: 2px solid #BB86FB;
        }

        .logo {
            font-size: 21px;
            font-weight: bold;
        }

        .menu a {
            color: #FFFFFF;
            text-decoration: none;
            margin-left: 20px;
        }

        .menu a:hover {
            color: #BB86FB;
        }

        .contenido {
            width: 85%;
            margin: 30px auto;
            background-color: #1E1E1E;
            padding: 25px;
            border-radius: 8px;
        }

        h1, h2 {
            color: #BB86FB;
            margin-bottom: 20px;
        }

        .tabla {
            width: 100%;
            margin-bottom: 30px;
            border-collapse: collapse;
            color: white;
        }

        .tabla th {
            background-color: #BB86FB;
            color: #0A0A0A;
            padding: 12px;
        }

        .tabla td {
            padding: 10px;
            border-bottom: 1px solid #444444;
        }

        .tabla tr:nth-child(even) {
            background-color: #292929;
        }

        .campo {
            margin-bottom: 18px;
        }

        .campo label {
            display: block;
            margin-bottom: 7px;
            color: #E5E5E5;
        }

        .campo input {
            width: 100%;
            padding: 10px;
            background-color: #292929;
            color: white;
            border: 1px solid #555555;
            border-radius: 5px;
        }

        .botones {
            margin-top: 20px;
        }

        .boton {
            padding: 10px 16px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin-right: 8px;
            font-weight: bold;
        }

        .agregar {
            background-color: #BB86FB;
            color: #0A0A0A;
        }

        .modificar {
            background-color: #00DCCC;
            color: #0A0A0A;
        }

        .borrar {
            background-color: #D06667;
            color: #0A0A0A;
        }

        .boton:hover {
            opacity: 0.8;
        }

        .mensaje {
            display: block;
            margin-top: 15px;
            color: #00DCCC;
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
                <a href="Tecnicos.aspx">Tecnicos</a>
            </nav>

        </header>

        <div class="contenido">

            <h1>Gestion de Tecnicos</h1>

            <h2>Registro de Tecnicos</h2>

            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" CssClass="tabla">
                <Columns>
                    <asp:BoundField DataField="tecnicoid" HeaderText="ID" />
                    <asp:BoundField DataField="nombretec" HeaderText="Nombre" />
                    <asp:BoundField DataField="especialidad" HeaderText="Especialidad" />
                </Columns>
            </asp:GridView>

            <h2>Ingrese los datos del tecnico y seleccione la opcion a realizar</h2>

            <div class="campo">
                <asp:Label ID="lTecnicoID" runat="server" Text="ID: "></asp:Label>
                <asp:TextBox ID="tbTecnicoID" runat="server"></asp:TextBox>
            </div>

            <div class="campo">
                <asp:Label ID="lNombreT" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="tbNombreT" runat="server"></asp:TextBox>
            </div>

            <div class="campo">
                <asp:Label ID="lEspecialidad" runat="server" Text="Especialidad: "></asp:Label>
                <asp:TextBox ID="tbEspecialidad" runat="server"></asp:TextBox>
            </div>

            <div class="botones">

                <asp:Button ID="bAgregar" runat="server" Text="Agregar Tecnico" CssClass="boton agregar" OnClick="bAgregar_Click1" />
                <asp:Button ID="bBorrar" runat="server" Text="Borrar Tecnico" CssClass="boton borrar" OnClick="bBorrar_Click" />
                <asp:Button ID="bModificar" runat="server" Text="Modificar Tecnico" CssClass="boton modificar" OnClick="bModificar_Click" />

            </div>

            <asp:Label ID="lMensaje" runat="server" CssClass="mensaje"></asp:Label>

        </div>

    </form>

</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="APP_TrabajoRegistro.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title style="color:white;">Formulario registro</title>
    <link rel="stylesheet" href="Estilos/Style.css"/>

</head>
<body>
    <form id="form1" runat="server">
        <br><br>
        <div class="div_principal">
            <div class="div_segundario" >
                <table>
                    <tr><h4>Formulario de Registro</h4></tr>
                    <hr>
                    <tr>
                        <asp:TextBox ID="txtId" runat="server" placeholder="Identificación" CssClass="caja"></asp:TextBox></tr>
                        <asp:TextBox ID="txtNombre" runat="server" placeholder="Nombre" CssClass="caja"></asp:TextBox></tr>
                        <asp:TextBox ID="txtContacto" runat="server" placeholder="Contacto" CssClass="caja"></asp:TextBox></tr>
                        <asp:TextBox ID="txtCorreo" runat="server" placeholder="Correo" CssClass="caja"></asp:TextBox></tr>
                            <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="botones" OnClick="btnRegistrar_Click" />
                        <h5>¿Ya eres usuario? <a href="login.html">Ingresar</a></h5>
                    <tr>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label></tr>

                </table>

            </div>
        </div>
    </form>
</body>
</html>

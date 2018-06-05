<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Galenos.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content grid">
        <div class=" jumbotron left_login" style="padding-top: 48px;margin-bottom:0px;">
            <img src="images/img_login.jpg" />
            <h3>Ingresa</h3>
            Ingresa a nuestro sistema para acceder a la toma de horas online, de esta forma podrás verificar en tiempo real las horas disponible de cada medico en cada área. Si no tienes una cuenta, regístrate.
        </div>
        <div class="right_login">
            <h2>Ingreso Clientes</h2>
            <asp:Label ID="lblUsername" runat="server" Text="R.U.T (12345678-9)"></asp:Label><br />
            <asp:TextBox ID="txtRut" runat="server"  oninput="checkRut(this)"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
            <asp:Label ID="lblMen" CssClass="mensaje_login" runat="server" Text="null"></asp:Label>
        </div>
        
    </div>
    <div class="back-aux">
    <img src="images/login_aux.svg" style="width: 82%;margin-left: 9%;"/>
    </div>
    <script>
        $(document).ready(function () {
            
            var exito = $('#ContentPlaceHolder1_lblMen').prop('innerHTML');
            if (exito=='false') {
                swal('', 'Usuario o contraseña incorrectos', 'error');
            } else if (exito == 'null') {
                //nada
            } else {
                window.location.replace('Inicio.aspx');
            }


        });

        
        function checkRut(rut) {
            // Despejar Puntos
            var valor = rut.value.replace('.','');
            // Despejar Guión
            valor = valor.replace('-','');
    
            // Aislar Cuerpo y Dígito Verificador
            cuerpo = valor.slice(0,-1);
            dv = valor.slice(-1).toUpperCase();
    
            // Formatear RUN
            rut.value = cuerpo + '-'+ dv
    
            // Si no cumple con el mínimo ej. (n.nnn.nnn)
            if(cuerpo.length < 7) { rut.setCustomValidity("RUT Incompleto");document.getElementById('ContentPlaceHolder1_btnRegistrar').disabled = true; return false;}
    
            // Calcular Dígito Verificador
            suma = 0;
            multiplo = 2;
    
            // Para cada dígito del Cuerpo
            for(i=1;i<=cuerpo.length;i++) {
    
                // Obtener su Producto con el Múltiplo Correspondiente
                index = multiplo * valor.charAt(cuerpo.length - i);
        
                // Sumar al Contador General
                suma = suma + index;
        
                // Consolidar Múltiplo dentro del rango [2,7]
                if(multiplo < 7) { multiplo = multiplo + 1; } else { multiplo = 2; }
  
            }
    
            // Calcular Dígito Verificador en base al Módulo 11
            dvEsperado = 11 - (suma % 11);
    
            // Casos Especiales (0 y K)
            dv = (dv == 'K')?10:dv;
            dv = (dv == 0)?11:dv;
    
            // Validar que el Cuerpo coincide con su Dígito Verificador
            if(dvEsperado != dv) { rut.setCustomValidity("RUT Inválido");document.getElementById('ContentPlaceHolder1_btnRegistrar').disabled = true; return false; }
    
            // Si todo sale bien, eliminar errores (decretar que es válido)
            rut.setCustomValidity('');

            document.getElementById('ContentPlaceHolder1_btnRegistrar').disabled = false;
            return true;
        }

    </script>

</asp:Content>

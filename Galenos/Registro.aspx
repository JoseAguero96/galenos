<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Galenos.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMensajeInicial" runat="server" Text="Registro de Pacientes"></asp:Label>
    <br />
    
    <div class="form-group form-container">
        <h3>Registro</h3>
        <div class="form-group row">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre" CssClass="col-sm-2 col-form-label required" ></asp:Label>
            <br />
            <div class="col-sm-10">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"  oninput="check(this)"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="Campo Obligatorio" ForeColor="Red" style="display:none;padding-left: 18%;" CssClass="validador"></asp:RequiredFieldValidator>
        </div>
        
        <br />
        <div class="form-group row">
            <asp:Label ID="lblApellido" runat="server" Text="Apellido" CssClass="col-sm-2 col-form-label " required></asp:Label>
            <br />
            <div class="col-sm-10">
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"  oninput="check(this)"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtApellido" ErrorMessage="Campo Obligatorio" ForeColor="Red" style="display:none;padding-left: 18%;" CssClass="validador"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div class="form-group row">
            <asp:Label ID="lblRut" runat="server" Text="Rut" CssClass="col-sm-2 col-form-label required"></asp:Label>
            <br />
            <div class="col-sm-10">
                <asp:TextBox ID="txtRut" runat="server" CssClass="form-control" oninput="checkRut(this)"></asp:TextBox>
            </div>
        </div>
        <br />
        <div class="form-group row">
            <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña" CssClass="col-sm-2 col-form-label required"></asp:Label>
            <br />
            <div class="col-sm-10">
                <asp:TextBox ID="txtContrasenia1" runat="server" TextMode="Password" CssClass="form-control" oninput="check(this)"></asp:TextBox>
            </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtContrasenia1" ErrorMessage="Campo Obligatorio" ForeColor="Red" style="display:none;padding-left: 18%;" CssClass="validador"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div class="form-group row">
            <asp:Label ID="lblConfirmeContrasenia" runat="server" Text="Confirme Contraseña" CssClass="col-sm-2 col-form-label required"></asp:Label>
            <br />
                <div class="col-sm-10">
                    <asp:TextBox ID="txtContrasenia2" runat="server" TextMode="Password" CssClass="form-control" oninput="check(this)"></asp:TextBox>
                </div>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtContrasenia2" ErrorMessage="Campo Obligatorio" ForeColor="Red" style="display:none;padding-left: 18%;" CssClass="validador"></asp:RequiredFieldValidator>
        </div>
        <br />
        <div class="form-group row">
            <asp:Label ID="lblPrevision" runat="server" Text="Seleccione Previsión" cssClass="col-md-2 col-form-label" style="max-width: 19%;text-align:center"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" cssClass="col-sm-2">
                <asp:ListItem Selected="True" Value="0">Particular</asp:ListItem>
                <asp:ListItem Value="1">Fonasa</asp:ListItem>
                <asp:ListItem Value="2">Isapre</asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <br />
        <div class="form-group row">
            <asp:Label ID="lblSeguro" runat="server" Text="Seguro Medico" cssClass="radio-inline col-sm-2 col-form-label" style="text-align:center"></asp:Label>
            <asp:RadioButton ID="rbSi" runat="server" GroupName="seguro" Text="Si" cssClass="radio" style="margin-top: 0.8%;"/>
        &nbsp;<asp:RadioButton ID="rbNo" runat="server" GroupName="seguro" Text="No" cssClass="radio" style="margin-top: 0.8%;"/>
        </div>
        <br />
        <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" cssClass="btn btn-submit"/>
    &nbsp;
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" cssClass="btn btn-success"/>
        <br />
    </div>
    
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblMen" runat="server"></asp:Label>
    <br />

    <script>

        $('#ContentPlaceHolder1_btnRegistrar').click(function () {
            $('.validador').toggle();
        });

        $(document).ready(function () {
            $('#ContentPlaceHolder1_btnRegistrar').attr('disabled', true);
            var exito = $('#ContentPlaceHolder1_lblMen').prop('innerHTML');
            if (exito=='true') {
                 swal('', 'Usuario Registrado Éxitosamente', 'success');
            } else if (exito == 'null') {
                //nada
            } else {
                if (exito != '') {
                    swal('', 'Algo salió mal, asegurate de ingresar los datos necesarios', 'error');
                };
            };
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



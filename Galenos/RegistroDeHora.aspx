<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroDeHora.aspx.cs" Inherits="Galenos.RegistroDeHora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="318px">
        
        <asp:Label ID="lblRegistro" runat="server" Text="Registrar Hora Medica"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbldatos" runat="server" Text="Datos de la reserva"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblProfesional" runat="server" Text="Nombre Profesional :"></asp:Label>
            
        &nbsp;<asp:Label ID="lblNombre" runat="server"></asp:Label>
        &nbsp;<asp:Label ID="lblApellido" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblFechaReserva" runat="server" Text="Fecha de la Reserva :"></asp:Label>
        &nbsp;<asp:Label ID="lblFecha" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblHoraReserva" runat="server" Text="Hora de la Reserva :"></asp:Label>
        &nbsp;<asp:Label ID="lblHora" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblAreaAtencion" runat="server" Text="Area de Atención :"></asp:Label>
        &nbsp;<asp:Label ID="lblArea" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbldatosusuario" runat="server" Text="Datos del paciente"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblnombre2" runat="server" Text="Nombre del Paciente :"></asp:Label>
        &nbsp;<asp:Label ID="lblnombrepaciente" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblrutdelPaciente" runat="server" Text="Rut del paciente :"></asp:Label>
        &nbsp;<asp:Label ID="lblrutpaciente" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnReserva" runat="server" OnClick="btnReserva_Click" Text="Realizar la reserva" />
        <br />
        <br />
        <br />
        <br />
       
    </asp:Panel>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroDeHora.aspx.cs" Inherits="Galenos.RegistroDeHora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="620px">
        
        <asp:Label ID="lblRegistro" runat="server" Text="Registrar Hora Medica"></asp:Label>
        <asp:Panel ID="Panel2" runat="server" BackColor="#CCFFFF" Height="148px">
            <asp:Label ID="lbldatos" runat="server" Text="Datos de la reserva"></asp:Label>
            <br />
            <asp:Label ID="lblProfesional" runat="server" Text="Nombre Profesional :"></asp:Label>
            <asp:Label ID="lblNombre" runat="server"></asp:Label>
            <asp:Label ID="lblApellido" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblFechaReserva" runat="server" Text="Fecha de la Reserva :"></asp:Label>
            <asp:Label ID="lblFecha" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblHoraReserva" runat="server" Text="Hora de la Reserva :"></asp:Label>
            <asp:Label ID="lblHora" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblAreaAtencion" runat="server" Text="Area de Atención :"></asp:Label>
            <asp:Label ID="lblArea" runat="server"></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" BackColor="#CCFFCC" Height="117px">
            <asp:Label ID="lbldatosusuario0" runat="server" Text="Datos del paciente"></asp:Label>
            <br />
            <asp:Label ID="lblnombre3" runat="server" Text="Nombre del Paciente :"></asp:Label>
            <asp:Label ID="lblnombrepaciente" runat="server"></asp:Label>
            <br />
            <asp:Label ID="lblrutdelPaciente0" runat="server" Text="Rut del paciente :"></asp:Label>
            <asp:Label ID="lblrutpaciente" runat="server"></asp:Label>
        </asp:Panel>
        <br />
&nbsp;<br /> &nbsp;<br /> &nbsp;<br />
        <br />
        <asp:Button ID="btnReserva" runat="server" OnClick="btnReserva_Click" Text="Realizar la reserva" />
        <br />
        <br />
        <br />
        <br />
       
    </asp:Panel>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TomaHora.aspx.cs" Inherits="Galenos.TomaHora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="348px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#B0FFFF" Height="64px">
            <br />
            <asp:Label ID="lblNombreProfesional" runat="server" Text="Nombre del Profesional :"></asp:Label>
            &nbsp;&nbsp;<asp:Label ID="lblNombre" runat="server" Text="*"></asp:Label>
            &nbsp;<asp:Label ID="lblApellido" runat="server" Text="*"></asp:Label>
            <br />
            <asp:Label ID="lblAreadelProfesional" runat="server" Text="Area :"></asp:Label>
            &nbsp;&nbsp;<asp:Label ID="lblArea" runat="server" Text="*"></asp:Label>
        </asp:Panel>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblSeleccionarHora" runat="server" Text="Seleccione día para la hora medica"></asp:Label>
        <br />
        <br />
        <asp:Calendar ID="calendario" runat="server" Align="right" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="calendario_SelectionChanged" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        &nbsp;<asp:Label ID="lblmsg" runat="server" Text="Horas Disponibles para el Día :" Visible="False"></asp:Label>
        <asp:Label ID="lblFecha" runat="server" Visible="False"></asp:Label>
        <br />
        &nbsp;<br /> &nbsp;<asp:Label ID="lblhoras" runat="server" Text="Seleccione Hora de Atención :" Visible="False"></asp:Label>
&nbsp;
        <asp:DropDownList ID="ddlHoras" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="ddlHoras_SelectedIndexChanged" Visible="False" Width="160px">
            <asp:ListItem Selected="True" Value="-1">Seleccione..</asp:ListItem>
            <asp:ListItem Value="08:00">08:00</asp:ListItem>
            <asp:ListItem Value="09:00">09:00</asp:ListItem>
            <asp:ListItem>10:00</asp:ListItem>
            <asp:ListItem>11:00</asp:ListItem>
            <asp:ListItem>12:00</asp:ListItem>
            <asp:ListItem>14:00</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;
        <br />
    </asp:Panel>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TomaHorasMedicas.aspx.cs" Inherits="Galenos.TomaHorasMedicas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            background: #fcfcfc;
            padding-top: 20px;
            padding-left: 20px;
            height: 737px;
        }
        .auto-style2 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content grid">
        <div class="auto-style1">
            <asp:Label ID="lblRegistroHoras" runat="server" Text="Reserva de Horas Medicas"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnHoraMedico"  runat="server" Text="Reservar hora por Medico" OnClick="btnHoraMedico_Click" />
            <br />
            <br />
            <asp:Button ID="btnPorArea" runat="server"  Text="Reservar hora por Area" OnClick="btnPorArea_Click" />
            <br />
            <br />
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="viewTabla" runat="server">
                    <asp:Panel ID="PanTabla" runat="server" BackColor="#CCFFFF" Height="127px">
                        &nbsp;
                        <asp:Label ID="lblNombreMedicoBuscado" runat="server" Text="Nombre de Medico : "></asp:Label>
                        <asp:TextBox ID="txtNomMedico" runat="server"></asp:TextBox>
                    </asp:Panel>
                </asp:View>
                <asp:View ID="viewMedico" runat="server">
                    <asp:Panel ID="Panel1" runat="server" BackColor="#CCFFFF" Height="158px">
                        <br />
                        &nbsp;<asp:Label ID="lblApellidoMedico" runat="server" Align="Left" Text="Ingrese Apellido del Medico:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtNombreMedico"  runat="server"  CssClass="auto-style2" Width="282px" class="textbox"></asp:TextBox>
                        <br />
                        <br />
                        &nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar Medico" OnClick="btnBuscar_Click" CssClass="botonlargo" />
                        <br />
                        <br />
                        &nbsp;<asp:Label ID="lblMensaje1" runat="server" ForeColor="Red"></asp:Label>
                    </asp:Panel>
                </asp:View>
                <asp:View ID="viewArea" runat="server">
                    <asp:Panel ID="Panel2" runat="server" BackColor="#CCFFFF" Height="172px">
                        <br />
                        &nbsp;<asp:Label ID="lblArea" runat="server" Text="Seleccione el Area para la reserva:"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="ddlArea" runat="server" Height="16px" Width="286px">
                        </asp:DropDownList>
                        <br />
                        <br />
                        &nbsp;<asp:Button ID="btnBuscarArea" CssClass="botonlargo" runat="server" OnClick="btnBuscarArea_Click" Text="Buscar medicos por Area" />
                        <br />
                        <br />
                        &nbsp;<asp:Label ID="lblMensaje2" runat="server" ForeColor="Red"></asp:Label>
                    </asp:Panel>
                </asp:View>
            </asp:MultiView>
        </div>
    </div>
</asp:Content>

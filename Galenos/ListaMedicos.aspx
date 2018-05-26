<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMedicos.aspx.cs" Inherits="Galenos.ListaMedicos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:Label ID="lblmensajito" align="center" runat="server" Text="Seleccione Profesional para Reserva" Font-Size="XX-Large"></asp:Label>
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="436px">
        <asp:GridView ID="gvmedicos"  runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="82px" style="margin-top: 1px" Width="789px" AutoGenerateSelectButton="True" EmptyDataText="no aplica" OnSelectedIndexChanged="gvmedicos_SelectedIndexChanged">
            <AlternatingRowStyle BorderStyle="Solid" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" Visible="False" />
                <asp:BoundField DataField="nombrecompleto" HeaderText="Nombre Profesional" />
                <asp:BoundField HeaderText="foto" Visible="False" />
                <asp:BoundField DataField="area_id" HeaderText="Area del Medico" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre de Medico" />
                <asp:BoundField DataField="nombre_area" HeaderText="Nombre Area" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <br />
        &nbsp;<asp:Label ID="lblseleccion" runat="server" Text="Profesional Seleccionado"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblnombreM" runat="server" Text="Nombre del Profesional"></asp:Label>
        <br />
        <asp:TextBox ID="txtnombre" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Area de desempeño"></asp:Label>
        <br />
        <asp:TextBox ID="txtarea" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btntomarhora" runat="server" OnClick="btntomarhora_Click" Text="Hacer Reserva" />
        <br />
        <br />
        <br />
        <br />
    </asp:Panel>
</asp:Content>

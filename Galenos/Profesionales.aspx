<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profesionales.aspx.cs" Inherits="Galenos.Profesionales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Panel ID="Panel1" runat="server" Height="306px" style="margin-top: 0px">
        <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Nuestros Medicos"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="gvmedicos" Class="table" runat="server" AutoGenerateColumns="False" Width="897px">
            <Columns>
                <asp:BoundField DataField="nombreCompleto" HeaderText="Nombre Profesional" />
                <asp:BoundField DataField="nombre_area" HeaderText="Area del Profesional" />
            </Columns>
        </asp:GridView>
    </asp:Panel>
</asp:Content>

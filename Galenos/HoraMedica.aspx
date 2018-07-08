<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HoraMedica.aspx.cs" Inherits="Galenos.HoraMedica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 138px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="475px">
        <br />
        <br />
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View3" runat="server">
                <div class="container">
                <div class="Row">

                    <div class="col-md-12" Align="Center">
                        <h2><b>Hora Eliminada Exitosamente</b></h2>
                    </div>
                     <div class="col-md-12"></div>
                    <div class="col-md-12" Align="Center">

                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary" Width="600px" OnClick="btnAceptar_Click" />

                    </div>

                </div>
            </div>
            </asp:View>
            <asp:View ID="View1" runat="server" EnableViewState="False">
                <asp:Panel ID="Panel2" runat="server" Height="551px">
                    <asp:Panel ID="Panel4" runat="server" Height="553px">
                        <asp:Label ID="Label1" runat="server" Font-Size="18pt" margin-top="30px" style="margin-left:5%;" Text="Sus Horas Médicas" Width="100%"></asp:Label>
                        <br />
                        <br />
                        <asp:GridView ID="gvHoras" runat="server" Width="100%" AutoGenerateColumns="False" AutoGenerateSelectButton="True" BackColor="#99CCFF" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="gvHoras_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="nombre_usuario" HeaderText="Nombre Paciente" />
                                <asp:BoundField DataField="nombre_medico" HeaderText="Nombre Medico" />
                                <asp:BoundField DataField="area_medico" HeaderText="Area de atención" />
                                <asp:BoundField DataField="day" HeaderText="Fecha de atención" />
                                <asp:BoundField DataField="hora" HeaderText="Hora de Atención" />
                                <asp:BoundField DataField="id" HeaderText="id reserva" NullDisplayText="No Aplica" />
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
                        &nbsp;<asp:Label ID="lblSeleccion" runat="server" Font-Size="18pt" margin-top="30px" style="margin-left:5%;" Text="Hora Seleccionada" Width="100%"></asp:Label>
                        <br />
                        <table style="margin-left:2%;">
                            <tbody>
                                <tr>
                                    <td class="auto-style1">Paciente</td>
                                    <td>
                                        <asp:TextBox ID="txtPaciente" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">Medico</td>
                                    <td>
                                        <asp:TextBox ID="txtMedico" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">Area</td>
                                    <td>
                                        <asp:TextBox ID="txtArea" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">Fecha</td>
                                    <td>
                                        <asp:TextBox ID="txtFecha" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">Hora de Atención</td>
                                    <td>
                                        <asp:TextBox ID="txtHora" runat="server" ReadOnly="True"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style1">Eliminar Hora</td>
                                    <td>
                                        <asp:Button ID="eliminarHora" runat="server" Text="Eliminar" Width="185px" CssClass="btn btn-primary" OnClick="eliminarHora_Click" />
                                    </td>
                                </tr>
                                
                            </tbody>
                        </table>
                    </asp:Panel>
                </asp:Panel>
            </asp:View>
        </asp:MultiView>
    </asp:Panel>
</asp:Content>

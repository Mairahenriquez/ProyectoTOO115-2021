<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="ProyectoTOO.Administracion.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Listas">
        <div class="container tm-features-section" id="features"> 
            <h3>Integrantes:</h3> 
            <table>
                <tr class="tr1"><td class="td1">Carnet</td> <td class="td1">Apellidos </td> <td class="td1">Nombres </td></tr>
                <tr><td>BU03002</td> <td>Barrios Urías </td> <td>Francisco Antonio </td></tr>
                <tr><td>CH17013</td> <td>Castro Henríquez </td> <td>Maira Yesenia  </td></tr>
                <tr><td>CS16059</td> <td>Chávez Santos </td> <td>Luis Eduardo </td></tr>
                <tr><td>MC09084</td> <td>Mendoza Carranza </td> <td>Armando Enrique </td></tr>
                <tr><td>SS06003</td> <td>Solorzano </td> <td>Douglas Oswaldo </td></tr>
            </table>
        </div>
    </div>
</asp:Content>
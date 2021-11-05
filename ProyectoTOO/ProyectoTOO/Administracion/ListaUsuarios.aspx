<%@ Page Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="ProyectoTOO.Administracion.ListaUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Titulo" runat="server">
    Lista de Usuarios
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
        <link href="Style/css/StyleSheet1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Lista de Usuarios del Sistema:</h3>
    <asp:Label ID="texto" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="mensaje" runat="server" CssClass="Info"></asp:Label>
    <div class="Listas">
        <asp:GridView ID="gvUsuario" AllowPaging="true"
            AutoGenerateColumns = "False" runat="server"
            DataKeyNames="idUsuario, passcode"
            AlternatingRowStyle-BackColor="#000" AllowSorting="true" OnPageIndexChanging="gvUsuario_PageIndexChanging" PageSize="12" >
            <AlternatingRowStyle BackColor ="#FA8072" /><AlternatingRowStyle />
                <Columns>
                    <asp:BoundField DataField="idUsuario" HeaderText="idUsuario" Visible="false" />
                    <asp:BoundField DataField="passcode" HeaderText="passcode" Visible="false" />
                    <asp:boundfield DataField="nombres" headertext="Nombres" />
                    <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha de Nacimiento" />
                    <asp:BoundField DataField="correoElectronico" HeaderText="Correo Electronico" />
                    <asp:BoundField DataField="telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acción" >
                        <ItemTemplate>
                            <asp:HyperLink ID="Eliminar" Onclick="if(!confirm('¿DESEA ELIMINAR EL USUARIO?'))return false" runat="server" NavigateUrl='<%# Eval("idUsuario", "~/Administracion/ListaUsuarios.aspx?usuario={0}") %>'>
                                <img src="Style/Imagenes/Eliminar.png" />
                            </asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            <PagerSettings Mode="NumericFirstLast" />
            <SelectedRowStyle BackColor="#00ffff" />
        </asp:GridView>
    </div>
</asp:Content>


<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExemploCookies._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label Text="Nome" runat="server" />
    <asp:TextBox id="txtNome" runat="server" />
    <br />
    <br />
    <asp:Label Text="Valor"  runat ="server" />
    <asp:TextBox id="txtValor" runat="server" />
    <br />
    <br />
    <asp:Button Text="Gravar" id="btnGravar" runat="server" OnClick="btnGravar_Click"  />
    <asp:Button Text="Recuperar" id="btnRecuperar" runat ="server" OnClick="btnRecuperar_Click"  />
    <br />
    <asp:Button Text="Gravar Vários Itens" id="btnGravarItens" runat="server" OnClick="btnGravarItens_Click"  />
    <br />
    <asp:LinkButton Text="Atualizar" id="lnkAtualizar" runat="server" OnClick="lnkAtualizar_Click" />
    <br />
    <asp:ListBox id="lstCookies" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstCookies_SelectedIndexChanged">
        <asp:ListItem>Unbound</asp:ListItem>
    </asp:ListBox>
    <br />
    <br />
    <asp:Label Text="" id="lblValorCookie" runat="server" />

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Core/Internal.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="VTNORTON.Core.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h2>Bem vindo ao Core!</h2>
        <p>Por favor, selecione uma página no painel</p>
    </div>
    <article>
        <h4>v2.0.0 - Changelog</h4>
        <p>Versão 2.0, ah, a versão 2.0. Todo o código por debaixo do capô foi alterado, ou seja, está bem melhor agora de manter esse sistema. Em adição a isso:</p>
        <ul>
            <li>Agora existe um texto explicativo para cada local de interação com usuário</li>
            <li>Agora Ebooks possuem descrição!</li>
            <li>Agora é possível editar os eBooks cadastrados no sistema.</li>
            <li>Listas de e-mail!
                <ul>
                    <li>Foi adicionando suporte a lista de e-mails! Agora todos os e-mails podem ser cadastrados aqui!</li>
                    <li>Adicionado função para inserção de vários e-mails de uma única vez!</li>
                    <li>Visualize os e-mails cadastrados no sistema de forma fácil!</li>
                </ul>
            </li>
            <li>Cadastre temas para e-mail marketing e visualize eles!</li>
            <li>Melhoras no design do sitema, incluindo mais destaque para as mensagens de sucesso e de erro ao cadastrar ou visualizar algo.</li>
            <li>Os feedbacks enviados, via aplicativos, agora irão cadastrar o e-mail automaticamente no sistema, e os feedbacks recebidos agora possuem um design mais limpo.</li>
            <li>Agora irá ser verificado se o e-mail cadastrado no sistema é realmente um e-mail (se está no formato de um e-mail)</li>
            <li>Antes da insersão de um e-mail é verificado se ele já não está no sistema.</li>
        </ul>
    </article>
</asp:Content>

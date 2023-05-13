<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="bug.aspx.cs" Inherits="HidraOnline.p.edit.bug" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/Bug.aspx">Novo bug</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
        <li><a href="/p/manage/advanced-bugs.aspx">Gerenciamento avançado de feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="left seventyfivepercent">
        <div class="toggle-options-head">Informações do feedback</div>
        <hr />
        <article>
            <p>
                <strong>Tipo: </strong>
                <asp:Label ID="lblType" runat="server" Text=""></asp:Label><br />
                <strong>Votos: </strong>
                <asp:Label ID="lblUpvotes" runat="server" Text=""></asp:Label><br />
                <strong>Data: </strong>
                <asp:Label ID="lblDate" runat="server" Text=""></asp:Label><br />
                <strong>Projeto: </strong>
                <asp:Label ID="lblProject" runat="server" Text=""></asp:Label><br />
                <strong>Status: </strong>
                <asp:Label ID="lblStatus" runat="server" Text=""></asp:Label><br />
                <strong>Menssagem: </strong>
                <asp:Label ID="lblMenssage" runat="server" Text=""></asp:Label><br />
                <strong>E-mail do remetente: </strong>
                <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label><br />
            </p>
        </article>
    </div>
    <div class="right twentyfivepercent sidebar">
        <div class="toggle-options-head">Editar feedbak</div>
        <hr />
        <p>
            Todas as informações possíveis deste feedback estão reunidas nesta página. A baixo você pode atualizar o feedback, ou exclui-lo. Saiba que ao excluir um feedback é impossível recuperar o mesmo.
        </p>

        <div class="left">
            <p>Status:</p>
        </div>
        <div class="right">
            <asp:DropDownList ID="ddlStatus" runat="server">
                <asp:ListItem Enabled="true" Selected="False" Text="Recebido" Value="1"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Em andamento" Value="2"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Disponível atualização" Value="3"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Cancelado" Value="4"></asp:ListItem>
                <asp:ListItem Enabled="true" Selected="False" Text="Concluido" Value="5"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="clean"></div>
        <br />
        <p>
            <asp:LinkButton ID="lbtExcluir" OnClick="lbtExcluir_Click" CssClass="red" runat="server">Excluir feedback</asp:LinkButton>
        </p>

        <br />
        <asp:Button ID="btnCancelar" OnClick="btnCancelar_Click" Height="50" CssClass="half btn-grey left" runat="server" Text="Cancelar" /><asp:Button OnClick="btnAtualizar_Click" ID="btnAtualizar" Height="50" CssClass="half btn-green right" runat="server" Text="Atualizar" /><br />
        <div class="clean"></div>
    </div>
    <div class="clean"></div>
</asp:Content>

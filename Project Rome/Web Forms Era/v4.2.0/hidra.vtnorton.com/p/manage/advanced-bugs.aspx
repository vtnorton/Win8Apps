<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="advanced-bugs.aspx.cs" Inherits="HidraOnline.p.manage.advanced_bugs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="SUBMENU" runat="server">
    <ul>
        <li><a href="/p/Bug.aspx">Relatar problema</a></li>
        <li><a href="/p/novo/sugestion.aspx">Nova sugestão</a></li>
        <li><a href="/p/manage/bugs.aspx">Gerenciar feedback</a></li>
        <li><a class="on" href="/p/manage/advanced-bugs.aspx">Gerenciamento avançado de feedback</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" runat="server">
    <div class="seventyfivepercent left">
        <div class="toggle-options-head">Opções de gerenciamento avançado de feedback</div>
        <hr />
        <p>Aqui está listado algumas opções possíveis para o gerenciamento avançado de feedbacks. Use essa ferramente com sabedoria, pois uma vez executado alguns destes recursos pode ser perigoso e deve ser utilizado com cautela.</p>
        <br />
        <ul class="advanced">
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Alterar todos para recebidos.</h4>
                    <p>Altera todos os feedbacks com o status "Não recebido" para "Recebido". </p>
                    <strong>Pronto para executar</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os feedbacks cancelados</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks que foram cancelados. </p>
                    <strong>Pronto para executar</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os feedbacks do sistema</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks informados pelo sistema atravéz do e-amil jade@vtnorton.com. </p>
                    <strong>Pronto para executar</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os feedbacks dos usuários</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks que foram cadastrados por usuários, ou seja, que não utilizaram o e-mail jade@vtnorton.com. </p>
                    <strong>Pronto para executar</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os feedbacks de um determinado usuário</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks que foram cadastrados por um usuário expecífio, para isso, deve ser inserido o e-mail do usuário. </p>
                    <asp:TextBox ID="txtEmail" placeholder="E-mail do usuário a ser deletado" TextMode="Email" CssClass="full100" runat="server"></asp:TextBox><br />
                    <strong style="color: #FF2E12">Ação necessária antes: "Inserir e-mail do usuário".</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os feedbacks por pesquisa</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks que foram contiverem, no tópico menssagens, o valor incluido no campo de texto.. </p>
                    <asp:TextBox ID="txtSearch" placeholder="Valor a ser pesquisado e deletado" CssClass="full100" runat="server"></asp:TextBox><br />
                    <strong style="color: #FF2E12">Ação necessária antes: "Inserir um valor no campo de texto".</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os feedbacks concluidos</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks que foram concluidos. </p>
                    <strong>Pronto para executar</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Excluir todos os valores cadastrados</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks. </p>
                    <strong>Pronto para executar</strong>
                </div>
                <div class="clean"></div>
            </li>
            <li>
                <div class="left">
                    <div class="execute-sql" title="Executar ação"></div>
                </div>
                <div class="right advanced-unique">
                    <h4 class="green">Resetar Ids da tabela</h4>
                    <p>Nesta ação é possível excluir todos os feedbacks que foram concluidos. </p>
                    <strong style="color: #FF2E12">Ação necessária antes: "Excluir todos os valores cadastrados".</strong>
                </div>
                <div class="clean"></div>
            </li>
        </ul>
    </div>

    <div class="twentyfivepercent right sidebar">
        <div class="toggle-options-head">Informações de feedbacks</div>
        <hr />
        <p>Número de feedbacks: </p>

        <h5>Pesquisar</h5>
        <hr />
        <p>Caso não esteja encontrando a ação que você procura, ou esteja esbarrando com uma ação ncessária antes, pesquisar aqui para localizar ela (esta pesquisa é feita somente dentro desta página).</p>
        <input id="txtPesquisarPagina" style="width: 100%" class="full100" placeholder="Pesquisar na página" type="text" />
        <br />
        <br />
        <asp:Button ID="btnPesquisar" CssClass="btn-green full" Height="50" runat="server" Text="Pesquisar" />
    </div>
    <div class="clean"></div>
</asp:Content>

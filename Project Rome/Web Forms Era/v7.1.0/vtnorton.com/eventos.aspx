<%@ Page Title="Eventos | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="eventos.aspx.cs" Inherits="VTNORTON.eventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <meta name="description" content="Veja a lista dos próximos eventos que irão acontecer, são eventos pagos ou gratuitos, algusn online outros offline e vale lembrar que aqui também estão os eventos em que eu vou participar, não só os que estou organizando." />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="http://twitter.com/vt_norton">Acompanhe os eventos pelo Twitter @vt_norton</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper">
        <h1>Próximos eventos</h1>
        <p>Veja a lista dos próximos eventos que irão acontecer, são eventos pagos ou gratuitos, algusn online outros offline e vale lembrar que aqui também estão os eventos em que eu vou participar, não só os que estou organizando.</p>
        <asp:Repeater ID="rptEvento" runat="server">
            <ItemTemplate>
                <div class="evento">
                    <div class="data left">
                        <span class="dia blue"><%#Eval("Dia") %></span><br />
                        <span class="mes"><p><%#Eval("Mes") %> de <%#Eval("Ano") %></p></span>
                    </div>
                    <div class="informacoes right">
                        <div class="left">
                            <h2><%#Eval("Nome") %></h2>
                            <h4 class="grey"><i><%#Eval("Endereco") %></i></h4>
                            <p><%#Eval("Descricao") %></p>
                            <p>Mais informações: <a href="<%#Eval("URL") %>"><%#Eval("URL") %></a></p>
                        </div>
                    </div>
                    <div class="clean"></div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Label ID="lblErro" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <hr />
        <br />
        <h1 class="grey">Eventos ocorridos</h1>
        <p>Estes eventos já aconteceram, mas eles ficarão aqui se exibindo por algum tempo. Muitos desdes eventos terão reprise futuramente, então fique atento nesta página porquê, quem sabe um dia você não tem a chance de participar de um destes eventos novamente.</p>
        <asp:Repeater ID="rptEventoPassado" runat="server">
            <ItemTemplate>
                <div class="evento">
                    <div class="data left">
                        <span class="dia grey"><%#Eval("Dia") %></span><br />
                        <span class="mes"><p><%#Eval("Mes") %> de <%#Eval("Ano") %></p></span>
                    </div>
                    <div class="informacoes right">
                        <div class="left">
                            <h2><%#Eval("Nome") %></h2>
                            <h4 class="grey"><i><%#Eval("Endereco") %></i></h4>
                            <p><%#Eval("Descricao") %></p>
                            <p>Mais informações: <a href="<%#Eval("URL") %>"><%#Eval("URL") %></a></p>
                        </div>
                    </div>
                    <div class="clean"></div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Label ID="lblErroPassado" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>

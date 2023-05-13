<%@ Page Title="Resultado da pesquisa | Vítor Norton" Language="C#" MasterPageFile="~/healtthrob.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="VTNORTON.search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSubMenu" runat="server">
    <ul>
        <li><a href="/formula">Formula - Universal Code Editor</a></li>
        <li><a href="/onenote">eBook Gratuito: OneNote</a></li>
    </ul>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="wrapper search-results">
        <h1>Resultado da pesquisa</h1>
        <p>Confira o resultado da sua pesquisa aqui.</p>
        <script>
            (function () {
                var cx = '008498062917135645102:euepdpahuqg';
                var gcse = document.createElement('script');
                gcse.type = 'text/javascript';
                gcse.async = true;
                gcse.src = 'https://cse.google.com/cse.js?cx=' + cx;
                var s = document.getElementsByTagName('script')[0];
                s.parentNode.insertBefore(gcse, s);
            })();
        </script>
        <gcse:searchresults-only></gcse:searchresults-only>
    </div>
</asp:Content>

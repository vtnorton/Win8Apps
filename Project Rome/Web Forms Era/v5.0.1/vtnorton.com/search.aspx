<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="VTNORTON.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-content">
        <h1><asp:Label ID="lblSearchQuery" runat="server" Text=""></asp:Label></h1>
        <div id='cse' style='width: 100%;'>Loading</div>
        <script src='//www.google.com/jsapi' type='text/javascript'></script>
        <script type='text/javascript'>
            google.load('search', '1', { language: 'pt', style: google.loader.themes.MINIMALIST });
            google.setOnLoadCallback(function () {
                var customSearchOptions = {};
                var orderByOptions = {};
                orderByOptions['keys'] = [{ label: 'Relevance', key: '' }, { label: 'Date', key: 'date' }];
                customSearchOptions['enableOrderBy'] = true;
                customSearchOptions['orderByOptions'] = orderByOptions;
                var imageSearchOptions = {};
                imageSearchOptions['layout'] = 'google.search.ImageSearch.LAYOUT_POPUP';
                customSearchOptions['enableImageSearch'] = true;
                var customSearchControl = new google.search.CustomSearchControl('008498062917135645102:x_fsqget2v8', customSearchOptions);
                customSearchControl.setResultSetSize(google.search.Search.FILTERED_CSE_RESULTSET);
                var options = new google.search.DrawOptions();
                options.enableSearchResultsOnly();
                options.setAutoComplete(true);
                customSearchControl.draw('cse', options);
                function parseParamsFromUrl() {
                    var params = {};
                    var parts = window.location.search.substr(1).split('&');
                    for (var i = 0; i < parts.length; i++) {
                        var keyValuePair = parts[i].split('=');
                        var key = decodeURIComponent(keyValuePair[0]);
                        params[key] = keyValuePair[1] ?
                            decodeURIComponent(keyValuePair[1].replace(/\+/g, ' ')) :
                            keyValuePair[1];
                    }
                    return params;
                }
                var urlParams = parseParamsFromUrl();
                var queryParamName = 'q';
                if (urlParams[queryParamName]) {
                    customSearchControl.execute(urlParams[queryParamName]);
                }
            }, true);
        </script>
    </div>
</asp:Content>

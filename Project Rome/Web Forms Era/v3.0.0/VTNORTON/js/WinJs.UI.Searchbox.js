$(document).ready(function () {
	var statusEl = document.getElementById("status");
	var suggestionList = ["Vitor Norton", "Arquiteto de Mentes", "Hidra", "Search", "Microsoft", "OneNote", "OneDrive", "Windows", "Windows 8", "Windows 8.1", "Windows 9", "Windows Phone 8",
        "Windows Phone 8.1", "Windows Phone 9", "Build", "Download de aplicativos", "2015: uma mensagem", "2016: uma mensagem", "Low Battery Menssage", "Mensagens engraçadas", "Calculadora de tempo",
        "Relógio", "Scandal Photos", "Shonda Rhimes", "Merci", "Style your tiles", "Heartthrob", "Quizz São Camilo", "M!xer", "ÔnibusTrack", "Terre", "Near chat", "Loja", "Podcast (app)", "Podcasts",
        "Soundtrack of my life", "Soundtrack", "Crimes e atenuantes", "Browser", "Suporte", "Contato", "Linha do tempo", "Histórico de versões", "Ultimas Atualizações", "Sobre", "Planos futuros",
        "Camisas", "Canecas", "Wallpapaers", "Papel de parede", "Avatares", "Design", "Portifolio", "Código aberto"];

	function suggestionsRequestedHandler(eventObject) {
		var queryText = eventObject.detail.queryText,
			query = queryText.toLowerCase(),
			suggestionCollection = eventObject.detail.searchSuggestionCollection;
		if (queryText.length > 0) {
		    suggestionCollection.appendSearchSeparator("Novidades");
		    suggestionCollection.appendResultSuggestion("Hidra", "Pesquise qualquer coisa", null, WinJS.UI.SearchBox.createResultSuggestionImage("/images/icones/search/search-hidra.jpg"), "");
		    suggestionCollection.appendResultSuggestion("Build", "Conheça nosso framework", null, WinJS.UI.SearchBox.createResultSuggestionImage("/images/icones/search/search-build.jpg"), "");
		    suggestionCollection.appendResultSuggestion("Arquiteto de Mentes", "Histórias - 1ª Temporada", null, WinJS.UI.SearchBox.createResultSuggestionImage("/images/icones/search/search-build.jpg"), "");
			suggestionCollection.appendSearchSeparator("Pesquisar");
			for (var i = 0, len = suggestionList.length; i < len; i++) {
				if (suggestionList[i].substr(0, query.length).toLowerCase() === query) {
					suggestionCollection.appendQuerySuggestion(suggestionList[i]);
				}
			}
	    }
	}

	function querySubmittedHandler(eventObject) {
		var queryText = eventObject.detail.queryText;
		WinJS.log && WinJS.log(queryText, "sample", "status");
	}

	WinJS.log = function (msg, source, type) {
	    if (type === "status") {
	        open("/hidra/index.aspx?q=" + msg, null, null, true);
	        //Abrir na mesma pagina
            //Tem erros aqui
		}
	}
	var searchBox = document.getElementById("searchBoxId");
	searchBox.addEventListener("suggestionsrequested", suggestionsRequestedHandler);
	searchBox.addEventListener("querysubmitted", querySubmittedHandler);

	WinJS.UI.processAll();
});
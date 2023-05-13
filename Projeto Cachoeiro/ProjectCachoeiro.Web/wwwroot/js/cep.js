function pesquisarCep(valor) {
    var cep = valor.replace(/\D/g, '');
    if (cep != "") {
        var validacep = /^[0-9]{8}$/;
        if (validacep.test(cep)) {
            var script = document.createElement('script');
            script.src = 'https://viacep.com.br/ws/' + cep + '/json/?callback=preencherdados';
            document.body.appendChild(script);
        }
        else {
            alert("Formato de CEP inválido.");
        }
    }
};

function preencherdados(conteudo) {
    if (!("erro" in conteudo)) {
        document.getElementById('rua').value = conteudo.logradouro;
        document.getElementById('bairro').value = conteudo.bairro;
        document.getElementById('cidade').value = conteudo.localidade;

        var dropdownlist = $("#estado").data("kendoDropDownList");
        dropdownlist.select(function (dataItem) {
            return dataItem.sigla == conteudo.uf;
        });
        dropdownlist.trigger("change");
    }
}
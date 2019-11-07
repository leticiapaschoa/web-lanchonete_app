function BuscaEndereco(cep) {

    var nroCep = cep.value;

    var urlApi = 'https://viacep.com.br/ws/' + nroCep + '/json/';

    var viaCepHttp = new XMLHttpRequest();
    viaCepHttp.open("GET", urlApi, false);
    viaCepHttp.send(null);

    var endereco = JSON.parse(viaCepHttp.responseText);

    document.getElementById('Rua').value = endereco.logradouro;
    document.getElementById('Bairro').value = endereco.bairro;
    document.getElementById('Cidade').value = endereco.localidade;
}
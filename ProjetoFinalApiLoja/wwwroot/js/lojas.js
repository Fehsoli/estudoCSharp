const uri = 'api/Lojas';
let lojas = [];

function getLojas() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayLojas(data))
        .catch(error => console.error('Unable to get lojas.', error));
}

function _displayLojas(data) {
    console.log(data);
    const tBody = document.getElementById('lojas');
    tBody.innerHTML = '';
    data.forEach(loja => {
        let tr = tBody.insertRow();

        let textNode0 = document.createTextNode(loja.lojaId);
        tr.insertCell(0).appendChild(textNode0);
        let textNode1 = document.createTextNode(loja.razaoSocial);
        tr.insertCell(1).appendChild(textNode1);
        let textNode2 = document.createTextNode(loja.cnpj);
        tr.insertCell(2).appendChild(textNode2);
        let textNode3 = document.createTextNode(loja.endereco);
        tr.insertCell(3).appendChild(textNode3);
    });

    lojas = data;
}
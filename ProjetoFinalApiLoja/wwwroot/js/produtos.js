const uri = 'api/Produtos';
let produtos = [];

function getProdutos() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayProdutos(data))
        .catch(error => console.error('Unable to get produtos.', error));
}

function _displayProdutos(data) {
    console.log(data);
    const tBody = document.getElementById('produtos');
    tBody.innerHTML = '';
    data.forEach(produto => {
        let tr = tBody.insertRow();

        let textNode0 = document.createTextNode(produto.produtoId);
        tr.insertCell(0).appendChild(textNode0);
        let textNode1 = document.createTextNode(produto.descricao);
        tr.insertCell(1).appendChild(textNode1);
        let textNode2 = document.createTextNode(produto.categoria);
        tr.insertCell(2).appendChild(textNode2);
        let textNode3 = document.createTextNode(produto.preco);
        tr.insertCell(3).appendChild(textNode3);
        let textNode4 = document.createTextNode(produto.estoque);
        tr.insertCell(4).appendChild(textNode4);
        let textNode5 = document.createTextNode(produto.lojaId);
        tr.insertCell(5).appendChild(textNode5);
    });

    produtos = data;
}
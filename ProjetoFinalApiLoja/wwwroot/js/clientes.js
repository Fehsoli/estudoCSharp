const uri = 'api/Clientes';
let clientes = [];

function getClientes() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayClientes(data))
        .catch(error => console.error('Unable to get clientes.', error));
}

function _displayClientes(data) {
    console.log(data);
    const tBody = document.getElementById('clientes');
    tBody.innerHTML = '';
    data.forEach(cliente => {
        let tr = tBody.insertRow();

        let textNode0 = document.createTextNode(cliente.clienteId);
        tr.insertCell(0).appendChild(textNode0);
        let textNode1 = document.createTextNode(cliente.nomeCliente);
        tr.insertCell(1).appendChild(textNode1);
        let textNode2 = document.createTextNode(cliente.lojaId);
        tr.insertCell(2).appendChild(textNode2);
    });

    clientes = data;
}
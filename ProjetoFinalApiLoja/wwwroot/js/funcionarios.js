const uri = 'api/Funcionarios';
let funcionarios = [];

function getFuncionarios() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayFuncionarios(data))
        .catch(error => console.error('Unable to get funcionarios.', error));
}

function _displayFuncionarios(data) {
    console.log(data);
    const tBody = document.getElementById('funcionarios');
    tBody.innerHTML = '';
    data.forEach(funcionario => {
        let tr = tBody.insertRow();

        let textNode0 = document.createTextNode(funcionario.funcionarioId);
        tr.insertCell(0).appendChild(textNode0);
        let textNode1 = document.createTextNode(funcionario.nomeFunc);
        tr.insertCell(1).appendChild(textNode1);
        let textNode2 = document.createTextNode(funcionario.cargo);
        tr.insertCell(2).appendChild(textNode2);
        let textNode3 = document.createTextNode(funcionario.lojaId);
        tr.insertCell(3).appendChild(textNode3);
    });

    funcionarios = data;
}
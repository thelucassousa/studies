//Return


//Após o return a função encerra.
function fullName (name, lastName){
    return name + lastName;
}

let full = fullName('Lucas', 'Sousa'); //a varíavel full está recebendo o retorno de fullName, agora se não tivesse nada, daria undefined
console.log(`Full name: ${full}`); //então podemos armazenar o valor dentro de uma variável;
console.log(fullName('Thiago', 'Silva')); //ou podemos somente dar um console.log;
//Função com retorno condicional:

function legalAge(age){
    if (age >= 18){
        return true
    } else{
        return false
    }
}

let verification = legalAge(19);
console.log(verification);
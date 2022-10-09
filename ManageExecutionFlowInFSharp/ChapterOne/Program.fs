// let age = 66
// if age > 65
//     then printfn "Senior citizen"
//     else printfn "Citizen"

// let age = 64
// let message = if age > 65 then "Senior citizen" else "Citizen"
// printfn $"%s{message}"

// let someCondition = true
// let value = if someCondition then "hello" else 1 // not allowed

// let someCondition = true
// let value = if someCondition then "hello" else "1" // allowed

let cardValue = 1
let cardDescription = if cardValue = 1 then "Ace" elif cardValue = 14 then "Ace" else "A card"
printfn $"%s{cardDescription}"
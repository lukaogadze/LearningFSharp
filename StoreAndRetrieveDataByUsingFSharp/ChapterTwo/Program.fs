open type System.Console
printfn "Welcome to the calculator program"
// // read input from the console and assign to `sum`
// let sum = 0
// printfn $"The sum is %i{sum}"

printfn "Type the first number"
let firstNumber = ReadLine() |> int
printfn "Type the second number"
let secondNumber = ReadLine() |> int
printfn $"First %i{firstNumber}, Second %i{secondNumber}"

let sum = firstNumber + secondNumber

printfn $"The sum is %i{sum}"
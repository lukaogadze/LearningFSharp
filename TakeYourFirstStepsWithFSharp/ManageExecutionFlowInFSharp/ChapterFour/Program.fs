open type System.Console

// let list = [1;2;3;4;5]
// for i in list do printf $"%d{i}"
//
// for i = 1 to 10 do
//     printfn $"%i{i}"
//     
// for i = 10 downto 1 do
//     printfn $"%i{i}"


let mutable quit = false
let no = 11
while not quit do
    printfn "Guess a number: "
    let guessNo = ReadLine() |> int
    if guessNo = no then
        quit <- true
        printfn $"You guessed correctly %i{no} is the secret number"
    else
        printfn $"%i{guessNo} is incorrect"
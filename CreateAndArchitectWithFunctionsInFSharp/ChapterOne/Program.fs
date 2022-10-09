let add a b = a + b

let addAndMultiply  a b c = (a + b) * c

let sum1 = addAndMultiply 1 2 3
printfn $"%i{sum1}"
printfn $"%i{addAndMultiply 1 2 3}"

// let sum2 = add 2 2
// let concat = add "Hello" "World"

let concat = add "Hello" "World"

// let convert a = int a

let convert (a: string): int = a |> int
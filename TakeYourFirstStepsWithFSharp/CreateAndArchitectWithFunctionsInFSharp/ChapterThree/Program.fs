
//
// // For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"
//
// let add2 a = a + 2
// let multiply3 a = a * 3
// let addAndMultiply a = a |> (add2 >> multiply3)
//
// (addAndMultiply 2) |> printfn "%i"

let list = [4; 3; 1]
let sort (list: int list) = List.sort list
let print (list: int list)= List.iter (printfn "item %i") list

list |> sort |> print // item 1 item 3 item 4
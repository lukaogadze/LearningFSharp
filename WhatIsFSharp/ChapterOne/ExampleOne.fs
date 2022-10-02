// What is F#
module ChapterOne.ExampleOne
open System // Get access to functionality in System namespace

// Define a list of names
let names = ["Peter"; "Julia"; "Xi"]

// Define a function that takes a name and produces a greeting
let getGreeting name = $"Hello {name}"

// Print a greeting for each name
names |> List.map getGreeting |> List.iter (fun greeting -> printfn $"{greeting}! Enjoy your F#")


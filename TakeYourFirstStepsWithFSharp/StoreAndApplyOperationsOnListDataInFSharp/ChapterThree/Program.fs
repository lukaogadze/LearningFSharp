// let cards = [1..5]
// // List.iter(fun i -> printfn "%i" i) cards // 1 2 3 4 5
// // List.iter (printfn "%i") cards
//
// // for i in cards do printfn "%i" i
//
//
// type Person = {FirstName: string; LastName: string}
// let people = [
//     {FirstName = "Albert"; LastName = "Einstein"}
//     {FirstName = "Marie"; LastName = "Curie"}
// ]
//
// let nobelPrizeWinners = List.map (fun p -> p.FirstName + " " + p.LastName) people
// printfn "%A" nobelPrizeWinners
//
// let filteredList = List.filter (fun x -> x % 2 = 0) cards
// List.iter (printfn "%i") filteredList
//
// let list = [2; 1; 5; 3]
// let sortedList = List.sort list
//
// let fruits = ["Banana"; "Apple"; "Pineapple"]
// let sortedFruits = List.sortBy (fun (x: string) -> x.Length) fruits
//
// type MagicCreature = { Name : string; Level: int; Attack: int }
// let creatures = [
//    { Name="Dragon"; Level=2; Attack=20 }
//    { Name="Orc"; Level=1; Attack=5 }
//    { Name="Demon"; Level=2; Attack=10 } 
// ]
//
// let compareCreatures c1 c2 =
//      if c1.Level < c2.Level then -1
//      else if c1.Level > c2.Level then 1
//      else if c1.Attack < c2.Attack then -1
//      else if c1.Attack > c2.Attack then 1
//      else 0
//
// let sorted = List.sortWith compareCreatures creatures

let list = [1..4]
//
// let found = List.find(fun x -> x % 2 = 0) list
//
//
// let findValue aValue aList =
//      let found = aList |> List.tryFind(fun item -> item = aValue)
//
//      match found with
//      | Some value -> printfn "%i" value
//      | None -> printfn "Not found"
//
// findValue 1 list // 1
// findValue 5 list // Not found

// let found = List.tryFindIndex(fun x -> x = 4) list
// match found with
//    | Some index -> printfn "%i" index
//    | None -> printfn "Not found"
//    
// let sum = List.sum [1..5]

type OrderItem = { Name: string; Cost:int }

let orderItems = [
       { Name="XBox"; Cost=500 }
       { Name="Book"; Cost=10 }
       { Name="Movie ticket"; Cost=7 }
     ]

let sum = List.sumBy(fun x -> x.Cost) orderItems

let numbers = [ 1.0; 2.5; 3.0 ]
let avg = List.average numbers
printfn $"%f{avg}"


type WeatherMeasurement = { Date: string; Temperature: float }
let measurements = [
    { Date="07/20/2021"; Temperature=21.3 }
    { Date="07/21/2021"; Temperature=23.2 }
    { Date="07/22/2021"; Temperature=20.7 }
]

let avgBy = List.averageBy(fun m -> m.Temperature) measurements
printfn $"%f{avgBy}"
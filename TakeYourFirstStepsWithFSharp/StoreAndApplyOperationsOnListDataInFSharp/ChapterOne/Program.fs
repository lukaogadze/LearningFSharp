// // let logEntryMonday = "first entry"
// // let logEntryTuesDay = "second entry"
// // let logEntryWednesday = "third entry"
//
// let logEntriesWeek = ["first entry"; "second entry"; "third entry"]
//
// let cards = ["Ace"; "King"; "Queen"]
//
// // let cards = [ 1; "Ace"; "King" ] // not permitted
//
// let numbers = [1..5]
//
// let newList = "Jack" :: cards
// let otherCardList = ["Jack"; "10"]
// let fullList = cards @ otherCardList

let cards = ["Ace"; "King"; "Queen"]
let list2 = List<int>.Empty
let otherCardList = ["10"; "9"]
let fullList1 = cards |> List.append ["Jack"] // "Jack", "Ace", "King", "Queen"
let fullList2 = cards |> List.append otherCardList // "10", "9", "Ace", "King", "Queen"
﻿open type System.Console

let cardDescription (card: int) : string =
    let cardNo: int = card % 13
    if cardNo = 1 then "Ace"
    elif cardNo = 11 then "Jack"
    elif cardNo = 12 then "Queen"
    elif cardNo = 0 then "King"
    else string cardNo
    
let suit no =
    let suitNo = no / 13
    if suitNo = 0 then "Hearts"
    elif suitNo = 1 then "Spades"
    elif suitNo = 2 then "Diamonds"
    else "Clubs"     

[<EntryPoint>]
let main argv =
    let cards = [1;10;2;34]
    for card in cards do
        printfn $"%s{cardDescription(card)} of %s{suit(card)}"    
    0
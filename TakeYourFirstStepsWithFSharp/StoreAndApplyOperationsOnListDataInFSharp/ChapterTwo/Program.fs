let cards = [0..5]


// let drawCard (list: int list) =
//     printfn $"%i{list.Head}"
//     list.Tail
//     
// let result = cards |> drawCard |> drawCard
// printfn "Hi"
let hand = []

let drawCard (tuple: int list * int list) =
    let deck = fst tuple
    let draw = snd tuple
    let firstCard = deck.Head
    printfn "%i" firstCard
    let hand = firstCard :: draw
    (deck.Tail, hand)
    
    
let d, h = (cards, hand) |> drawCard |> drawCard

printfn $"Deck: %A{d} Hand: %A{h}"    
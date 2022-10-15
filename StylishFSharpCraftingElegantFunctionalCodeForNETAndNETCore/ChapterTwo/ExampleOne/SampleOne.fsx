open System

let convertMilesYards (milesPointYards: float): float =
    let wholeMiles = milesPointYards |> floor
    let fractions = milesPointYards - float wholeMiles
    wholeMiles + (fractions / 0.1760)
    

let decimalMiles = 1.0880 |> convertMilesYards
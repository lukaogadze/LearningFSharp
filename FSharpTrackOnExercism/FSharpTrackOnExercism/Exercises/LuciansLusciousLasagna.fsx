let expectedMinutesInOven = 40
expectedMinutesInOven |> ignore

let remainingMinutesInOven minutesInOven =
    expectedMinutesInOven - minutesInOven
    
remainingMinutesInOven 30 |> ignore   

let preparationTimeInMinutes layers =
    layers * 2
    
preparationTimeInMinutes 2 |> ignore

let elapsedTimeInMinutes layers lasagnaInOvenMinutes =
    let layerWork = preparationTimeInMinutes layers
    let remainingMinutes = layerWork + lasagnaInOvenMinutes
    remainingMinutes
    
elapsedTimeInMinutes 3 20 |> ignore    
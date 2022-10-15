// let addInterest (interestType:int, amt:float, rate:float, y:int) =
//     let rate = checkRate rate
//     let mutable amt = amt
//     checkAmount(&amt)
//     let mutable intType = interestType
//     if intType <= 0 then intType <- 1
//     if intType = 1 then
//         let yAmt = amt * rate / 100.
//         amt + yAmt * (float y)
//     else
//     amt * System.Math.Pow(1. + (rate/100.), float y)
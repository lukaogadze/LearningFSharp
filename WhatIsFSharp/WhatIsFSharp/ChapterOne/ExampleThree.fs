// Correctness with functions and pattern matching
module ChapterOne.ExampleThree

// Returns a WithdrawalResult
let withdrawMoney amount = // Implementation elided

let handleWithdrawal amount =
    let w = withdrawMoney amount

    // The F# compiler enforces accounting for each case!
    match w with
    | Success s -> printfn $"Successfully withdrew %f{s.Amount}"
    | InsufficientFunds f -> printfn $"Failed: balance is %f{f.Balance}"
    | CardExpired d -> printfn $"Failed: card expired on {d}"
    | UndisclosedFailure -> printfn "Failed: unknown :("
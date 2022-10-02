// Rich data types
module ChapterOne.ExampleTwo

// Group data with Records
type SuccessfulWithdrawal = { Amount: decimal
                              Balance: decimal }

type FailedWithdrawal = {
    Amount: decimal
    Balance: decimal
    IsOverDraft: bool
}

// Use discriminated unions to represent data of 1 or more forms
type WithdrawalResult =
    | Success of SuccessfulWithdrawal
    | InsufficientFunds of FailedWithdrawal
    | CardExpired of System.DateTimeOffset
    | UndisclosedFailure
    
    

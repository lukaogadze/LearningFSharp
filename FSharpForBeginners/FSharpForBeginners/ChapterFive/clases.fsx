type Repo(name: string, stars: int) =
    // private properties
    let baseUrl = "https://github.com"

    // private method
    let incrementStarsBy stars n = stars + n

    // Additional Constructors
    new() = Repo("", 0)

    // Instance Properties
    member this.Name = name
    member val Stars = stars with get, set

    // static Methods
    static member PrintHelp() = "Class that contains repo information"

    // methods
    member this.GetBaseUrl() = baseUrl
    member this.GetRepoUrl() = $"{baseUrl}/{this.Name}"
    member this.IncrementStarsBy(n) = this.Stars <- incrementStarsBy this.Stars n


Repo.PrintHelp()

let fsharpRepo = Repo("dotnet/fsharp", 2800)
let blankRepo = Repo()

fsharpRepo.Name
fsharpRepo.GetRepoUrl()
fsharpRepo.Stars <- 3000
fsharpRepo.IncrementStarsBy 2
fsharpRepo.Stars
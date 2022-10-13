type GithubProject = {ProjectName: string; Stars: int}

let sample: GithubProject = {
    ProjectName = "Supa"
    Stars = 23331
}  
let fsharp = {
    ProjectName = "dotnet/fsharp"
    Stars = 2800
}

printfn $"{fsharp.ProjectName} has {fsharp.Stars} stars"

let updateFSharp = {fsharp with Stars = 2801}
printfn $"{updateFSharp.ProjectName} now has {updateFSharp.Stars} stars"

type GithubProjectWithMember = 
    { ProjectName: string 
      Stars: int }
    
    member this.GetUrl() =
        $"https://github.com/{this.ProjectName}"
    
    member _.GetCodeOwner() = "dotnet"

let fsharpProj = {
    ProjectName = "dotnet/fsharp"
    Stars = 2800
}

fsharpProj.GetUrl()
fsharpProj.GetCodeOwner()

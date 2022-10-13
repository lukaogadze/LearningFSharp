type StringGithubProject = 
    { ProjectName: string
      Stars: int
      State: string }

let fakeProject = {
    ProjectName = "Amazing Project"
    Stars = 0
    State = "adsasddas"
}

type ProjectState =
    | Archived
    | Active of {| Maintainer: string |}

type GithubProject = 
    { ProjectName: string
      Stars: int
      State: ProjectState }


let corefxlab =
    { ProjectName = "corefxlab"
      Stars = 1500
      State = ProjectState.Archived }

let fhsarp =
    { ProjectName = "dotnet/fsharp"
      Stars = 2800
      State = ProjectState.Active {| Maintainer = "F# Team" |} }
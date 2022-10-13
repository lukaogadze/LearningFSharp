let point1 = (1.0, 2.0)

let githubStars = ("dotnet/fsharp", 2900);

fst githubStars
snd githubStars

let projectName1, stars = githubStars

printfn $"{projectName1}: {stars}"

let projectName2, _ = githubStars
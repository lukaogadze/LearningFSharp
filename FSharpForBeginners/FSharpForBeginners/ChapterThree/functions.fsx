fun () -> printfn "Hello World"
fun x -> x  + 1
fun x y -> x + y

let addOne x = x + 1

3 |> addOne

let buildUrlNoAnnotations protocol baseUrl path = $"{protocol}://{baseUrl}/{path}"
buildUrlNoAnnotations 1 "github.com" (1.0, 4.0)

let buildUrl (protocol: string) (baseUrl: string) (path: string) : string =
    $"{protocol}://{baseUrl}/{path}"

// buildUrl 1 "github.com" (1.0, 4.0)
buildUrl "http" "github.com" "dotnet/fsharp"
#r "nuget:FSharp.Data"

open FSharp.Data
open System.IO

let getHtml (htmlFile: string) : HtmlDocument option =
    try
        let html = HtmlDocument.Load htmlFile
        Some html
    with
    | ex ->
        printfn $"Error: {ex}"
        None

HtmlDocument.Load "doesnotexist"

"doesnotexist" |> getHtml

let htmlPath = Path.Join(__SOURCE_DIRECTORY__, "fsharp-github-repo.html")

htmlPath |> getHtml

let getLinks (html: HtmlDocument option) =
    match html with
    | Some x -> x.Descendants ["a"]
    | None -> Seq.empty

getLinks (getHtml htmlPath)

htmlPath |> getHtml |> getLinks

let getLinksFromHtml = getHtml >> getLinks
getLinksFromHtml htmlPath

htmlPath
|> getLinksFromHtml
|> fun links -> printfn $"{links}"


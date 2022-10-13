#r "nuget:FSharp.Data"

open FSharp.Data
open System.IO


type IHtmlParser =
    abstract member ParseHtml: string -> HtmlDocument

type WebParser() =
    interface IHtmlParser with
        member this.ParseHtml url = HtmlDocument.Load url

    member this.ParseHtml url = (this :> IHtmlParser).ParseHtml url

type FileParser() =
    interface IHtmlParser with
        member this.ParseHtml filepath =
            filepath
            |> File.ReadAllText
            |> fun fileContents -> HtmlDocument.Parse(fileContents)
    
    member this.ParseHtml filePath = (this :> IHtmlParser).ParseHtml filePath


let webParser = WebParser() :> IHtmlParser
let fileParser = FileParser() :> IHtmlParser

let parseHtml(parser: IHtmlParser) (source: string) = parser.ParseHtml source

parseHtml webParser "https://github.com/dotnet/fsharp"

let webParser2 =
    { new IHtmlParser with 
        member this.ParseHtml url = HtmlDocument.Load url }

let fileParser2 = 
    { new IHtmlParser with
        member this.ParseHtml filepath =
            filepath
            |> File.ReadAllText
            |> fun fileContents -> HtmlDocument.Parse(fileContents) }
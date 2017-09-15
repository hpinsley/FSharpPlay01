// Learn more about F# at http://fsharp.org
module Main

open System
open Utils.Sorting
open Utils.Web

let playWithSorting () =
    printfn "%A" (quicksort [1;5;23;18;9;1;3])
    printfn "%A" (quicksort ["dog";"cat";"elephant";"bat"])

let playWithWeb () =
    let myCallback (reader:IO.StreamReader) url =
        let html = reader.ReadToEnd()
        let html1000 = html.Substring(0,1000)
        // printfn "Downloaded %s. First 1000 is %s" url html1000
        html // return all the html

    let google = fetchUrl myCallback "http://google.com"
    // printfn "%A" google

    // build a function with the callback "baked in"
    let fetchUrl2 = fetchUrl myCallback
    // test with a list of sites
    let sites = ["http://www.bing.com";
                 "http://www.google.com";
                 "http://www.yahoo.com"]
    // process each site in the list
    let contentLength =
        sites
        |> List.map (fetchUrl2 >> String.length)
    printfn "%A" contentLength

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    playWithSorting()
    playWithWeb()

    0 // return an integer exit code
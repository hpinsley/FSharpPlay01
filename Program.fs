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
    printfn "%A" google

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    playWithSorting()
    // playWithWeb()

    0 // return an integer exit code
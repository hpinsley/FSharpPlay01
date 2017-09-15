// Learn more about F# at http://fsharp.org
module Main

open System
open Sorting

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "%A" (quicksort [1;5;23;18;9;1;3])

    0 // return an integer exit code





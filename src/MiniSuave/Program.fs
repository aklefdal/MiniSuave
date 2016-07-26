module MiniSuave

open Suave.Http
open Suave.Filters
open Suave.Combinators
open Suave.Console
open Suave.Successful

[<EntryPoint>]
let main argv =
    let request = {Route = ""; Type = Suave.Http.GET}
    let response = {Content = ""; StatusCode = 200}
    let context = {Request = request; Response = response}

    executeInLoop context (GET >=> Path "/hello" >=> OK "hello")
    0

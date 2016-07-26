module MiniSuave.Tests

open Suave.Http
open Suave.Successful
open NUnit.Framework

let request = {Route = ""; Type = Suave.Http.GET}
let response = {Content = ""; StatusCode = 200}
let context = {Request = request; Response = response}

[<Test>]
let ``OK returns 200`` () =
  let result = Suave.Successful.OK "" context |> Async.RunSynchronously
  Assert.AreEqual(200, result.Value.Response.StatusCode)

[<Test>]
let ``OK returns content`` () =
  let content = System.Guid.NewGuid().ToString()
  let result = Suave.Successful.OK content context |> Async.RunSynchronously
  Assert.AreEqual(content, result.Value.Response.Content)

namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("MiniSuave")>]
[<assembly: AssemblyProductAttribute("MiniSuave")>]
[<assembly: AssemblyDescriptionAttribute("Creating a miniture version of Suave. Chapter 1 in F# Applied")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
    let [<Literal>] InformationalVersion = "1.0"

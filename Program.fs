namespace aspnetcoreapp

module m1 =

  open m2
  open System
  open Microsoft.AspNetCore.Hosting

  [<EntryPoint>]
  let main argv =
      printfn "running web stuff"
      let host = WebHostBuilder().UseKestrel().UseStartup<Startup>().Build()
      host.Run()
      0 // return an integer exit code

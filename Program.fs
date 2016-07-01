namespace aspnetcoreapp

module m1 =

  open m2
  open System
  open Microsoft.AspNetCore.Hosting

  [<EntryPoint>]
  let main argv =
      printfn "running web stuff"
      let builder = new WebHostBuilder()
      let kestrel = builder.UseKestrel()
      let startup = kestrel.UseStartup<Startup>()
      let b = startup.Build()
      b.Run()
      0 // return an integer exit code

namespace aspnetcoreapp

module m2 =

  open System
  open Microsoft.AspNetCore.Builder
  open Microsoft.AspNetCore.Hosting
  open Microsoft.AspNetCore.Http

  type Startup() =
    member this.Configure (app : IApplicationBuilder) =
      app.Run(fun context -> context.Response.WriteAsync("Hello from ASP.NET Core!"))

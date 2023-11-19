using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RecipesApp.Client;
using RecipesApp.Client.Configurations;
using RecipesApp.Client.Services;
using RecipesApp.Shared.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

builder.Services.AddScoped<IRecipeService, ClientRecipeService>();
builder.Services.AddScoped<ICommentService, ClientCommentService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) } );

await builder.Build().RunAsync();

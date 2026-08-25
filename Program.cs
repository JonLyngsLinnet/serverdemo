using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();


public class FlaeskestegController : ControllerBase
{
    [HttpGet(nameof(GetFlaeskestegs))]
    
    public object GetFlaeskestegs()
    {
        return new
        {
            id = 1,
            Name = "umuts flæskesteg"
        };
    }
}
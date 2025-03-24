var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapGet("/sections", () =>
    {
        var sections = new List<Section>()
            {
                new Section { 
                    Title = "Who?", 
                    Content = "WhoComponent", 
                    Icon = "icon1", 
                    Html = "<div class=\"col-auto\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"CallerName\" placeholder=\"Caller Name\">" +
                           "</div>" +
                           "<div class=\"col-auto\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"CallerPhoneNumber\" placeholder=\"Caller Phone Number\">" +
                           "</div>" +
                           "<div class=\"col flex-fill d-flex justify-content-end\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"Who_HeaderNotes\" placeholder=\"Notes\" style=\"width:500px;\">" +
                           "</div>" 
                },
                new Section
                {
                    Title = "Challenges", 
                    Content = "ChallengesComponent", 
                    Icon = "icon2",
                    Html = "<div class=\"col-auto\">" +
                           "<div class=\"form-check form-check-inline\">" +
                           "<input class=\"form-check-input\" type=\"checkbox\" id=\"Challenges1\" value=\"1\">" +
                           "<label class=\"form-check-label\" for=\"Challenges1\">Pain</label></div>" +
                           "<div class=\"form-check form-check-inline\">" +
                           "<input class=\"form-check-input\" type=\"checkbox\" id=\"Challenges2\" value=\"2\">" +
                           "<label class=\"form-check-label\" for=\"Challenges2\">Difficulty Breathing</label></div>" +
                           "<div class=\"form-check form-check-inline\">" +
                           "<input class=\"form-check-input\" type=\"checkbox\" id=\"Challenges3\" value=\"3\">" +
                           "<label class=\"form-check-label\" for=\"Challenges3\">Balance</label></div>" +
                           "</div>" + // end of checkbox col-auto
                           "<div class=\"col flex-fill d-flex justify-content-end\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"Challenges_HeaderNotes\" placeholder=\"Notes\" style=\"width:500px;\">" +
                           "</div>"
                },
                new Section { 
                    Title = "Needs",
                    Content = "NeedsComponent",
                    Icon = "icon3",
                    Html = "<div class=\"col-auto\">" +
                           "<select id=\"Needs_Dropdown\" class=\"form-select form-select-sm\">" +
                           "<option value=\"0\">Select Common Need</option>"+
                           "<option value=\"1\">Option 1</option>"+
                           "</select>"+
                           "</div>" +
                           "<div class=\"col flex-fill d-flex justify-content-end\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"Needs_HeaderNotes\" placeholder=\"Notes\" style=\"width:500px;\">" +
                           "</div>"
                },
                new Section { Title = "Install Location", Content = "LocationComponent", Icon = "icon4" },
                new Section
                {
                    Title = "Branch Assignment", 
                    Content = "BranchComponent", 
                    Icon = "icon5",
                    Html = "<div class=\"col-auto d-flex d-inline align-items-end\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm me-2\" id=\"ZipCodeHeader\" placeholder=\"Zip Code\" style=\"width: 125px;\">" +
                           "<span class=\"badge text-bg-secondary\">Branch Name (List,Of,Options,Available) (1 Match)</span>" +
                           "</div>" +
                           "<div class=\"col flex-fill d-flex justify-content-end\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"Location_HeaderNotes\" placeholder=\"Notes\" style=\"width:500px;\">" +
                           "</div>" 
                },
                new Section
                {
                    Title = "Where did you hear about us?", 
                    Content = "SurveyComponent", 
                    Icon = "icon5",
                    Html = "<div class=\"col-auto\">" +
                           "<select id=\"Survey_Dropdown\" class=\"form-select form-select-sm\">" +
                           "<option value=\"0\">Select Survey Options</option>"+
                           "<option value=\"1\">Option 1</option>"+
                           "</select>"+
                           "</div>" +
                           "<div class=\"col flex-fill d-flex justify-content-end\">" +
                           "<input type=\"input\" class=\"form-control form-control-sm\" id=\"Survey_HeaderNotes\" placeholder=\"Notes\" style=\"width:500px;\">" +
                           "</div>"
                }
            }
            .ToArray();
        return sections;
    })
.WithName("GetSections")
.WithOpenApi();

app.MapFallbackToFile("/index.html");

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

internal record Section()
{
    public string Title { get; init; }
    public string Content { get; init; }
    public string Icon { get; init; }
    public string Html { get; init; }
}

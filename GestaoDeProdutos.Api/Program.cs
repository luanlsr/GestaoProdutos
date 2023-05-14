using GestaoDeProdutos.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDocSwagger();
builder.Services.AddRouting(options => options.LowercaseUrls = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwaggerDoc();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

using API_Serviciokankuamo;

var builder = WebApplication.CreateBuilder(args);
string ServicioKankuamoCORS = "_ServicioKankuamoCORS";

// Add services to the container.
builder.Services.AddConfigureCORS(ServicioKankuamoCORS);
builder.Services.AddControllers();
builder.Services.AddRegisterServiciokankuamo_DbContext(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(ServicioKankuamoCORS);
app.UseAuthorization();

app.MapControllers();

app.Run();

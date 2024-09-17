using dotnet_kafka_implementation;

var builder = WebApplication.CreateBuilder(args);

//Add the BackgroundWorkerService
builder.Services.AddHostedService<BackgroundWorkerService>();

//Inject the Producer Services
builder.Services.AddSingleton<KafkaConsumer, KafkaConsumer>();

var app = builder.Build();

app.Run();

using Microsoft.EntityFrameworkCore;
using MyTicket.DAL;
using MyTicket.DAL.Interfaces;
using MyTicket.DAL.Repositories;
using MyTicket.Services.Interfaces;
using MyTicket.Services.Services;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
       
        builder.Services.AddControllers();
        builder.Services.AddScoped<ITicketService, TicketService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IEventService, EventService>();
        builder.Services.AddScoped<ITicketRepository, TicketRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IEventReposiory, EventRepository>();
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("MyTicket")));
        

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseCors(b =>
        {
            b.AllowAnyOrigin();
            b.AllowAnyMethod();
            b.AllowAnyHeader();
        });

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
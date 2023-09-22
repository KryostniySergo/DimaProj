using DimaProj.DB.Model;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<Flight> Flights { get; set; } = null!;
    public DbSet<Passenger> Passenger { get; set; } = null!;
    public DbSet<City> Cities { get; set; } = null!;

    Random gen = new Random();
    DateTime RandomDateTime()
    {
        DateTime start = new DateTime(2023, 1, 1).ToUniversalTime();
        int range = (DateTime.Today - start).Days;
        return start.AddDays(gen.Next(range));
    }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;" +
            "Port=5432;" +
            "Database=kapitonov;" +
            "Username=postgres;" +
            "Password=12345");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var Moscow = new City
        {
            Id = 1,
            Name = "Москва"
        };
        var Habarowsk = new City
        {
            Id = 2,
            Name = "Хабаровск"
        };
        var Samara = new City
        {
            Id = 3,
            Name = "Самара"
        };

        var first = new Flight
        {
            Id = 1,
            Name = $"Борт {1}",
            CityId = Moscow.Id,
            FlyTime = RandomDateTime()
        };

        var second = new Flight
        {
            Id = 2,
            Name = $"Борт {2}",
            CityId = Habarowsk.Id,
            FlyTime = RandomDateTime()
        };

        var third = new Flight
        {
            Id = 3,
            Name = $"Борт {3}",
            CityId = Samara.Id,
            FlyTime = RandomDateTime()
        };

        List<Passenger> passengers = new List<Passenger>();
        int offset = 0;
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\AndrushaWork\DimaProj\DimaProj\DB\Del_me_Later\Names.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var sline = line.Split();
                passengers.Add(new Passenger
                {
                    Id = ++offset,
                    Name = sline[0],
                    SecondName = sline[1],
                    Surname = sline[2],
                    FlightId = gen.Next(1, 4)
                });
            }
        }

        modelBuilder.Entity<Flight>()
            .HasOne(s => s.City)
            .WithMany(s => s.Flights)
            .HasForeignKey(s => s.CityId);

        modelBuilder.Entity<Passenger>()
            .HasOne(p => p.Flight)
            .WithMany(f => f.Passengers)
            .HasForeignKey(p => p.FlightId);

        modelBuilder.Entity<City>().HasData(Moscow, Habarowsk, Samara);
        modelBuilder.Entity<Flight>().HasData(first, second, third);
        modelBuilder.Entity<Passenger>().HasData(passengers);

    }
}
namespace BlazingPizza.EFCore.Repositories.DataContexts;
public class BlazingPizzaContext : DbContext
{
    public BlazingPizzaContext(DbContextOptions options) : base(options) { }

    public DbSet<EFEntities.PizzaSpecial> Specials { get; set; }
    public DbSet<EFEntities.Topping> Toppings { get; set; }
    public DbSet<EFEntities.Pizza> Pizzas { get; set; }
    public DbSet<EFEntities.Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());

    }

    //Update-Database -p BlazingPizza.EfCore.Repositories -s BlazingPizza.EfCore.Repositories -context BlazingPizzaContext
    //Add-Migration NameOfMigration -p BlazingPizza.EfCore.Repositories -s BlazingPizza.EfCore.Repositories -context BlazingPizzaContext

}

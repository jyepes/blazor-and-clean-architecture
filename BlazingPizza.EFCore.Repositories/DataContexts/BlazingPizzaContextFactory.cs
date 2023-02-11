namespace BlazingPizza.EFCore.Repositories.DataContexts;
class BlazingPizzaContextFactory :
    IDesignTimeDbContextFactory<BlazingPizzaContext>
{
    public BlazingPizzaContext CreateDbContext(string[] args)
    {
        var OptionsBuilder =
            new DbContextOptionsBuilder<BlazingPizzaContext>();
        OptionsBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;database=BlazingPizzaDBCA");
        return new BlazingPizzaContext(OptionsBuilder.Options);
    }
}

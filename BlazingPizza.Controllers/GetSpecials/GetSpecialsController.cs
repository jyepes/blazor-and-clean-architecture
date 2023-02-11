namespace BlazingPizza.Controllers.GetSpecials;
public class GetSpecialsController : IGetSpecialsController
{
    readonly IGetSpecialsInputPort InputPort;
    readonly IGetSpecialsPresenter Presenter;

    public GetSpecialsController(IGetSpecialsInputPort inputPort,
        IGetSpecialsPresenter presenter)
    {
        InputPort = inputPort;
        Presenter = presenter;
    }

    public async Task<IReadOnlyCollection<PizzaSpecial>> GetSpecialsAsync()
    {
        return await Presenter.GetSpecialsAsync(
            await InputPort.GetSpecialsAsync());
    }
}

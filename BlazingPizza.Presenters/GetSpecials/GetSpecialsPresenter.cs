namespace BlazingPizza.Presenters.GetSpecials;
public class GetSpecialsPresenter : IGetSpecialsPresenter
{
    readonly string ImagesBaseUrl;

    public GetSpecialsPresenter(string imagesBaseUrl)
    {
        ImagesBaseUrl = imagesBaseUrl;
    }

    public Task<IReadOnlyCollection<PizzaSpecial>>
        GetSpecialsAsync(IReadOnlyCollection<PizzaSpecial> specials)
    {
        foreach (var Special in specials)
        {
            Special.ImageUrl = $"{ImagesBaseUrl}/{Special.ImageUrl}";
        }
        return Task.FromResult(specials);
    }
}

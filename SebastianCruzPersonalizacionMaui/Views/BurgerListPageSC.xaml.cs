using SebastianCruzPersonalizacionMaui.Models;
using SebastianCruzPersonalizacionMaui.Services;

namespace SebastianCruzPersonalizacionMaui.Views;

public partial class BurgerListPageSC : ContentPage
{
    private readonly ApiServiceSC _apiService;

    public BurgerListPageSC()
    {
        InitializeComponent();
        _apiService = new ApiServiceSC();
        LoadBurgers();
    }

    private async void LoadBurgers()
    {
        var burgers = await _apiService.GetBurgersAsync();
        BurgerListView.ItemsSource = burgers;
    }
}

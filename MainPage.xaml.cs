using HamburgerLC.Data;
using HamburgerLC.Models;
using HamburgerLC.Views;
using Microsoft.Maui.ApplicationModel.Communication;
using Microsoft.Maui.Controls;

namespace   HamburgerLC;

public partial class MainPage : ContentPage
{
    BurgerLC selected;
    public MainPage()
    {
        InitializeComponent();
        List.ItemsSource = UpdateList();
    }

    private async void Add(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Burger");
    }

    private async void selectedLC(object sender, SelectionChangedEventArgs e)
    {
        selected = e.CurrentSelection[0] as BurgerLC;
        await Navigation.PushAsync(new BurgerItemPage
        {
            J_pass = selected,
            BindingContext = selected,
        });
    }

    private static List<BurgerLC> UpdateList()
    {
        List<BurgerLC> burger = App.BurgerRP.GetAllBurger();
        return burger;
    }
}


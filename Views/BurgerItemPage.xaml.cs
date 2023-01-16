using HamburgerLC.Data;
using HamburgerLC.Models;

namespace HamburgerLC.Views;

[QueryProperty(nameof(J_pass), "Pass")]
public partial class BurgerItemPage : ContentPage
{
    BurgerLC Item = new BurgerLC();
    BurgerLC Pass = new BurgerLC();
    bool _flag;

    public BurgerItemPage()
    {
        InitializeComponent();
    }

    public BurgerLC J_pass
    {
        get => Pass;
        set
        {
            Pass = value;
        }
    }

    private async void SaveLC(object sender, EventArgs e)
    {
        Item = Pass;
        Item.Name = nameB.Text;
        Item.Description = descB.Text;
        Item.WithExtraCheese = _flag;

        if (string.IsNullOrEmpty(Item.Name) || string.IsNullOrEmpty(Item.Description))
        {
            return;
        }
        App.BurgerRP.AddNewBurger(Item);
        await Shell.Current.GoToAsync("Main");
    }

    private async void CancelLC(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Main");
    }

    private void CheckedChangedLC(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }

    private async void DeleteLC(object sender, EventArgs e)
    {
        Item = Pass;
        App.BurgerRP.DeleteBurger(Item);  
        await Shell.Current.GoToAsync("Main");
    }
}

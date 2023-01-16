using HamburgerLC.Data;
using HamburgerLC.Models;
using HamburgerLC.Views;

namespace HamburgerLC;

public partial class App : Application
{
    public static BurgerDatabaseLC BurgerRP { get; private set; }

    public App (BurgerDatabaseLC repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRP = repo;
    }
}
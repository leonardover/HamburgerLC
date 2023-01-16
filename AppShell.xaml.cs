using HamburgerLC.Views;

namespace HamburgerLC;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("Burger", typeof(BurgerItemPage));
        Routing.RegisterRoute("Main", typeof(MainPage));
    }
}

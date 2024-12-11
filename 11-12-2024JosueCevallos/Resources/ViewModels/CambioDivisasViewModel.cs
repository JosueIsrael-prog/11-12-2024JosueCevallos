namespace _11_12_2024JosueCevallos.Resources.ViewModels;

public class CambioDivisasViewModel : ContentPage
{
	public CambioDivisasViewModel()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}
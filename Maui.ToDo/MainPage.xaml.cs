using Maui.ToDo.ViewModel;

namespace Maui.ToDo;

public partial class MainPage : ContentPage
{

	public MainPage(MainVeiwModel mainVeiwModel)
	{
		InitializeComponent();
		BindingContext = mainVeiwModel;
	}
}


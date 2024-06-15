namespace OnePunchMan.Pages;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    private async void moveToAbout(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//about");
    }
}

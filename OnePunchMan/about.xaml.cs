namespace OnePunchMan;

public partial class about : ContentPage
{
    public about()
    {
        InitializeComponent();
    }

    private void OnTime(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;
        TimeText.Text = dt.ToString("yyyy/MM/dd HH:mm:ss");
    }

    private async void OnClicked(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//MainPage");
    }
}

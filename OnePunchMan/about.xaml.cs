namespace OnePunchMan;

public partial class about : ContentPage
{
	public about()
	{
		InitializeComponent();
        DateTime dt = DateTime.Now;
        TimeText.Text = dt.ToString("yyyy/MM/dd HH:mm:ss");
    }
}

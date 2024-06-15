namespace OnePunchMan.Pages;

using System.Diagnostics;
using System;
using System.Timers;
using System.Diagnostics.Metrics;
using Android.Media;
using Xamarin.KotlinX.Coroutines;

public partial class about : ContentPage
{
    IDispatcherTimer timer = Application.Current.Dispatcher.CreateTimer();

    int counter = 0;

    async void Timer_Counter()
    {
        counter++;
        int h = counter / 3600;
        int s = counter % 60;
        int m = counter % 3600 / 60;
        string DisplayTime = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
        
        displaytimer(DisplayTime);
    }

    public about()
    {
        InitializeComponent();
        StopWatch.Text = "00:00:00";

        timer.Interval = TimeSpan.FromSeconds(1); // 1秒間隔
        timer.Tick += (s, e) => Timer_Counter();
    }

    private void OnClicked_Get_NowTime(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;
        TimeText.Text = dt.ToString("yyyy/MM/dd HH:mm:ss");
    }

    private async void OnClicked_Move_Main(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Home");
    }

    private async void displaytimer(string DisplayTime)
    {
        StopWatch.Text = DisplayTime;
    }

    private void OnClicked_Start_Timer(object sender, EventArgs e)
    {
        timer.Start(); // タイマーを開始
    }
    private void OnClicked_Stop_Timer(object sender, EventArgs e)
    {
        timer.Stop(); // タイマーを停止
    }
}
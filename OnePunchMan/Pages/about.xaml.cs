namespace OnePunchMan.Pages;

using System.Diagnostics;
using System;
using System.Timers;
using System.Diagnostics.Metrics;
using Android.Media;

public partial class about : ContentPage
{

    Timer timer = new Timer();
    
    int counter = 0;

    void Timer_Counter(Object source, ElapsedEventArgs e)
    {
        counter++;
        int h = counter / 3600;
        int m = (counter - h * 3600) / 60;
        int s = (counter - h * 3600) - (m * 60);
        string DisplayTime = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);

        displaytimer(DisplayTime);
    }

    public about()
    {
        InitializeComponent();
        timer.Interval = 1000; // 1秒ごとに処理を行う
        timer.Elapsed += Timer_Counter;
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

    private void displaytimer(string DisplayTime)
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
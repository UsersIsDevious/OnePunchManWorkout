namespace OnePunchMan.Pages;

using System.Diagnostics;
using System;
using System.Timers;
using System.Diagnostics.Metrics;
using Android.Media;

public partial class about : ContentPage
{
    public about()
    {
        InitializeComponent();
    }

    private void OnClicked_Get_NowTime(object sender, EventArgs e)
    {
        DateTime dt = DateTime.Now;
        TimeText.Text = dt.ToString("yyyy/MM/dd HH:mm:ss");
    }


    //　あまりにも意味が分からなかった為一旦コメントアウト
    //private void Timer(object sender, EventArgs e)
    //{
    //    Timer timer = new Timer();
    //    timer.Interval = 1000; // 1秒ごとに処理を行う
    //    timer.Elapsed += Timer_Counter;
    //    int counter = 0;
    //    timer.Start(); // タイマーを開始
    //    void Timer_Counter(int counter, object sender, ElapsedEventArgs e)
    //    {
    //        counter++;
    //        int h = counter / 3600;
    //        int m = (counter - h * 3600) / 60;
    //        int s = (counter - h * 3600) - (m * 60);
    //        string DisplayTime = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
    //        StopWatch.Text = DisplayTime;
    //    }
    //}

    private async void OnClicked_Move_Main(object sender, EventArgs e)
    {
        // サブページへ移動
        await Shell.Current.GoToAsync("//Home");
    }

    private void OnClicked_Start_Timer(object sender, EventArgs e){

    }
    private void OnClicked_Stop_Timer(object sender, EventArgs e)
    {

    }
}
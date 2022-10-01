namespace WebViewTest;

public partial class MainPage : ContentPage
{
    HtmlWebViewSource src = new();

    public MainPage()
    {
        InitializeComponent();
        web.Source = src;
    }

    private void btn_Clicked(object sender, EventArgs e)
    {
        Random rnd = new();
        src.Html += $"<h1>Hello World {rnd.Next()}!</h1><br>";
        //src.Html += $"<h1>Hello World {rnd.Next()}!</h1><br>"; //uncommenting this willl crash the app with a non handled win32 exception...
        web.Reload();
    }
}
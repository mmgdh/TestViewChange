namespace TestViewChange.ContentViews;

public partial class pageMain : ContentView
{
	public pageMain()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        SecondContent.Content = new Grid()
        {
            BackgroundColor = Colors.Red
        };
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        SecondContent.Content = new Grid()
        {
            BackgroundColor = Colors.Blue
        };
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        SecondContent.Content = new Grid()
        {
            BackgroundColor = Colors.Yellow
        };
    }
}
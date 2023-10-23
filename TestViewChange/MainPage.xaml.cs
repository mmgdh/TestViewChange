using TestViewChange.ContentViews;

namespace TestViewChange
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            PageContent.Content = new pageMain();
        }
    }
}
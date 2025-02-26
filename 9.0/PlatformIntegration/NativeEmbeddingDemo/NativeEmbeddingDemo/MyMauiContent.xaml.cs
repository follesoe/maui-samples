using CommunityToolkit.Maui.Views;

namespace NativeEmbeddingDemo
{
    public partial class MyMauiContent : ContentPage
    {
        int count = 0;

        public Image DotNetBot => image;

        public MyMauiContent()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            await image.ScaleTo(1.2, 60);
            await image.ScaleTo(1, 60);
            
            var popup = new Popup
            {
                Content = new VerticalStackLayout
                {
                    Children = 
                    {
                        new Label
                        {
                            Text = "This is a very important message!"
                        }
                    }
                }
            };
            
            this.ShowPopup(popup);
        }
    }
}
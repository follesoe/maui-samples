namespace NativeEmbeddingDemo
{
    public partial class MyMauiContent : ContentView
    {
        int count = 0;

        public Image DotNetBot => image;

        public MyMauiContent()
        {
            InitializeComponent();
            
            listView.ItemsSource = new List<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };
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
        }
    }
}
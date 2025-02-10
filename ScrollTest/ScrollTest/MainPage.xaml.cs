namespace ScrollTest;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

   

    private void ScrollView_OnScrolled(object? sender, ScrolledEventArgs e)
    {
        if (e.ScrollY > 0) 
        {
            entryTest.IsVisible = false;
            imageTest.IsVisible = false;
        }
        else
        {
            entryTest.IsVisible = true;
            imageTest.IsVisible = true;
        }
    }

}
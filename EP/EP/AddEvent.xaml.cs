namespace EventPlanner;

public partial class AddEvent : ContentPage
{
	public AddEvent()
	{
		InitializeComponent();
	}
    private void ToEvents(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new Events(), true);
        Routing.RegisterRoute(nameof(Events), typeof(Events));

    }
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }
    private void OnBackClick(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), true);
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

    }
    private void ToHome(object sender, EventArgs e)
    {
        Application.Current.MainPage.Navigation.PushModalAsync(new MainPage(), true);
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

    }
    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}


namespace KidsApp;

public partial class KidsLearningDetailsPage : ContentPage
{
	public KidsLearningDetailsPage(string categoryName)
	{
		InitializeComponent();
		DisplayLearningResult(categoryName);
		Title = categoryName;
	}

    private void DisplayLearningResult(string categoryName)
    {
		LearningData learningData = new LearningData();
		switch (categoryName)
		{
			case "Numbers":
				CvKids.ItemsSource = learningData.Numbers; break;
            case "Letters":
                CvKids.ItemsSource = learningData.Letters; break;
            case "Shapes":
                CvKids.ItemsSource = learningData.Shapes; break;
            case "Colors":
                CvKids.ItemsSource = learningData.Colors; break;
            case "Fruits":
                CvKids.ItemsSource = learningData.Fruits; break;
            case "Animals":
                CvKids.ItemsSource = learningData.Animals; break;
            default:
                break;
        }
    }

    private async void CvKids_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selecteItem = e.CurrentSelection.FirstOrDefault() as LearningItems;
        await TextToSpeech.SpeakAsync(selecteItem.Name);
    }
}
using System.Collections.ObjectModel;
namespace BindingDemo
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<int> TestScores { get; set; } = new ObservableCollection<int> { 85, 92, 76, 88, 95 };
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private void btnAddScore_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(txtAddScore.Text, out int newScore) && newScore >= 0 && newScore <= 100)
            {
                TestScores.Add(newScore);
                txtAddScore.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Invald Input", "Please enter a valid score between 0 and 100.", "OK");
            }
        }
        private void OnDeleteScore(Object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is int score)
            {
                TestScores.Remove(score);
            }
            else
            {
                DisplayAlert("Error", "Unable to delete score.", "OK");
            }
        }
    }
}

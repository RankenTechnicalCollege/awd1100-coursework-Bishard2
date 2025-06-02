namespace TestScores
{
    public partial class MainPage : ContentPage
    {
        int totalScore = 0;
        int testScoreCount = 0;
        float averageScore = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddScoreClicked(object sender, EventArgs e)
        {
            if (int.TryParse(txtScoreEntry.Text, out int testScore) && testScore >= 0 && testScore <= 100)
            {
                ++testScoreCount;

                totalScore = totalScore + testScore;
                averageScore = (float)totalScore / testScoreCount;

                lblTotalScore.Text = $"  {totalScore}";
                lblScoreCount.Text = $"  {testScoreCount}";
                lblAverage.Text = $"  {averageScore}";
            }
            else
            {
                DisplayAlert("Invalid Input", "Please enter a valid score.", "OK");

            }
            txtScoreEntry.Text = string.Empty;
        }
        private void OnClearClicked(object sender, EventArgs e)
        {
            lblTotalScore.Text = string.Empty;
            lblScoreCount.Text = string.Empty;
            lblAverage.Text = string.Empty;
            txtScoreEntry.Text = string.Empty;
            totalScore = 0;
            testScoreCount = 0;
            averageScore = 0;
        }
        private void OnExitClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }
    }
}

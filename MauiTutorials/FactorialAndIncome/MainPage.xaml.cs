using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FactorialAndIncome
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateFactorial_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberEntry.Text, out int number))
            {
                lblResult.Text = "";
                if (number < 0)
                {
                    lblResult.Text = "Please enter a non negative number!";
                }
                else if (number == 0)
                {
                    lblResult.Text = "Factorial of 0 is 1";
                }
                else
                {
                    long factorial = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        factorial = factorial * i;
                    }
                    lblResult.Text = $"The factorial of {number} is {factorial}.";
                }
            }
            else
            {
                lblResult.Text = "Invalid Input. Please enter a whole number!";

            }
        }
        private async void GoToIncomeTaxPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IncomeTaxPage());
        }
    }
}

using CRUDUsers.Data;
using CRUDUsers.Models;
using System.Linq.Expressions;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace CRUDUsers
{
    public partial class MainPage : ContentPage
    {
        private readonly DataContext _dataContext;

        public ObservableCollection<User> Users { get; set; }

        public MainPage(DataContext dataContext)
        {
            InitializeComponent();
            _dataContext = dataContext;
            Users = new ObservableCollection<User>();
            BindingContext = this;
            LoadUsers();
        }

        private async void LoadUsers()
        {
            try
            {
                await _dataContext.Database.EnsureCreatedAsync();
                var users = await _dataContext.Users.ToListAsync();
                foreach (var user in users)
                {
                    Users.Add(user);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to load users {ex.Message}", "OK");
            }
        }


        private async void OnAddUserClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                await DisplayAlert("Error", "Name cannot be empty", "OK");
                return;
            }
            try
            {
                var newUser = new User { Name = NameEntry.Text.Trim() };
                _dataContext.Users.Add(newUser);
                await _dataContext.SaveChangesAsync();

                Users.Add(newUser);
                NameEntry.Text = string.Empty;
                await DisplayAlert("Sucess", "User added successfully", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to add user: {ex.Message}", "OK");
                return;
            }
        }

        private async void OnDeleteUserClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is User userToDelete)
            {
                bool confirmed = await DisplayAlert("Confirm Delete",
                    $"Are you sure you want to delete {userToDelete.Name}?",
                    "Yes", "No");
                if (!confirmed)
                {
                    return;
                }
                try
                {
                    _dataContext.Users.Remove(userToDelete);
                    await _dataContext.SaveChangesAsync();

                    Users.Remove(userToDelete);
                    await DisplayAlert("Success", "User deleted successfully", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"Failed to delete user: {ex.Message}", "OK");
                    return;
                }
            }
        }

        private async void OnEditUserClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is User userToEdit)
            {
                string newName = await DisplayPromptAsync("Edit User", "Enter new name:", initialValue: userToEdit.Name);
                if (string.IsNullOrWhiteSpace(newName))
                {
                    await DisplayAlert("Error", "Name cannot be empty", "OK");
                    return;
                }
                try
                {
                    userToEdit.Name = newName.Trim();
                    _dataContext.Users.Update(userToEdit);
                    await _dataContext.SaveChangesAsync();

                    var index = Users.IndexOf(userToEdit);
                    if (index != -1)
                    {
                        Users[index] = userToEdit;
                    }
                    await DisplayAlert("Success", "User Updated successfully", "OK");
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Error", $"Failed to update user: {ex.Message}", "OK");
                }
            }
        }
    }
}

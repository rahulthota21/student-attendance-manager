private void Login_Click(object sender, RoutedEventArgs e)
{
    if (UsernameBox.Text == "admin" && PasswordBox.Password == "password")
    {
        new MainWindow().Show();
        this.Close();
    }
    else
    {
        MessageBox.Show("Invalid credentials!");
    }
}

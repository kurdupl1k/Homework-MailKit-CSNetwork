using System.Windows;

namespace Project
{
  public partial class AuthorizationWindow : Window
  {
    public static string Email { get; private set; }
    public static string Password { get; private set; }

    public AuthorizationWindow() { InitializeComponent(); }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      Email = txtbxEmail.Text;
      Password = psswrdbx.Password;
    }
  }
}
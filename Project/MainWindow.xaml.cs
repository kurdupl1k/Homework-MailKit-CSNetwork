using MailKit.Net.Imap;
using MimeKit;
using System.Windows;

namespace Project
{
  public partial class MainWindow : Window
  {
    public MainWindow() { InitializeComponent(); }

    private void DataGrid_Loaded(object sender, RoutedEventArgs e)
    {
      using (ImapClient imapClient = new ImapClient())
      {
        imapClient.Connect("imap.gmail.com", 993, true);
        imapClient.Authenticate(AuthorizationWindow.Email,
          AuthorizationWindow.Password);

        var inbox = imapClient.Inbox;
        inbox.Open(MailKit.FolderAccess.ReadOnly);

        foreach (var message in inbox)
          dgMessages.Items.Add(new MimeMessage()
          {
            Subject = message.Subject,
            Body = message.Body
          });
      }
    }
  }
}
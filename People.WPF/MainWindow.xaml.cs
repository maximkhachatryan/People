using People.WPF.Folks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace People.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IFolksContract _service;
        public MainWindow()
        {
            InitializeComponent();
            var factory = new ChannelFactory<IFolksContract>(new NetTcpBinding(), new EndpointAddress("net.tcp://localHost:6000/Folks"));
            _service = factory.CreateChannel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _service.Insert(new PersonDTO
            {
                FirstName = txtFirstName.Text,
                LastName=txtLastName.Text,
                Notes=txtNotes.Text,
                Email=txtEmail.Text,
                Phone=txtPhone.Text
            });
        }
    }
}

using FriendStorage.UI.ViewModel;
using System.Windows;

namespace FriendStorage.UI.View
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel viewModel;

        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.viewModel = mainViewModel;
            DataContext = viewModel;
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.Load();
        }
    }
}

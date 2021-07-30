using System.Windows;
using System.Windows.Controls;

namespace View
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new CategoryTable();
        }

        private void ChangeCategory(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeView treeView = sender as TreeView;
            if (treeView == null)
                return;

            Category category = treeView.SelectedItem as Category;
            if (category == null)
                return;

            mainView.Children.Clear();
            mainView.Children.Add(category.Control);
        }
    }
}

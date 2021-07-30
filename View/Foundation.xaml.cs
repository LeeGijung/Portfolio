using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace View
{
    /// <summary>
    /// Foundation.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Foundation : UserControl
    {
        public Foundation()
        {
            InitializeComponent();
            DataContext = new ViewModel.Foundation();
        }
    }
}

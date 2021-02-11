using System;
using System.Collections.Generic;
using System.Linq;
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
using DesignPatterns.Views;
using DesignPatterns.Models;
using DesignPatterns.ViewModels;

namespace DesignPatterns.Views
{
    /// <summary>
    /// Interakční logika pro AddUserView.xaml
    /// </summary>
    public partial class AddUserView : Page
    {
        public AddUserView()
        {
            InitializeComponent();
            DataContext = new AddUserViewModel();
            
        }
    }
}

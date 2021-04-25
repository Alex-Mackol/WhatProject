using System;
using System.Collections.Generic;
using System.ComponentModel;
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

//using WhatProject.Models;
using WhatProject.ViewModel;

namespace WhatProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ICollectionView ItemList;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ThemeViewModel themeViewModel = new ThemeViewModel();
            CollectionViewSource itemSourceList = new CollectionViewSource()
            {
                Source = themeViewModel.ThemeGridItems
            };
            ItemList = itemSourceList.View;

            Themes.ItemsSource = ItemList;
        }
    }
}

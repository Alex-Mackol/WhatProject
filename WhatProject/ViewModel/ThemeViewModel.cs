using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WhatProject.Models;

namespace WhatProject.ViewModel
{
    class ThemeViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Theme> themeGridItems;
        public ObservableCollection<Theme> ThemeGridItems
        {
            get => themeGridItems;
            set
            {
                themeGridItems = value;
                OnPropertyChanged(nameof(ThemeGridItems));
            }
        }

        public ThemeViewModel()
        {
            ThemeGridItems = new ObservableCollection<Theme>();
            ThemeGridItems.Add(new Theme(1, "theme1"));
            ThemeGridItems.Add(new Theme(2, "theme2"));
            ThemeGridItems.Add(new Theme(3, "theme3"));
            ThemeGridItems.Add(new Theme(4, "theme4"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

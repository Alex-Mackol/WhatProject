using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatProject.Models
{
    class Theme : INotifyPropertyChanged
    {
        private string name;
        private int id;

        public int Id { get => id; }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        public Theme(int id,string name )
        {
            Lessons = new HashSet<Lesson>();

            this.name = name;
            this.id = id;
        }

        public virtual ICollection<Lesson> Lessons { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

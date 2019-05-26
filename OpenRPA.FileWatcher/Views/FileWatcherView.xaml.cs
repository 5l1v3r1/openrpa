﻿using OpenRPA.Interfaces;
using OpenRPA.Interfaces.entity;
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

namespace OpenRPA.FileWatcher.Views
{
    public partial class FileWatcherView : UserControl, INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
        public FileWatcherView(FileWatcherDetectorPlugin plugin)
        {
            InitializeComponent();
            this.plugin = plugin;
            DataContext = this;
        }
        private IDetectorPlugin plugin;
        public FileWatcherDetector Entity
        {
            get
            {
                return plugin.Entity as FileWatcherDetector;
            }
        }
        public string EntityName
        {
            get
            {
                if (Entity == null) return string.Empty;
                return Entity.name;
            }
            set
            {
                Entity.name = value;
                NotifyPropertyChanged("Entity");
            }
        }
        public string EntityPath
        {
            get
            {
                if (Entity == null) return string.Empty;
                plugin.Stop();
                plugin.Start();
                return Entity.Watchpath;
            }
            set
            {
                Entity.Watchpath = value;
                NotifyPropertyChanged("Entity");
            }
        }
        public string EntityFilter
        {
            get
            {
                if (Entity == null) return string.Empty;
                plugin.Stop();
                plugin.Start();
                return Entity.WatchFilter;
            }
            set
            {
                Entity.WatchFilter = value;
                NotifyPropertyChanged("Entity");
            }
        }
        private void Open_Selector_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Highlight_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Select_Click(object sender, RoutedEventArgs e)
        {
        }
        private void StartRecordPlugins()
        {
        }
        private void StopRecordPlugins()
        {
        }
        public void OnUserAction(Interfaces.IPlugin sender, Interfaces.IRecordEvent e)
        {
        }
    }
}

﻿using System;
using System.Windows;

namespace SQLiteWpfApp.Views.Windows
{
    public partial class RequestsWindow : Window
    {
        private static RequestsWindow? _instance = null;

        private static Action _action = () =>
        {
            var instance = Instance;
            instance.Show();
        };

        public static RequestsWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RequestsWindow();
                }
                return _instance;
            }
        }

        public static Action Action => _action;

        public RequestsWindow()
        {
            InitializeComponent();

            DataContext = (Action)(() => _instance = null);
        }
    }
}
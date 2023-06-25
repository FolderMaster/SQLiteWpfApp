﻿using System;
using System.Collections.Generic;
using System.Windows;

using Model.Dependent;
using Model.Independent;
using ViewModel.VMs.DbSet;
using View.MessageBoxes;

namespace View.Windows.DbSet.Dependent
{
    public partial class StudentsWindow : Window
    {
        private static StudentsWindow? _instance = null;

        private static Action _action = () =>
        {
            var instance = Instance;
            instance.Show();
        };

        public static StudentsWindow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentsWindow();
                }
                return _instance;
            }
        }

        public static Action Action => _action;

        public StudentsWindow()
        {
            InitializeComponent();

            var messageService = new ErrorMessageBoxService();

            DataContext = new List<object>()
            {
                new ControlDbSetVM<Student>(messageService),
                new DbSetVM<Group>(messageService), new DbSetVM<Scholarship>(messageService),
                new DbSetVM<Person>(messageService),
                (Action)(() => _instance = null)
            };
        }
    }
}
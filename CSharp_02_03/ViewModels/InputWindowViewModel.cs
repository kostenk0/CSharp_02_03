﻿using CSharp_02_03.Model;
using CSharp_02_03.Tools;
using CSharp_02_03.Tools.Meneger;
using CSharp_02_03.Windows;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace CSharp_02_03.ViewModels
{
    class InputViewModel : BaseViewModel
    {
        private Person _mainPerson;
        private RelayCommand<object> _proceed;
        private RelayCommand<object> _close;

        public InputViewModel()
        {
            _mainPerson = new Person();
        }

        public Person MainPerson
        {
            get
            {
                return _mainPerson;
            }
            set
            {
                _mainPerson = value;
                OnPropertyChanged("MainPerson");
            }
        }

        public RelayCommand<object> Proceed
        {
            get
            {
                return _proceed ?? (_proceed = new RelayCommand<object>(
                           ProceedImplementation));
            }
        }

        private async void ProceedImplementation(object obj)
        {
            LoaderManeger.Instance.ShowLoader();
            Person person = new Person();
            try
            {
                await Task.Run(() =>
                {
                    person = new Person(_mainPerson.Name, _mainPerson.Surname, _mainPerson.Email, _mainPerson.DateOfBirth);
                    if (person.IsBirthday)
                        MessageBox.Show("Happy birthday!!!");
                });
                OutputWindow outputWindow = new OutputWindow(person);
                outputWindow.ViewModel = "OutputWindow";
                outputWindow.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                LoaderManeger.Instance.HideLoader();
            }
        }

        public RelayCommand<object> CloseCommand
        {
            get
            {
                return _close ?? (_close = new RelayCommand<object>(o => Environment.Exit(0)));
            }
        }
    }
}

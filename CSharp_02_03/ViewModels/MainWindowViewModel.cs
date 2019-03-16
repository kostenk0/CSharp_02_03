using CSharp_02_03.Tools;
using CSharp_02_03.Tools.Meneger;
using System;
using System.Windows;

namespace CSharp_02_03.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel, ILoaderOwner
    {
        private bool _isControlEnabled = true;

        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }

        public Visibility LoaderVisibility { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal MainWindowViewModel()
        {
            LoaderManeger.Instance.Initialize(this);
        }

    }
}

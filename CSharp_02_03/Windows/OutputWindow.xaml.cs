using CSharp_02_03.Model;
using CSharp_02_03.Tools.Meneger;
using CSharp_02_03.ViewModels;
using System;
using System.ComponentModel;
using System.Windows;

namespace CSharp_02_03.Windows
{
    /// <summary>
    /// Interaction logic for OutputWindow.xaml
    /// </summary>
    public partial class OutputWindow : Window
    {
        public string ViewModel { get; set; }

        public OutputWindow(Person person)
        {
            InitializeComponent();
            OutputViewModel model = new OutputViewModel(person);
            this.DataContext = model;
            if (model.CloseAction == null)
                model.CloseAction = new Action(() => this.Close());
            this.Closing += Window_Closing;
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            LoaderManeger.Instance.HideLoader();
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
    }
}

using System.ComponentModel;

namespace CSharp_02_03.Tools
{
    internal interface ILoaderOwner : INotifyPropertyChanged
    {
        bool IsControlEnabled { get; set; }
    }
}

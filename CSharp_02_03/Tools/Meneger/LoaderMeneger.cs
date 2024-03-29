﻿namespace CSharp_02_03.Tools.Meneger
{
    internal class LoaderManeger
    {
        private static readonly object Locker = new object();
        private static LoaderManeger _instance;

        internal static LoaderManeger Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                lock (Locker)
                {
                    return _instance ?? (_instance = new LoaderManeger());
                }
            }
        }

        private ILoaderOwner _loaderOwner;

        private LoaderManeger()
        {

        }

        internal void Initialize(ILoaderOwner loaderOwner)
        {
            _loaderOwner = loaderOwner;
        }

        internal void ShowLoader()
        {
            _loaderOwner.IsControlEnabled = false;
        }
        internal void HideLoader()
        {
            _loaderOwner.IsControlEnabled = true;
        }
    }
}

﻿using System;

using NotepadRs4.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace NotepadRs4.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Initialize();
        }

        // TODO: Check if this can be done soly by the ViewModel
        private void txtContent_Drop(object sender, Windows.UI.Xaml.DragEventArgs e)
        {
            ViewModel.DropText(e);
        }
        // TODO: Check if this can be done soly by the ViewModel
        private void txtContent_DragOver(object sender, Windows.UI.Xaml.DragEventArgs e)
        {
            e.AcceptedOperation = Windows.ApplicationModel.DataTransfer.DataPackageOperation.Copy;
        }
    }
}

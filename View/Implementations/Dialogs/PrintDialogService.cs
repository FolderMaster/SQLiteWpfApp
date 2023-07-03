﻿using System.Windows.Controls;
using System.Windows.Documents;

using ViewModel.Interfaces;

namespace View.Implementations.Dialogs
{
    public class PrintDialogService : IPrintDialogService
    {
        private PrintDialog _dialog;

        public void Print(object document, string description)
        {
            if (_dialog.ShowDialog() == true)
            {
                _dialog.PrintDocument(document as DocumentPaginator, description);
            }
        }

        public PrintDialogService()
        {
            _dialog = new PrintDialog();
        }
    }
}
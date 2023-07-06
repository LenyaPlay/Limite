using Limite.Commands;
using Limite.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Limite
{
    public class MainContentViewModel : ViewModel
    {
        private object content;
        private RelayCommand openPageCommand;
        public object Content
        {
            get => content;
            set => Set(ref content, value);
        }
        public RelayCommand OpenPageCommand
        {
            get => openPageCommand;
            set => Set(ref openPageCommand, value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Limite.ViewModels
{
    public class ThemeViewModel : ViewModel
    {
        private string name;
        private string uri;
        private SolidColorBrush color;

        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        public string Uri
        {
            get => uri;
            set => Set(ref uri, value);
        }

        public SolidColorBrush Color
        {
            get => color;
            set => Set(ref color, value);
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_MAUI_APPLICATION
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _expressionDisplay = string.Empty;
        [ObservableProperty]
        private string _resultDisplay = string.Empty;


    }
}

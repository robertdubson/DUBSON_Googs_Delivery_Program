using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class AboutViewModel : IViewModel
    {
        public string _aboutText;



        public string AboutText { get { return _aboutText; } set { _aboutText = value; OnPropertyChanged("AboutText"); } }

        public void LoadData()
        {

        }

        public void OnPropertyChanged(string propertyName)
        {

        }
    }
}

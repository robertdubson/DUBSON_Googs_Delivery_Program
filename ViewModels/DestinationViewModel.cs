using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Model;
using System.ComponentModel;
using Mappers;
using DataLib;
using DataLib.UnitOfWork;
namespace ViewModels
{
    public class DestinationViewModel : IViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ProductViewModel parentViewModel;

        public void OnPropertyChanged(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        List<DestinationModel> modelObjects;

        DestinationService _destinationService;

        private static DestinationViewModel instance;

        DestinationModel _selectedDestination;

        DestinationMapper _destinationMapper;

        public DestinationViewModel()
        {
            

            _destinationService = new DestinationService(new UnitOfWork(new ApplicationContext()).DestinationRepository);

            _destinationMapper = new DestinationMapper();

            modelObjects = new List<DestinationModel>();

            //_selectedDestination = new DestinationModel();

            LoadData();

            instance = this;
        }

        public DestinationModel SelectedDestination { get { return _selectedDestination; } set { _selectedDestination = value; OnPropertyChanged("SelectedDestination"); } }

        public static DestinationViewModel Instance { get { return instance; }  }
        
        public List<DestinationModel> ModelObjects { get { return modelObjects; } set { modelObjects = value; OnPropertyChanged("ModelObjects"); } }

        public void LoadData() {

            ModelObjects = _destinationService.GetAllDestinations().Select(dest => _destinationMapper.FromDomainToModel(dest)).ToList();
        
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Model;
using Mappers;
using DataLib;
using System.ComponentModel;
namespace ViewModels
{
    public class TransportViewModel : IViewModel, INotifyPropertyChanged
    {
        TransportMapper _transportMapper;

        TransportService _transportService;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }

        List<TransportModel> modelObjects;

        TransportModel selectedTransport;

        public TransportModel SelectedTransport { get { return selectedTransport; } set { selectedTransport = value; OnPropertyChanged("SelectedTransport"); } }
    
        public List<TransportModel> ModelObjects { get { return modelObjects; } set { modelObjects = value; OnPropertyChanged("ModelObjects"); } }


        public TransportViewModel()
        {

            _transportService = new TransportService(new DataInitializer().transportRepository);
            _transportMapper = new TransportMapper();
            
            modelObjects = _transportService.GetAllTransports().Select(transport => _transportMapper.FromDomainToModel(transport)).ToList();
        
        }

        public void LoadData() { 
        
        
        }
    }
}

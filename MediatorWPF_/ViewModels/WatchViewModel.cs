using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Mediator
{
    public class WatchViewModel : ISubscriber<WatchMessage>, INotifyPropertyChanged
    {
        private ObservableCollection<Product> _Products;
        private string _messageReceived;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private IMediator _mediator;
        public WatchViewModel()
        {
            LoadProduct();
            PublishCommand = new RelayCommand(Publish);
            _mediator = SingletonMediator.GetMediator;

        }
        #region public properties
        public ObservableCollection<Product> Products
        {
            get
            {
                return _Products;
            }
            set
            {
                if (value != _Products)
                {
                    _Products = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Products"));
                }
            }
        }

        public string ReceivedMessageFrom
        {
            get
            {
                return _messageReceived;
            }
            set
            {
                _messageReceived = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ReceivedMessageFrom"));
            }
        }

        public RelayCommand PublishCommand { get; set; } 
        #endregion

        #region private method
        private void Publish()
        {
            WatchMessage watchMessage = new WatchMessage
            {
                WatchInfoMessage = "watch notification"
            };

            _mediator.Publish(watchMessage);
            // empty method
        }
        
        private void LoadProduct()
        {
            List<Product> products = new List<Product>()
                {
                     new Product {Id=1, Name="Classic Watch", Description="Watch with all the basic fucntionalities.", Image="watch3.PNG"},
                    new Product {Id=2, Name="Premium watch", Description="Premium watch with all premium features",Image="watch2.PNG"},
                    new Product {Id=3, Name="Office watch", Description="Watch for all professionals", Image="watch1.PNG"}
                };
            Products = new ObservableCollection<Product>(products.ToList());
            Products.ToList().ForEach(p => p.Image = "../Images/" + p.Image);
        }

        public void Handle(WatchMessage message)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

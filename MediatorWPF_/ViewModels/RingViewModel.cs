using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace WPF_Mediator
{
    public class RingViewModel : ISubscriber<PhoneMessage>, INotifyPropertyChanged
    {
        private ObservableCollection<Product> _Products;
        private string _messageReceived;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private IMediator _mediator;
        public RingViewModel()
        {
            LoadProduct();
            PublishCommand = new RelayCommand(Publish);

            _mediator = SingletonMediator.GetMediator;

            _mediator.Subscribe(this);
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

        #region private methods
        private void Publish()
        {
            RingMessage ringMessage = new RingMessage
            {
                RingSaleNumber = 2500
            };

            // publish ringMessage
        }

        private void LoadProduct()
        {
            List<Product> products = new List<Product>()
                {
                    new Product {Id=1, Name="Diamond Ring", Description="Classic diamond ring", Image="ClassicRing2.PNG"},
                    new Product {Id=2, Name="Wedding Ring", Description="Perfect ring for wedding",Image="RubyRing.PNG"},
                    new Product {Id=3, Name="American diamond ring", Description="Quality ring", Image="ClassicRing.PNG"}
                };
            Products = new ObservableCollection<Product>(products.ToList());
            Products.ToList().ForEach(p => p.Image = "../Images/" + p.Image);
        }

        public void Handle(PhoneMessage message)
        {
            ReceivedMessageFrom = message.PhoneInfoMessage;
        }
        #endregion
    }
}

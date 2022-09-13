using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace WPF_Mediator
{
    public class PhoneViewModel : ISubscriber<PhoneMessage>, ISubscriber<WatchMessage>, INotifyPropertyChanged
    {
        private ObservableCollection<Product> _Products;
        private string _messageReceived;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private IMediator _mediator;
        public PhoneViewModel()
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
            PhoneMessage phoneMessage = new PhoneMessage
            {
                PhoneInfoMessage = "Info from phone VM",
                IsPhonePriceIncreased = true
            };

            _mediator.Publish(phoneMessage);
        }

        private void LoadProduct()
        {
            List<Product> products = new List<Product>()
                {
                    new Product {Id=1, Name="Samsung Phone", Description="Low cost phone with 4000MAH battery", Image="Samsung.PNG"},
                    new Product {Id=2, Name="iPhone", Description="iPhone 12 S Series",Image="iPhone.PNG"},
                    new Product {Id=3, Name="Xiaomi", Description="Xiaomi Redmi Note 9", Image="xaomiMob.PNG"}
                };
            Products = new ObservableCollection<Product>(products.ToList());
            Products.ToList().ForEach(p => p.Image = "../Images/" + p.Image);
        }

        public void Handle(PhoneMessage message)
        {
            // empty
        }

        public void Handle(WatchMessage message)
        {
            ReceivedMessageFrom = message.WatchInfoMessage;
        }
        #endregion
    }
}

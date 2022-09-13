using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Mediator
{ 
    public class PhoneMessage : IMessage
    {
        public string PhoneInfoMessage { get; set; }
        public bool IsPhonePriceIncreased { get; set; }
    }
}

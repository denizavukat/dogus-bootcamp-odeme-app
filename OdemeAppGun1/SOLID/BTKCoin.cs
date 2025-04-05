using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeAppGun1.SOLID
{
    public class BTKCoin : ILog
    {
        public string log(string message)
        {
            return "BTK Coin ile " + message + " TL Ödeme Yapıldı";
        }
    }
}

using BUS.Interface;
using PlasticsFactory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Business
{
    public class PaymentInputBO : Responsity<PaymentInput>, IPaymentInput
    {
        public int GetID()
        {
            int count = GetData(u => u.isDelete == false).ToList().Count();
            if(count==0)
            {
                return 1;
            }
            return GetData(u => u.isDelete == false).ToList().Last().ID+1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Helper
{
    // interface untuk pengiriman object antar form
    public interface IListener
    {
        void Ok(object sender, object data);
        void Ok(object sender, bool isNewData, object data);
    }
}

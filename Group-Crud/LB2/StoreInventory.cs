using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class StoreInventory
    {
        string _name;
        int _upcCode;
        int _storePrice;
        int _costPerCase;
        int _unitsPerCase;
        string _distributor;

        public StoreInventory(string name, int upcCode, string distributor, int storePrice, int costPerCase, int unitsPerCase)
        {
            _name = name;
            _upcCode = upcCode;
            _distributor = distributor;
            _storePrice = storePrice;
            _costPerCase = costPerCase;
            _unitsPerCase = unitsPerCase;
        }

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public int UpcCode
        {
            set { _upcCode = value; }
            get { return _upcCode; }
        }

        public string Distributor
        {
            set { _distributor = value; }
            get { return _distributor; }
        }

        public int StorePrice
        {
            set { _storePrice = value; }
            get { return _storePrice; }
        }

        public int CostPerCase
        {
            set { _costPerCase = value; }
            get { return _costPerCase; }
        }

        public int UnitsPerCase
        {
            set { _unitsPerCase = value; }
            get { return _unitsPerCase; }
        }
    }
}

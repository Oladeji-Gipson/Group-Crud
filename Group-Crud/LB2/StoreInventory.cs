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
        string _upcCode;
        double _storePrice;
        double _costPerCase;
        int _unitsPerCase;
        string _distributor;

        public StoreInventory(string name, string upcCode, string distributor, double storePrice, double costPerCase, int unitsPerCase)
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

        public string UpcCode
        {
            set { _upcCode = value; }
            get { return _upcCode; }
        }

        public string Distributor
        {
            set { _distributor = value; }
            get { return _distributor; }
        }

        public double StorePrice
        {
            set { _storePrice = value; }
            get { return _storePrice; }
        }

        public double CostPerCase
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

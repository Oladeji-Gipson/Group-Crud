using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class StoreInventory
    {
        private string _name;
        private string _upc;
        private decimal _price;
        private decimal _cost;
        private int _units;
        private string _distributor;
        private int _position;


        public void SetStoreInventory(string name, string upc, decimal price, decimal cost, int units, string distributor, int position)
        {
            _name = name;
            _upc = upc;
            _price = price;
            _cost = cost;
            _units = units;
            _distributor = distributor;
            _position = position;
        }

        public void SetNewPrice(decimal newPrice)
        {
            _price = newPrice;
        }

        public string GetName()
        {
            if (_name == null) { _name = ""; }
            return _name;
        }

        public string GetUpc()
        {
            return _upc;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public decimal GetCost()
        {
            return _cost;
        }

        public int GetUnits()
        {
            return _units;
        }

        public string GetDistributor()
        {
            return _distributor;
        }

        public int GetPosition()
        {
            return _position;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject2.business_page
{
    class Product
    {
        public Product(string prodName, string category, string supplier, string unitPrice, string quantityPerUnit, string unitsInStock, string unitsOnOrder, string reorderLevel, string discontinued)
        {
            this.prodName = prodName;
            Category = category;
            Supplier = supplier;
            UnitPrice = unitPrice;
            QuantityPerUnit = quantityPerUnit;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
        }

        public string prodName { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public string UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
    }
}
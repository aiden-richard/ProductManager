using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager
{
    /// <summary>
    /// Represents a product for sale
    /// </summary>
    internal class Product
    {
        /// <summary>
        /// A unique identifier for the product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The user facing name of the product
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Manufacturer's Suggested Retail Price
        /// </summary>
        public double MSRP { get; set; }

        /// <summary>
        /// The price we are selling the product at to the consumer
        /// </summary>
        public double SalesPrice { get; set; }

        /// <summary>
        /// The number of units of this product in stock
        /// </summary>
        public int Quantity { get; set; }
    }
}

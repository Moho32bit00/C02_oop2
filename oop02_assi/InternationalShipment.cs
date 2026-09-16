using System;
using System.Collections.Generic;
using System.Text;

namespace oop02_assi
{
    public class InternationalShipment : Shipment
    {
        public string DestinationCountry
        {
            get { return DestinationCountry; }
            set
            {
                if (DestinationCountry != null || DestinationCountry != "" || DestinationCountry != " ")
                {
                    DestinationCountry = value;
                }
            }
        }
        public decimal CustomsFee
        {
            get { return CustomsFee; }
            set
            {
                if (CustomsFee >= 0)
                {
                    CustomsFee = value;
                }
            }

        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }
        public InternationalShipment() { }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.CustomsFee = CustomsFee;
            this.DestinationCountry = DestinationCountry;
        }
    }
}

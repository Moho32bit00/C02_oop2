using System;
using System.Collections.Generic;
using System.Text;

namespace C02_oop02
{
    public class ExpressShipment : Shipment
    {
        public decimal ExtraFee
        {
            get { return ExtraFee; }
            set
            {
                if (ExtraFee >= 0)
                {
                    ExtraFee = value;
                }
            }
        }
        public override decimal EstimatedCost { get { return DeliveryFee + (Weight * 5) + ExtraFee; } }

        public ExpressShipment() { }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal fee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            Destination = destination;
            this.ExtraFee = ExtraFee;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace oop02_assi
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

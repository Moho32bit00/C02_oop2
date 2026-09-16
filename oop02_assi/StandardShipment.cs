using System;

namespace C02_oop02
{
    public class StandardShipment : Shipment
    {
        public StandardShipment() { }
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }
    }
}
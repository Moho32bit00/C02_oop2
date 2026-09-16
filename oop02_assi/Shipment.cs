using System;
using System.Collections.Generic;
using System.Text;

namespace oop02_assi
{
    public class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public string TrackingCode => trackingCode;

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != null && value != "" && value != " ")
                {
                    description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return weight; }

            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }

            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        public DeliveryAddress Destination { get; set; }

        public virtual decimal EstimatedCost
        {
            get
            {
                return deliveryFee + (weight * 5);
            }
        }

        public Shipment() { }
        public Shipment(string trackingCode)
        {
            this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        public void PrintShipment()
        {
            Console.Write($"Distenation : \nCity : {Destination.City}\nStreet : {Destination.Street}\nBuilding Number : " +
                $"{Destination.BuildingNumber}\nTracking Code : {trackingCode}\nDescription : {description}\nWeight : {weight}\nDelivery Fee : {deliveryFee}\n" +
                $"estimated cost : {EstimatedCost}\n\n");
        }
    }
}


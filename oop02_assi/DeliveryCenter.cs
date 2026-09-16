using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop02_assi
{
    public class DeliveryCenter
    {

        private Shipment[] shipment;
        public string CenterName { get; set; }
        public DeliveryCenter() { this.shipment = new Shipment[20]; }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipment.Length)
                {
                    return shipment[index];
                }
                else { return default; ; }
            }
            set
            {
                if (index >= 0 && index < shipment.Length)
                {
                    shipment[index] = value;
                }
            }
        }

        public Shipment this[string TrackingCode]
        {
            get
            {
                for (int i = 0; i < shipment.Length; i++)
                {
                    if (shipment[i].TrackingCode == TrackingCode)
                    {
                        return shipment[i];
                    }

                }
                return default;
            }
        }

        public bool AddShipment(Shipment s_shipment)
        {
            if (shipment == null) shipment = new Shipment[20];

            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i] == null)
                {
                    shipment[i] = s_shipment;
                    return true;
                }

            }
            return false;
        }

        public bool RemoveShipment(string tracking_code)
        {
            for (int i = 0; i < shipment.Length; i++)
            {
                if (shipment[i].TrackingCode == tracking_code)
                {
                    for (int j = i; j < shipment.Length - 1; j++)
                    {
                        shipment[j] = shipment[j + 1];
                    }
                    shipment[shipment.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrinAllShipment()
        {
            int i = 0;
            while (shipment[i] != null)
            {
                shipment[i].PrintShipment();
                i++;
            }
        }
    }


}

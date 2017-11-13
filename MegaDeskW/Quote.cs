using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaDeskW
{
    public class Quote
    {
        public DateTime date { get; set; }
        public string clientName { get; set; }
        public int rushDays { get; set; }
        public int price { get; set; }
        public Desk desk { get; set; }

        public string calculatePrice(Desk desk, String material, Quote quote)
        {

            int basePrice = 200;
            desk.surface = desk.depth * desk.width;
            int drawersPrice = desk.drawwers * 50;
            int rushDays = this.rushDays;
            int extraSurfacePrice = 0;
            int rushDaysPrice = 0;
            int materialPrice = 0;

            if (desk.surface > 1000)
            {
                extraSurfacePrice = desk.surface - 1000;
            }


            switch (material)
            {
                case "Oak": materialPrice = (int)Desk.material.Oak; break;
                case "Laminate": materialPrice = (int)Desk.material.Laminate; break;
                case "Pine": materialPrice = (int)Desk.material.Pine; break;
                case "Rossewood": materialPrice = (int)Desk.material.Rossewood; break;
                case "Veneer": materialPrice = (int)Desk.material.Veneer; break;
                default: materialPrice = 0; break;
            }

            if (desk.surface > 0 && desk.surface < 1000)
            {
                switch (quote.rushDays)
                {
                    case 3: rushDaysPrice = 60; break;
                    case 5: rushDaysPrice = 40; break;
                    case 7: rushDaysPrice = 30; break;
                    default: rushDaysPrice = 0; break;
                }
            }
            else if (desk.surface >= 1000 && desk.surface <= 2000)
            {
                switch (quote.rushDays)
                {
                    case 3: rushDaysPrice = 70; break;
                    case 5: rushDaysPrice = 50; break;
                    case 7: rushDaysPrice = 35; break;
                    default: rushDaysPrice = 0; break;
                }
            }
            else
            {
                switch (quote.rushDays)
                {
                    case 3: rushDaysPrice = 80; break;
                    case 5: rushDaysPrice = 60; break;
                    case 7: rushDaysPrice = 40; break;
                    default: rushDaysPrice = 0; break;
                }
            }

            price = this.price =basePrice + extraSurfacePrice + drawersPrice + rushDaysPrice + materialPrice;
            return price.ToString();
        }
    }
}
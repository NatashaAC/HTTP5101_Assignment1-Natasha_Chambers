using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101_Assignment1_Natasha_Chambers.Controllers
{
    public class HostingCostController : ApiController
    {
        /*
         * Question 6 - Initiative  Question Objective:
         * Calculate the amount to charge a client for web hosting 
         * and maintenance based on rate of $5.50/FN (FN = 14 days) 
         * plus 13% HST
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public string Get(int id)
        {
            // Variables for rates, tax and total
            decimal fortnightRate = 5.50M;
            decimal chargeRate;
            decimal tax = 0.13M;
            decimal total;

            // Variables for messges
            string fortnightMssg = "";
            string taxMssg = "";
            string totalMssg = "";

            if (id < 14)
            {
                // Charge rate if has been less than 14 days
                chargeRate = fortnightRate * 1;
                tax = chargeRate * tax;
                total = chargeRate + tax;

                fortnightMssg = "1 fortnights at " + fortnightRate + "/FN = $" + chargeRate + " CAD";
                taxMssg = "HST 13% = $" + Math.Round(tax, 2) + " CAD";
                totalMssg = "Total = $" + Math.Round(total, 2) + " CAD";

            } else if (id >= 14 && id <= 21)
            {
                // Charge rate if has been 14 days or more, but less than 21 days or 21 days
                chargeRate = fortnightRate * 2;
                tax = chargeRate * tax;
                total = chargeRate + tax;

                fortnightMssg = "2 fortnights at " + fortnightRate + "/FN = $" + chargeRate + " CAD";
                taxMssg = "HST 13% = $" + Math.Round(tax, 2) + " CAD";
                totalMssg = "Total = $" + Math.Round(total, 2) + " CAD";

            } else if (id > 21 && id <= 28 )
            {
                // Charge rate if has been more than 21 days, but less than 28 days or 28 days
                chargeRate = fortnightRate * 3;
                tax = chargeRate * tax;
                total = chargeRate + tax;

                fortnightMssg = "3 fortnights at " + fortnightRate + "/FN = $" + chargeRate + " CAD";
                taxMssg = "HST 13% = $" + Math.Round(tax, 2) + " CAD";
                totalMssg = "Total = $" + Math.Round(total, 2) + " CAD";
            }

            return fortnightMssg + taxMssg + totalMssg;
        }
    }
}

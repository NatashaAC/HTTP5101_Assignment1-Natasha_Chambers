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
        /// This method with take and interger determine
        /// the amount to charge a client for web hosting 
        /// and maintenance based on rate of $5.50/FN(FN = 14 days)
        /// plus 13% HST
        /// </summary>
        /// <param name="id">input of an interger number</param>
        /// <returns>3 sentences that describe the fortnight rate, tax and total</returns>
        /// <example> 
        ///     GET api/HostingCost/0 - 
        ///     “1 fortnights at $5.50/FN = $5.50 CAD” 
        ///     “HST 13% = $0.72 CAD” 
        ///     “Total = $6.22 CAD” 
        /// </example>
        /// <example> 
        ///     GET api/HostingCost/14 - 
        ///     “2 fortnights at $5.50/FN = $11.00 CAD” 
        ///     “HST 13% = $1.43 CAD” 
        ///     “Total = $12.43 CAD” 
        /// </example>
        /// <example> 
        ///     GET api/HostingCost/28 - 
        ///     “3 fortnights at $5.50/FN = $16.50 CAD” 
        ///     “HST 13% = $2.14 CAD” 
        ///     “Total = $18.64 CAD” 
        /// </example>
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
                taxMssg = "HST 13% = $" + Math.Round(tax, 2).ToString() + " CAD";
                totalMssg = "Total = $" + Math.Round(total, 2).ToString() + " CAD";

            } else if (id >= 14 && id <= 21)
            {
                // Charge rate if has been 14 days or more, but less than 21 days or 21 days
                chargeRate = fortnightRate * 2;
                tax = chargeRate * tax;
                total = chargeRate + tax;

                fortnightMssg = "2 fortnights at " + fortnightRate + "/FN = $" + chargeRate + " CAD";
                taxMssg = "HST 13% = $" + Math.Round(tax, 2).ToString() + " CAD";
                totalMssg = "Total = $" + Math.Round(total, 2).ToString() + " CAD";

            } else if (id > 21 && id <= 28 )
            {
                // Charge rate if has been more than 21 days, but less than 28 days or 28 days
                chargeRate = fortnightRate * 3;
                tax = chargeRate * tax;
                total = chargeRate + tax;

                fortnightMssg = "3 fortnights at " + fortnightRate + "/FN = $" + chargeRate + " CAD";
                taxMssg = "HST 13% = $" + Math.Round(tax, 2).ToString() + " CAD";
                totalMssg = "Total = $" + Math.Round(total, 2).ToString() + " CAD";
            }

            return fortnightMssg + taxMssg + totalMssg;
        }

        /// <summary>
        /// This method with take and interger determine
        /// the amount to charge a client for web hosting 
        /// and maintenance based on rate of $5.50/FN(FN = 14 days)
        /// plus 13% HST
        /// </summary>
        /// <param name="days"> input of an interger number </param>
        /// <returns>3 sentences that describe the fortnight rate, tax and total</returns>
        /// <example> 
        ///     GET api/HostingCost/cost/0 - 
        ///     “1 fortnights at $5.50/FN = $5.50 CAD” 
        ///     “HST 13% = $0.72 CAD” 
        ///     “Total = $6.22 CAD” 
        /// </example>
        /// <example> 
        ///     GET api/HostingCost/cost/14 - 
        ///     “2 fortnights at $5.50/FN = $11.00 CAD” 
        ///     “HST 13% = $1.43 CAD” 
        ///     “Total = $12.43 CAD” 
        /// </example>
        /// <example> 
        ///     GET api/HostingCost/Cost/28 - 
        ///     “3 fortnights at $5.50/FN = $16.50 CAD” 
        ///     “HST 13% = $2.14 CAD” 
        ///     “Total = $18.64 CAD” 
        /// </example>
        [HttpGet]
        [Route("api/hostingcost/cost/{days}")]
        public string Cost(int days)
        {
            // Variables for rates, tax and total
            decimal fortnightRate = 5.50M;
            decimal chargeRate;
            decimal tax = 0.13M;
            decimal total;

            // Variables for messges
            string fortnightMssg;
            string taxMssg;
            string totalMssg;

            decimal fortnight = (decimal)days / 14;
            fortnight = Math.Ceiling(fortnight);
            chargeRate = fortnightRate * fortnight;
            total = chargeRate + tax;
            tax = chargeRate * tax;

            fortnightMssg = "1 fortnights at " + fortnightRate + "/FN = $" + chargeRate + " CAD";
            taxMssg = "HST 13% = $" + Math.Round(tax, 2).ToString() + " CAD";
            totalMssg = "Total = $" + Math.Round(total, 2).ToString() + " CAD";


            return fortnightMssg + taxMssg + totalMssg;
        }
    }
}

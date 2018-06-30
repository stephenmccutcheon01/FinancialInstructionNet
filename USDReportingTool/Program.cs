using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using SharedObjects;
using USDReportingTool.Properties;

namespace USDReportingTool
{
    /// <summary>
    ///     Console App for reporting on the instructions sent to the API
    /// </summary>
    /// <remarks>
    ///     Date:   30/06/2018
    ///     Author: Stephen McCutcheon
    /// </remarks>
    internal class Program
    {
        /// <summary>
        ///     The Initial Point where the program starts, The main menu
        /// </summary>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private static void Main()
        {
            ConsoleKeyInfo selectedKey;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to USD Reporting Tool.");
                Console.WriteLine("==============================");
                Console.WriteLine("");

                Console.WriteLine("     1. Amount in USD settled incoming everyday");
                Console.WriteLine("     2. Amount in USD settled outgoing everyday");
                Console.WriteLine("     3. Rankings of entities based on incoming and outgoing amount");
                Console.WriteLine("     4. Get All Data");
                Console.WriteLine("     5. Exit");
                Console.WriteLine("");
                Console.WriteLine("Please select a report (1,2,3,4 or 5)?");
                selectedKey = Console.ReadKey();
                switch (selectedKey.KeyChar)
                {
                    case '1':
                    {
                        GetUsdTotal(true);
                        break;
                    }
                    case '2':
                    {
                        GetUsdTotal(false);
                        break;
                    }
                    case '3':
                    {
                        GetRankings();
                        break;
                    }
                    case '4':
                    {
                        GetAllData();
                        break;
                    }
                    case '5':
                    {
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Error: Invalid key entry, please enter a number between 1 and 5.");
                        Console.WriteLine("===============================");
                        Console.WriteLine();
                        break;
                    }
                }

                if (selectedKey.KeyChar != '5' && selectedKey.KeyChar != '3')
                {
                    Console.WriteLine("Please press a key to return to main menu");
                    Console.ReadKey();
                }
            } while (selectedKey.KeyChar != '5');
        }


        /// <summary>
        ///     Get Rankings Main Menu
        /// </summary>
        /// <remarks>
        ///     Date:   30/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        private static void GetRankings()
        {
            ConsoleKeyInfo selectedKey;
            do
            {
                Console.Clear();
                Console.WriteLine("Rankings");
                Console.WriteLine("===============");
                Console.WriteLine();
                Console.WriteLine("     1. Incoming Rankings");
                Console.WriteLine("     2. Outgoing Rankings");
                Console.WriteLine("     3. Back to Main Menu");
                Console.WriteLine();
                Console.WriteLine("Please enter a choice?");
                selectedKey = Console.ReadKey();
                switch (selectedKey.KeyChar)
                {
                    case '1':
                    {
                        GetRankingsReport(true);
                        break;
                    }
                    case '2':
                    {
                        GetRankingsReport(false);
                        break;
                    }
                    case '3':
                    {
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Error: Invalid key entry, please enter a number between 1 and 3.");
                        Console.WriteLine("===============================");
                        Console.WriteLine();
                        break;
                    }
                }

                if (selectedKey.KeyChar != '3')
                {
                    Console.WriteLine("Please press a key to continue.");
                    Console.ReadKey();
                }
            } while (selectedKey.KeyChar != '3');
        }

        /// <summary>
        ///      Get the rankings report for either incoming or outgoing
        /// </summary>
        /// <param name="buy"></param>
        /// <remarks>
        ///    Author: Stephen McCutcheon
        ///    Date: 30/06/2018
        /// </remarks>
        private static void GetRankingsReport(bool buy)
        {
            Console.Clear();
            if (buy)
                Console.WriteLine("Incoming Rankings");
            else
                Console.WriteLine("Outgoing Rankings");

            Console.WriteLine("===========================");
            var apiServiceUrl = Settings.Default.APIAddress + "Rankings";
            using (var client = new WebClient())
            {
                client.QueryString.Add("Buy", buy.ToString());
                var dataString = client.DownloadString(apiServiceUrl);

                var data = JsonConvert.DeserializeObject<List<RankingInstruction>>(dataString);


                foreach (var x in data)
                {
                    Console.WriteLine("-------------------");
                    Console.Write("Rank: ");
                    Console.WriteLine(x.Ranking.ToString());
                    Console.WriteLine("-------------------");

                    Console.WriteLine(x.FinancialInstruction.ToString());
                }
            }
        }

        /// <summary>
        ///     Get the USD Total broken down by date and whether it's incoming or outgoing
        /// </summary>
        /// <param name="buy"></param>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        private static void GetUsdTotal(bool buy)
        {
            Console.Clear();
            if (buy)
                Console.WriteLine("USD Incoming");
            else
                Console.WriteLine("USD Outgoing");

            Console.WriteLine("==============");
            var apiServiceUrl = Settings.Default.APIAddress + "UsdTotals";
            using (var client = new WebClient())
            {
                client.QueryString.Add("Buy", buy.ToString());
                var dataString = client.DownloadString(apiServiceUrl);

                var data = JsonConvert.DeserializeObject<List<UsdTotal>>(dataString);


                foreach (var x in data) Console.WriteLine(x.ToString());
            }
        }

        /// <summary>
        ///      Gets all the data in the instruction db 
        /// </summary>
        /// <remarks>
        ///     Author: Stephen McCutcheon
        ///     Date: 30/06/2018
        /// </remarks>
        private static void GetAllData()
        {
            Console.Clear();
            Console.WriteLine("Get all Data");
            Console.WriteLine("==============");
            var apiServiceUrl =  Settings.Default.APIAddress + "Instruction";
            using (var client = new WebClient())
            {
                var dataString = client.DownloadString(apiServiceUrl);

                var data = JsonConvert.DeserializeObject<List<Instruction>>(dataString);

                foreach (var x in data) Console.WriteLine(x.ToString());
            }
        }
    }
}
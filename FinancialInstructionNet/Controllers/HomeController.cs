using System.Web.Mvc;

namespace FinancialInstructionNet.Controllers
{

    /// <summary>
    ///     Initial Landing Page
    /// </summary>
    /// <remarks>
    ///      Author: Stephen McCutcheon
    ///      Date: 30/06/2018
    /// </remarks>
    public class HomeController : Controller
    {
        #region public method

        /// <summary>
        ///    Landing Page
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        ///      Author: Stephen McCutcheon
        ///      Date: 30/06/2018
        /// </remarks>
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        #endregion public method
    }
}

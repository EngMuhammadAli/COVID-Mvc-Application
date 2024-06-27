using Covid_Mvc_Project.Models;
using Covid_Mvc_Project.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Covid_Mvc_Project.Controllers
{
    public class CovidController : Controller
    {
        private readonly CovidService _covidService;

        public CovidController()
        {
            _covidService = new CovidService();
        }

        // GET: Covid
        public ActionResult Index()
        {
            // Initialize with default values or load from previous selection
            var model = new CovidDataViewModel
            {
                Country = "Pakistan",
                SelectedDate = DateTime.Today
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> Index(CovidDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Call service to fetch data based on model.SelectedDate and model.Country
                var covidData = await _covidService.GetCovidDataAsync(model.Country);

                // Update model with fetched data
                model.Cases = covidData.Cases;
                model.TodayCases = covidData.TodayCases;
                model.Deaths = covidData.Deaths;
                model.TodayDeaths = covidData.TodayDeaths;
                model.Recovered = covidData.Recovered;
                model.Active = covidData.Active;
                model.Critical = covidData.Critical;
                model.CasesPerOneMillion = covidData.CasesPerOneMillion;
                model.DeathsPerOneMillion = covidData.DeathsPerOneMillion;
                model.Tests = covidData.Tests;
                model.TestsPerOneMillion = covidData.TestsPerOneMillion;
                model.Population = covidData.Population;

                return View(model);
            }

            // If model state is not valid, return to the view with validation errors
            return View(model);
        }

        // GET: CovidController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CovidController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CovidController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CovidController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CovidController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CovidController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CovidController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

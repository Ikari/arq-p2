using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NextLibRestFrontEndMVC.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace NextLibRestFrontEndMVC.Controllers
{
    public class RegraController : Controller
    {
        // GET: Regra
        public ActionResult Index()
        {
            List<RegraViewModel> regras = null;

            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:2379/api/");

                var responseTask = cliente.GetAsync("regras");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    regras = JsonConvert.DeserializeObject<List<RegraViewModel>>(readTask.Result);
                }
            }

            return View(regras);
        }

        // GET: Regra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Regra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regra/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Edit/5
        public ActionResult Edit(string id)
        {
            RegraViewModel regra = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:2379/api/");

                var responseTask = client.GetAsync("regras/" + id);
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    regra = JsonConvert.DeserializeObject<RegraViewModel>(readTask.Result);
                }
            }

            return View(regra);
        }

        // POST: Regra/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Regra/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
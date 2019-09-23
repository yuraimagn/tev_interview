using Interview.Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace Interview.Api.Controllers
{
    public class UserViewController : Controller
    {
        private string _baseUrl = ConfigurationManager.AppSettings["apiBaseAddress"];

        public ActionResult Index()
        {
            List<UserViewModel> users = new List<UserViewModel>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = client.GetAsync("api/User").GetAwaiter().GetResult();
                if(res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    users = JsonConvert.DeserializeObject <List<UserViewModel>>(response);
                }
            }
            return View(users);
        }

        public ActionResult Details(int id)
        {
            UserViewModel user = new UserViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = client.GetAsync("api/User/"+id).GetAwaiter().GetResult();
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    user = JsonConvert.DeserializeObject<UserViewModel>(response);
                }
            }

            return View(user);
        }

        // GET: UserView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserView/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserView/Edit/5
        public ActionResult Edit(int id)
        {
            UserViewModel user = new UserViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = client.GetAsync("api/User/" + id).GetAwaiter().GetResult();
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    user = JsonConvert.DeserializeObject<UserViewModel>(response);
                }
            }

            return View(user);
        }

        // POST: UserView/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserView/Delete/5
        public ActionResult Delete(int id)
        {
            UserViewModel user = new UserViewModel();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = client.GetAsync("api/User/" + id).GetAwaiter().GetResult();
                if (res.IsSuccessStatusCode)
                {
                    var response = res.Content.ReadAsStringAsync().Result;
                    user = JsonConvert.DeserializeObject<UserViewModel>(response);
                }
            }

            return View(user);
        }

        // POST: UserView/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

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

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UserViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(_baseUrl);

                        var response = client.PostAsJsonAsync("api/User", user).GetAwaiter().GetResult();
                        if (response.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Server error try after some time.");
                        }
                    }
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }

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

        [HttpPost]
        public ActionResult Edit(int id, UserViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(_baseUrl);
                        var response = client.PutAsJsonAsync("api/User/" + id, user).GetAwaiter().GetResult();
                        if (response.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Server error try after some time.");
                        }
                    }
                    return RedirectToAction("Index");
                }
                return View(user);
            }
            catch
            {
                return View();
            }
        }

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

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_baseUrl);

                    var response = client.DeleteAsync($"api/User/{id}").GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                        ModelState.AddModelError(string.Empty, "Server error try after some time.");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}

using DNC.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DNC.MVC.Controllers
{
    public class ToDoListController : Controller
    {
        Uri baseUrl = new Uri("https://localhost:44378/api/ToDoList");

        HttpClient client;

        private readonly ILogger _logger;

        private readonly IOptions<ConfigurationOfcolour> _conf;

        public int ListLimitCount { get; set; }

        public ToDoListController(ILogger<ToDoListController> logger, IOptions<ConfigurationOfcolour> conf)
        {
            _conf = conf;
            _logger = logger;
            client = new HttpClient();
            client.BaseAddress = baseUrl;
        }
        public IActionResult Index()
        {
            try
            {
                List<ToDoListModel> modelList = new List<ToDoListModel>();
                HttpResponseMessage res = client.GetAsync(client.BaseAddress + "/GetAllToDoList").Result;
                
                if (res.IsSuccessStatusCode)
                {
                    string data = res.Content.ReadAsStringAsync().Result;
                    modelList = JsonConvert.DeserializeObject<List<ToDoListModel>>(data);

                
                }


                return View(modelList);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View(new List<ToDoListModel>());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateOrEdit(ToDoListModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            try
            {
                if (model.ID == 0)
                {
                    HttpResponseMessage res = client.PostAsync(client.BaseAddress + "/AddList", content).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    return View();
                }
                else
                {
                    HttpResponseMessage res = client.PutAsync(client.BaseAddress + "/UpdateList", content).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                    return View("Create", model);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            try
            {

                ToDoListModel model = new ToDoListModel();
                HttpResponseMessage res = client.GetAsync(client.BaseAddress + "/GetListById/" + id).Result;
                if (res.IsSuccessStatusCode)
                {
                    string data = res.Content.ReadAsStringAsync().Result;
                    model = JsonConvert.DeserializeObject<ToDoListModel>(data);

                }
                return View("Create", model);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return View("Index");

            }
        }



        public ActionResult Delete(int id)
        {
            try
            {
                ToDoListModel model = new ToDoListModel();
                HttpResponseMessage res = client.DeleteAsync(client.BaseAddress + "/DeleteList/" + id).Result;
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");

                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);

                return RedirectToAction("Index");
            }
        }
    }
}


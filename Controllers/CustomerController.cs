using Domain.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            // 從Web API取得資料 
            //WebClient client = new WebClient();
            //client.Headers["Accept"] = "application/json";
            //string rvl = client.DownloadString(new Uri("http://localhost:7671/api/Customer"));
            //// 將Json字串轉成ViewModel
            //IList<CustomerViewModel> models = JsonConvert.DeserializeObject<IList<CustomerViewModel>>(rvl);
            //// 將ViewModel傳給View使用
            //return View(models);
            return View();
        }
        public ActionResult Index2()
        {
            // 從Web API取得資料 
            //WebClient client = new WebClient();
            //client.Headers["Accept"] = "application/json";
            //string rvl = client.DownloadString(new Uri("http://localhost:7671/api/Customer"));
            //// 將Json字串轉成ViewModel
            //IList<CustomerViewModel> models = JsonConvert.DeserializeObject<IList<CustomerViewModel>>(rvl);
            //// 將ViewModel傳給View使用
            //return View(models);
            return View();
        }
    }
}

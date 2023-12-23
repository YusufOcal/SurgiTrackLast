using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SurgiTrackUI.Models;
using System.Text;

namespace SurgiTrackUI.Controllers
{
    public class AnalAtreziController : Controller
    {
        public IActionResult AnalAtrezi()
        {
            return View();
        }
        public IActionResult AnalAtreziAdd()
        {
            var viewModel = new AmeliyatListViewModel
            {

                Ameliyatlar = GetAmeliyats()
              
            };

            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> AnalAtreziAdd(AmeliyatListViewModel ameliyatViewModel)
        {

            using var httpClient = new HttpClient();

            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(ameliyatViewModel.AnalAtrezis),
                Encoding.UTF8,
                "application/json"
            );
            await httpClient.PostAsync("https://localhost:7207/api/AnalAtrezi/AnalAtreziAdd", jsonContent);




            return View("AnalAtreziAdd", ameliyatViewModel);
        }
        private List<Ameliyat> GetAmeliyats()
        {
            using var httpClient = new HttpClient();

            var apiUrl = "https://localhost:7207/api/Ameliyat/GetAllAmeliyat";
            var response = httpClient.GetStringAsync(apiUrl).Result;
            var ameliyats = JsonConvert.DeserializeObject<List<Ameliyat>>(response);

            return ameliyats;
        }
        public async Task<IActionResult> AnalAtreziListesi()
        {
            using var httpClient = new HttpClient();


            var search = HttpContext.Request.Query["search"].ToString();


            var apiUrl = "https://localhost:7207/api/AnalAtrezi/GetAllAnalAtrezi";

            var response = await httpClient.GetStringAsync(apiUrl);


            var AnalAtreziListesi = JsonConvert.DeserializeObject<List<AnalAtreziController>>(response);



            return View(AnalAtreziListesi);
        }
        public async Task<IActionResult> TekilAnalAtrezi(int id)
        {
            using var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync($"https://localhost:7207/api/AnalAtrezi/GetByIdAnalAtrezi?id={id}");

            var AnalAtrezi = JsonConvert.DeserializeObject<AnalAtreziController>(response);

            return View(AnalAtrezi);
        }


        public async Task<IActionResult> Delete(int id)
        {
            using var httpClient = new HttpClient();


            var response = await httpClient.DeleteAsync($"https://localhost:7207/api/AnalAtrezi/AnalAtreziDeleteById?id={id}");


            if (response.IsSuccessStatusCode)
            {

                return RedirectToAction("AnalAtreziListesi");
            }
            else
            {

                var errorMessage = await response.Content.ReadAsStringAsync();
                ModelState.AddModelError(string.Empty, errorMessage);
                return RedirectToAction("AnalAtreziListesi");
            }


        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync($"https://localhost:7207/api/AnalAtrezi/GetByIdAnalAtrezi?id={id}");

            var AnalAtrezi = JsonConvert.DeserializeObject<AnalAtreziController>(response);

            return View("Edit", AnalAtrezi);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(AnalAtreziController AnalAtrezi)
        {
            using var httpClient = new HttpClient();

            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(AnalAtrezi),
                Encoding.UTF8,
                "application/json"
            );

            await httpClient.PutAsync($"https://localhost:7207/api/AnalAtrezi/AnalAtreziUpdate", jsonContent);
            return RedirectToAction("AnalAtreziListesi");
        }
        }
}

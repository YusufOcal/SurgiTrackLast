using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SurgiTrackUI.Models;
using System.Text;

namespace SurgiTrackUI.Controllers
{
    public class AntiRefluController : Controller
    {
        public IActionResult AntiReflu()
        {
            return View();
        }
        public IActionResult AntiRefluAdd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AntiRefluAdd(AntiReflu AntiReflu)
        {

            using var httpClient = new HttpClient();

            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(AntiReflu),
                Encoding.UTF8,
                "application/json"
            );
            await httpClient.PostAsync("https://localhost:7207/api/AntiReflu/AntiRefluAdd", jsonContent);




            return View();
        }
        public async Task<IActionResult> AntiRefluListesi()
        {
            using var httpClient = new HttpClient();


            var search = HttpContext.Request.Query["search"].ToString();


            var apiUrl = "https://localhost:7207/api/AntiReflu/GetAllAntiReflu";

            var response = await httpClient.GetStringAsync(apiUrl);


            var AntiRefluListesi = JsonConvert.DeserializeObject<List<AntiReflu>>(response);



            return View(AntiRefluListesi);
        }
        public async Task<IActionResult> TekilAntiReflu(int id)
        {
            using var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync($"https://localhost:7207/api/AntiReflu/GetByIdAntiReflu?id={id}");

            var AntiReflu = JsonConvert.DeserializeObject<AntiReflu>(response);

            return View(AntiReflu);
        }


        public async Task<IActionResult> Delete(int id)
        {
            using var httpClient = new HttpClient();


            var response = await httpClient.DeleteAsync($"https://localhost:7207/api/AntiReflu/AntiRefluDeleteById?id={id}");


            if (response.IsSuccessStatusCode)
            {

                return RedirectToAction("AntiRefluListesi");
            }
            else
            {

                var errorMessage = await response.Content.ReadAsStringAsync();
                ModelState.AddModelError(string.Empty, errorMessage);
                return RedirectToAction("AntiRefluListesi");
            }


        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            using var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync($"https://localhost:7207/api/AntiReflu/GetByIdAntiReflu?id={id}");

            var AntiReflu = JsonConvert.DeserializeObject<AntiReflu>(response);

            return View("Edit", AntiReflu);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(AntiReflu AntiReflu)
        {
            using var httpClient = new HttpClient();

            var jsonContent = new StringContent(
                JsonConvert.SerializeObject(AntiReflu),
                Encoding.UTF8,
                "application/json"
            );

            await httpClient.PutAsync($"https://localhost:7207/api/AntiReflu/AntiRefluUpdate", jsonContent);
            return RedirectToAction("AntiRefluListesi");
        }
    }
}
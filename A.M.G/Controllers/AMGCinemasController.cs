
using A.M.G.Data;
using A.M.G.Data.AMGServices;
using A.M.G.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace A.M.G.Controllers
{
    public class AMGCinemasController : Controller
    {

       
            private readonly ICinemasService _service;

            public AMGCinemasController(ICinemasService service)
            {
                _service = service;
            }

            
            public async Task<IActionResult> Index()
            {
                var allCinemas = await _service.GetAllAsync();
                return View(allCinemas);
            }


            //Get: Cinemas/Create
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Create([Bind("Logo,Name,Description")] AMGCinema cinema)
            {
                if (!ModelState.IsValid) return View(cinema);
                await _service.AddAsync(cinema);
                return RedirectToAction(nameof(Index));
            }

          
         
            public async Task<IActionResult> Details(int id)
            {
                var cinemaDetails = await _service.GetByIdAsync(id);
                if (cinemaDetails == null) return View("Not Found");
                return View(cinemaDetails);
            }

            public async Task<IActionResult> Edit(int id)
            {
                var cinemaDetails = await _service.GetByIdAsync(id);
                if (cinemaDetails == null) return View("Not Found");
                return View(cinemaDetails);
            }

            [HttpPost]
            public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] AMGCinema cinema)
            {
                if (!ModelState.IsValid) return View(cinema);
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }

            
            public async Task<IActionResult> Delete(int id)
            {
                var cinemaDetails = await _service.GetByIdAsync(id);
                if (cinemaDetails == null) return View("Not Found");
                return View(cinemaDetails);
            }

            [HttpPost, ActionName("Delete")]
            public async Task<IActionResult> DeleteConfirm(int id)
            {
                var cinemaDetails = await _service.GetByIdAsync(id);
                if (cinemaDetails == null) return View("Not Found");

                await _service.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
        
    }
    
}

﻿using FreshBooks.Data;
using FreshBooks.Data.Service;
using FreshBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreshBooks.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IBookService _service;

        public CatalogController(IBookService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Catalog()
        {
            var allBooks = await _service.GetAllAsync();
            return View(allBooks);
        }

        //Get: Books Detail

        public async Task<IActionResult> Details(int id)
        {
            var booksDetail = await _service.GetBookAsync(id);
            return View(booksDetail);
        }

        //Get: Catalog/Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Well to FreshBook";
            ViewBag.Description = "Sell Used Books here";
            return View();
        }


        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResult = allBooks.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Catalog", filterResult);
            }
            return View("Catalog", allBooks);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            await _service.AddNewBookAsync(book);
            return RedirectToAction(nameof(Catalog));
        }
    }
}

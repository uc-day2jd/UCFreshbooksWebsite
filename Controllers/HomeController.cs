﻿using FreshBooks.Data;
using FreshBooks.Data.Service;
using FreshBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FreshBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBookService _service;

        public HomeController(IBookService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Home()
        {
            // Get all books from the database
            var allBooks = await _service.GetAllAsync();

            // Shuffle the books using a random number generator
            var rng = new Random();
            var shuffledBooks = allBooks.OrderBy(b => rng.Next());

            // Take the first three books and return them to the view
            var firstThree = shuffledBooks.Take(3);
            return View(firstThree);
        }
        //Get: Books Detail

        public async Task<IActionResult> Details(int id)
        {
            var booksDetail = await _service.GetBookAsync(id);
            return View(booksDetail);
        }

        [HttpGet("SignUp")]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpGet("TOS")]
        public IActionResult TOS()
        {
            return View();
        }
        [HttpGet("PrivacyPolicy")]
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet("Request")]
        public IActionResult Request()
        {
            return View();
        }
        [HttpGet("SuccessSignUp")]
        public IActionResult SuccessSignUp()
        {
            return View();
        }
        [HttpGet("OrderForm")]
        public IActionResult OrderForm()
        {
            return View();
        }
        [HttpGet("About")]
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
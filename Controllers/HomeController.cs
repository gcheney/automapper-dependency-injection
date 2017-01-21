using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapperDI.Models;
using AutoMapperDI.ViewModels;
using AutoMapper;

namespace AutoMapperDI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var blobs = new List<Blob>()
            {
                new Blob { Id = 1, Content = "One"},
                new Blob { Id = 2, Content = "Two"},
                new Blob { Id = 3, Content = "Three"}
            };

            var viewModel = Mapper.Map<IEnumerable<BlobViewModel>>(blobs);
            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

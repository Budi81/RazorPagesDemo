using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Data;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages
{
    public class AdministrationPanelModel : PageModel
    {
        private readonly IRepository _repository;
        public List<Book> Books { get; set; }

        public AdministrationPanelModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {
            Books = new List<Book>();
        }

        public void OnClick()
        {
            Books = _repository.GetAllBooks();
        }
    }
}

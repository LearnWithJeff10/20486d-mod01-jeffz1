using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActorsRazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActorsRazorPages.Pages.Actors
{
    public class IndexModel : PageModel
    {
        public IList<Actor> Actors;

        private IData _data;

        public void OnGet(IData data)
        {
            _data = data;
            Actors = _data.ActorsInitializeData();
        }
    }
}
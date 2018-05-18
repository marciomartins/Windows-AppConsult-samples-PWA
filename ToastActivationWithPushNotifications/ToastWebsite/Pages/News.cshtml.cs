﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToastWebsite.Pages
{
    public class NewsModel : PageModel
    {
        public string NewsId { get; set; }

        public void OnGet(string newsId)
        {
            NewsId = newsId;
        }
    }
}
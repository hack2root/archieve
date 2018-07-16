﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MiddlewareExtensibilitySample.Data;
using MiddlewareExtensibilitySample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiddlewareExtensibilitySample.Pages
{
    public class IndexModel : PageModel
    {
        readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public List<Request> Requests { get; private set; }

        public async Task OnGetAsync()
        {
            Requests = await _db.Requests.ToListAsync();
        }
    }
}
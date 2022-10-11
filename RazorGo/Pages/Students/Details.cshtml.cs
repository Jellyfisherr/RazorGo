using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorGo.Data;
using RazorGo.Models;

namespace RazorGo.Pages.Students
{
    public class DetailsModel : PageModel
    {   //连接数据库的类schoolcontext
        private readonly SchoolContext _context;
        //依赖注入context
        public DetailsModel(SchoolContext context)
        {
            //初始化
            _context = context;
        }

      public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null ) //|| _context.Students == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            else 
            {
                Student = student;
            }
            return Page();
        }
    }
}

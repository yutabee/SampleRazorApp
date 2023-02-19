using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SampleRazorApp.Data;
using SampleRazorApp.Models;

namespace SampleRazorApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly SampleRazorApp.Data.SampleRazorAppContext _context;

        public CreateModel(SampleRazorApp.Data.SampleRazorAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        //Personインスタンスを生成し、フォームの値をプロパティにバインド
        [BindProperty]
        public Person Person { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
        　//バリデーションをかけて問題があった場合は現在のページを再表示する
          if (!ModelState.IsValid || _context.Person == null || Person == null)
            {
                return Page();
            }
            //Personのインスタンスをデータコンテキストに追加
            _context.Person.Add(Person);
            //非同期処理でデータコンテキストの内容をデータベースに反映
            await _context.SaveChangesAsync();
            //トップページにリダイレクトさせる
            return RedirectToPage("./Index");
        }
    }
}

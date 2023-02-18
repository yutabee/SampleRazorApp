using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SampleRazorApp.Pages
{
    public class OtherModel : PageModel
    {
        public string Message { get; set; }

        /*OnPostがPOSTメソッドを受け取った時の処理*/
        public void OnPost()
        {
            /*クライアントから送信されたフォームの「name="msg"」*/
            Message = "you typed: " + Request.Form["msg"];
        }
    }
}

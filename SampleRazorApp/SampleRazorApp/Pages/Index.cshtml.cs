// using System.ComponentModel.DataAnnotations;  追記する

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

public class IndexModel : PageModel
{
    public string Message = "no message.";
    /*データの型を指定*/
    /*フォームと関連付けされたプロパティは送信後もvalueに保持される*/
    [DataType(DataType.Text)]
    public string Name { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Mail { get; set; }

    [DataType(DataType.PhoneNumber)]
    public string Tel { get; set; }

    public void OnGet()
    {
        Message = "入力して下さい。";
    }

    /*設定したプロパティと同名の引数を設定すると受け取れる。（小文字でOK！！）*/
    public void OnPost(string name, string password, string mail, string tel)
    {
        Message = $"[Name: {name}, password:({password.Length}chars), mail:{mail}<{tel}>]";
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleRazorApp.Models;

namespace SampleRazorApp.Data
{
    //データコンテキスト：DbContextを継承している
    public class SampleRazorAppContext : DbContext
    {
        //コンストラクター:  DbContextOptionsでデータコンテキストのオプションを扱う
        public SampleRazorAppContext (DbContextOptions<SampleRazorAppContext> options)
            : base(options)
        {
        }
        //Personをジェネリクスとして指定したDbSetを作成
        //DbSetが実際にデータベースにアクセスする機能を提供する
        //このPersonプロパティに様々なメソッドが含まれている
        public DbSet<SampleRazorApp.Models.Person> Person { get; set; } = default!;
    }
}

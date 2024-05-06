using AlicanApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlicanApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>
       {
           new Ogrenci{Id=1,AdSoyad="murat kul"},
           new Ogrenci{Id=2,AdSoyad="ali can yücel"},
           new Ogrenci{Id=3,AdSoyad="mehmet karanfil"}
       };

        [HttpGet]
        public List<Ogrenci> Get()
        {
            return ogrenciler;

        }
        [HttpGet("{id}")] // idyi route yazmak için
        public Ogrenci Get(int id)
        {
            return ogrenciler.FirstOrDefault(o => o.Id == id);
        }
        [HttpPost]
        public Ogrenci Post(Ogrenci ogrenci)
        {
            ogrenciler.Add(ogrenci);
            return ogrenci;
        }
    }
}

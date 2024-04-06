using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        //! Anlık veriyi aldık ve kontrol ederek view sayfasına
        //! bir veri gönderiyoruz.
        //! Fakat bunun için model olduğunu belirtmemiz gerekiyor.
        //! Dolayısıyla bu işi bu şekilde
        //! yapmak yerine aşağıda gösterilecek şekilde de kullanabiliriz: 
        
        //? int time = DateTime.Now.Hour;
        //? var sayhi = time > 12 ? "Have a good day!" : "Good Morning";
        //? return View(model: sayhi);
        
        
        //! Bunun sayesinde üst tarafta bir daha diğer sayfaya
        //! veri göndermeyle uğraşmak yerine direkt burada oluşturduğumuz
        //! veriyi/değişkeni diğer sayfada direkt alıp kullanabiliyoruz.
        //! Ayrıca bir aktarmaya gerek yok.
        
        //? int time = DateTime.Now.Hour;
        //? ViewBag.sayhi = time > 12 ? "Have a good day!" : "Good Morning";
        //? ViewBag.UserName = " Anil";
        
        
        //! Ve bir diğer yol ViewData kullanmak. Bu da aynı işlevi görüyor fakat
        //! değişken tanımlamak gibi değil de key -> value ilişkisi var. İlgili
        //! kod bloğunda örneği bulabiliriz: 

        // int time = DateTime.Now.Hour;
        // ViewData["sayhi"]= time > 12 ? "Have a good day!" : "Good Morning";
        // ViewData["username"] = " Anil";

        // var meetingInfo = new MeetingInfo()
        // {
        //     MeetingId = 1,
        //     MeetingLocation = "Conference Room",
        //     MeetingDate = new DateTime(2024,01,22,20,0,0),
        //     MeetingNumberOfPeople = 10
        // };
        
        var meetingInfo = new MeetingInfo()
        {
            MeetingId = 1,
            MeetingLocation = "Conference Room",
            MeetingDate = new DateTime(2024, 01, 22, 20, 0, 0),
            MeetingNumberOfPeople = Repository.Users.Where(x=> x.WillAttend == true).Count()
            
        };
        return View(meetingInfo); 
    }
}
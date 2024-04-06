var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews(); // MVC Mimarisiyle çalışacağımızı belirttik.

var app = builder.Build();


// İlgili static dosyayı aktif etmemiz gerekiyor: 
app.UseStaticFiles();

// Routing işlemleri için kullanıyoruz. İşimizi garantiye alıyoruz
app.UseRouting();

// MVC 
// Rest API
// Razor Pages 

// Mimarilerini kullanarak istediğimiz gibi projeyi yönlendirebiliriz.

// Bu fonksiyon ile varsayılan {controller=Home}/{action=Home}/id? ayarlamış oluyoruz.
// app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
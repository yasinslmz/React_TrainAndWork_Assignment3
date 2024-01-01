using Microsoft.AspNetCore.Mvc;
using ProductManagementWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Billing> billings = new List<Billing>()
{
};


        public static List<Category> categories = new List<Category>()
        {
            new Category(){Id=1,Name="Comics Books",IsStatus=true,slug="com"},
            new Category(){Id=2,Name="Arts & Photography Books",IsStatus=true,slug="Arts"},
            new Category(){Id=3,Name="Business & Money Books",IsStatus=true,slug="Business"},
            new Category(){Id=4,Name="Children's Books",IsStatus=true,slug="Children"},
            new Category(){Id=5,Name="Travel Books",IsStatus=true,slug="Travel"},
            new Category(){Id=6,Name="Adventure Books",IsStatus=true,slug="Adventure"},
            new Category(){Id=7,Name="Science Fiction",IsStatus=true,slug="Science"},
            new Category(){Id=8,Name="Mystery & Thriller",IsStatus=true,slug="Mystery"},
            new Category(){Id=9,Name="Romance",IsStatus=true,slug="Romance"},
            new Category(){Id=10,Name="Fantasy",IsStatus=true,slug="Fantasy"},
            new Category(){Id=11,Name="Biography & Memoir",IsStatus=true,slug="Biography"},
            new Category(){Id=12,Name="Self-Help",IsStatus=true,slug="Self"},
            new Category(){Id=13,Name="Cooking",IsStatus=true,slug="Cooking"},
            new Category(){Id=14,Name="History",IsStatus=true,slug="History"},
            new Category(){Id=15,Name="Science",IsStatus=true,slug="Science"},
            new Category(){Id=16,Name="Health & Fitness",IsStatus=true,slug="Health"},
            new Category(){Id=17,Name="Humor",IsStatus=true,slug="Humor"},
            new Category(){Id=18,Name="Poetry",IsStatus=true,slug="Poetry"}

        };
        public static List<Product> products = new List<Product>()
    {
        new Product() { Id = 1, Name = "Kitap 1", Price = 20, Stock = 50, CategoryId = 1, IsStatus = true, Author = "Yazar 1", PageCount = 200, Language = "Türkçe",imagePath="https://cdn.kobo.com/book-images/00284104-af1d-45d4-88f5-2a96bfb462d9/353/569/90/False/history-of-comic-books.jpg",count=0 },
        new Product() { Id = 2, Name = "Kitap 2", Price = 25, Stock = 75, CategoryId = 1, IsStatus = true, Author = "Yazar 2", PageCount = 300, Language = "İngilizce",imagePath="https://cdn.kobo.com/book-images/00284104-af1d-45d4-88f5-2a96bfb462d9/353/569/90/False/history-of-comic-books.jpg",count=0 },
        new Product() { Id = 3, Name = "Kitap 3", Price = 18, Stock = 60, CategoryId = 2, IsStatus = true, Author = "Yazar 3", PageCount = 250, Language = "Fransızca",imagePath="https://img.buzzfeed.com/buzzfeed-static/static/2019-11/26/20/asset/0aa9a3ffe2c4/sub-buzz-145-1574801381-7.jpg",count=0 },
        new Product() { Id = 4, Name = "Kitap 4", Price = 22, Stock = 80, CategoryId = 2, IsStatus = true, Author = "Yazar 4", PageCount = 280, Language = "Almanca",imagePath="https://img.buzzfeed.com/buzzfeed-static/static/2019-11/26/20/asset/0aa9a3ffe2c4/sub-buzz-145-1574801381-7.jpg" ,count=0},
        new Product() { Id = 5, Name = "Kitap 5", Price = 30, Stock = 90, CategoryId = 3, IsStatus = true, Author = "Yazar 5", PageCount = 320, Language = "İspanyolca",imagePath="https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/61A11ABubdL._AC_UF1000,1000_QL80_.jpg",count=0 },
        new Product() { Id = 6, Name = "Kitap 6", Price = 28, Stock = 70, CategoryId = 3, IsStatus = true, Author = "Yazar 6", PageCount = 270, Language = "Rusça",imagePath="https://m.media-amazon.com/images/W/MEDIAX_792452-T2/images/I/61A11ABubdL._AC_UF1000,1000_QL80_.jpg" ,count=0},
        new Product() { Id = 7, Name = "Kitap 7", Price = 35, Stock = 100, CategoryId = 4, IsStatus = true, Author = "Yazar 7", PageCount = 340, Language = "Çince",imagePath="https://www.foodandwine.com/thmb/mX740zW664DTgICsSniIjrrpuXc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/children-books-about-food-give-a-mouse-a-cookie-FT-BLOG1017-4befa6c4a886416e97f4427ccb6801a8.jpg" ,count=0},
        new Product() { Id = 8, Name = "Kitap 8", Price = 40, Stock = 120, CategoryId = 4, IsStatus = true, Author = "Yazar 8", PageCount = 380, Language = "Japonca",imagePath="https://www.foodandwine.com/thmb/mX740zW664DTgICsSniIjrrpuXc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/children-books-about-food-give-a-mouse-a-cookie-FT-BLOG1017-4befa6c4a886416e97f4427ccb6801a8.jpg",count=0 },
        new Product() { Id = 9, Name = "Kitap 9", Price = 19, Stock = 55, CategoryId = 2, IsStatus = true, Author = "Yazar 9", PageCount = 210, Language = "Korece" ,imagePath="https://img.buzzfeed.com/buzzfeed-static/static/2019-11/26/20/asset/0aa9a3ffe2c4/sub-buzz-145-1574801381-7.jpg",count=0},
        new Product() { Id = 10, Name = "Kitap 10", Price = 23, Stock = 85, CategoryId = 5, IsStatus = true, Author = "Yazar 10", PageCount = 290, Language = "Hintçe" ,imagePath="https://images.squarespace-cdn.com/content/v1/57483e0df699bbec3bf5f6ef/1613467917786-RW4ZZ85DLKQ1QBGLNJRR/best-outdoor-adventure-books.jpg",count=0},
        new Product() { Id = 11, Name = "Kitap 11", Price = 26, Stock = 65, CategoryId = 6, IsStatus = true, Author = "Yazar 11", PageCount = 310, Language = "Portekizce",imagePath="https://m.media-amazon.com/images/I/81xWLgbAUzS._AC_UF1000,1000_QL80_.jpg" ,count=0},
        new Product() { Id = 12, Name = "Kitap 12", Price = 32, Stock = 95, CategoryId = 12, IsStatus = true, Author = "Yazar 12", PageCount = 360, Language = "Italyanca",imagePath="https://cdn.kobo.com/book-images/0e809b81-0b4b-4ed5-814f-80d56b3e6203/1200/1200/False/how-to-help-yourself-with-self-help.jpg",count=0 },
        new Product() { Id = 13, Name = "Kitap 13", Price = 38, Stock = 110, CategoryId = 16, IsStatus = true, Author = "Yazar 13", PageCount = 400, Language = "Arapça",imagePath="https://mindbodygreen-res.cloudinary.com/image/upload/c_pad,w_480,q_auto,f_auto,fl_lossy/org/o477dwu3wkjd8fho1.png" ,count=0},
        new Product() { Id = 14, Name = "Kitap 14", Price = 17, Stock = 45, CategoryId = 4, IsStatus = true, Author = "Yazar 14", PageCount = 180, Language = "İbranice",imagePath="https://www.foodandwine.com/thmb/mX740zW664DTgICsSniIjrrpuXc=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/children-books-about-food-give-a-mouse-a-cookie-FT-BLOG1017-4befa6c4a886416e97f4427ccb6801a8.jpg",count=0 },
        new Product() { Id = 15, Name = "Kitap 15", Price = 21, Stock = 105, CategoryId = 11, IsStatus = true, Author = "Yazar 15", PageCount = 250, Language = "Farsça" ,imagePath="https://m.media-amazon.com/images/I/712BNZEce0L._AC_UF1000,1000_QL80_.jpg",count=0},
        new Product() { Id = 16, Name = "Kitap 16", Price = 27, Stock = 75, CategoryId = 11, IsStatus = true, Author = "Yazar 16", PageCount = 320, Language = "Hollandaca",imagePath="https://m.media-amazon.com/images/I/71WMdG33VgL._AC_UF894,1000_QL80_.jpg",count=0 },
        new Product() { Id = 17, Name = "Kitap 17", Price = 33, Stock = 80, CategoryId = 12, IsStatus = true, Author = "Yazar 17", PageCount = 380, Language = "İsveççe" ,imagePath="https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1679659097-410sd2-izcL._SL500_.jpg?crop=1xw:1xh;center,top&resize=980:*",count=0},
        new Product() { Id = 18, Name = "Kitap 18", Price = 36, Stock = 100, CategoryId = 2, IsStatus = true, Author = "Yazar 18", PageCount = 420, Language = "Norveççe",imagePath="https://img.buzzfeed.com/buzzfeed-static/static/2019-11/26/20/asset/0aa9a3ffe2c4/sub-buzz-145-1574801381-7.jpg" ,count=0},
        new Product() { Id = 19, Name = "Kitap 19", Price = 42, Stock = 120, CategoryId = 1, IsStatus = true, Author = "Yazar 19", PageCount = 450, Language = "Yunanca" ,imagePath="https://cdn.kobo.com/book-images/00284104-af1d-45d4-88f5-2a96bfb462d9/353/569/90/False/history-of-comic-books.jpg",count=0},
        new Product() { Id = 20, Name = "Kitap 20", Price = 30, Stock = 90, CategoryId = 2, IsStatus = true, Author = "Yazar 20", PageCount = 400, Language = "Polonyaca",imagePath="https://img.buzzfeed.com/buzzfeed-static/static/2019-11/26/20/asset/0aa9a3ffe2c4/sub-buzz-145-1574801381-7.jpg" ,count=0},
       
    };

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            foreach (var product in products)
            {
                // Kitap isminden benzersiz bir slug oluştur
                var slug = GenerateSlug(product.Name);

                // Slug'ı ürünün özelliklerine ekle
                product.Slug = slug;
            }



            return products;
        }

        [HttpGet("Billing")]
        public List<Billing> Billing()
        {
            var bills = billings.ToList();
            var user = LoginController.users.Find(u => u.Id == 1);

            if (user != null)
            {
                // Kullanıcının billIds özelliğini kontrol et ve null değilse yeni bir fatura ID ekleyin
                if (user.billIds == null)
                {
                    user.billIds = new List<int>();
                }

                user.billIds.Add(1);

                return bills;
            }
            else
            {
                return bills; 
            }
        }
        [HttpPost("Checkout")]
        public IActionResult Checkout([FromBody] Billing value)
        {
            if (value == null)
            {
                // Gelen Billing null ise, BadRequest dönebilirsiniz.
                return BadRequest("Invalid Billing data");
            }

            var bills = billings.ToList();

            // Yeni bir Billing ekleyelim
            bills.Add(value);

            // Güncellenmiş billing listesini kaydedelim
            billings = bills;

            // Başarıyla eklendiği bildirilsin
            return Ok(billings);
        }

        // Kitap isminden benzersiz bir slug oluştur
        private static string GenerateSlug(string title)
        {
            var slug = title.ToLower().Replace(" ", "-");

            // Slug'ı benzersiz kıl
            var count = 1;
            while (products.Any(p => p.Slug == slug))
            {
                slug = $"{title.ToLower().Replace(" ", "-")}-{count}";
                count++;
            }

            return slug;
        }
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int? id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                return product;

            }

            return null;


        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] Product value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            int maxId = products.Max(p => p.Id);
            value.Id = maxId + 1;
            products.Add(value);

            return Ok();
        }


        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product value)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = value.Name;
            product.Price = value.Price;
            product.Stock = value.Stock;
            product.CategoryId = value.CategoryId;
            product.IsStatus = value.IsStatus;

            return Ok();
        }


        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            products.Remove(product);
            return Ok();
        }

    }
}

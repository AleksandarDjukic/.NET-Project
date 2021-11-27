using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

public class GPU
{
    public int id;
    public string naziv;
    public double cena;
    public string slika;
    public string opis;

    public GPU(string _naziv, double _cena, string _slika, int _id, string _opis)
    {
        id = _id;
        naziv = _naziv;
        cena = _cena;
        slika = _slika;
        opis = _opis;
    }
}

public class HomeController : Controller
{
    public GPU[] ponuda = {
                new GPU("AMD RX 5700XT", 599,
                    "https://www.amd.com/system/files/2019-06/237107-rx5700xt-gpu-gallery2-1260x709.png", 0,"Radeon RX 5700 XT features PCI Express 4.0 support, with a throughput of 16 GT/s and enables two times the bandwidth compared to PCI Express 3.0. Get ready for the next generation of PC gaming."),
                new GPU("NVidia RTX 3080", 1000,
                    "https://bestconsumerrating.com/wp-content/uploads/2020/10/Nvidia-GeForce-RTX-3080-Founders-Edition-Review.jpg",1,"The GeForce RTX™ 3080 delivers the ultra " +
                    "performance that gamers crave, powered by Ampere—NVIDIA’s 2nd gen RTX architecture. It’s built with enhanced RT Cores and Tensor Cores, new streaming " +
                    "multiprocessors, and superfast G6X memory for an amazing gaming experience." ),
                new GPU("Nvidia RTX 2080 Ti", 800,
                    "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6291/6291646_sd.jpg",2,"The NVIDIA® GeForce® RTX 2080 Ti graphics card is built for gaming realism and performance. Its powerful NVIDIA Turing™ GPU architecture, breakthrough technologies, and 11 GB of next-gen, ultra-fast GDDR6 memory make it an ultimate gaming GPU."),
                new GPU("AMD RX 5500 XT", 199,
                    "https://static.bhphoto.com/images/images2500x2500/1576140372_1527977.jpg",3,"Next Level 1080p Gaming Ultra-responsive, high fidelity AAA gaming with up to 60FPS and esports gaming with up to 90FPS"),
                new GPU("Nvidia GTX 1080 Ti", 299,
                    "https://c1.neweggimages.com/ProductImage/14-126-185-S99.jpg",4,"The GeForce ® GTX 1080 Ti is NVIDIA's new flagship gaming GPU, based on the NVIDIA Pascal architecture. The latest addition to the ultimate gaming platform, this card is packed with extreme gaming horsepower, next-gen 11 Gbps GDDR5X memory."),
                new GPU("Nvidia GTX 1050 Ti", 129,
                    "https://img.gigatron.rs/img/products/large/image583e98a1e4499.png",5,"Everyone deserves great gaming. That's why we created the fast, powerful GeForce GTX 1050. Now, you can turn your PC into a true gaming rig, powered by NVIDIA Pascal™ the most advanced gaming GPU architecture ever created.")
    };
    public ActionResult Index()
    {
        ViewBag.ponuda = ponuda;

        return View();
    }
    public ActionResult About()
    {
        ViewBag.oNama = "Welcome to GPU Store, your number one source for all things . We're dedicated to giving you the very best of graphics card, with a focus on quality..Founded in 2021 byNjegos Djukic, GPU has come a long way from its beginnings in Zvornik.When Njegos first started out, his passion for drove them to do tons of research so that GPU can offer you becomne the world's most advanced gpus. We now serve customers all over country, and are thrilled that were able to turn our passion into myown website. We hope you enjoy our products as much as we enjoy offering them to you.If you have any questions or comments, please dont hesitate to contact us .Sincerely, GPU Store";
        return View();
    }
    public ActionResult Contact()
    {
        ViewBag.Poruka = "Contact us";

        return View();
    }
    public ActionResult Partners()
    {
        ViewBag.Message = "Partners";

        return View();
    }
    public ActionResult Product(int id)
    {
        ViewBag.GPU = ponuda[id];
        return View();
    }
}

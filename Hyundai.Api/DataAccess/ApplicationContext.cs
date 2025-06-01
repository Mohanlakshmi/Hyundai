using Hyundai.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Hyundai.Api.DataAccess
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Product> Products {  get; set; }
        
        public ApplicationContext(DbContextOptions options): base(options) {
            LoadProducts();
        }
        public void LoadProducts()
        {
             


            Product product = new Product()
            {
                id = 111,
                title = "John Legend Live",
                description = "Come and join one of the world\'s most beloved artists as he performs live and just for you from MelodyVR’s studio in LA.",
                artist = "John Legend",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_FDC_L0103_App_Hero-1607341456001.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_FDC_L0103_App_Square-1607341456001.jpg",
                accentColor = "#f52459",
                backgroundColor= "#841225",
                textColor = "#ffffff",
                feature_order = "4",
                 price = "12.99"
            };
            Products.Add(product);

            product = new Product()
            {
                id = 114,
                title = "Fontaines D.C. in London",
                description = "Live show from Brixton Academy.",
                artist = "Fontaines D.C.",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_JOL_L0022_App_Hero-1589529179871.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_JOL_L0022_App_Square-1589535273302.jpg",
                accentColor = "#8a8989",
                backgroundColor = "#424242",
                textColor = "#FFCCCC",
                feature_order = "3",
                price = "12.99"
            };
            Products.Add(product);

            product = new Product()
            {
                id = 115,
                title = "Lady Leshurr",
                description = "Get ready for royalty. The impossibly skilled artist behind the iconic \'Queens Speech\' freestyles shows us how she became a viral phenomenon, with a flawless display of personality-filled, inventive rap.", 
                artist = "John Legend",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_LAL_P0299_App_Hero-1595603595282.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_LAL_P0299_App_Square-1595603595282.jpg",
                accentColor = "#e31718",
                backgroundColor = "#1f0809",
                textColor = "#ffffff",
                feature_order = "8",
                price = "12.99"
            };
            Products.Add(product);

            product = new Product()
            {
                id = 118,
                title = "Lady Leshurr",
                description = "Get ready for royalty. The impossibly skilled artist behind the iconic \'Queens Speech\' freestyles shows us how she became a viral phenomenon, with a flawless display of personality-filled, inventive rap.",
                artist = "John Legend",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_LAL_P0299_App_Hero-1595603595282.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_LAL_P0299_App_Square-1595603595282.jpg",
                accentColor = "#e31718",
                backgroundColor = "#1f0809",
                textColor = "#ffffff",
                feature_order = "8",
                price = "12.99"
            };
            Products.Add(product);

            product = new Product()
            {
                id = 121,
                title = "Ramz",
                description = "Come and join one of the world\'s most beloved artists as he performs live and just for you from MelodyVR’s studio in LA.",
                artist = "Ramz",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_RAM_P0295_App_Hero__01-1595262686134.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_RAM_P0295_App_Square-1595263538889.jpg",
                accentColor = "#f52459",
                backgroundColor = "#0d0a10",
                textColor = "#ffffff",
                feature_order = "1",
                price = "12.99"
            };
            Products.Add(product);
            product = new Product()
            {
                id = 125,
                title = "Machine Gun Kelly",
                description = "Live from LA.",
                artist = "Machine Gun Kelly",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_MGK_P0252_App_Hero-1588081917889.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_MGK_P0252_App_Square-1588081917889.jpg",
                accentColor = "#ef3f3a",
                backgroundColor = "#131a1d",
                textColor = "#ffffff",
                feature_order = "4",
                price = "12.99"
            };
            Products.Add(product);
            product = new Product()
            {
                id = 999,
                title = "Ashok",
                description = "Come and join one of the world\'s most beloved artists as he performs live and just for you from MelodyVR’s studio in LA.",
                artist = "Ramz",
                isFree = false,
                image1 = "https://d17jafawxl91z1.cloudfront.net/MVR_RAM_P0295_App_Hero__01-1595262686134.jpg",
                image2 = "https://d17jafawxl91z1.cloudfront.net/MVR_RAM_P0295_App_Square-1595263538889.jpg",
                accentColor = "#f52459",
                backgroundColor = "#0d0a10",
                textColor = "#ffffff",
                feature_order = "1",
                price = "12.99"
            };
            Products.Add(product);


        }

        public List<Product> GetProducts()
        {
            return Products.Local.ToList<Product>();
        }

    }
}

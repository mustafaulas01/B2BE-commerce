using DOGOB2B.ENTITY.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.DATAACCESS.Concrete.Entity_Framework.Context
{
    public class DogoB2BContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=DogoB2B;Integrated Security=true");
        }
      
          
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Product
            modelBuilder.Entity<Product>().HasData(
        
                new Product()
                {
                    Id = 1,
                    ItemCode = "dgs018-box064",
                    ItemDim1Code = 39,
                    ItemName = "Women Vegan Leather Gray Ankle Boots - Lost Design",
                    Gender = "Women",
                    MainProductGroup = "Shoes",
                    BottomProductGroup = "Boots",
                    ProductModel = "Boxford",
                    Barcode = "8680544164738",
                    PicturePath = "https://www.dogostore.com/Data/K/D25/1473.jpg",
                    Stock = 14,
                    Price = 600
                },
                     new Product()
                     {
                         Id = 2,
                         ItemCode = "dgs020-myr022",
                         ItemDim1Code = 40,
                         ItemName = "Women Vegan Leather Beige Sneakers - Call me Hotdog Design",
                         Gender = "Women",
                         MainProductGroup = "Shoes",
                         BottomProductGroup = "Flat Shoes",
                         ProductModel = "Myra",
                         Barcode = "8680544215942",
                         PicturePath = "https://www.dogostore.com/Data/K/D11/7691.jpg",
                         Price = 650,
                         Stock = 20
                     },
                              new Product()
                              {
                                  Id = 3,
                                  ItemCode = "dgs014-lb008",
                                  ItemDim1Code = 38,
                                  ItemName = "Women Vegan Leather Green Long Boots - Koala Hug Design",
                                  Gender = "Women",
                                  MainProductGroup = "Shoes",
                                  BottomProductGroup = "Boots",
                                  ProductModel = "Long Boots",
                                  Barcode = "8680544077700",
                                  PicturePath = "https://www.dogostore.com/Data/K/D51/13035.jpg",
                                  Price = 750,
                                  Stock = 45
                              },
                                  new Product()
                                  {
                                      Id = 4,
                                      ItemCode = "dgs014-lb034",
                                      ItemDim1Code = 39,
                                      ItemName = "Women Vegan Leather Beige Long Boots - Catch Me Baby Design",
                                      Gender = "Women",
                                      MainProductGroup = "Shoes",
                                      BottomProductGroup = "Boots",
                                      ProductModel = "Long Boots",
                                      Barcode = "8680544086696",
                                      PicturePath = "https://www.dogostore.com/Data/K/D51/3181.jpg",
                                      Price = 750,
                                      Stock = 15
                                  },
                                      new Product()
                                      {
                                          Id = 5,
                                          ItemCode = "dgs014-sb017",
                                          ItemDim1Code = 38,
                                          ItemName = "Women Vegan Leather Beige Ankle Boots - Purple Blue And Blue Design",
                                          Gender = "Women",
                                          MainProductGroup = "Shoes",
                                          BottomProductGroup = "Boots",
                                          ProductModel = "Short Boots",
                                          Barcode = "8680544077021",
                                          PicturePath = "https://www.dogostore.com/Data/K/D21/1194.jpg",
                                          Price = 600,
                                          Stock = 23
                                      },
                                          new Product()
                                          {
                                              Id = 6,
                                              ItemCode = "dgs020-hzl025",
                                              ItemDim1Code = 40,
                                              ItemName = "Women Vegan Leather Blue Lace Up Sandals - Les Papillons Design",
                                              Gender = "Women",
                                              MainProductGroup = "Shoes",
                                              BottomProductGroup = "Sandals",
                                              ProductModel = "Hazel",
                                              Barcode = "8680544201259",
                                              PicturePath = "https://www.dogostore.com/Data/K/D75/5043.jpg",
                                              Price = 680,
                                              Stock = 11
                                          },
                                               new Product()
                                               {
                                                   Id = 7,
                                                   ItemCode = "dgs023-acem008",
                                                   ItemDim1Code = 42,
                                                   ItemName = "Men Vegan Leather White Sneakers - Equal Design",
                                                   Gender = "Men",
                                                   MainProductGroup = "Shoes",
                                                   BottomProductGroup = "Flat Shoes",
                                                   ProductModel = "Ace Sneakers Men",
                                                   Barcode = "8680544246588",
                                                   PicturePath = "https://www.dogostore.com/Data/K/D24/13763.jpg",
                                                   Price = 724,
                                                   Stock = 11
                                               },
                                                     new Product()
                                                     {
                                                         Id = 8,
                                                         ItemCode = "dgsnk023-028",
                                                         ItemDim1Code = 43,
                                                         ItemName = "Time Waits for No-one / Dogo Sneakers Men s Shoes",
                                                         Gender = "Men",
                                                         MainProductGroup = "Shoes",
                                                         BottomProductGroup = "Flat Shoes",
                                                         ProductModel = "Men Sneakers",
                                                         Barcode = "8680544247905",
                                                         PicturePath = "https://www.dogostore.com/Data/K/D24/14030.jpg",
                                                         Price = 730,
                                                         Stock = 31
                                                     },

                                                           new Product()
                                                           {
                                                               Id = 9,
                                                               ItemCode = "dgs023-acem009",
                                                               ItemDim1Code = 42,
                                                               ItemName = "Men Vegan Leather White Sneakers - Meet me Halfway Design",
                                                               Gender = "Men",
                                                               MainProductGroup = "Shoes",
                                                               BottomProductGroup = "Flat Shoes",
                                                               ProductModel = "Ace Sneakers Men",
                                                               Barcode = "8680544246632",
                                                               PicturePath = "https://www.dogostore.com/Data/K/D24/13770.jpg",
                                                               Price = 724,
                                                               Stock = 43
                                                           }


                );
            #endregion
            #region Category
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id=1,Name="Ayakkabı"},
                new Category() { Id = 2, Name = "Üst Giyim" },
                    new Category() { Id = 3, Name = "Aksesuar" }

                );
            #endregion

        

            modelBuilder.Entity<Product>().HasKey( x => x.Id );
            modelBuilder.Entity<Product>().Property(a=>a.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Product>().Property(a => a.Price).HasColumnType("Money");

            
            modelBuilder.Entity<Category>().HasKey( x => x.Id );
            modelBuilder.Entity<Category>().Property(a => a.Id).ValueGeneratedOnAdd();

           

            modelBuilder.Entity<ShoppingCardItem>().HasKey( x => x.Id );
            modelBuilder.Entity<ShoppingCardItem>().Property(a => a.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<ShoppingCardItem>().ToTable("ShoppingCardItems");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCardItem> ShoppingCardItems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FYP.Models
{
    public class MusicDataContext : DbContext
    {
        public IQueryable<Images> images
        {
            get
            {
                return new[]
                {
                    new Images{
                        Name = "Image 1",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 2",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 3",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 4",
                        ImageUrl = "../images/pic01.jpg",
                    },

                    new Images {
                        Name = "Image 5",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 6",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 7",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images{
                        Name = "Image 8",
                        ImageUrl = "../images/pic01.jpg",
                    },

                      new Images {
                        Name = "Image 5",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 6",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images {
                        Name = "Image 7",
                        ImageUrl = "../images/pic01.jpg",
                    },
                    new Images{
                        Name = "Image 8",
                        ImageUrl = "../images/pic01.jpg",
                    },

                }.AsQueryable();
            }
        }
        public MusicDataContext(DbContextOptions<MusicDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

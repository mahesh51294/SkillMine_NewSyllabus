using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine_NewSyllabus
{
    class BookStore
    {

        private string nameofBook;
        private string author;
        private double price, discountPrice;

        public BookStore(string nameofBook,string author,double price)
        {
            this.nameofBook = nameofBook;
            this.price = price;
            this.author = author;
          

        }

        public void discount()
        {
            discountPrice = price - (price * 10 / 100);
        }

        public override string ToString()
        {
            return $"{nameofBook}---{author}----{price}---{discountPrice}";
        }

        static void Main(string[]args)
        {
            BookStore obj = new BookStore("zyx","abc",500);

            obj.discount();
            Console.WriteLine(obj);
        }


    }

    class product
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public override string ToString()
        {
            return $"id {id} name{name} price{price}";
        }

        static void Main(string[]args)
        {
            List<product> l = new List<product>();
            l.Add(new product { id = 1, name = "bat", price = 2000 });
            l.Add(new product { id = 2, name = "ball", price = 200 });
            l.Add(new product { id = 3, name = "gloves", price = 500 });
            l.Add(new product { id = 4, name = "pad", price = 300 });
            l.Add(new product { id = 5, name = "shoes", price = 1000 });

            foreach(product p in l)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("price less than 1000");
            foreach(product p in l)
            {
                if (p.price < 1000)
                    Console.WriteLine(p);

                
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotDree1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<category> cl = new List<category>()
            {
                new category {catid=1, catName="jeans" },
                new category {catid=2, catName="tshirt" },
                new category {catid=3, catName="shorts" },
                new category {catid=4, catName="nightwear" }


            };
            foreach (category c1 in cl)
            {
                Console.WriteLine(c1.catid);
            }

            List<product> pl = new List<product>()
            {
                new product {proid=1,
                cli=new List<category>()
                { new category {catid=1, catName="jeans" },
                new category {catid=2, catName="tshirt" },
                new category {catid=3, catName="shorts" },
                new category {catid=4, catName="nightwear" }


                },
           /*        new product{proid=2,
                cli=new List<category>()
                { new category {catid=1, catName="jeans" },
                new category {catid=2, catName="tshirt" },
                new category {catid=3, catName="shorts" },
                new category {catid=4, catName="nightwear" }
                } }  */
               
        }
    };
        }
    }
} 

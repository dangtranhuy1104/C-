using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCsharp
{
    public class ProductManagement
    {
        public List<Product> ListProduct = null;


        public ProductManagement()
        {
            ListProduct = new List<Product>();
        }

        public int GenerateID()
        {
            int max = 1;
            if (ListProduct != null && ListProduct.Count > 0)
            {
                max = ListProduct[0].STT;
                foreach (Product pr in ListProduct)
                {
                    if (max < pr.STT)
                    {
                        max = pr.STT;
                    }
                }
                max++;
            }
            return max;
        }

        public int CountProduct()
        {
            int count = 0;
            if (ListProduct != null)
            {
                count = ListProduct.Count;
            }
            return count;
        }

        //Ham tim theo ma SP
        public Product FindByProductID(string id)
        {
            Product searchID = null;
            if (ListProduct != null && ListProduct.Count > 0)
            {
                foreach (Product pro in ListProduct)
                {
                    if (pro.ProductID == id)
                    {
                        searchID = pro;
                    }
                }
            }
            return searchID;
        }

        public void CreateProduct()
        {
            Product pr = new Product();
            pr.STT = GenerateID();

            Console.Write("Nhap ID san pham : ");
            pr.ProductID = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ten san pham : ");
            pr.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gia san pham: ");
            pr.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("   Ban co muon luu san pham nay (Y/N) : ");
            string save = Convert.ToString(Console.ReadLine());
            if (save == "Y" || save == "y" || save == "yes" || save == "YES")
            {
                Console.Clear();
                ListProduct.Add(pr);
                Console.WriteLine("Them san pham thanh cong !\n");
            }
            else if (save == "N" || save == "n" || save == "no" || save == "NO")
            {
                Console.Clear();
                Console.WriteLine(" San pham khong duoc luu lai !\n\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dung tao san pham!\n\n");
            }
        }

        //Ham xoa Product theo ID
        public bool DeleteByID(string id)
        {
            bool IsDeleted = false;
            Product prID = FindByProductID(id);
            if (prID != null)
            {
                IsDeleted = ListProduct.Remove(prID);
            }
            return IsDeleted;
        }

        // Ham hien thi danh sach Product
        public void ShowProduct(List<Product> products)
        {
            Console.WriteLine("{0,-5} | {1,-15} | {2,-15} | {3,-15}  |", "No.", "ID SP", "Ten SP", "Gia");

            if (products != null && products.Count > 0)
            {
                foreach (Product pr in products)
                {
                    Console.WriteLine("{0,-5} | {1,-15} | {2,-15} | ${3,-15} |", pr.STT, pr.ProductID, pr.Name, pr.Price);

                }
            }
            Console.WriteLine();
        }

        //Ham tra ve danh sach Product
        public List<Product> GetProducts()
        {
            return ListProduct;
        }

    }
}

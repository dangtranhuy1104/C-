using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCsharp
{
    class Program
    {
        ProductManagement prManagement = new ProductManagement();

        public static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }

        static void PressAnyKey()
        {
            Console.WriteLine("\n\t\tEnter any key to continue ... ");
            Console.ReadLine();
            Console.Clear();
        }

        public void Menu()
        {
            int key;
            string answer;
            while (true)
            {
                Console.WriteLine(" ------------- Menu -------------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Them san pham moi");
                Console.WriteLine("2. Hien thi danh sach san pham");
                Console.WriteLine("3. Xoa san pham theo ID ");
                Console.WriteLine("4. Exit");
                Console.WriteLine(" ====================================");
                try
                {
                    Console.Write(" Nhap lua chon cua ban : ");
                    key = Convert.ToInt32(Console.ReadLine());

                    switch (key)
                    {
                        case 1:
                            Console.WriteLine(" Them san pham \n");
                            prManagement.CreateProduct();
                            Console.Write("Ban co muon tiep tuc (Y/N) :");
                            answer = Convert.ToString(Console.ReadLine());
                            if (answer == "Y" || answer == "y")
                            {
                                Console.Clear();
                                goto case 1;
                            }
                            else if (answer == "N" || answer == "n")
                            {
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Lua chon cua ban khong hop len => Thoat!\n\n");
                            }
                            break;

                        case 2:
                            if (prManagement.CountProduct() > 0)
                            {
                                Console.WriteLine(" Hien thi danh sach san pham \n");
                                prManagement.ShowProduct(prManagement.GetProducts());
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(" Danh sach cua ban hien nay dang trong ! \n\n");
                            }
                            PressAnyKey();
                            break;

                        case 3:
                            if (prManagement.CountProduct() > 0)
                            {
                                string id;
                                Console.WriteLine(" Xoa san pham theo ID \n");
                                Console.Write("Nhap ID san pham : ");
                                id = Console.ReadLine();
                                if (prManagement.DeleteByID(id))
                                {
                                    Console.WriteLine("ID san pham = {0} da duoc xoa! \n\n", id);
                                }
                                else
                                {
                                    Console.WriteLine("San pham da bi xoa hoac khong ton tai trong danh sach\n\n");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Danh sach san pham trong !\n\n");
                            }
                            Console.Write("Ban co muon tiep uc (Y/N) :");
                            answer = Convert.ToString(Console.ReadLine());
                            if (answer == "Y" || answer == "y")
                            {
                                Console.Clear();
                                goto case 3;
                            }
                            else if (answer == "N" || answer == "n")
                            {
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Lua chon cua ban khong hop len => Thoat!\n\n");
                            }
                            break;

                        case 4:
                            Console.WriteLine(" \u263A \u263A \u263A Goodbye !! \u263A \u263A \u263A\n\n");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine(" Chuc nang khong hop le => Hay nhap lai!");
                            break;

                    }

                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine(" Loai du lieu ko hop le!!!");
                    Console.WriteLine("=> " + error.Message);
                }
            }
        }

    }
}

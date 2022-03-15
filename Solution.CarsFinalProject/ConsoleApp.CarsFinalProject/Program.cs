using ConsoleApp.CarsFinalProject.Infracture;
using ConsoleApp.CarsFinalProject.Managers;
using System;
using System.Linq;
using System.Text;

namespace ConsoleApp.CarsFinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Title = "CarSystem v1.1";

            var brandMgr = new BrandManager();
            var modelMgr = new ModelManager();
            var carMgr = new CarManager();

         readMenu:
             PrintMenu();

            Menu carsys = ScanerManager.ReadMenu("Menyudan seçin: ");

            switch (carsys)
            {
                case Menu.BrandAdd:
                    Console.Clear();
                    Brands b = new Brands();
                    b.BrandName = ScanerManager.ReadString("Brand Adini Daxil Edin: ");
                    brandMgr.Add(b);
                    goto case Menu.BrandAll;
                case Menu.BrandEdit:
                    Console.Clear();
                    ShowAllBrands(brandMgr);
                    int value = ScanerManager.ReadInteger("Secilmish Markanin Nº daxil edin: ");
                    brandMgr.EditName(value);
                    goto case Menu.BrandAll;
                case Menu.BrandRemove:
                    Console.Clear();
                    ShowAllBrands(brandMgr);
                    int value7 = ScanerManager.ReadInteger("Silmək isdədiyiniz Markanin Nº daxil edin: ");
                    Brands b1 = brandMgr.GetAll().FirstOrDefault(item => item.BrandId == value7);
                    brandMgr.RemoveBrand(b1);
                    goto case Menu.BrandAll;
                case Menu.BrandSingle:
                    Console.Clear();
                    ShowAllBrands(brandMgr);
                    int value6 = ScanerManager.ReadInteger("Secilmish Markanin Nº daxil edin: ");
                    brandMgr.SingleBrand(value6);
                    goto readMenu;
                case Menu.BrandAll:
                    Console.Clear();
                    ShowAllBrands(brandMgr);
                    goto readMenu;
                case Menu.ModelAdd:
                    Console.Clear();
                    Models m = new Models();
                    m.ModelName = ScanerManager.ReadString("Model Adini Daxil Edin:");
                    modelMgr.Add(m);
                    goto case Menu.ModelAll;
                case Menu.ModelEdit:
                    Console.Clear();
                    ShowAllModels(modelMgr);
                    Console.WriteLine("Model id deyishmek ucun => 1 | Model adini deyishmek ucun => 2");
                    bool success = int.TryParse(Console.ReadLine(), out int menuNumber);
                    if (success && menuNumber == 1)
                    {
                        int value2 = ScanerManager.ReadInteger("Secilmish Modelin Nº daxil edin: ");
                        modelMgr.EditModelBrand(value2);
                    }
                    if (success && menuNumber == 2)
                    {
                        int value2 = ScanerManager.ReadInteger("Secilmish Modelin Nº daxil edin: ");
                        modelMgr.EditName(value2);
                    }
                    goto case Menu.ModelAll;
                case Menu.ModelRemove:
                    Console.Clear();
                    ShowAllModels(modelMgr);
                    int value8 = ScanerManager.ReadInteger("Silmək isdədiyiniz Modelin Nº daxil edin: ");
                    Models m1 = modelMgr.GetAll().FirstOrDefault(item => item.ModelId == value8);
                    modelMgr.RemoveModel(m1);
                    goto case Menu.ModelAll;
                case Menu.ModelSingle:
                    Console.Clear();
                    ShowAllModels(modelMgr);
                    int value5 = ScanerManager.ReadInteger("Secilmish Modelin Nº daxil edin: ");
                    modelMgr.SingleModel(value5);
                    goto readMenu;
                case Menu.ModelAll:
                    Console.Clear();
                    ShowAllModels(modelMgr);
                    goto readMenu;
                case Menu.CarAdd:
                    Console.Clear();
                    Cars c = new Cars();
                    c.Year = ScanerManager.ReadDate("Avtomobil İlini Daxil Edin:");
                    c.Price = ScanerManager.ReadDouble("Avtomobil Qiymətini Daxil Edin:");
                    c.Color = ScanerManager.ReadString("Avtomobil Rəngili Daxil Edin:");
                    c.Engine = ScanerManager.ReadDouble("Avtomobil Mühərrikini Daxil Edin:");
                    carMgr.Add(c);
                    goto case Menu.CarAll;
                case Menu.CarEdit:
                    Console.Clear();
                    ShowAllCars(carMgr);
                    Console.WriteLine("Avtomobil Nº deyishmek ucun => 1 | Ilini deyishmek ucun => 2 | Qiyməti dəyişmək ucun => 3" +
                        "Rəngini dəyişmək üçün => 4 | Mühərrik həcmini dəyişmək üçün => 5");
                    bool s1 = int.TryParse(Console.ReadLine(), out int menuNums);
                    if (s1 && menuNums == 1)
                    {
                        int value3 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                        carMgr.EditCarModel(value3);
                    }
                    if (s1 && menuNums == 2)
                    {
                        int value3 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                        carMgr.EditYear(value3);
                    }
                    if (s1 && menuNums == 3)
                    {
                        int value3 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                        carMgr.EditPrice(value3);
                    }
                    if (s1 && menuNums == 4)
                    {
                        int value3 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                        carMgr.EditColor(value3);
                    }
                    if (s1 && menuNums == 5)
                    {
                        int value3 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                        carMgr.EditEngine(value3);
                    }
                    goto case Menu.CarAll;
                case Menu.CarRemove:
                    Console.Clear();
                    ShowAllCars(carMgr);
                    int value9 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                    Cars c1 = carMgr.GetAll().FirstOrDefault(item => item.CarId == value9);
                    carMgr.RemoveCar(c1);
                    goto case Menu.CarAll;
                case Menu.CarSingle:
                    Console.Clear();
                    ShowAllCars(carMgr);
                    int value4 = ScanerManager.ReadInteger("Secilmish Avtomobilin Nº daxil edin: ");
                    carMgr.SingleCar(value4);
                    goto readMenu;
                case Menu.CarAll:
                    Console.Clear();
                    ShowAllCars(carMgr);
                    goto readMenu;
                case Menu.All:
                    ShowAllBrands(brandMgr);
                    ShowAllModels(modelMgr);
                    ShowAllCars(carMgr);
                    goto readMenu;
                case Menu.Exit:
                    goto lEnd;
                default:
                    break;
            }
         lEnd:
            Console.WriteLine("END...");
            Console.WriteLine("Cixmaq Ucun Her Hansi Bir Duymeni Sixin");
            Console.ReadKey();
        }
        static void PrintMenu()
        {
            Console.WriteLine(new string('-', Console.WindowWidth));

            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Menu carsys = (Menu)Enum.Parse(typeof(Menu), item);
                Console.WriteLine($"{((byte)carsys).ToString().PadLeft(2)}. {item}");
            }
            Console.WriteLine($"{new string('-', Console.WindowWidth)}");
        }
        static void ShowAllBrands(BrandManager brandMgr)
        {
            Console.Clear();
            Console.WriteLine("**********Brands**********");
            foreach (var item in brandMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }
        static void ShowAllModels(ModelManager modelMgr)
        {
            Console.Clear();
            Console.WriteLine("**********Models**********");
            foreach (var item in modelMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }
        static void ShowAllCars(CarManager carMgr)
        {
            Console.Clear();
            Console.WriteLine("**********Cars**********");
            foreach (var item in carMgr.GetAll())
            {
                Console.WriteLine(item);
            }
        }

    }
}

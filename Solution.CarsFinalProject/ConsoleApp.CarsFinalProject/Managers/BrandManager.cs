using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CarsFinalProject.Managers
{
    public class BrandManager
    {
        Brands[] data = new Brands[0];
        public void Add(Brands entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }
        public void EditName(int value)
        {
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i].BrandId == value)
                {
                    Console.WriteLine("Marka adini dəyişin...! ");
                    string newName = ScanerManager.ReadString("Ad daxil edin...");
                    data[i].BrandName = data[i].BrandName.Replace(data[i].BrandName, newName);
                    break;
                }
            }
        }
        public void SingleBrand(int value)
        {
            string singleBrand = "";
            for(int i = 0; i < data.Length; i++)
            {
                if(data[i].BrandId == value)
                {
                    singleBrand = $"Marka Nº: {data[i].BrandId} | Marka Adi: {data[i].BrandName}";
                    break;
                }
            }
            Console.WriteLine(singleBrand);
        }
        public void RemoveBrand(Brands entity)
        {
            int index = Array.IndexOf(data, entity);
            if (index == -1)
            {
                return;
            }
            for (int i = index; i < data.Length - 1; i++)
            {
                data[i] = data[i + 1];
            }
            if (data.Length > 0)
            {
                Array.Resize(ref data, data.Length - 1);
            }
        }
        public Brands[] GetAll()
        {
            return data;
        }
    }
}

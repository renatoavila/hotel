using AppHotel.Domain.Entity;
using AppHotel.Repository;
using AppHotel.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel.Service.Processors
{
    public class ProcessorCategory
    {
        private IRepository<Category> _repository = new Repository<Category>();
        public List<Category> list = new List<Category>();

        public void InsertCategory(string name, decimal price)
        {
            Category ctgry = new Category(name,price);
            _repository.Insert(ctgry, list);

        }

        public string GetCategory()
        {
            StringBuilder str = new StringBuilder("");
            List<Category> listCategory = _repository.Get(list);
            foreach (var item in listCategory)
            {
                str.Append( $"A categoria '{item.Name}' com o valor de '{item.Price}' foi gravada com sucesso.");
                str.AppendLine();
            }
            return str.ToString();
        }
    }
}

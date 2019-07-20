using AppHotel.Domain.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace AppHotel.Repository.Test
{
    public class CategoryRepository_Test
    {
        [Fact]
        public void Test1()
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            Category category = new Category("Teste", 1000);

            categoryRepository.Create(category);

            List<Category> categories = categoryRepository.Get();

            category = new Category("Teste2", 2000);

            categoryRepository.Create(category);

            categories = categoryRepository.Get();

            QuartoRepository quartoRepository = new QuartoRepository();

            Quarto quarto = new Quarto("Teste", 1000, "Xandao", "Xandao 2");

            quartoRepository.Create(quarto);
            List<Quarto> quartoList = quartoRepository.Get();
        }
    }
}

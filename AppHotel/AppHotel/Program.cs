using AppHotel.Service.Processors;
using System;
using System.Text.RegularExpressions;

namespace AppHotel.Application
{
    class Program
    {
        //TODO: verificar lista de memoria
        public static ProcessorCategory category = new ProcessorCategory(); 
        static void Main(string[] args)
        {
            

            GetScreenInitial();
        }

        private static void GetScreenInitial()
        {
            var continuar = true;
            do
            {
                var itemMenu = GetMenuinitial();
                var pattern = "[14]";
                if (Regex.IsMatch(itemMenu, pattern))
                {
                    switch (itemMenu)
                    {
                        case "1":
                            GetScreenCategory();
                            break;
                        //case "2":
                        //    GetTelaSaque();
                        //    break;
                        //case "3":
                        //    GetTelaSaldo();
                        //    break;
                        //case "4":
                        //    Console.Clear();
                        //    continuar = false;
                        //    break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }

                }
                

               
            } while (continuar);
        }

        private static string  GetMenuinitial()
        {
            

            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("Aplicativo Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Cadastrar Categoria");
            //Console.WriteLine("2 - Saque");
            //Console.WriteLine("3 - Saldo detalhado");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();
            Console.Write("Selecione a opção: ");
            return Console.ReadLine();
        }

        private static void GetScreenCategory()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine(" Aplicação Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine("Cadastro de Categoria");
            Console.WriteLine();
            Console.Write("Informe nome da categoria: ");
            string OpcaoNome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Informe o preço: ");
            decimal opcaoPreco = Convert.ToDecimal(Console.ReadLine());

            category.InsertCategory(OpcaoNome, (decimal)opcaoPreco);

            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine(" Aplicação Hotel");
            Console.WriteLine("------------------------");
            Console.WriteLine("Cadastro de Categoria");
            Console.WriteLine();
            Console.WriteLine(category.GetCategory());
            Console.ReadKey();

           
        }
    }
}

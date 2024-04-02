// See https://aka.ms/new-console-template for more information
using System.Reflection;
using _240401_1.models;

Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.Name = "SemNocao";
c1.EmailAddress = "SemNocao@tamaluco.ney";

//Construtor por Instanciação
Customer c2 = new Customer(2);
c2.Name = "TensoMemo";
c2.EmailAddress = "TensoMemo@.com.commemo";

//Construtor por Atribuição
Customer c3 = new Customer{
    CustomerId = 3,
    Name = "Sapão",
    EmailAddress = "Sapão@Grotescao.memo"
};

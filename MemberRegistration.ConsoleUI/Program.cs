using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.DependencyResolvers.Ninject.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member
            {
                FirstName = "Hüseyin", LastName = "Aydın", DateOfBirth = new DateTime(1994,09,11), TCNO = "33938131416", Email = "huseyinaydin99@gmail.com"
            });
            Console.WriteLine("Yeni üye kaydı yapıldı. Kara ambar kamyuncular derneği.");
            Console.ReadKey();
        }
    }
}

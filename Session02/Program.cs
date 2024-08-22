using Session02.Context;
using Session02.Model;
using Microsoft.EntityFrameworkCore;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext context = new CompanyDbContext();

            #region Create : insert
            //Employee emp1 = new Employee() {  Name = "nada", Age = 30, Salary = 10000 };
            //Employee emp2 = new Employee() {  Name = "ahmed", Age = 20, Salary = 10000 };


            ////using (CompanyDbContext context = new CompanyDbContext()) // DBconnection
            ////{
            ////    //logic
            ////}

            ////using Definition => c# 8.0 featurs

            //using CompanyDbContext context = new CompanyDbContext(); //DBconnection
            //Console.WriteLine(context.Entry(emp1).State);
            //Console.WriteLine(context.Entry(emp2).State);

            //context.Employees.Add(emp1); //==> change entity to added  
            //context.Employees.Add(emp2); //==> change entity to added  

            ////context.Add(emp1);
            ////context.Set<Employee>().Add(emp1);
            ////context.Entry(emp1).State = EntityState.Detached;

            //Console.WriteLine("===============");
            //Console.WriteLine(context.Entry(emp1).State);
            //Console.WriteLine(context.Entry(emp2).State);


            //context.SaveChanges(); //=> genarate sql script add 2 employee


            //Console.WriteLine("===============");
            //Console.WriteLine(context.Entry(emp1).State);
            //Console.WriteLine(context.Entry(emp2).State);

            #endregion

            #region Retrieve
            //var emp1 = context.Employees.Where(e => e.Salary < 15000).AsNoTracking();

            ////if (emp1 != null) 
            ////{
            ////    Console.WriteLine(context.Entry(emp1).State);
            ////}

            //foreach (var item in emp1)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(context.Entry(item).State);
            //    Console.WriteLine("------------");
            //}

            #endregion

            #region Update
            //var emp = context.Employees.AsNoTracking().FirstOrDefault(e => e.EId == 3);

            //if(emp is not null )
            //{
            //    Console.WriteLine(context.Entry(emp).State);

            //    emp.Name = "mahmoud";

            //    context.Employees.Update(emp);
            //    Console.WriteLine("===============");
            //    Console.WriteLine(context.Entry(emp).State);


            //    context.SaveChanges();

            //    Console.WriteLine("===============");
            //    Console.WriteLine(context.Entry(emp).State);
            //}

            #endregion

            #region delete
            //var emp = context.Employees.FirstOrDefault(e => e.EId == 3);

            //if (emp is not null)
            //{
            //    Console.WriteLine(context.Entry(emp).State);

            //    context.Employees.Remove(emp);
            //    Console.WriteLine("===============");
            //    Console.WriteLine(context.Entry(emp).State);

            //    context.SaveChanges();

            //    Console.WriteLine("===============");
            //    Console.WriteLine(context.Entry(emp).State);
            //}
            #endregion

                        
        }
    }
}

//data => sql inset

//object
//datebase connection =>objeect from dbContext

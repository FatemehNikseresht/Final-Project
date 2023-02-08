using Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class PersonService
    {
        public List<Person> Select()
        {
            using (var Context =new OnlineShopDbContext()) 
            {
                try
                {
                   var People =Context.Person.ToList();
                    return People;
                }
                catch (Exception)
                {

                    throw;
                }
                finally 
                {
                    if (Context != null)
                    { 
                        Context.Dispose();
                    }
                }
            }
        }

        public void Insert(Person person)
        {
            using (var Context = new OnlineShopDbContext())
            {
                try
                {
                    Context.Person.Add(person);
                    Context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }
            }
        }

        public void Remove(Person person)
        {
            using (var Context = new OnlineShopDbContext())
            {
                try
                {
                    Context.Person.Remove(person);
                    Context.SaveChanges();
                 
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                    {
                        Context.Dispose();
                    }
                }
            }
        }
    }
}

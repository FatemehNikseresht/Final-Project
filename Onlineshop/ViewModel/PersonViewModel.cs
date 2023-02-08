using Model.Dtos;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.Dtos;

namespace ViewModel
{
    public class PersonViewModel
    {


        //gfhgf
        private readonly PersonService _personService;

        public PersonViewModel()
        {
            _personService = new PersonService();
        }
        public dynamic FillGrid()
        {
            return _personService.Select();
        }
        public void Save(PersonSaveDto personSaveDto)
        {
            var Person = new Person()
            {
                FirstName = personSaveDto.FirstName,
                LastName = personSaveDto.LastName,
            };
            _personService.Insert(Person);
        }
        public void Delete(PersonDeleteDto PersonDeleteDto)
        {
            var Person = new Person()
            { 
                Id = PersonDeleteDto.Id
            };
            _personService.Remove(Person);
        }
    }
}

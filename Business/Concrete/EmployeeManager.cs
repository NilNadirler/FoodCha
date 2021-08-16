using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IResult Add(Employee employee)
        {
            _employeeRepository.Add(employee);
            return new SuccessResult("Urun eklendi");
        }

        public IResult Delete(Employee employee)
        {
            _employeeRepository.Delete(employee);
            return new SuccessResult("Urun silindi");
        }

        public IDataResult<Employee> Get(Employee employee)
        {
            return new SuccessDataResult<Employee>(_employeeRepository.Get(e=>e.Id==employee.Id));
        }

        public IDataResult<List<Employee>> GetAll()
        {
            return new SuccessDataResult<List<Employee>>(_employeeRepository.GetAll());
        }

        public IResult Update(Employee employee)
        {
            _employeeRepository.Update(employee);
            return new SuccessResult("Urun guncellendi");
        }
    }
}

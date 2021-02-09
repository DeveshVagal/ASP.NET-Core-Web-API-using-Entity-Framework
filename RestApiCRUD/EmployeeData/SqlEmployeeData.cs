using RestApiCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUD.EmployeeData
{
    public class SqlEmployeeData : IEmployeeData
    {
        private EmployeeContext _employeeContext;

        public SqlEmployeeData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Guid.NewGuid();
            _employeeContext.Devesh.Add(employee);
            _employeeContext.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(Employee employee)
        {
            /*   var existingEmployee = _employeeContext.Devesh.Find(employee);

               if(existingEmployee != null)
               {
                   _employeeContext.Devesh.Remove(existingEmployee);
               }*/

            _employeeContext.Devesh.Remove(employee);
            _employeeContext.SaveChanges();
        }

        public Employee EditEmployee(Employee employee)
        {
            var existingEmployee = _employeeContext.Devesh.Find(employee.Id);

            if(existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                _employeeContext.Devesh.Update(existingEmployee);
                _employeeContext.SaveChanges();
            }

            return employee;
        }

        public Employee GetEmployee(Guid id)
        {
           var employee =  _employeeContext.Devesh.Find(id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
           return _employeeContext.Devesh.ToList();
        }
    }
}

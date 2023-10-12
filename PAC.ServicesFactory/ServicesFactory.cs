using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PAC.BusinessLogic;
using PAC.DataAccess;
using PAC.Domain;
using PAC.IBusinessLogic;
using PAC.IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace PAC.ServicesFactory
{
    public class ServicesFactory
    {
        public ServicesFactory() { }
        public void RegistrateServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DbContext, PACContext>();
            serviceCollection.AddScoped<IStudentsRepository<Student>, StudentsRepository<Student>>();

            serviceCollection.AddScoped<IStudentLogic, StudentLogic>();
        }
    }
}

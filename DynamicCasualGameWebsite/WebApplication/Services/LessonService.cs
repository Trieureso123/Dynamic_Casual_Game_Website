using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using WebApplication.Repositories;

namespace WebApplication.Services
{
    public interface ILessonService : IBaseRepository<Lesson>
    {
        
    }

    public class LessonService
    {
    }
}

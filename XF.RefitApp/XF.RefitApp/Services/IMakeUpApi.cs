using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using XF.RefitApp.Models;

namespace XF.RefitApp.Services
{
    public interface IMakeUpApi
    {
        [Get("/api/v1/products.json?brand=maybelline")]
        Task<List<MakeUp>> GetMakeUps();

        [Get("/api/students/courses")]
        Task<List<CourseModel>> GetCourses([Header("Authorization")] string token);

        [Get("/api/students/profiles")]
        Task<string> GetProfile([Header("Authorization")] string token);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VS1561Crasher.Controllers
{
   [Route("api/[controller]")]
   public class CrashController : Controller
   {
      private readonly IDependency _dependency;

      public CrashController(IDependency dependency)
      {
         _dependency = dependency;
      }

      [HttpPost]
      public string DoCrash()
      {
         return "Isn't crashed";
      }
   }

   public interface IDependency
   {
   }
}

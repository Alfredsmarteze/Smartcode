using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartcode.Models
{
  public  interface IYourMessage
    {
        public Task AddMessage(YourMessage yourMessage); 
    }
}

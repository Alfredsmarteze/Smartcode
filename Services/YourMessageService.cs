using Microsoft.AspNetCore.Mvc;
using Smartcode.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartcode.Models
{
    public class YourMessageService : IYourMessage
    {
        private readonly Smartcodecontext _smartcodecontext;
        public YourMessageService(Smartcodecontext smartcodecontext) 
        {
            _smartcodecontext = smartcodecontext;
        }

        public async Task AddMessage(YourMessage yourMessage)
        {
            
             await _smartcodecontext.yourMessage.AddAsync(yourMessage);
            await _smartcodecontext.SaveChangesAsync();            
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab_8_ASP.Net.Pages
{
    public class TimeModel : PageModel
    {
        public string Message {get; set;}
        public List<int> LuckyNumbers {get;set;}


        public void OnGet()
        {
            var rand = new Random();

            Message = "Here are your lucky numbers";
            
            LuckyNumbers = new List<int>();
            
            for(int i = 0; i < 10; i++)
            {
                LuckyNumbers.Add(rand.Next(1000));
            }

        }
    }
}
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services.Description;

namespace Server.Controllers
{
    public class TokenGeneration
    {
        BankModelsContainer banks = new BankModelsContainer();

        //Queue<Token> tokenQueue= new Queue<Token>();


        //public List<Token> GetTokenList()
        //{
        //    var Records = from records in banks.Tokens select records;
        //    return (List<Token>)Records;
        //}

        private Random rnd;

        public TokenGeneration()
        {
            rnd = new Random();
        }

        public int GenerateRandomNumber(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        //TokenGeneration rng = new TokenGeneration();
        //int randomNumber = rng.GenerateRandomNumber(1, 100);
        //Console.WriteLine(randomNumber);

    }

   
       
           
        
    
}
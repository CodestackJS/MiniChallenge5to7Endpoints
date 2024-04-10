using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge5to7Endpoints.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MultipleControllers : ControllerBase
    {
        [HttpGet("/MadLibs")]
        public string MadLibs(string Name, string Location, string firstVerb, string Noun, string Adjective){
            string MadLibSentence = $"Once upon a time in the magical land of {Location}, there lived a cheerful little {Noun} named {Name}. Once sunny day, {Name} decided to have a(n) {Adjective} adventure at the park. First, {Name} skipped {firstVerb} down the slide, feeling the wind rush past them.";
            return MadLibSentence;
        }

        [HttpGet("/OddEven")]
        public string OddEven(int x = 2){
            string answer;
            if (x%2 == 1){
                answer = "odd";
            }
            else{
                answer = "even";
            }
            return "the chosen number will be " + answer;
        }

        [HttpGet("/ReverseIt")]
         public string ReverseIt(string input)
         {
            if (string.IsNullOrEmpty(input))
                return "Please provide a valid input.";

                char[] changeToCharArray = input.ToCharArray();
                Array.Reverse(changeToCharArray);

                string reversed = new string(changeToCharArray);
                return $"You entered {input}, reversed is {reversed}";
        }
            
         [HttpGet("/intReverseIt")]
         public string intReverseIt(string input){
            if (string.IsNullOrEmpty(input))
            return "It needs an input";

            if(!input.All(char.IsDigit))
            return "this nees to be an integer";

            char[] changeToCharArray = input.ToCharArray();
            Array.Reverse(changeToCharArray);
            string reversed = new string(changeToCharArray);
            return "Your input is " + input + " Your reverse input will be " + reversed;
         }
    }
}
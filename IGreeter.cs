using Microsoft.Extensions.Configuration;

namespace CustomerOrder
{
    //Custom service Greetings
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {// This service:  IConfiguration configuration is registred
         // by defaul web host builder
            _configuration = configuration;
        }
        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
            // f(key) = value 
        }
    }
}
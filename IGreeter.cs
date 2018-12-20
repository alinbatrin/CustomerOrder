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


        // This service:  IConfiguration configuration is registred
        // by defaul web host builder
        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // f(key) = value 
        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}
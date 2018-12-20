namespace CustomerOrder
{
    //Custom service Greetings
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        //public Greeter(IConfigu)
        public string GetMessageOfTheDay()
        {
            return "Greetings!! GG - Dev Alin Batrin";
        }
    }
}
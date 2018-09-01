namespace Nya.HelloWorld
{
    public class StatusCodeImplementation : IStatusCode
    {
        public Status Code { get; }

        public StatusCodeImplementation(Status code)
        {
            Code = code;
        }
    }
}

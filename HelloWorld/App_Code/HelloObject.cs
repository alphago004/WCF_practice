namespace HelloWorldService
{
    public class HelloObject
    {
        public bool happyHello { get; set; }
        public string helloMessage { get; set; }

        public HelloObject()
        {
            helloMessage = "say hello";
            happyHello = true;
        }
    }
}
namespace FirstProject_QuickStart
{
    public class HelloWorld
    {
        public MessageWriter MessageWriter { get; set; }

        public void SayHello()
        {
            MessageWriter.Write("Hello Spring.NET QuickStart!");
        }
    }
}
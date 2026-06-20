using SingletonPatternExample;

Logger logger1 = Logger.GetInstance();
logger1.Log("First message");

Logger logger2 = Logger.GetInstance();
logger2.Log("Second message");

if (logger1 == logger2)
{
    Console.WriteLine("Only one Logger instance exists.");
}
else
{
    Console.WriteLine("Multiple Logger instances exist.");
}
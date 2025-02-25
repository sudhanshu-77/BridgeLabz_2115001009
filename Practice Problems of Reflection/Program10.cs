// Custom Logging Proxy Using Reflection: Implement a Dynamic Proxy that intercepts method calls on an interface (e.g., IGreeting.SayHello()) and logs the method name before executing it. 
using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

public interface IGreeting
{
    void SayHello();
}

public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
}

public class LoggingProxy : RealProxy
{
    private readonly IGreeting _target;

    public LoggingProxy(IGreeting target) : base(typeof(IGreeting))
    {
        _target = target;
    }

    public override IMessage Invoke(IMessage msg)
    {
        var methodCall = msg as IMethodCallMessage;
        Console.WriteLine($"Invoking method: {methodCall.MethodName}");
        var result = methodCall.MethodBase.Invoke(_target, methodCall.Args);
        return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
    }
}

public class Program10
{
    public static void Main()
    {
        IGreeting greeting = new Greeting();
        IGreeting proxy = (IGreeting)new LoggingProxy(greeting).GetTransparentProxy();
        proxy.SayHello();
    }
}


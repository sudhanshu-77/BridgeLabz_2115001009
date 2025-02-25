
// Dependency Injection using Reflection: Implement a simple DI container that scans classes with [Inject] attribute and injects dependencies dynamically. 
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Constructor)]
public class InjectAttribute : Attribute { }

public class ServiceA
{
    public void Print() => Console.WriteLine("ServiceA is working!");
}

public class ServiceB
{
    private readonly ServiceA _serviceA;

    [Inject]
    public ServiceB(ServiceA serviceA)
    {
        _serviceA = serviceA;
    }

    public void Execute() => _serviceA.Print();
}

public class Container
{
    public T Resolve<T>()
    {
        ConstructorInfo constructor = typeof(T).GetConstructors()[0];
        ParameterInfo[] parameters = constructor.GetParameters();

        object[] dependencies = new object[parameters.Length];

        for (int i = 0; i < parameters.Length; i++)
        {
            dependencies[i] = Activator.CreateInstance(parameters[i].ParameterType);
        }

        return (T)constructor.Invoke(dependencies);
    }
}

public class Program11
{
    public static void Main()
    {
        Container container = new Container();
        ServiceB serviceB = container.Resolve<ServiceB>();
        serviceB.Execute();
    }
}


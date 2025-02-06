//Multiple Inheritence

using System;


interface A{
    void Add(); //Public
}

interface B{
    void Sub(); //Public
}

class C : A,B {

     int a = 20;
    int b =30;

    public void Add(){
        Console.WriteLine("Addition " + (a + b));
    }

    public void Sub(){
        
        Console.WriteLine(a - b);

    }

     static void Main(string[] args){

        C obj = new C();
        obj.Add();
        obj.Sub();
}
}


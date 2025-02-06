// Inheritence

using System;

class A{

    int a = 40;
    int b = 50;
    int c;

    public void add(){
        c = a + b;
        Console.WriteLine("Addition " + c);
    }
    public void sub(){
        c = a - b;
        Console.WriteLine("Substraction " + c);


    
}
class B : A {
    

    // int a = 40;
    // int b = 50;
    public void multi(){
        
        int c = a * b;

        Console.WriteLine("Multiplication " + c);

    }

    public void divison(){
        int c = a / b;

        Console.WriteLine("Division " + c);
    }


    static void Main(string[] args){

        B obj = new B();
        obj.add();
        obj.sub();
        obj.multi();
        obj.divison();

    }

    }
}
public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x, int y);

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("Calculator dotask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + " " + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x + " " + y);
        return x* y;
    }

    public  int Divide(int x, int y)
    {
        Console.WriteLine(x+" "+y);
        return x/y;
    }
    public int Subtract(int x, int y)
    {
        Console.WriteLine(x+" "+y);
        return x-y;
    }
    public String GetModel()
    {
        return "X500";
    }
}

public class Delegatedemo
{
    public static void TestOne()
    {
        MathCalculator mc=new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask;//new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = mc.Add;//new MethodHandlerB(mc.Add);
        MethodHandlerB methodHandlertwo = mc.Multiply;
        MethodHandlerB methodHandlerB1 = mc.Divide;//new MethodHandlerB(mc.Divide);
        methodHandlerA();
        int addresult = methodHandlerB(100, 50);
        Console.WriteLine(addresult);
        int multiplyResult=methodHandlertwo(20, 5);
        Console.WriteLine(multiplyResult);
        int divideresult =methodHandlerB1(200, 5);
        Console.WriteLine(divideresult);

    }
    public static void TestTwo()
    {
        MathCalculator mc =new MathCalculator();
        MethodHandlerB methodHandlerB=mc.Add;
        methodHandlerB += mc.Multiply;
        methodHandlerB(100, 50);    
    }
}
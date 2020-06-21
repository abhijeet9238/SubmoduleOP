using System;
using SubmoduleClasslibrary;
namespace SubmoduleOP
{
    class Program
    {
        
        static void Main(string[] args)
        {
            A obj = new A();
            obj.Operation();
            
        }
    }
    public class A
    {
        public IOperations _ops;
        public A()
        {
            _ops = new Operations();
        }
        public void Operation()
        {
            Console.WriteLine("Enter nuber 1:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter nuber 2:");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Results :");
            Console.WriteLine(string.Format("add :{0}",_ops.add(a, b)));
            Console.WriteLine(string.Format("sub :{0}",_ops.sub(a, b)));
            Console.WriteLine(string.Format("mul :{0}",_ops.mul(a, b)));
            Console.WriteLine(string.Format("div :{0}",_ops.div(a, b)));
        }
    }
}

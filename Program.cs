using System;
using System.Console;

namespace HelloWorld //이것은 네임스페이스이고 이름은 HelloWorld입니다.
{
    class Program
    {
        //프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                System.Console.WriteLine("HelloWorld  이름"); 
	    System.Console.WriteLine("Hi");
                System.Console.ReadKey(); // 콘솔에서 키를 받기위해 대기
                return ;
              
            }
            System.Console.WriteLine("Hello {0}", args[0]);// args[0] 0번째를 호출
            System.Console.ReadKey();
            
        }
      
    }
}

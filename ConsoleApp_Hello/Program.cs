using System;
using System.Diagnostics;

namespace ConsoleApp_Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = IronPython.Hosting.Python.CreateEngine();
            var scope = engine.CreateScope();
            var paths = engine.GetSearchPaths();

            //파이썬 모듈 참고 경로를 추가
            paths.Add(@"C:\Anaconda2");
            paths.Add(@"C:\Anaconda2\DLLs");
            paths.Add(@"C:\Anaconda2\Lib");
            paths.Add(@"C:\Anaconda2\Lib\site-packages");

            engine.SetSearchPaths(paths);

            try
            {
                var source = engine.CreateScriptSourceFromFile("../../../test.py");
                source.Execute(scope);

                var getPythonFuncResult = scope.GetVariable<Func<string>>("getPythonFunc");
                Console.WriteLine("def 실행 테스트 : " + getPythonFuncResult());

                var sum = scope.GetVariable<Func<int, int, int>>("sum");
                Console.WriteLine(sum(1, 2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}

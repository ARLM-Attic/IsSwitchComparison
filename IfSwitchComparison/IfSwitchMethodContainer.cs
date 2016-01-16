using System;
using BenchmarkDotNet;

namespace IfSwitchComparison
{
    public class IfSwitchMethodContainer
    {
        // m_ numeration for convinient work with the IlSpy

        #region Just if\switch block
        // Only switch block, no switch default
        public static int m1_SwitchTest(int x)
        {
            switch (x)
            {
                case 10: return 1;
                case 20: return 2;
                case 30: return 3;
            }
            return -1;
        }

        // Only if block, no "else if" constructions
        public static int m2_IfTest(int x)
        {
            if (x == 10) return 1;
            if (x == 20) return 2;
            if (x == 30) return 3;
            return -1;
        }

        // Only switch block, 
        public static int m3_SwitchDefaultTest(int x)
        {
            switch (x)
            {
                case 10: return 1;
                case 20: return 2;
                case 30: return 3;
                default:  return -1;
            }
        }

        // Only if block, with "else if" constructions
        public static int m4_IfElseTest(int x)
        {
            if (x == 10) { return 1;}
            else if (x == 20) { return 2;}
            else if (x == 30){return 3;}
            else{return -1;}
        }
        #endregion


        #region if\switch block and any method
        // Switch block and method, no switch default
        
        public static int m5_SwitchAndMethodTest(int x)
        {
            int result = -1;
            switch (x)
            {
                case 10: { result = 1; break;}
                case 20: { result = 2; break;}
                case 30: { result = 3; break;}
            }

            m9_LogResult(result);
            return result;
        }

        // if block and method, no "else if" constructions
        
        public static int m6_IfAndMethodTest(int x)
        {
            int result = -1;
            if (x == 10) { result = 1; }
            if (x == 20) { result = 2; }
            if (x == 30) { result = 3; }

            m9_LogResult(result);

            return result;
        }

        // switch block and method, with "default" construction 
        
        public static int m7_SwitchDefaultAndMethodTest(int x)
        {
            int result = -1;
            switch (x)
            {
                case 10: { result = 1; break; }
                case 20: { result = 2; break; }
                case 30: { result = 3; break; }
            }

            m9_LogResult(result);

            return result;
        }

        // if block and method, with "else if" constructions
        
        public static int m8_IfElseAndMethodTest(int x)
        {
            int result = -1;

            if (x == 10) { result = 1; }
            else if (x == 20) { result = 2; }
            else if (x == 30) { result = 3; }
            
            m9_LogResult(result);

            return result;
        }
        #endregion

        #region Benchmarks methods
        [Benchmark]
        public int Switch_NoDefault_NoOtherOperation()
        {
            m1_SwitchTest(1);
            m1_SwitchTest(10);
            m1_SwitchTest(20);
            m1_SwitchTest(30);
            return 0;
        }

        [Benchmark]
        public int If_NoElse_NoOtherOperations()
        {
            m2_IfTest(1);
            m2_IfTest(10);
            m2_IfTest(20);
            m2_IfTest(30);
            return 0;
        }

        [Benchmark]
        public int Switch_Default_NoOtherOperations()
        {
            m3_SwitchDefaultTest(1);
            m3_SwitchDefaultTest(10);
            m3_SwitchDefaultTest(20);
            m3_SwitchDefaultTest(30);
            return 0;
        }

        [Benchmark]
        public int If_ElseIf_NoOtherOperations()
        {
            m4_IfElseTest(1);
            m4_IfElseTest(10);
            m4_IfElseTest(20);
            m4_IfElseTest(30);
            return 0;
        }

        [Benchmark]
        public int Switch_NoDefault_OtherOperation()
        {
            m5_SwitchAndMethodTest(1);
            m5_SwitchAndMethodTest(10);
            m5_SwitchAndMethodTest(20);
            m5_SwitchAndMethodTest(30);
            return 0;
        }

        [Benchmark]
        public int If_NoElse_OtherOperations()
        {
            m6_IfAndMethodTest(1);
            m6_IfAndMethodTest(10);
            m6_IfAndMethodTest(20);
            m6_IfAndMethodTest(30);
            return 0;
        }

        [Benchmark]
        public int Switch_Default_OtherOperations()
        {
            m7_SwitchDefaultAndMethodTest(1);
            m7_SwitchDefaultAndMethodTest(10);
            m7_SwitchDefaultAndMethodTest(20);
            m7_SwitchDefaultAndMethodTest(30);
            return 0;
        }

        [Benchmark]
        public int If_ElseIf_OtherOperations()
        {
            m8_IfElseAndMethodTest(1);
            m8_IfElseAndMethodTest(10);
            m8_IfElseAndMethodTest(20);
            m8_IfElseAndMethodTest(30);
            return 0;
        }
        #endregion

        // Just a stub
        public static void m9_LogResult(int x)
        {
            // Do nothing, just a stub. 
            // If compiler omit or inline it - add here something like "File.WriteAllText(tourPath, x.ToString());"
        }
    }
}

namespace IfSwitchComparison
{
    public static class IfSwitchMethodContainer
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

        // Just a stub
        public static void m9_LogResult(int x)
        {
            // Do nothing, just a stub. 
            // If compiler omit or inline it - add here something like "File.WriteAllText(tourPath, x.ToString());"
        }
    }
}

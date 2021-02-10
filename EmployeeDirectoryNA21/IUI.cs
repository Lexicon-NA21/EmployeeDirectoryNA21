namespace EmployeeDirectoryNA21
{
    public interface IUI
    {
        string GetInput();
        void Print(Employee employee);
        void Print(string message);
    }

    public class MockUI : IUI
    {
        public string GetInput()
        {
            return "Kalle";
        }

        public void Print(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public void Print(string message)
        {
            throw new System.NotImplementedException();
        }
    }


    //public class NewUI : IUI
    //{
    //    public string GetInput()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public void Print(Employee employee)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public void Print(string message)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
}
namespace EmployeeDirectoryNA21
{
    public interface IUI
    {
        string GetInput();
        void Print(Employee employee);
        string Print(string message);
      

    }

    public class NewUI : IUI
    {
        public string GetInput()
        {
            throw new System.NotImplementedException();
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
}
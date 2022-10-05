using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Spy spy = new Spy();
            spy.StealFieldInfo("ReflectionConsole.Hacker", "username", "password");


        }
    }
    public class Spy
    {
        public  void  StealFieldInfo(string investClass,params string[] investField)
        {
            Type classTupe = Type.GetType(investClass);
            FieldInfo[]field=classTupe.GetFields(BindingFlags.Public |BindingFlags.NonPublic | BindingFlags.Instance |BindingFlags.Static);
            Object classInstant = Activator.CreateInstance(classTupe,new object[] {});
            Console.WriteLine("The name of class is "+classTupe.Name);

            foreach (FieldInfo item in field.Where(f=>investField.Contains(f.Name)))
            {
                Console.WriteLine(item.Name+"="+item.GetValue(classInstant));
            }
        
            
        }
    }
    public class Hacker
    {
        public string username = "securityGod82";
        private string password = "mySuperSecretPassw0rd";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {
        }
    }

}

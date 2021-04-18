using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_VM_Obs.coll
{
    class Employee : ObservableObject
    {
        public Employee()
        {
            this.PropertyChanged += Employee_PropertyChanged;
        }

        private void Employee_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "BirthDate":
                    if (BirhtDate.HasValue)
                    {
                        Age = DateTime.Now.Year - BirhtDate.Value.Year;
                    }
                    else
                    {
                        Age = null;
                    }
                    break;  
                default:
                    break;
            }
        }


        private string FirstName, LastName;
        private DateTime? BirhtDate;
        private int? age;

        

        public string FirstName1 { get => FirstName; set =>Set(ref FirstName, value); }
        public string LastName1 { get => LastName; set =>Set(ref LastName, value); }
        public DateTime? BirhtDate1 { get => BirhtDate; set =>Set(ref BirhtDate, value); }
        public int? Age { get => age; private set =>Set(ref age, value); }
        public override string ToString()
        {
            return $"{FirstName1} {LastName1}";
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace beadando_VM_Obs.coll
{
    class MainVM : ViewModelBase
    {
        public MainVM()
        {
            CMD_Add = new RelayCommand(Add, AddCanExecute);
            CMD_Delete = new RelayCommand(Delete, DeleteCanExecute);
            CMD_New = new RelayCommand(New,NewCanExecute);

            Employees = new ObservableCollection<Employee>();
            this.PropertyChanged += MainVM_PropertyChanged;
        }

        private void MainVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SearchWord":
                    CharNum = SearchWord.Length;
                    break;
                case "Selected":
                    SelectedNotNull = Selected != null;
                    break;
                default:
                    break;
            }
        }

        private string searchWord;
        private int charNum;
        private Employee selected;
        private bool selectedNotNull;

        public string SearchWord { get => searchWord; set => Set(ref searchWord, value); }
        public int CharNum { get => charNum; set => Set(ref charNum, value); }

        public ObservableCollection<Employee> Employees { get; private set; }
        public Employee Selected { get => selected; set => Set(ref selected, value); }
        public ICommand CMD_Add { get; private set; }
        public ICommand CMD_Delete { get; private set; }
        public ICommand CMD_New { get; private set; }
        public bool SelectedNotNull { get => selectedNotNull; set => Set(ref selectedNotNull, value); }

        private void Add()
        {
            Employees.Add(Selected);
        }
        private bool AddCanExecute()
        {
            return SelectedNotNull && !string.IsNullOrWhiteSpace(Selected.FirstName1) && !string.IsNullOrWhiteSpace(Selected.LastName1) && !Employees.Contains(Selected);
        }
        private void Delete()
        {
            Employees.Remove(Selected);
        }
        private bool DeleteCanExecute()
        {
            return SelectedNotNull && Employees.Contains(Selected);
        }
        private void New()
        {
            Selected = new Employee();
        }
        private bool NewCanExecute()
        {
            return true;
        }
    }
}
  /*
   () =>
            {
                Employees.Add(Selected);
                Selected = new Employee();
},
            () => Selected != null && !Employees.Contains(Selected) && !string.IsNullOrWhiteSpace(Selected.FirstName1) && !string.IsNullOrWhiteSpace(Selected.LastName1)) ;

}
  */ 

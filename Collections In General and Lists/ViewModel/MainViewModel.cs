using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Collections_In_General_and_Lists.Annotations;
using Collections_In_General_and_Lists.Model;
using HelperClasses;

namespace Collections_In_General_and_Lists.ViewModel
{
    //TODO: MVVM, bindings, Commands and collections
    class MainViewModel: INotifyPropertyChanged
    {
        private List<PersonModel> _listOfPeople;
        private ObservableCollection<PersonModel> _observableListOfPeople;
        private Dictionary<string, List<PersonModel>> _genderDictionary;
        private List<PersonModel> males;
        private List<PersonModel> females;
        private ICommand _addPersonCommand;
        private PersonModel _selectedPerson;
        private ICommand _removePersonCommand;
        private ICommand _clearObservableListOfPeople;

        public MainViewModel()
        {
            #region Populate ListOfPeople
            ListOfPeople = new List<PersonModel>();

            ListOfPeople.Add(new PersonModel(Gender.Male, "Bob", 40));
            ListOfPeople.Add(new PersonModel(Gender.Female, "Sue", 40));
            ListOfPeople.Add(new PersonModel(Gender.Male, "Rob", 40));
            ListOfPeople.Add(new PersonModel(Gender.Female, "Lue", 40));
            ListOfPeople.Add(new PersonModel(Gender.Male, "Tod", 40));
            ListOfPeople.Add(new PersonModel(Gender.Female, "Sally", 40));
            ListOfPeople.Add(new PersonModel(Gender.Male, "Dod", 40));
            ListOfPeople.Add(new PersonModel(Gender.Female, "Cheryl", 40));
            #endregion

            #region Populate GenderDictionary
            GenderDictionary = new Dictionary<string, List<PersonModel>>();

            males = new List<PersonModel>();
            females = new List<PersonModel>();
            foreach (PersonModel person in ListOfPeople)
            {
                
                if (person.Gender == Gender.Male)
                {
                    males.Add(person);
                }
                if (person.Gender == Gender.Female)
                {
                    females.Add(person);
                }
            }
            GenderDictionary[Gender.Male.ToString()] = males;
            GenderDictionary[Gender.Female.ToString()] = females;

            #endregion

            #region The Commands being instantiated

            _addPersonCommand = new RelayCommand(AddPerson);
            _removePersonCommand = new RelayCommand(RemovePerson);
            _clearObservableListOfPeople = new RelayCommand(ClearList);

            #endregion

            ObservableListOfPeople = new ObservableCollection<PersonModel>();
        }

        #region Methods used by the commands

        private void ClearList()
        {
            ObservableListOfPeople.Clear();
        }

        private void RemovePerson()
        {
            if (ObservableListOfPeople.Contains(SelectedPerson))
            {
                ObservableListOfPeople.Remove(SelectedPerson);
            }
        }

        private void AddPerson()
        {
            if (!ObservableListOfPeople.Contains(SelectedPerson))
            {
                ObservableListOfPeople.Add(SelectedPerson);
            }
        }

        #endregion

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set
            {
                _selectedPerson = value;
            }
        }

        #region The properties for the lists
        public List<PersonModel> ListOfPeople
        {
            get { return _listOfPeople; }
            set { _listOfPeople = value; }
        }

        public ObservableCollection<PersonModel> ObservableListOfPeople
        {
            get { return _observableListOfPeople; }
            set
            {
                _observableListOfPeople = value;
                //OnPropertyChanged();
            }
        }

        public Dictionary<string, List<PersonModel>> GenderDictionary
        {
            get { return _genderDictionary; }
            set { _genderDictionary = value; }
        }
        #endregion

        #region Commands
        public ICommand ClearObservableListOfPeople
        {
            get { return _clearObservableListOfPeople; }
            set { _clearObservableListOfPeople = value; }
        }

        public ICommand AddPersonCommand
        {
            get { return _addPersonCommand; }
            set { _addPersonCommand = value; }
        }

        public ICommand RemovePersonCommand
        {
            get { return _removePersonCommand; }
            set { _removePersonCommand = value; }
        }
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

using System.Collections;
using System.Collections.Generic;
using Common;
using People.Library;
using System.Windows;

namespace PeopleViewer
{
    public partial class MainWindow : Window
    {
        PersonRepository repository = new PersonRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcreteFetchButton_Click(object sender, RoutedEventArgs e)
        {
            List<Person> people = repository.GetPeople();
            PersonListBox.ItemsSource = people;
//            foreach (var person in people)
//            {
//                PersonListBox.Items.Add(person);
//            }
        }

        private void AbstractFetchButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> people = repository.GetPeople();
            PersonListBox.ItemsSource = people;
//            foreach (var person in people)
//            {
//                PersonListBox.Items.Add(person);
//            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            PersonListBox.ItemsSource = null;
//            PersonListBox.Items.Clear();
        }
    }
}

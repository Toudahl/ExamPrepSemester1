using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Collections_In_General_and_Lists
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_clearSelection_Click(object sender, RoutedEventArgs e)
        {
            listview_ListOfPeople.SelectedItem = null;
            listview_GenderDictionaryMale.SelectedItem = null;
            listview_GenderDictionaryFemale.SelectedItem = null;
        }
    }
}

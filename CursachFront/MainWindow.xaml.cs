using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CursachFront
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static PageOption Options = new PageOption();
        private static PageUserCabinet Cabinets = new PageUserCabinet();
        private static searching Searching = new searching();
        private static Veiw View = new Veiw();
        private static CHANDGESUSPECT Changer = new CHANDGESUSPECT();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ToOption(object sender, RoutedEventArgs e) { OptionsPages.Content = Options; }
        public static void Cancell(MainWindow mainWindow) { mainWindow.CansellOptionMetod();}
        public  void CansellOptionMetod() { OptionsPages.Content = null; } 


        private void ToCabinet(object sender, RoutedEventArgs e) { CadinetOficer.Content = Cabinets; }
        public static void CancellCabinet(MainWindow mainWindow) { mainWindow.CansellCabinetMetod(); }
        public void CansellCabinetMetod() { CadinetOficer.Content = null; }
       
        /// //////////////////кнопки поиска/
     
        private void ToSearching(object sender, RoutedEventArgs e) { FindesPages.Content = Searching; }
        public static void CancellSearching(MainWindow mainWindow) { mainWindow.CansellSearchingMetod(); }
        public static void ToSearchingEnotherframe(MainWindow mainWindow) { mainWindow.ToSearchingMetod(); }

       
        private void ToSearchingMetod() { FindesPages.Content = Searching; }
        public void CansellSearchingMetod() { FindesPages.Content = null; }

        /// //////////////////кнопки view/

        private void ToView(object sender, RoutedEventArgs e) { FindesPages.Content = View; }
        public static void CancellView(MainWindow mainWindow) { mainWindow.CansellViewMetod(); }
        public static void ToViewEnotherframe(MainWindow mainWindow) { mainWindow.ToViewMetod(); }


        private void ToViewMetod() { FindesPages.Content = View; }
        public void CansellViewMetod() { FindesPages.Content = null; }
        /// //////////////////кнопки changer/
        private void ToChangeSubject(object sender, RoutedEventArgs e) { FindesPages.Content = Changer; }
        public static void CancellChangeSubject(MainWindow mainWindow) { mainWindow.CansellChangeSubjectMetod(); }
        public static void ToChangeSubjectEnotherframe(MainWindow mainWindow) { mainWindow.ToChangeSubjectMetod(); }


        private void ToChangeSubjectMetod() { FindesPages.Content = Changer; }
        public void CansellChangeSubjectMetod() { FindesPages.Content = null; }
    }
}

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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReleVezerles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        // változók
        public static int elektrodakszama;
        public static string merestipus;
        public static int helykozmax;
        public static int meresekszama;

        private bool eSelected = false;
        private bool mSelected = false;


        public void wenneralfa(int szonda)
        {
            /* MINTA
              
               ABCD
               A-B-C-D
               A--B--C--D   */

            /* TERVEZÉS
               0. (előfeltétel) hány szonda van? (gombon lehet majd állitani ---> változó(szondadb))
               1. (algoritmus) ABCD funkcionalitású szondák, addig mér amíg az algoritmus alapján a D nem lesz nagyobb a szondadb változónknál
               2. (ciklus) amint nagyobb lenne a D szonda sorszáma mint a szondadb, akkor egy (helykoz) valtozó 1-el nől, és úgy fut le nullától
               3. (lezárás) a mérés addig fut amíg képes rá, ez alatt azt értjük,
               hogy ha az A szonda első helyen áll, és a helyköz úgymond eléri azt a maximális számot,
               hogy a D szonda már nem tudna úgy elhelyezkedni hogy a sorszáma ne legyen nagyobb a szonda db-nál,
               ha erre már nem képes akkor már nem mérünk tovább     */

            

            //MEGVALÓSÍTÁS
            int szondadb = szonda;
            int Ahelye = 1;
            int Bhelye = 2;
            int Chelye = 3;
            int Dhelye = 4;
            int helykoz = 1;
            meresekszama = 0;

            while (Dhelye < szondadb+1) //mérés lezárása, helyköz léptetés
            {
                while (Dhelye < szondadb+1) //sor lezárása, soron belüli léptetés
                {
                    MessageBox.Show("A: " + Ahelye + " B: " + Bhelye + " C: " + Chelye + " D: " + Dhelye);  //kiirjuk az adatokat
                    meresekszama++;
                    Ahelye++;   // léptetünk soron belül
                    Bhelye++;
                    Chelye++;
                    Dhelye++;
                }
                helykoz++;
                helykozmax = helykoz;
                Ahelye = 1;
                Bhelye = Ahelye+helykoz;
                Chelye = Bhelye+helykoz;
                Dhelye = Chelye+helykoz;
            }
            DisableButtons();
            ResetParameters();
            MessageBox.Show("Werrner-Alfa, Kész");
            MessageBox.Show("Meresek száma: " + meresekszama);
            MessageBox.Show("Max lépésköz: " + (helykozmax-1));
        }

        public void Schlumberger(int szonda)
        {
            /* MINTA
              
               ABCD
               A-BC-D
               A--BC--D   */

            /* TERVEZÉS
               0. (előfeltétel) hány szonda van? (gombon lehet majd állitani ---> változó(szondadb))
               1. (algoritmus) ABCD funkcionalitású szondák, addig mér amíg az algoritmus alapján a D nem lesz nagyobb a szondadb változónknál
               2. (ciklus) amint nagyobb lenne a D szonda sorszáma mint a szondadb, akkor egy (helykoz) valtozó 1-el nől, és úgy fut le nullától
               3. (lezárás) a mérés addig fut amíg képes rá, ez alatt azt értjük,
               hogy ha az A szonda első helyen áll, és a helyköz úgymond eléri azt a maximális számot,
               hogy a D szonda már nem tudna úgy elhelyezkedni hogy a sorszáma ne legyen nagyobb a szonda db-nál,
               ha erre már nem képes akkor már nem mérünk tovább     */

            //MEGVALÓSÍTÁS
            int szondadb = szonda;
            int Ahelye = 1;
            int Bhelye = 2;
            int Chelye = 3;
            int Dhelye = 4;
            int helykoz = 1;
            meresekszama = 0;

            while (Dhelye < szondadb + 1) //mérés lezárása, helyköz léptetés
            {
                while (Dhelye < szondadb + 1) //sor lezárása, soron belüli léptetés
                {
                    MessageBox.Show("A: " + Ahelye + " B: " + Bhelye + " C: " + Chelye + " D: " + Dhelye);  //kiirjuk az adatokat
                    meresekszama++;
                    Ahelye++;   // léptetünk soron belül
                    Bhelye++;
                    Chelye++;
                    Dhelye++;
                }
                helykoz++;
                helykozmax = helykoz;
                Ahelye = 1;
                Bhelye = Ahelye + helykoz;
                Chelye = Bhelye + 1;
                Dhelye = Chelye + helykoz;
            }
            DisableButtons();
            ResetParameters();
            MessageBox.Show("Schlumberger, KÉSZ");
            MessageBox.Show("Meresek száma: " + meresekszama);
            MessageBox.Show("Max lépésköz: " + (helykozmax - 1));
        }

        public void Dipolaxialis(int szonda)
        {
            /* MINTA
              
               ABCD
               AB-CD
               AB--CD   */

            /* TERVEZÉS
               0. (előfeltétel) hány szonda van? (gombon lehet majd állitani ---> változó(szondadb))
               1. (algoritmus) ABCD funkcionalitású szondák, addig mér amíg az algoritmus alapján a D nem lesz nagyobb a szondadb változónknál
               2. (ciklus) amint nagyobb lenne a D szonda sorszáma mint a szondadb, akkor egy (helykoz) valtozó 1-el nől, és úgy fut le nullától
               3. (lezárás) a mérés addig fut amíg képes rá, ez alatt azt értjük,
               hogy ha az A szonda első helyen áll, és a helyköz úgymond eléri azt a maximális számot,
               hogy a D szonda már nem tudna úgy elhelyezkedni hogy a sorszáma ne legyen nagyobb a szonda db-nál,
               ha erre már nem képes akkor már nem mérünk tovább     */

            //MEGVALÓSÍTÁS
            int szondadb = szonda;
            int Ahelye = 1;
            int Bhelye = 2;
            int Chelye = 3;
            int Dhelye = 4;
            int helykoz = 1;
            meresekszama = 0;

            while (Dhelye < szondadb + 1) //mérés lezárása, helyköz léptetés
            {
                while (Dhelye < szondadb + 1) //sor lezárása, soron belüli léptetés
                {
                    MessageBox.Show("A: " + Ahelye + " B: " + Bhelye + " C: " + Chelye + " D: " + Dhelye);  //kiirjuk az adatokat
                    meresekszama++;
                    Ahelye++;   // léptetünk soron belül
                    Bhelye++;
                    Chelye++;
                    Dhelye++;
                }
                helykoz++;
                helykozmax = helykoz;
                Ahelye = 1;
                Bhelye = Ahelye + 1;
                Chelye = Bhelye + helykoz;
                Dhelye = Chelye + 1;
            }
            DisableButtons();
            ResetParameters();
            MessageBox.Show("Dipól-axiális, KÉSZ");
            MessageBox.Show("Meresek száma: " + meresekszama);
            MessageBox.Show("Max lépésköz: " + (helykozmax - 1));
        }


        public void Inditas(object sender, RoutedEventArgs e)
        {
            if (Eszam.SelectedItem != null && Mtipus.SelectedItem!=null)
            {
                elektrodakszama = int.Parse(Eszam.Text); //Eszam > elektrodaszám ComboBoxItem 
                merestipus = Mtipus.Text; // Mtipus > Mérési típus ComboBoxItem

                Szünet.IsEnabled = true;
                Leallit.IsEnabled = true;

                switch (merestipus)
                {
                    case "Wenner-alfa":
                        wenneralfa(elektrodakszama);
                        break;

                    case "Schlumberger":
                        Schlumberger(elektrodakszama);
                        break;

                    case "Dipól-axiális":
                        Dipolaxialis(elektrodakszama);
                        break;
                }
            }
        }


        //Indítás gomb aktiválás
        private void Eszam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Eszam.SelectedItem != null)
            {
                eSelected = true;
            }

            if (mSelected == true)
            {
                Indito.IsEnabled = true;
            }
        }

        private void Mtipus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Mtipus.SelectedItem != null)
            {
                mSelected = true;
            }

            if (mSelected == true)
            {
                Indito.IsEnabled = true;
            }
        }

        public void DisableButtons()
        {
            //lefutás utánn a szünet és leállítás gomb kikapcsolása
            Szünet.IsEnabled = false;
            Leallit.IsEnabled = false;
        }

        public void ResetParameters()
        {
            Eszam.SelectedItem = null;
            Mtipus.SelectedItem = null;
            mSelected = false;
            eSelected = false;
            Indito.IsEnabled = false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

    }
}

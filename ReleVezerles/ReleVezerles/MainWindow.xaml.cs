﻿using System;
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

            // MEGVALÓSÍTÁS
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
            //ResetParameters();
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
            //ResetParameters();
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
            //ResetParameters();
            MessageBox.Show("Dipól-axiális, KÉSZ");
            MessageBox.Show("Meresek száma: " + meresekszama);
            MessageBox.Show("Max lépésköz: " + (helykozmax - 1));
        }

        public void tetszoleges1(int szonda)
        {
            /* MINTA
               
               a felhasználó adja meg
            */

            /* TERVEZÉS
               
                0. A felhasználó kiválasztja, hogy tetszőleges beállitásokkal akar dolgozni
                1. A felhasználó adhatja meg, hogy hol helyezkedjenek el a szondák
                2. Megkell vizsgálni, hogy megfelelő sorrendben helyezkedjenek el a szondák egymáshoz képest
                3. Mivel ez a verzió nem ciklikusan fog végrehajtódni, hanem csak egyszer, ezért nincs szükség a kiiratási panel teljes felhasználására
            */

            // MEGVALÓSÍTÁS


            // megfelelő intervallum ellenőrzése
            /*
                    !   !   !   !   !   !   !   !   !   !   !   !   !
                    az elektrodakszama változó valamiért nem működik
                    !   !   !   !   !   !   !   !   !   !   !   !   !
             */
            if (int.Parse(A.Text) <= 0 && (int.Parse(A.Text) < elektrodakszama)) MessageBox.Show("1-től " + elektrodakszama + "-ig adhatsz meg számot!");
            if (int.Parse(M.Text) <= 0 && (int.Parse(M.Text) < elektrodakszama)) MessageBox.Show("1-től " + elektrodakszama + "-ig adhatsz meg számot!");
            if (int.Parse(N.Text) <= 0 && (int.Parse(N.Text) < elektrodakszama)) MessageBox.Show("1-től " + elektrodakszama + "-ig adhatsz meg számot!");
            if (int.Parse(B.Text) <= 0 && (int.Parse(B.Text) < elektrodakszama)) MessageBox.Show("1-től " + elektrodakszama + "-ig adhatsz meg számot!");

            // egymáshoz képest jók-e
            if (int.Parse(M.Text) <= int.Parse(A.Text)) MessageBox.Show("Az 'M' szondának az értéke nem lehet kisebb vagy egyenlő az 'A' szonda értékével, kérlek adj meg egy számot ami " + A.Text + "-nél nagyobb!");
            if (int.Parse(N.Text) <= int.Parse(M.Text)) MessageBox.Show("Az 'N' szondának az értéke nem lehet kisebb vagy egyenlő az 'M' szonda értékével, kérlek adj meg egy számot ami " + M.Text + "-nél nagyobb!");
            if (int.Parse(B.Text) <= int.Parse(N.Text)) MessageBox.Show("Az 'B' szondának az értéke nem lehet kisebb vagy egyenlő az 'N' szonda értékével, kérlek adj meg egy számot ami " + N.Text + "-nél nagyobb!");
           
            DisableButtons();
            //ResetParameters();
            MessageBox.Show("Tetszőleges mérés, Kész");
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
                    case "Tetszőleges":
                        tetszoleges1(elektrodakszama);
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
            if (Mtipus.SelectedValue.ToString() != "Tetszőleges")
            {
                if (Mtipus.SelectedItem != null)
                {
                    mSelected = true;
                }

                if (eSelected == true)
                {
                    Indito.IsEnabled = true;
                }
                ExtraPanel(false);
            }
            else
            {
                //kiegészítő ablak megnyitás
                MessageBox.Show("Amikor az adatokat adja meg, kérem legyen tekintettel arra, hogy a szondák egy bizonyos szabály alapján követik egymást: A M N B");
                ExtraPanelReset();
                ExtraPanel(true);

                mSelected = true;

                if (eSelected == true)
                {
                    Indito.IsEnabled = true;
                }

            }
        }

        public void DisableButtons()
        {
            //lefutás utánn a szünet és leállítás gomb kikapcsolása
            Szünet.IsEnabled = false;
            Leallit.IsEnabled = false;
        }

        //HIBA-------------------------HIBA > Mtipus_SelectionChanged > Fő IF logika bugot okoz, más módszer kell.
        public void ResetParameters()
        {
            Eszam.SelectedItem = null;
            Mtipus.SelectedItem = null;
            mSelected = false;
            eSelected = false;
            Indito.IsEnabled = false;
        }

        public void ExtraPanel(bool status)
        {
            if (status == false)
            {
                Tparam.Visibility = Visibility.Hidden;
                TextA.Visibility = Visibility.Hidden;
                TextB.Visibility = Visibility.Hidden;
                TextN.Visibility = Visibility.Hidden;
                TextM.Visibility = Visibility.Hidden;
                A.Visibility = Visibility.Hidden;
                M.Visibility = Visibility.Hidden;
                N.Visibility = Visibility.Hidden;
                B.Visibility = Visibility.Hidden;
            }
            else
            {
                Tparam.Visibility = Visibility.Visible;
                TextA.Visibility = Visibility.Visible;
                TextB.Visibility = Visibility.Visible;
                TextN.Visibility = Visibility.Visible;
                TextM.Visibility = Visibility.Visible;
                A.Visibility = Visibility.Visible;
                M.Visibility = Visibility.Visible;
                N.Visibility = Visibility.Visible;
                B.Visibility = Visibility.Visible;
            }
        }

        public void ExtraPanelReset()
        {
            //Az értékek nullázása 

            A.Text = null;
            B.Text = null;
            N.Text = null;
            M.Text = null;
        }
        public MainWindow()
        {
            InitializeComponent();
            ExtraPanel(false);
        }

    }
}

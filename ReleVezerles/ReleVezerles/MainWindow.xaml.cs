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

        static void wennerafla()
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


        }


        public MainWindow()
        {

            InitializeComponent();
        }
    }
}
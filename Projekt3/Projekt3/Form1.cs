using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt3
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            // int liczba = 5;
            //int x = suma(liczba, 4, 5.5); //bez konkretnej nazwy"liczba" utworzy się metoda z v1, v2, v3 po wybraniu opcji z zaroweczki

            Button b = new Button();
            b.Text = "Nowy";
           // b.BackColor = Color.Yellow;
            // b.Click += button1_Click;
            // b.Click += nowaMetoda; //po wybraniu pierwszej opcji z zaroweczki
            // b.Click += kolejnaMetoda;
            // b.Click += ostatniaMetoda;
            b.Click += nowyButton;
            Controls.Add(b);  //Controls - kontener, który zarządza kontrolkami

        }

        private void nowyButton(object sender, EventArgs e) //sender = ref. do obiektu wywolujacego, sender jest typu object
        {
            /*
            if(sender is Button) //jesli sender jest buttonem
            {
                Button klikniety;
                klikniety = (sender as Button); //odczytujemy sender jako button(wtedy możeby odwoływać się do składowych button)
                klikniety.Text = "Nieaktywny";

                Button kolejny = new Button();
                Controls.Add(kolejny);

                kolejny.Size = klikniety.Size;
                kolejny.Text = "Nowy";
                kolejny.BackColor = Color.Green;
                kolejny.Location = new Point(klikniety.Location.X,
                                             klikniety.Location.Y + klikniety.Height + 10);
                klikniety.BackColor = Color.Yellow;
                klikniety.Enabled = false;
                kolejny.Click += nowyButton;
            }
             else if (sender is TextBox)
            {
                TextBox klikniety;
                klikniety = (sender as TextBox);
                klikniety.Text = "Poprzedni";
                klikniety.Enabled = false;
                TextBox kolejny = new TextBox();
                kolejny.Text = "Nowy";
                kolejny.Location = new System.Drawing.Point(klikniety.Location.X,
                                             klikniety.Location.Y + klikniety.Height + 10);
                Controls.Add(kolejny);
                kolejny.Click += nowyButton;
            }
            */

            Control klikniety = null;
            Control kolejny = null;

            if (sender is Button)
            {
                klikniety = (sender as Button);
                kolejny = new Button();

            }
            else if (sender is TextBox)
            {
                klikniety = (sender as TextBox);
                kolejny = new TextBox();
            }

            if (kolejny != null && klikniety != null)
            {
                klikniety.Text = "Poprzedni";
                klikniety.Enabled = false;

                kolejny.Text = "Nowy";
                kolejny.Location = new System.Drawing.Point(klikniety.Location.X,
                                             klikniety.Location.Y + klikniety.Height + 10);
                Controls.Add(kolejny);
                kolejny.Click += nowyButton;
            }
             
            /* 
             DEBUGER
             - do programu przekazywane są nazwy zmiennych, metod itp. itd.
             - jak jest błąd wyświetla go i nazywa jaki to jest wyjatek
             - jak najedziemy później na nasze zmienne w kodzie, to wyświetlają się jego wartości np null czy lokalizacja
             - można zaznaczać breakPoint-y dzięki niemu debuger zatrzyma program przed wykonaniem tej linijki(możemy linijka po linijce prześledzik kod żeby znaleźc błąd)
             - kropeczka ze strzałką, po zaznaczeniu dalej widzimy co dzieje się z programem po wykonaniu nastepnyj linii ale nadal przed tym zaznaczenim
             - conditioner potrzebny przy pętlach jeśli coś wykonuje sie milion razy, a chcemy zobaczyć np 2200 wykonanie
             - dzięki niemu możemy ingerować w wartości zmiennych w trakcie diałania programu np dać nazwę zmiennej przy utworzeniu nowego obiektu np TextBox
             */
        }

        private void ostatniaMetoda(object sender, EventArgs e)
        {
            MessageBox.Show("   Obiecuje, juz ostatnie :)");
        }

        private void kolejnaMetoda(object sender, EventArgs e)
        {
            MessageBox.Show("   Kolejne okienko...");
        }

        private void nowaMetoda(object sender, EventArgs e)
        {
            MessageBox.Show("   Nowe :)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Pierwsze okienko!   ");
        }
    }
}

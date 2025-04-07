using Geometria;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab4
{
    public static class ListBoxExtension
    {
        public static void Dodaj(this ListBox listBox, IEnumerable<IWyświetl> obiekty)
        {
            foreach (var obiekt in obiekty)
            {
                listBox.Items.Add(obiekt.PobierzIdentyfikator());
            }
        }
    }
}

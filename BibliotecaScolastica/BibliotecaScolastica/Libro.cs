using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public string annoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int NumeroPagine { get; set; }

        public Libro(string _autore, string _titolo, string _annoPubblicazione, string _editore, int _numeroPagine)
        {
            Autore = _autore;
            Titolo = _titolo;
            annoPubblicazione = _annoPubblicazione;
            Editore = _editore;
            NumeroPagine = _numeroPagine;

        }
    }
}

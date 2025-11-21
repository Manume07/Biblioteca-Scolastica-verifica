using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        // memorizzare il nome indirizzo, orari apertura e chiusura che contiene i Libri
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; }
        public string OrarioChiusura { get; set; }
        public List<Libro> Libri { get; set; }
        public Biblioteca(string _nome, string _indirizzo, string _orarioApertura, string _orarioChiusura)
        {
            Nome = _nome;
            Indirizzo = _indirizzo;
            OrarioApertura = _orarioApertura;
            OrarioChiusura = _orarioChiusura;
            Libri = new List<Libro>();
        }


    }
}

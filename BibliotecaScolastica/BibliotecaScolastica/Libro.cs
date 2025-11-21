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
        public override string ToString()
        {
            return $"Titolo: {Titolo}, Autore: {Autore}, Anno di Pubblicazione: {annoPubblicazione}, Editore: {Editore}, Numero di Pagine: {NumeroPagine}";
        }

        public string ReadingTime()
        {
            if(NumeroPagine<100)
            {
                return "Tempo di lettura pari a 1h";
            }
            else if(NumeroPagine >= 100 && NumeroPagine <=200)
            {
                return "Tempo di lettura pari a 2h";
            }
            else
            {
                return "Tempo di lettura pari a +2h";
            }

        }
        public void AggiungiLibro()
        {
            Console.WriteLine("Inserisci l'autore del libro:");
            string autore = Console.ReadLine();
            Console.WriteLine("Inserisci il titolo del libro:");
            string titolo = Console.ReadLine();
            Console.WriteLine("Inserisci l'anno di pubblicazione del libro:");
            string annoPubblicazione = Console.ReadLine();
            Console.WriteLine("Inserisci l'editore del libro:");
            string editore = Console.ReadLine();
            Console.WriteLine("Inserisci il numero delle pagine del libro:");
            int numeroPagine = int.Parse(Console.ReadLine());
            List<Libro> biblioteca = new List<Libro>();
            biblioteca.Add(new Libro(autore, titolo, annoPubblicazione, editore, numeroPagine));

        }
        public void CercaLibroPerTitolo(string titolo)
        {
            Console.WriteLine("Inserisci il titolo del libro da cercare:");
            titolo = Console.ReadLine();
            for (int i = 0; i < titolo.Length; i++)
            {
                if(titolo == Titolo)
                {
                    Console.WriteLine(this.ToString());
                }
                else
                {
                    Console.WriteLine("Libro non trovato");
                }
            }
        }
        public void CercaLibriPerAutore(string autore)
        {
            Console.WriteLine("Inserisci l'autore del libro da cercare:");
            autore = Console.ReadLine();
            for (int i = 0; i < autore.Length; i++)
            {
                if(autore == Autore)
                {
                    Console.WriteLine(this.ToString());
                }
                else
                {
                    Console.WriteLine("Libro non trovato");
                }
            }
        }   

        public void ContaLibri(List<Libro> biblioteca)
        {
            Console.WriteLine($"Numero totale di libri presenti in biblioteca: {biblioteca.Count}");
        }



    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Composite
{
    public interface Movie  //gerekli interface oluşturldu
    {
        public void showInfos();
    }

    public class Thriller : Movie //interfaceten kalıtım alan film kategorisi
    {

        private int Id;
        private string Name;
        private string releaseDate;
        private double Imdb;

        public Thriller(int id, string name, string releaseDate, double imdb)
        {
            Id = id;
            Name = name;
            this.releaseDate = releaseDate;
            Imdb = imdb;
        }

        public void showInfos()  //override etme işlemi
        {
            Console.WriteLine("film adı " + Name);
            Console.WriteLine("Yayın tarihi " + releaseDate);
            Console.WriteLine("Imbd " + Imdb);
            //Console.WriteLine("film adı " + Name);
        }


    }

    public class Horror : Movie //Aynı şekilde interface'ten yararlnama işlemi
    {

        private int Id;
        private string Name;
        private string releaseDate;
        private Double Imdb;

        public Horror(int id, string name, string releaseDate, double imdb)
        {
            Id = id;
            Name = name;
            this.releaseDate = releaseDate;
            Imdb = imdb;
        }

        public void showInfos()
        {
            Console.WriteLine("Film adi" + Name);
            Console.WriteLine("Yayyın tarihi " + releaseDate);
            Console.WriteLine("Imdb" + Imdb);
            //Console.WriteLine();
        }
    }

    public class MovieContainer : Movie  //Movie container ile eklenen filmler listede kaydediliyor ve tek bir class ile işi çözüyoruz.  
    {
        private List<Movie> movies;

        public void showInfos()
        {
            foreach (var movie in movies)
            {
                movie.showInfos();
            }
        }

        public void AddMovie(Movie movie)
        {
            movies.Add(movie);

        }

        public void RemoveMovie(Movie movie)
        {
            movies.Remove(movie);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

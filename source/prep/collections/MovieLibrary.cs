using System;
using System.Collections.Generic;
using System.Linq;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return this.movies;
    }

    public void add(Movie movie)
    {
      bool found = false;
      for (int i = 0; i < this.movies.Count; i++)
      {
        if ((this.movies[i].date_published == movie.date_published)
            && (this.movies[i].genre == movie.genre)
            && (this.movies[i].production_studio == movie.production_studio)
            && (this.movies[i].rating == movie.rating)
            && (this.movies[i].title == movie.title))
        {
          found = true;
        }
      }
      if (!found)
      {
        this.movies.Add(movie);
      }
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if (this.movies[i].production_studio == ProductionStudio.Pixar)
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if ((this.movies[i].production_studio == ProductionStudio.Pixar)||(this.movies[i].production_studio == ProductionStudio.Disney))
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if (this.movies[i].production_studio != ProductionStudio.Pixar)
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if (this.movies[i].date_published.Year > year)
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if ((this.movies[i].date_published.Year >= startingYear) && (this.movies[i].date_published.Year <= endingYear))
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if (this.movies[i].genre == Genre.kids)
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> all_action_movies()
    {
      IList<Movie> moviesToReturn = new List<Movie>();
      for (int i = 0; i < this.movies.Count; i++)
      {
        if (this.movies[i].genre == Genre.action)
        {
          moviesToReturn.Add(this.movies[i]);
        }
      }
      return moviesToReturn.AsEnumerable();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}

using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using Oskars.Oscars;

namespace Oskars
{
    static class ControlDb
    {
        private static SqlConnection GetConnection()
        {
            string tasks = ConfigurationManager.ConnectionStrings["OscarConnection"].ConnectionString;
            SqlConnection connect = new SqlConnection(tasks);
            connect.Open();
            return connect;
        }

        public static BindingList<AllActorsWinners> GetAllActorsWinners(string win, int id, string sex)
        {
            BindingList<AllActorsWinners> getNominants = new BindingList<AllActorsWinners>();
            string commandGetWinners = string.Format("SELECT m.name_and_surname, m.age, m.sex, n.year, n.id_nomination, n.movie, n.win FROM Movie_Figures as m INNER JOIN Movie_Nominants as n ON m.name_and_surname = n.figure WHERE n.win = '{0}' AND m.id_profession = {1} AND m.sex = '{2}'", win, id, sex);
            SqlCommand selectWinners = new SqlCommand(commandGetWinners, GetConnection());
            SqlDataReader sqlReader = selectWinners.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {

                    Console.Write(sqlReader.GetValue(0) + " " + sqlReader.GetValue(1) + " " + sqlReader.GetValue(2) + " " + sqlReader.GetValue(3) + " " + sqlReader.GetValue(4) + " " + sqlReader.GetValue(5) + " " + sqlReader.GetValue(6) + " ");
                    AllActorsWinners newNominant = new AllActorsWinners
                    {
                        name_and_surname = sqlReader.GetValue(0).ToString(),
                        age = int.Parse(sqlReader.GetValue(1).ToString()),
                        sex = sqlReader.GetValue(2).ToString(),
                        year = int.Parse(sqlReader.GetValue(3).ToString()),
                        id_nomination = int.Parse(sqlReader.GetValue(4).ToString()),
                        movie = sqlReader.GetValue(5).ToString(),
                        win = sqlReader.GetValue(6).ToString()
                    };

                    getNominants.Add(newNominant);
                }
            }
            return getNominants;
        }

        public static BindingList<FilmByYear> getFilmByYear(int year, decimal budget)
        {
            var list = new BindingList<FilmByYear>();
            string commandGetFilm = string.Format("SELECT m.title, m.year, m.budget, n.id_nomination, n.figure, n.win FROM Movies as m INNER JOIN Movie_Nominants as n ON m.title = n.movie WHERE m.year > {0} AND m.budget > {1}; ", year, budget);
            SqlCommand selectFils = new SqlCommand(commandGetFilm, GetConnection());
            SqlDataReader sqlReader = selectFils.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    FilmByYear newNominant = new FilmByYear
                    {
                        title = sqlReader.GetValue(0).ToString(),
                        year = int.Parse(sqlReader.GetValue(1).ToString()),
                        budget = double.Parse(sqlReader.GetValue(2).ToString()),
                        idNomination = int.Parse(sqlReader.GetValue(3).ToString()),
                        figure = sqlReader.GetValue(4).ToString(),
                        win = sqlReader.GetValue(5).ToString()
                    };
                    list.Add(newNominant);
                }
            }
            return list;
        }

        public static BindingList<SerieFiguresReq> getSerieFigures(int id, int age)
        {
            BindingList<SerieFiguresReq> list = new BindingList<SerieFiguresReq>();
            string commandGetFigures = string.Format("SELECT m.name_and_surname, m.sex, m.age, m.town, n.title, n.year, n.box_office FROM Movie_Figures AS m INNER JOIN Figures_In_Movies AS f ON m.name_and_surname = f.name_and_surname INNER JOIN Movies AS n ON f.title = n.title WHERE m.id_profession = {0} AND m.age < {1}", id, age);
            SqlCommand selectFigures = new SqlCommand(commandGetFigures, GetConnection());
            SqlDataReader sqlReader = selectFigures.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    SerieFiguresReq newNominant = new SerieFiguresReq
                    {
                        nameAndSurname = sqlReader.GetValue(0).ToString(),
                        sex = sqlReader.GetValue(1).ToString(),
                        age = int.Parse(sqlReader.GetValue(2).ToString()),
                        town = sqlReader.GetValue(3).ToString(),
                        title = sqlReader.GetValue(4).ToString(),
                        year = int.Parse(sqlReader.GetValue(5).ToString()),
                        boxOffice = decimal.Parse(sqlReader.GetValue(6).ToString())

                    };
                    list.Add(newNominant);
                }

            }
            return list;
        }

        public static BindingList<FiguresToMovies> getMovieFigures(string town, decimal boxOffice)
        {
            BindingList<FiguresToMovies> list = new BindingList<FiguresToMovies>();
            string commandGetFigures = string.Format("SELECT m.name_and_surname, m.id_profession, m.sex, m.age, f.title, f.year, f.budget FROM Movie_Figures as m INNER JOIN Figures_In_Movies as n ON m.name_and_surname = n.name_and_surname INNER JOIN Movies as f ON n.title = f.title WHERE m.town = '{0}' AND f.box_office > {1}", town, boxOffice);
            SqlCommand selectFigures = new SqlCommand(commandGetFigures, GetConnection());
            SqlDataReader sqlReader = selectFigures.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    FiguresToMovies newNominant = new FiguresToMovies
                    {
                        nameAndSurname = sqlReader.GetValue(0).ToString(),
                        idProfession = int.Parse(sqlReader.GetValue(1).ToString()),
                        sex = sqlReader.GetValue(2).ToString(),
                        age = int.Parse(sqlReader.GetValue(3).ToString()),
                        title = sqlReader.GetValue(4).ToString(),
                        year = int.Parse(sqlReader.GetValue(5).ToString()),
                        budget = decimal.Parse(sqlReader.GetValue(6).ToString())

                    };
                    list.Add(newNominant);
                }

            }
            return list;
        }

        public static void getAllSeries(int from, int to, string channels)
        {

            string commandGetAllSeries = string.Format("SELECT * FROM Series WHERE(completed_seasons BETWEEN {0} AND {1}) AND(TV_Channel IN({2}))", from, to, channels);
            SqlCommand selectSeries = new SqlCommand(commandGetAllSeries, GetConnection());
            SqlDataReader sqlReader = selectSeries.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    Nominant newNominant = new Nominant
                    {
                    };
                }
            }
        }


        public static void Add(object info)
        {
            try
            {
                var ob = (Series)info;
                string commandAddInfo = "Insert Into Series (title,year,TV_Channel,completed_seasons) Values(@title,@year,@TV_Channel,@compleated_seasons)";
                SqlCommand addInfo = new SqlCommand(commandAddInfo, GetConnection());
                addInfo.Parameters.AddWithValue("title", ob.title);
                addInfo.Parameters.AddWithValue("year", ob.year);
                addInfo.Parameters.AddWithValue("TV_Channel", ob.tvChanal);
                addInfo.Parameters.AddWithValue("compleated_seasons", ob.completedSeasons);
                addInfo.ExecuteNonQuery();
            }
            catch
            {
            }
        }

        public static void Remove(string title)
        {
            try
            {

                string commandRemoveInfo = "DELETE  FROM Series WHERE title=@title";
                SqlCommand command = new SqlCommand(commandRemoveInfo, GetConnection());
                command.Parameters.AddWithValue("title", title);
                command.ExecuteNonQuery();
            }
            catch
            {
            }
        }

        public static BindingList<Nominant> SelectAll()
        {
            BindingList<Nominant> getNominants = new BindingList<Nominant>();
            string commandSelectAll = "Select * from nominats";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    Nominant newNominant = new Nominant
                    {
                        name = sqlReader.GetValue(0).ToString(),
                        nominations = (int)sqlReader.GetValue(1),
                        oscars = (int)sqlReader.GetValue(2)
                    };
                    getNominants.Add(newNominant);
                }
            }
            return getNominants;
        }


        public static BindingList<Series> SelectAllFromSeries()
        {
            BindingList<Series> getSeries = new BindingList<Series>();
            string commandSelectAll = "Select * from Series";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    Series newSeries = new Series
                    {
                        title = sqlReader.GetValue(0).ToString(),
                        year = int.Parse(sqlReader.GetValue(1).ToString()),
                        tvChanal = sqlReader.GetValue(2).ToString(),
                        completedSeasons = int.Parse(sqlReader.GetValue(3).ToString())
                    };
                    getSeries.Add(newSeries);
                }
            }
            return getSeries;
        }

        public static BindingList<Movies> SelectAllFromMovies()
        {
            BindingList<Movies> getMovies = new BindingList<Movies>();
            string commandSelectAll = "Select * from Movies";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    Movies newMovies = new Movies
                    {
                        title = sqlReader.GetValue(0).ToString(),
                        year = int.Parse(sqlReader.GetValue(1).ToString()),
                        budegt = double.Parse(sqlReader.GetValue(2).ToString()),
                        boxOffice = decimal.Parse(sqlReader.GetValue(3).ToString())
                    };
                    getMovies.Add(newMovies);
                }
            }
            return getMovies;
        }

        public static BindingList<MovieFigures> SelectAllFromMovieFigures()
        {
            BindingList<MovieFigures> getMovies = new BindingList<MovieFigures>();
            string commandSelectAll = "Select * from Movie_Figures";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    MovieFigures newMovies = new MovieFigures
                    {
                        name = sqlReader.GetValue(0).ToString(),
                        idProfession = int.Parse(sqlReader.GetValue(1).ToString()),
                        sex = sqlReader.GetValue(2).ToString(),
                        age = int.Parse(sqlReader.GetValue(3).ToString()),
                        town = sqlReader.GetValue(4).ToString()
                    };
                    getMovies.Add(newMovies);
                }
            }
            return getMovies;
        }

        public static BindingList<SerieFigures> SelectAllFromSerieFigures()
        {
            BindingList<SerieFigures> getMovies = new BindingList<SerieFigures>();
            string commandSelectAll = "Select * from Serie_Figures";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            while (sqlReader.Read())
            {
                SerieFigures newMovies = new SerieFigures
                {
                    name = sqlReader.GetValue(0).ToString(),
                    idProffesion = int.Parse(sqlReader.GetValue(1).ToString()),
                    sex = sqlReader.GetValue(2).ToString(),
                    age = sqlReader.GetValue(3).ToString(),
                    town = sqlReader.GetValue(4).ToString()
                };
                getMovies.Add(newMovies);
                if (sqlReader.HasRows)
                {
                }
            }
            return getMovies;
        }



        public static BindingList<MovieNominants> SelectAllFromMovieNominants()
        {
            BindingList<MovieNominants> getMovies = new BindingList<MovieNominants>();
            string commandSelectAll = "Select * from Movie_Nominants";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    MovieNominants newMovies = new MovieNominants
                    {
                        id = int.Parse(sqlReader.GetValue(0).ToString()),
                        year = int.Parse(sqlReader.GetValue(1).ToString()),
                        idNomination = int.Parse(sqlReader.GetValue(2).ToString()),
                        figure = sqlReader.GetValue(3).ToString(),
                        movie = sqlReader.GetValue(4).ToString(),
                        win = sqlReader.GetValue(4).ToString()
                    };
                    getMovies.Add(newMovies);
                }
            }
            return getMovies;
        }

        public static BindingList<SerieNominants> SelectAllFromSerieNominants()
        {
            BindingList<SerieNominants> getMovies = new BindingList<SerieNominants>();
            string commandSelectAll = "Select year, figure, series, win from Series_Nominants";
            SqlCommand selectInfo = new SqlCommand(commandSelectAll, GetConnection());
            SqlDataReader sqlReader = selectInfo.ExecuteReader();
            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    SerieNominants newMovies = new SerieNominants
                    {
                        //id = int.Parse(sqlReader.GetValue(0).ToString()),
                        year = int.Parse(sqlReader.GetValue(0).ToString()),
                        //idNomination = int.Parse(sqlReader.GetValue(2).ToString()),
                        figure = sqlReader.GetValue(1).ToString(),
                        series = sqlReader.GetValue(2).ToString(),
                        win = sqlReader.GetValue(3).ToString()
                    };
                    getMovies.Add(newMovies);
                }
            }
            return getMovies;
        }
    }
}

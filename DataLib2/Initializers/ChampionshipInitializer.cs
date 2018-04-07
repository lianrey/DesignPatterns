using System;
using DataLib2.Entities;
using DataLib2.Interfaces;
using System.Collections.Generic;

namespace DataLib2.Initializers
{
    public class ChampionshipInitializer : IInitializer<Championship>
    {
        public IEnumerable<Championship> Result { get; private set; }

        public void Initialize()
        {
            Result = new List<Championship>
            {
                new Championship
                {
                    Year = 1950,
                    First = "Nino Farina",
                    Second = "Juan Manuel Fangio",
                    Third = "Luigi Fagioli"
                },
                new Championship
                {
                    Year = 1951,
                    First = "Juan Manuel Fangio",
                    Second = "Alberto Ascari",
                    Third = "Froilan Gonzalez"
                },
                new Championship
                {
                    Year = 1952,
                    First = "Alberto Ascari",
                    Second = "Nino Farina",
                    Third = "Piero Taruffi"
                },
                new Championship
                {
                    Year = 1953,
                    First = "Alberto Ascari",
                    Second = "Juan Manuel Fangio",
                    Third = "Nino Farina"
                },
                new Championship
                {
                    Year = 1954,
                    First = "Juan Manuel Fangio",
                    Second = "Froilan Gonzalez",
                    Third = "Mike Hawthorn"
                },
                new Championship
                {
                    Year = 1955,
                    First = "Juan Manuel Fangio",
                    Second = "Stirling Moss",
                    Third = "Eugenio Castellotti"
                },
                new Championship
                {
                    Year = 1956,
                    First = "Juan Manuel Fangio",
                    Second = "Stirling Moss",
                    Third = "Peter Collins"
                },
                new Championship
                {
                    Year = 1957,
                    First = "Juan Manuel Fangio",
                    Second = "Stirling Moss",
                    Third = "Luigi Musso"
                },
                new Championship
                {
                    Year = 1958,
                    First = "Mike Hawthorn",
                    Second = "Stirling Moss",
                    Third = "Tony Brooks"
                },
                new Championship
                {
                    Year = 1959,
                    First = "Jack Brabham",
                    Second = "Tony Brooks",
                    Third = "Stirling Moss"
                },
                new Championship
                {
                    Year = 1960,
                    First = "Jack Brabham",
                    Second = "Bruce McLaren",
                    Third = "Stirling Moss"
                },
                new Championship
                {
                    Year = 1961,
                    First = "Phil Hill",
                    Second = "Wolfgang von Trips",
                    Third = "Stirling Moss"
                },
                new Championship
                {
                    Year = 1962,
                    First = "Graham Hill",
                    Second = "Jim Clark",
                    Third = "Bruce McLaren"
                },
                new Championship
                {
                    Year = 1963,
                    First = "Jim Clark",
                    Second = "Graham Hill",
                    Third = "Richie Ginther"
                },
                new Championship
                {
                    Year = 1964,
                    First = "John Surtees",
                    Second = "Graham Hill",
                    Third = "Jim Clark"
                },
                new Championship
                {
                    Year = 1965,
                    First = "Jim Clark",
                    Second = "Graham Hill",
                    Third = "Jackie Stewart"
                },
                new Championship
                {
                    Year = 1966,
                    First = "Jack Brabham",
                    Second = "John Surtees",
                    Third = "Jochen Rindt"
                },
                new Championship
                {
                    Year = 1967,
                    First = "Dennis Hulme",
                    Second = "Jack Brabham",
                    Third = "Jim Clark"
                },
                new Championship
                {
                    Year = 1968,
                    First = "Graham Hill",
                    Second = "Jackie Stewart",
                    Third = "Dennis Hulme"
                },
                new Championship
                {
                    Year = 1969,
                    First = "Jackie Stewart",
                    Second = "Jackie Ickx",
                    Third = "Bruce McLaren"
                },
                new Championship
                {
                    Year = 1970,
                    First = "Jochen Rindt",
                    Second = "Jackie Ickx",
                    Third = "Clay Regazzoni"
                },
                new Championship
                {
                    Year = 1971,
                    First = "Jackie Stewart",
                    Second = "Ronnie Peterson",
                    Third = "Francois Cevert"
                },
                new Championship
                {
                    Year = 1972,
                    First = "Emerson Fittipaldi",
                    Second = "Jackie Stewart",
                    Third = "Dennis Hulme"
                },
                new Championship
                {
                    Year = 1973,
                    First = "Jackie Stewart",
                    Second = "Emerson Fittipaldi",
                    Third = "Ronnie Peterson"
                },
                new Championship
                {
                    Year = 1974,
                    First = "Emerson Fittipaldi",
                    Second = "Clay Regazzoni",
                    Third = "Jody Scheckter"
                },
                new Championship
                {
                    Year = 1975,
                    First = "Niki Lauda",
                    Second = "Emerson Fittipaldi",
                    Third = "Carlos Reutemann"
                },
                new Championship
                {
                    Year = 1976,
                    First = "James Hunt",
                    Second = "Niki Lauda",
                    Third = "Jody Scheckter"
                },
                new Championship
                {
                    Year = 1977,
                    First = "Niki Lauda",
                    Second = "Jody Scheckter",
                    Third = "Mario Andretti"
                },
                new Championship
                {
                    Year = 1978,
                    First = "Mario Andretti",
                    Second = "Ronnie Peterson",
                    Third = "Carlos Reutemann"
                },
                new Championship
                {
                    Year = 1979,
                    First = "Jody Scheckter",
                    Second = "Gilles Villeneuve",
                    Third = "Alan Jones"
                },
                new Championship
                {
                    Year = 1980,
                    First = "Alan Jones",
                    Second = "Nelson Piquet",
                    Third = "Carlos Reutemann"
                },
                new Championship
                {
                    Year = 1981,
                    First = "Nelson Piquet",
                    Second = "Carlos Reutemann",
                    Third = "Alan Jones"
                },
                new Championship
                {
                    Year = 1982,
                    First = "Keke Rosberg",
                    Second = "Didier Pironi",
                    Third = "John Watson"
                },
                new Championship
                {
                    Year = 1983,
                    First = "Nelson Piquet",
                    Second = "Alain Prost",
                    Third = "Rene Arnoux"
                },
                new Championship
                {
                    Year = 1984,
                    First = "Niki Lauda",
                    Second = "Alain Prost",
                    Third = "Elio de Angelis"
                },
                new Championship
                {
                    Year = 1985,
                    First = "Alain Prost",
                    Second = "Michele Alboreto",
                    Third = "Keke Rosberg"
                },
                new Championship
                {
                    Year = 1986,
                    First = "Alain Prost",
                    Second = "Nigel Mansell",
                    Third = "Nelson Piquet"
                },
                new Championship
                {
                    Year = 1987,
                    First = "Nelson Piquet",
                    Second = "Nigel Mansell",
                    Third = "Ayrton Senna"
                },
                new Championship
                {
                    Year = 1988,
                    First = "Ayrton Senna",
                    Second = "Alain Prost",
                    Third = "Gerhard Berger"
                },
                new Championship
                {
                    Year = 1989,
                    First = "Alain Prost",
                    Second = "Ayrton Senna",
                    Third = "Riccardo Patrese"
                },
                new Championship
                {
                    Year = 1990,
                    First = "Ayrton Senna",
                    Second = "Alain Prost",
                    Third = "Nelson Piquet"
                },
                new Championship
                {
                    Year = 1991,
                    First = "Ayrton Senna",
                    Second = "Nigel Mansell",
                    Third = "Riccardo Patrese"
                },
                new Championship
                {
                    Year = 1992,
                    First = "Nigel Mansell",
                    Second = "Riccardo Patrese",
                    Third = "Michael Schumacher"
                },
                new Championship
                {
                    Year = 1993,
                    First = "Alain Prost",
                    Second = "Ayrton Senna",
                    Third = "Damon Hill"
                },
                new Championship
                {
                    Year = 1994,
                    First = "Michael Schumacher",
                    Second = "Damon Hill",
                    Third = "Gerhard Berger"
                },
                new Championship
                {
                    Year = 1995,
                    First = "Michael Schumacher",
                    Second = "Damon Hill",
                    Third = "David Coulthard"
                },
                new Championship
                {
                    Year = 1996,
                    First = "Damon Hill",
                    Second = "Jacques Villeneuve",
                    Third = "Michael Schumacher"
                },
                new Championship
                {
                    Year = 1997,
                    First = "Jacques Villeneuve",
                    Second = "Heinz-Harald Frentzen",
                    Third = "David Coulthard"
                },
                new Championship
                {
                    Year = 1998,
                    First = "Mika Hakkinen",
                    Second = "Michael Schumacher",
                    Third = "David Coulthard"
                },
                new Championship
                {
                    Year = 1999,
                    First = "Mika Hakkinen",
                    Second = "Eddie Irvine",
                    Third = "Heinz-Harald Frentzen"
                },
                new Championship
                {
                    Year = 2000,
                    First = "Michael Schumacher",
                    Second = "Mika Hakkinen",
                    Third = "David Coulthard"
                },
                new Championship
                {
                    Year = 2001,
                    First = "Michael Schumacher",
                    Second = "David Coulthard",
                    Third = "Rubens Barrichello"
                },
                new Championship
                {
                    Year = 2002,
                    First = "Michael Schumacher",
                    Second = "Rubens Barrichello",
                    Third = "Juan Pablo Montoya"
                },
                new Championship
                {
                    Year = 2003,
                    First = "Michael Schumacher",
                    Second = "Kimi Räikkönen",
                    Third = "Juan Pablo Montoya"
                },
                new Championship
                {
                    Year = 2004,
                    First = "Michael Schumacher",
                    Second = "Rubens Barrichello",
                    Third = "Jenson Button"
                },
                new Championship
                {
                    Year = 2005,
                    First = "Fernando Alonso",
                    Second = "Kimi Räikkönen",
                    Third = "Michael Schumacher"
                },
                new Championship
                {
                    Year = 2006,
                    First = "Fernando Alonso",
                    Second = "Michael Schumacher",
                    Third = "Felipe Massa"
                },
                new Championship
                {
                    Year = 2007,
                    First = "Kimi Räikkönen",
                    Second = "Lewis Hamilton",
                    Third = "Fernando Alonso"
                },
                new Championship
                {
                    Year = 2008,
                    First = "Lewis Hamilton",
                    Second = "Felipe Massa",
                    Third = "Kimi Raikkonen"
                },
                new Championship
                {
                    Year = 2009,
                    First = "Jenson Button",
                    Second = "Sebastian Vettel",
                    Third = "Rubens Barrichello"
                },
                new Championship
                {
                    Year = 2010,
                    First = "Sebastian Vettel",
                    Second = "Fernando Alonso",
                    Third = "Mark Webber"
                },
                new Championship
                {
                    Year = 2011,
                    First = "Sebastian Vettel",
                    Second = "Jenson Button",
                    Third = "Mark Webber"
                },
                new Championship
                {
                    Year = 2012,
                    First = "Sebastian Vettel",
                    Second = "Fernando Alonso",
                    Third = "Kimi Raikkonen"
                },
                new Championship
                {
                    Year = 2013,
                    First = "Sebastian Vettel",
                    Second = "Fernando Alonso",
                    Third = "Mark Webber"
                },
                new Championship
                {
                    Year = 2014,
                    First = "Lewis Hamilton",
                    Second = "Nico Rosberg",
                    Third = "Daniel Ricciardo"
                },
                new Championship
                {
                    Year = 2015,
                    First = "Lewis Hamilton",
                    Second = "Nico Rosberg",
                    Third = "Sebastian Vettel"
                },
                new Championship
                {
                    Year = 2016,
                    First = "Nico Rosberg",
                    Second = "Lewis Hamilton",
                    Third = "Daniel Ricciardo"
                }
            };
        }

    }
}

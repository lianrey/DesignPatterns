﻿using System;
using System.Collections.Generic;
using DataLib2.Entities;
using DataLib2.Interfaces;

namespace DataLib2.Initializers
{
    public class TeamInitializer : IInitializer<Team>
    {
        public IEnumerable<Team> Result { get; private set; }

        public void Initialize()
        {
            Result = new List<Team>()
            {
                new Team("Vanwall", 1958),
                new Team("Cooper", 1959, 1960),
                new Team("Ferrari", 1961, 1964, 1975, 1976, 1977, 1979, 1982, 1983, 1999, 2000, 2001, 2002, 2003, 2004, 2007, 2008),
                new Team("BRM", 1962),
                new Team("Lotus", 1963, 1965, 1968, 1970, 1972, 1973, 1978),
                new Team("Brabham", 1966, 1967),
                new Team("Matra", 1969),
                new Team("Tyrrell", 1971),
                new Team("McLaren", 1974, 1984, 1985, 1988, 1989, 1990, 1991, 1998),
                new Team("Williams", 1980, 1981, 1986, 1987, 1992, 1993, 1994, 1996, 1997),
                new Team("Benetton", 1995),
                new Team("Renault", 2005, 2006 ),
                new Team("Brawn GP", 2009),
                new Team("Red Bull Racing", 2010, 2011, 2012, 2013),
                new Team("Mercedes", 2014, 2015, 2016)
            };
        }
    }
}

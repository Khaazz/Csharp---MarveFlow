﻿using MarvelFlow.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarvelFlow.App.Lib
{
    public static class AppUtils
    {
        public static bool ValidMail(string mail)
        {
            Regex r = new Regex(@".*@.*\..*", RegexOptions.IgnoreCase);

            return r.IsMatch(mail);
        }

        public static bool ValidName(string input)
        {
            Regex r = new Regex(@"[A-Z][a-z]*[a-z -][A-Za-z][a-z]*");

            return r.IsMatch(input);
        }

        public static bool ValidNameHero(string input)
        {
            Regex r = new Regex(@"^([A-Z][a-z]*( [A-Za-z][a-z]*)*)$");

            return r.IsMatch(input);
        }

        public static bool IsIdMovieValid (string input)
        {
            Regex r = new Regex(@"^[A-Za-z][A-Za-z]([0-9])*$");
            return r.IsMatch(input);
        }

        public static bool IsDisplayListValid (string input)
        {
            Regex r = new Regex(@"^([A-Za-z][A-Za-z]([0-9])*, )*[A-Za-z][A-Za-z]([0-9])*$");

            return r.IsMatch(input);

        }

        public static bool IsIdHeroValid (string input)
        {
            Regex r = new Regex(@"^[A-Za-z][A-Za-z]$");
            return r.IsMatch(input);
        }

        public static string ConvertList(List<Hero> listHero)
        {

            return String.Join(", ", listHero.Select(h => h.Id));
        }

        public static List<string> ConvertStringToList(string listHero)
        {
            Regex r = new Regex(@", ");
            return r.Split(listHero).ToList();
        }
    }
}

﻿using System;

namespace LeagueOfLegends.Helpers.Generics {
    public class Singleton<T> where T : class, new() {
        protected Singleton() {
        }

        private static readonly Lazy<T> _instance = new Lazy<T>(() => new T());

        public static T Instance => _instance.Value;
    }
}
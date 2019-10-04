using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VincularPropriedade
{
    public static class DataSource
    {

        static DataSource()
        {

        }
        public static List<Pessoa> getPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa() { ID = 1, Nome = "João", Pais = "Brasil"},
                new Pessoa() { ID = 2, Nome = "Maria", Pais = "Peru"},
                new Pessoa() { ID = 3, Nome = "Pedro", Pais = "Espanha"},
                new Pessoa() { ID = 4, Nome = "Thiago", Pais = "Portugal"},
                new Pessoa() { ID = 5, Nome = "Marcos", Pais = "Brasil"}
            };
            return pessoas;
        }

        //public static List<Filtro> getFiltros()
        //{
        //    List<Filtro> filtros = new List<Filtro>()
        //    {
        //        new Filtro() {Nome = "Switch 1", isOn = true },
        //        new Filtro() {Nome = "Switch 2", isOn = true },
        //        new Filtro() {Nome = "Switch 3", isOn = false },
        //        new Filtro() {Nome = "Switch 4", isOn = false },
        //        new Filtro() {Nome = "Switch 5", isOn = true }
        //    };
        //    return filtros;
        //}


        public static ObservableCollection<Filtro> getFiltros2()
        {
            ObservableCollection<Filtro> filtros = new ObservableCollection<Filtro>()
            {
                new Filtro("Switch 1", true),
                new Filtro("Switch 2", false),
                new Filtro("Switch 3", true),
                new Filtro("Switch 4", false),
                new Filtro("Switch 5", true),

            };
            return filtros;
        }







    }
}

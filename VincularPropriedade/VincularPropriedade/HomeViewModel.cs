using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace VincularPropriedade
{
    public static class HomeViewModel
    {
        public static ObservableCollection<Filtro> filtros { get; set; }

        static HomeViewModel()
        {
            HomeViewModel.filtros = DataSource.getFiltros2();
        }
    }
}

using NorthWind.Commands;
using NorthWind.ViewModels;
using SelectAuthor_MVVM.Models;
using SelectAuthor_MVVM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SelectAuthor_MVVM.ViewModels
{
    public class AppViewModel : BaseViewModel
    {

        private List<Author> authors;

        public List<Author> Authors
        {
            get { return authors; }
            set { authors = value; OnPropertyChanged(); }
        }


        public ListView listview { get; set; }
        public MainWindow mainwindow { get; set; }
        public RelayCommand ClickCommand { get; set; }


        public AppViewModel()
        {
            

                AuthorRepository.GetAllAuthors();
                Authors = AuthorRepository.AuthorRepo;
        }


    }
}

using Burger_app.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Burger_app.Models
{
    class LandingViewModel : BaseViewModel
    {

        public LandingViewModel()
        {
            burgers = GetBurgers();
        }
       public ObservableCollection<Burger> burgers 
        { 
            get { return burgers; }
            set
            {
                burgers = value;
                OnPropertyChanged();
            }
        }

        private Burger selectedBurger;

        public Burger SelectedBurger
        {
            get { return selectedBurger; }
            set
            {
                selectedBurger = value;
                OnPropertyChanged();
            }
        }

        public ICommand SelectedCommand => new Command(DisplayBurger);

        private void DisplayBurger()
        {
            
        }

        public ObservableCollection<Burger> GetBurgers()
        {
            return new ObservableCollection<Burger>
            {
                new Burger { Name = "CLASSIC", Price = 12.99f, Image = "classic.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burger { Name = "DOUBLE", Price = 19.99f, Image = "two.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burger { Name = "SHARK", Price = 17.29f, Image = "shark.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burger { Name = "CHICKEN", Price = 15.99f, Image = "chicken.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burger { Name = "MEAT", Price = 11.99f, Image = "meat.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"},
                new Burger { Name = "BBQ", Price = 13.99f, Image = "bbq.png", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Bibendum est ultricies"}
            };
        }
        }
    }
}

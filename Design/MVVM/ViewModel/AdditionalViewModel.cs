using Design.Core;
using Design.MVVM.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace Design.MVVM.ViewModel
{
    class AdditionalViewModel
    {
        DataRepository _repo;
        public ObservableCollection<Product> Products { get; set; }
        public RelayCommand removeCommand;
        public AdditionalViewModel()
        {
            var _dbcontext = new VegDbContext();
            _repo = new DataRepository(_dbcontext);

            Products = new ObservableCollection<Product>();

            _repo.GetData<Product>().ToList().ForEach(o => Products.Add(o));
        }

        public Product selectedItem;
        public Product SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
            }
        }

        public RelayCommand RemoveCommand => removeCommand ??
                    (removeCommand = new RelayCommand(o =>
                    {
                        Products.Remove((Product)o);
                    }));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace Grapics_ModernUI.ViewModels
{
    public class GraphicsViewModel : Screen
    {
        public GraphicsViewModel()
        {
            LoadChartContents();
        }
        private IObservableCollection<FinancialStuff> _financialStuffList;

        public IObservableCollection<FinancialStuff> FinancialStuffList
        {
            get { return _financialStuffList; }
            set
            {
                _financialStuffList = value;
                NotifyOfPropertyChange(() => FinancialStuffList);
            }
        }

        public class FinancialStuff
        {
            public string Name { get; set; }
            public int Amount { get; set; }
        }

        private void LoadChartContents()
        {
            Random rand = new Random();
            FinancialStuffList = new BindableCollection<FinancialStuff>
            {
                new FinancialStuff() {Name = "MSFT", Amount = rand.Next(0, 200)},
                new FinancialStuff() {Name = "AAPL", Amount = rand.Next(0, 200)},
                new FinancialStuff() {Name = "GOOG", Amount = rand.Next(0, 200)},
                new FinancialStuff() {Name = "BBRY", Amount = rand.Next(0, 200)},
            };
        }
    }
}

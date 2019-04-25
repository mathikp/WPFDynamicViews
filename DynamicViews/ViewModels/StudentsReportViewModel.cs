using DynamicViews.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DynamicViews.ViewModels
{
    public class StudentsReportViewModel : INotifyPropertyChanged, IReportViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string id;
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != this.name)
                {
                    this.name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public StudentsReportViewModel()
        {

        }

        public void GenerateReport()
        {
            System.Windows.MessageBox.Show($"Id = {Id}, Name = {Name}");
        }
    }
}

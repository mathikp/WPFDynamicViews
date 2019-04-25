using DynamicViews.Models;
using DynamicViews.ViewModels;
using System.Collections.Generic;
using System.Windows.Input;

namespace DynamicViews
{
    public class MainWindowViewModel
    {
        private ICommand _generateReportCommand;
        public Report SelectedReport { get; set; }

        public List<Report> Reports { get; set; }

        public ICommand GenerateReportCommand
        {
            get
            {
                if (_generateReportCommand == null)
                {
                    _generateReportCommand = new RelayCommand(
                        p => GenerateReport()
                        );
                }

                return _generateReportCommand;
            }
        }

        public MainWindowViewModel()
        {
            Reports = new List<Report>
            {
                new Report{ Name = "Students Report", ViewModel = new StudentsReportViewModel()},
                new Report{ Name = "Marks Report", ViewModel = new MarksReportViewModel()}
            };

            SelectedReport = Reports[0];
        }

        public void GenerateReport()
        {
            SelectedReport.ViewModel.GenerateReport();
        }
    }
}

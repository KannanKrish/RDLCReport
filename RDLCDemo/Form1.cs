using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace RDLCDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setting Report Viewer RDLC File
            // Using Embedded Resources
            //reportViewer1.LocalReport.ReportEmbeddedResource = GetType().Namespace + ".DemoReport.rdlc";

            //using File Path. For that RDLC file need to copy inside executable file.
            reportViewer1.LocalReport.ReportPath = "DemoReport.rdlc";

            //Setting Parameters for RDLC Report
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Header", "My Header"));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("Footer", "My Footer"));

            // Loading DataSource in Report Viewer
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("StudentDataSet",Student.GetStudents()));
            
            // Refreshing the Report Viewer
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}

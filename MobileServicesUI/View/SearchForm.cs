using MobileServicesLibrary;
using MobileServicesLibrary.Models;
using MobileServicesUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileServicesUI.View
{
    public partial class SearchForm : Form
    {
        string searchTerm;
        private LoadingFormFunct loadingForm = new LoadingFormFunct();
        public SearchForm(String searchTerm)
        {
            InitializeComponent();
            this.searchTerm = searchTerm;

            PopulateForm();

        }

        private void PopulateForm()
        {
            loadingForm.Show();
            this.flowLayoutPanelSearch.Controls.Clear();
            try
            {
                List<ServiceModel> services = GlobalConfig.databaseConnection.GetSearchResults(searchTerm);
                if(services.Count != 0)
                {
                    SearchPanel.Hide();
                    ServicesPopulator.Initialize(this.flowLayoutPanelSearch, services, true);
                    loadingForm.Close();


                }
                else
                {
                    label1.Text = $"Sorry No services matching {searchTerm} found ,try searching with a different term";
                    SearchPanel.Show();
                    loadingForm.Close();
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                label1.Text = $"Sorry something went wrong, \n{e.Message}";
                SearchPanel.Show();
                loadingForm.Close();
            }
        }
    }
}

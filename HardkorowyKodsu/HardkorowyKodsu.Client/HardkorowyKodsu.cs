using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace HardkorowyKodsu.Client
{
    public partial class HardkorowyKodsu : Form
    {
        static HttpClient client = new HttpClient();

        public HardkorowyKodsu()
        {
            InitializeHttpClient();
            InitializeComponent();
        }
        private void InitializeHttpClient()
        {
            client.BaseAddress = new Uri(Configuration.ServerConfiguration.APIUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private async void GetTables(object sender, EventArgs e)
        {
            try
            {
                var response = await client.GetStringAsync(Configuration.ServerConfiguration.TablesController);
                var data = JsonConvert.DeserializeObject<List<string>>(response);
                this.tablesViewsListBox.DataSource = data;
            }
            catch(HttpRequestException httpRequestException)
            {
                MessageBox.Show(string.Format("Failed to acquire Tables/Views from the DB due to the following error: '{0}'", httpRequestException.Message));
            }
        }


        private async void GetColumns(object sender, EventArgs e)
        {
            if (tablesViewsListBox.SelectedValue == null)
                return;

            try
            {
                var selectedTable = tablesViewsListBox.SelectedValue.ToString();
                var response = await client.GetStringAsync(Configuration.ServerConfiguration.ColumnsController + selectedTable);

                var data = JsonConvert.DeserializeObject<List<string>>(response);
                this.tableViewColumnsListBox.DataSource = data;
            }
            catch (HttpRequestException httpRequestException)
            {
                MessageBox.Show(string.Format("Failed to acquire Table/View columns from the DB due to the following error: '{0}'", httpRequestException.Message));
            }
        }

        private void refreshTablesButton_Click(object sender, EventArgs e)
        {
            GetTables(sender, e);
        }
    }
}

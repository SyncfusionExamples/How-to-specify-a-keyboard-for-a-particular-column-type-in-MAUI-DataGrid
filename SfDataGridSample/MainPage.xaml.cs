using Syncfusion.Maui.DataGrid;
using System.Data;
using System.Reflection;
namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dataGrid.CellRenderers.Remove("Text");
            dataGrid.CellRenderers.Add("Text", new CustomTextBoxRenderer());
        }

    } 

    public class CustomTextBoxRenderer : DataGridTextBoxCellRenderer
    {
        protected override SfDataGridEntry OnCreateEditUIView()
        {
            var entry = base.OnCreateEditUIView();
            entry.Keyboard = Keyboard.Numeric;
            return entry;
        }
    }
}

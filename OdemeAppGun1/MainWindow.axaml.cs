using Avalonia.Controls;
using Avalonia.Interactivity;
using OdemeAppGun1.SOLID;

namespace OdemeAppGun1
{

     public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var btn = this.FindControl<Button>("btnOdemeYap");
            if (btn != null)
            {
                btn.Click += btnOdemeYap_Click;
            }
        }

        private void btnOdemeYap_Click(object? sender, RoutedEventArgs e)
        {
            // Get references to controls
            var combo = this.FindControl<ComboBox>("cmbLogTipi");
            var txt = this.FindControl<TextBox>("txtTutar");
            var lbl = this.FindControl<TextBlock>("lblSonuc");

            if (combo?.SelectedItem is ComboBoxItem selectedItem && txt != null && lbl != null)
            {
                string displayName = selectedItem.Content?.ToString() ?? "";
                string className = OdemeAppGun1.SOLID.LogOptionMapper.MapDisplayNameToClassName(displayName);

                //Reflection
                LogFactory factory = new LogFactory();
                ILog iLog = factory.yeniNesneOlustur(className);

                string result = iLog.log(txt.Text);
                lbl.Text = result;
            }
        }
    }
}
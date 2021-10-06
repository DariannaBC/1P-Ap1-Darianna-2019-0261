using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using _1P_Ap1_Darianna_2019_0261.Entidades;
using _1P_Ap1_Darianna_2019_0261.BLL;



namespace _1P_Ap1_Darianna_2019_0261.UI
{
    /// <summary>
    /// Interaction logic for ConsultaAportes.xaml
    /// </summary>
    public partial class ConsultaAportes : Window
    {
        public ConsultaAportes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = AportesBLL.GetList(j => j.persona.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 1:
                        listado = AportesBLL.GetList(j => j.concepto.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = listado.Where(e => e.fecha.Date >= DesdeDataPicker.SelectedDate).ToList();

            if (HastaDatePicker.SelectedDate != null)
                listado = listado.Where(e => e.fecha.Date <= HastaDatePicker.SelectedDate).ToList();

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

            MontoTextBox.Text = listado.Sum(y => y.monto).ToString();
            ConteoTextBox.Text = listado.Count().ToString();
        }
    }
}

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
using DataBase.loggin;
using SQLite;

namespace DataBase
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Usuario> usuarios;
        public Window1()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            LeerBaseDatos();
        }
        void LeerBaseDatos()
        {
            using (SQLite.SQLiteConnection conn =
               new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Usuario>();
                usuarios = (conn.Table<Usuario>().ToList()).
                    OrderBy(c => c.Nombre).ToList();
            }
            if (usuarios != null)
            {
                lvUsuarios.ItemsSource = usuarios;
            }
        }
        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            DataBase.MainWindow form = new DataBase.MainWindow();
            form.ShowDialog();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Eliminar form = new DataBase.Eliminar();
            form.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Sample01();
            Sample02();
        }

        public void Sample01()
        {
            Task t1 = new Task(() => MessageBox.Show("mensaje"));
            t1.Start();

            AddMessage("Final de hila principal",0);
        }

        public void Sample02()
        {
            Task t1 = new Task(() => MessageBox.Show("mensaje"));
            t1.Start();

            Task t2 = new Task(() => AddMessage("Ejecutando tarea 2", 5));
            t2.Start();

            Task t3 = new Task(() => AddMessage("Ejecutando tarea 3", 5));
            t3.Start();

            Task t4 = new Task(() => AddMessage("Ejecutando tarea 4", 5));
            t4.Start();

            AddMessage("Final de hila principal", 0);
        }

        void AddMessage(string message, int seconds)
        {
            Thread.Sleep(1000 * seconds);

            var hilo = Thread.CurrentThread.ManagedThreadId;

            this.Dispatcher.Invoke(() =>
                                    {
                                        MessageLabel.Content += $"Mensaje: {message}, " +
                                                                $"Hola Actual:{hilo} \n ";
                                    });


        }
    }
}

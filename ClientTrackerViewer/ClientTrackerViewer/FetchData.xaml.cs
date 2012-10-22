using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace ClientTrackerViewer
{
    /// <summary>
    /// Interaction logic for FetchData.xaml
    /// </summary>
    public partial class FetchData : UserControl
    {
        public FetchData()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open a clientTracker.xml file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenDataFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.DefaultExt = ".xml";
            if ((bool)of.ShowDialog())
            {
                string t = of.FileName;
                using (TextReader tr = new StreamReader(t))
                {
                    var s = tr.ReadToEnd();
                }
            }
        }
    }
}

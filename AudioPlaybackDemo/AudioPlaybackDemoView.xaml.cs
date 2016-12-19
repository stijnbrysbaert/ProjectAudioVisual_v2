using NAudioWpfDemo.DMX;
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

namespace NAudioWpfDemo
{
    /// <summary>
    /// Interaction logic for AudioPlaybackDemo.xaml
    /// </summary>
    public partial class AudioPlaybackDemoView : UserControl
    {
        public AudioPlaybackDemoView()
        {
            InitializeComponent();
        }

        private void sldrPattern_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VerwerkData.patternCode = Convert.ToInt16(e.NewValue);
        }

        private void sldrGroup_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            VerwerkData.groupCode = Convert.ToInt16(e.NewValue);
        }

        private void cboPorts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

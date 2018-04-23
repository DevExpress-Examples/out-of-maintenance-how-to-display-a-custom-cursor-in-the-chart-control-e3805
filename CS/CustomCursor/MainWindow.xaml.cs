using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using DevExpress.Xpf.Charts;

namespace CustomCursor {

    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void chartControl1_QueryChartCursor(object sender, QueryChartCursorEventArgs e) {
            e.Cursor = Cursors.None;
            e.CursorImage = new BitmapImage(new Uri(@"/CustomCursor;component/mycursor.png", UriKind.Relative));
        }

    }

}

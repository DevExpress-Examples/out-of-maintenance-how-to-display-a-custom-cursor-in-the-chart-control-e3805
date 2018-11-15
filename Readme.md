<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomCursor/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/CustomCursor/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/CustomCursor/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/CustomCursor/MainWindow.xaml))
<!-- default file list end -->
# How to display a custom cursor in the chart control


<p>This example shows how to display a custom cursor when the mouse pointer is hovering over  the chart control. </p>


<h3>Description</h3>

<p>To accomplish this task, handle the  <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsChartControl_QueryChartCursortopic"><u>ChartControl.QueryChartCursor</u></a> event and assign your custom image (e.g., a <strong>Bit</strong><strong>m</strong><strong>apImage </strong>object loaded from application resources) to the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsQueryChartCursorEventArgs_CursorImagetopic"><u>QueryChartCursorEventArgs.CursorImage</u></a> property.</p><p>Note that you need to include your image in the project and set the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsQueryChartCursorEventArgs_Cursortopic"><u>QueryChartCursorEventArgs.Cursor</u></a> property to <strong>None </strong>to see the custom image in the chart control. </p>

<br/>



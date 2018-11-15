<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/DXGrid_PreventGroupRowsFromExpanding/Window1.xaml) (VB: [Window1.xaml.vb](./VB/DXGrid_PreventGroupRowsFromExpanding/Window1.xaml.vb))
* [Window1.xaml.cs](./CS/DXGrid_PreventGroupRowsFromExpanding/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/DXGrid_PreventGroupRowsFromExpanding/Window1.xaml.vb))
<!-- default file list end -->
# How to Prevent Group Rows from being Expanded


<p>The following example shows how to customize whether a particular group row can be expanded.</p><p>In this example, the 'Status: Invalidated' group row is prevented from being expanded, and the full expanding is disabled. To do this, the GroupRowExpanding event is handled, and the event parameter's Allow property is set to false when the RowHandle property returns the 'Status: Invalidated' row's handle, or an invalid handle (this happens when all group rows are about to be expanded).</p>

<br/>



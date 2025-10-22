# How to Bind Columns from ViewModel in WPF / UWP TreeGrid in MVVM?

This example illustrates to bind the columns from ViewModel in [WPF TreeGrid](https://www.syncfusion.com/wpf-controls/treegrid) and [UWP TreeGrid](https://www.syncfusion.com/uwp-ui-controls/treegrid) (SfTreeGrid).

You can bind the [SfTreeGrid.Columns](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeGrid.SfTreeGrid.html#Syncfusion_UI_Xaml_TreeGrid_SfTreeGrid_Columns) property in ViewModel by having the binding property of **Syncfusion.SfGrid.UI.Xaml.TreeGrid.Columns** type. Thus, you can set binding to the **SfTreeGrid.Columns** property that provides DataContext of TreeGrid in ViewModel.

### XAML:

```xml
<syncfusion:SfTreeGrid Name="treeGrid" 
                       Grid.Row="1" 
                       ChildPropertyName="ReportsTo"  
                       AutoExpandMode="AllNodesExpanded"
                       ShowRowHeader="True" 
                       Columns="{Binding SfGridColumns, Mode=TwoWay}"
                       AutoGenerateColumns="False"
                       ItemsSource="{Binding Employees}"
                       ParentPropertyName="ID"
                       SelfRelationRootValue="-1">
</syncfusion:SfTreeGrid>
```

Refer to the following code example in which the TreeGrid column is populated with some [TreeGridTextColumn](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.TreeGrid.TreeGridTextColumn.html) when creating the ViewModel instance.

### C#:

```c#
public class ViewModel: NotificationObject
{
    #region Private Variables
    private ObservableCollection<EmployeeInfo> _employees;
    private TreeGridColumns sfGridColumns;
    #endregion

    public TreeGridColumns SfGridColumns
    {
        get { return sfGridColumns; }
        set
        { 
            this.sfGridColumns = value;
            RaisePropertyChanged("SfGridColumns");
        }
    }

    #region ctr

    public ViewModel()
    {
        this.Employees = GetEmployeesDetails();
        rowDataCommand = new RelayCommand(ChangeCanExecute);
        this.sfGridColumns = new TreeGridColumns();
        sfGridColumns.Add(new TreeGridTextColumn() { MappingName = "FirstName" });
        sfGridColumns.Add(new TreeGridTextColumn() { MappingName = "LastName" });
        sfGridColumns.Add(new TreeGridTextColumn() { MappingName = "Title" });
        sfGridColumns.Add(new TreeGridTextColumn() { MappingName = "Salary" });
    }
    #endregion
}
```
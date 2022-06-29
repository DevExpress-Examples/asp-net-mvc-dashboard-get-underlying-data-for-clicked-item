Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports DevExpress.DataAccess.Web

Namespace MvcDashboard_UnderlyingData

    Public Class DashboardConfig

        Public Shared Sub RegisterService(ByVal routes As RouteCollection)
            routes.MapDashboardRoute("api/dashboard", "DefaultDashboard")
            ' Uncomment this line to save dashboards to the App_Data folder.
            Call DashboardConfigurator.Default.SetDashboardStorage(New DashboardFileStorage("~/App_Data/Dashboards"))
            Call DashboardConfigurator.Default.SetConnectionStringsProvider(New ConfigFileConnectionStringsProvider())
        ' Uncomment these lines to create an in-memory storage of dashboard data sources. Use the DataSourceInMemoryStorage.RegisterDataSource
        ' method to register the existing data source in the created storage.
        'var dataSourceStorage = new DataSourceInMemoryStorage();
        'DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
        End Sub
    End Class
End Namespace

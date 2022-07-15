@Code
    ViewBag.Title = "MVCxDashboard"
End Code

@section Scripts
    <script src="~/Scripts/UnderlyingData.js"></script>
End section

<div id="myPopup"></div>
<div style="position:absolute; left:0; right:0; top:0; bottom:0;">
    @Html.DevExpress().Dashboard(Sub(settings)
        settings.Name = "Dashboard"
        settings.ControllerName = "DefaultDashboard"
        settings.Width = Unit.Percentage(100)
        settings.Height = Unit.Percentage(100)
        settings.WorkingMode = DevExpress.DashboardWeb.WorkingMode.Viewer
        settings.ClientSideEvents.BeforeRender = "onBeforeRender"
    End Sub).GetHtml()
</div>
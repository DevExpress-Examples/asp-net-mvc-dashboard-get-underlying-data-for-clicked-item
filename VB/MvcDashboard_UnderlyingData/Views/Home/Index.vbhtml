﻿@Code
    ViewBag.Title = "MVCxDashboard"
End Code

@section Scripts
    <script type="text/javascript" src="~/Scripts/UnderlyingData.js"></script>
End section

<div id="myPopup"></div>
<div style="position: absolute; left: 0; top: 0; right: 0; bottom: 0;">
    @Html.DevExpress().Dashboard(Sub(settings)
    settings.Name = "Dashboard"
    settings.ControllerName = "DefaultDashboard"
    settings.WorkingMode = DevExpress.DashboardWeb.WorkingMode.Viewer
    settings.ClientSideEvents.BeforeRender = "onBeforeRender"
End Sub).GetHtml()
</div>
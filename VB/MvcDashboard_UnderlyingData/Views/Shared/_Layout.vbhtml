<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewBag.Title</title>
    @Html.DevExpress().GetStyleSheets(
    New StyleSheet With {.ExtensionSuite = ExtensionSuite.Dashboard}
)
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.Dashboard}
    )
    @RenderSection("Scripts", required:= False)
</head>

<body>
    @RenderBody()
</body>
</html>
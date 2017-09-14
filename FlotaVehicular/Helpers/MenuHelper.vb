Imports System.Web.Mvc
Imports System.Web.Mvc.Html
Imports System.Runtime.CompilerServices

Public Module MenuHelper
    ''' <summary>
    ''' Determines whether the specified controller is selected.
    ''' </summary>
    ''' <param name="html">The HTML.</param>
    ''' <param name="controller">The controller.</param>
    ''' <param name="action">The action.</param>
    ''' <returns></returns>
    <Extension()>
    Public Function IsActive(ByVal html As HtmlHelper, Optional controller As String = Nothing, Optional action As String = Nothing) As String
        Const cssClass As String = "active"
        Dim currentAction = DirectCast(html.ViewContext.RouteData.Values("action"), String)
        Dim currentController = DirectCast(html.ViewContext.RouteData.Values("controller"), String)

        If [String].IsNullOrEmpty(controller) Then
            controller = currentController
        End If

        If [String].IsNullOrEmpty(action) Then
            action = currentAction
        End If

        Return If(controller = currentController AndAlso action = currentAction, cssClass, [String].Empty)
    End Function
End Module

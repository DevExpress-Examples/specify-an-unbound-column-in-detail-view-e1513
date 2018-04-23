﻿' Developer Express Code Central Example:
' Specify an unbound column in detail view
' 
' You should configure your detail view as described in the Master-Detail:
' DataTable Use
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/CustomDocument731.htm) help
' topic. Take note of the 5th point: "Specify and Customize Views To Represent
' Datatables ". Create an unbound column for the detail view, and subscribe to the
' CustomUnboundColumnData event of the detail view. Handle this event as described
' in the following topic:
' ColumnView.CustomUnboundColumnData Event
' (ms-help://DevExpress.NETv8.2/DevExpress.XtraGrid/DevExpressXtraGridViewsBaseColumnView_CustomUnboundColumnDatatopic.htm)
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1513

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
	Friend Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
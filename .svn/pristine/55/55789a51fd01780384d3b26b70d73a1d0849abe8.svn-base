Public Class OtherPreviewControl
    Dim m_invo_no As String

    Property invo_no() As String
        Get
            Return m_invo_no
        End Get
        Set(ByVal value As String)
            m_invo_no = value
        End Set
    End Property

    Dim ds As New DataSet
    Dim _isprint As Boolean = False
    Sub Markreport_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
        Dim report1 As New C_Invoice_Other
        Dim invo_no As String = ""
        'report1.invoiceno.Value = invo_no
        report1.RequestParameters = False

        report1.Export_report_other1.Tables.Clear()
        report1.Export_report_other1.Tables.Add(ds.Tables(0).Copy)
        report1.DataSource = report1.Export_report_other1
        report1.DataMember = "SEP210_Print_Other"


        report1.CreateDocument()
        Dim catalogReport As DevExpress.XtraReports.UI.XtraReport = CType(sender, DevExpress.XtraReports.UI.XtraReport)

        Dim i As Integer
        For i = 0 To report1.Pages.Count - 1
            catalogReport.Pages.Insert(1 + i * 2, report1.Pages(i))
        Next i

        If _isprint Then

            report1.XrLabel69.Visible = True
            report1.XrLabel70.Visible = True
        Else
            report1.XrLabel69.Visible = False
            report1.XrLabel70.Visible = False
        End If

        'report1.invoiceno.Value = invo_no

        'Me.PrintControl1.PrintingSystem = report1.PrintingSystem
        If Not PrintControl1.IsDisposed Then
            PrintControl1.PrintingSystem = report1.PrintingSystem
            'PrintControl1.Show()
        End If

        'report1.ShowPreviewDialog()

        'Return report

    End Sub 'catalogReport_AfterPrint

     
    Public Function CreatReport(ByVal dsinvo As DataSet, ByVal isprint As Boolean)
        Try

            Dim report As New C_Packing_Other()
            AddHandler report.AfterPrint, AddressOf Markreport_AfterPrint
            report.RequestParameters = False
            'KRSERPDataSet1()
            _isprint = isprint
            ds = dsinvo

            report.Export_report_other1.Tables.Clear()
            report.Export_report_other1.Tables.Add(dsinvo.Tables(0).Copy)
            report.DataSource = report.Export_report_other1
            report.DataMember = "SEP210_Print_Other"

           

            '파라메터 전달
            'report.SEP210_PrintTableAdapter.Fill(report.KrserpDataSet1.Tables(0), invo_no)

            report.CreateDocument()
            'report.invoiceno.Value = invo_no

            'Me.PrintControl1.PrintingSystem = report.PrintingSystem
            report.ShowPreviewDialog()



        Catch ex As Exception

        End Try
    End Function
    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        PrintControl1.SetDocumentMapVisibility(False)
        Me.PrintControl1.SetPageView(1, 2)
        'Me.PrintControl1.Zoom = 75%
        PrintControl1.PrintingSystem = Nothing
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub
End Class

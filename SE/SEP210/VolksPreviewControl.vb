Public Class VolksPreviewControl
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

    Sub Markreport_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
        Dim report1 As New C_Packing_VOL
        Dim invo_no As String = ""
        'report1.invoiceno.Value = invo_no
        report1.RequestParameters = False

        '런타임에서 sp를 호출하면 작동되는데, 빈행만 추가되면 되는 데, 값이 복사되어 추가됨
        '테스트 후 포기함..
        'report.Detail.PrintOnEmptyDataSource = True
        'report.Detail.RepeatCountOnEmptyDataSource = 0
        '런타임에서 sp를 호출하면 작동되는데, 빈행만 추가되면 되는 데, 값이 복사되어 추가됨
        '테스트 후 포기함..

        report1.KRSERPDataSet11.Tables.Clear()
        report1.KRSERPDataSet11.Tables.Add(ds.Tables(0).Copy)

        report1.DataSource = report1.KRSERPDataSet11
        report1.DataMember = "SEP210_Print_Volkswagen"
        'report1.DataAdapter = report1.BindingSource1
        '파라메터 전달
        'report1.SEP210_PrintTableAdapter.Fill(report1.KrserpDataSet1.Tables(0), invo_no)

        report1.CreateDocument()
        Dim catalogReport As DevExpress.XtraReports.UI.XtraReport = CType(sender, DevExpress.XtraReports.UI.XtraReport)

        Dim i As Integer
        For i = 0 To report1.Pages.Count - 1
            catalogReport.Pages.Insert(1 + i * 2, report1.Pages(i))
        Next i

        'report1.invoiceno.Value = invo_no

        'Me.PrintControl1.PrintingSystem = report1.PrintingSystem
        If Not PrintControl1.IsDisposed Then
            PrintControl1.PrintingSystem = report1.PrintingSystem
            'PrintControl1.Show()
        End If

        'report1.ShowPreviewDialog()

        'Return report

    End Sub 'catalogReport_AfterPrint

    'Public Function CreatReport(ByVal pinvo_no As String, ByVal printtype As String)
    '    Try


    '        If printtype = "" Then
    '            Dim report1 As New C_Packing_VOL()
    '            'AddHandler report.AfterPrint, AddressOf Markreport_AfterPrint

    '            'invo_no = pinvo_no

    '            'report.invoiceno.Value = invo_no
    '            report.RequestParameters = False

    '            '런타임에서 sp를 호출하면 작동되는데, 빈행만 추가되면 되는 데, 값이 복사되어 추가됨
    '            '테스트 후 포기함..
    '            'report.Detail.PrintOnEmptyDataSource = True
    '            'report.Detail.RepeatCountOnEmptyDataSource = 0
    '            '런타임에서 sp를 호출하면 작동되는데, 빈행만 추가되면 되는 데, 값이 복사되어 추가됨
    '            '테스트 후 포기함..


    '            'report1.KRSERPDataSet11.Tables.Clear()
    '            'report1.KRSERPDataSet11.Tables.Add(dsinvo.Tables(0).Copy)
    '            report1.DataSource = report.KRSERPDataSet11
    '            report1.DataMember = "SEP210_Print_Volkswagen"
    '            'report.DataAdapter = report.KRSERPDataSet1TableAdapters

    '            '파라메터 전달
    '            'report.SEP210_PrintTableAdapter.Fill(report.KrserpDataSet1.Tables(0), invo_no)

    '            report.CreateDocument()
    '            'report.invoiceno.Value = invo_no

    '            'Me.PrintControl1.PrintingSystem = report.PrintingSystem
    '            report.ShowPreviewDialog()

    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Function
    Public Function CreatReport(ByVal dsinvo As DataSet, ByVal isprint As Boolean)
        Try

            Dim report As New C_Invoce_VOL()
            AddHandler report.AfterPrint, AddressOf Markreport_AfterPrint
            report.RequestParameters = False
            'KRSERPDataSet1()

            ds = dsinvo

            report.KRSERPDataSet11.Tables.Clear()
            report.KRSERPDataSet11.Tables.Add(dsinvo.Tables(0).Copy)
            report.DataSource = report.KRSERPDataSet11
            report.DataMember = "SEP210_Print_Volkswagen"

            If isprint Then

                report.XrLabel69.Visible = True
                report.XrLabel70.Visible = True
            Else
                report.XrLabel69.Visible = False
                report.XrLabel70.Visible = False
            End If
            'report.BindingSource1.DataSource = report.KRSERPDataSet11
            'report.DataAdapter = report.BindingSource1

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

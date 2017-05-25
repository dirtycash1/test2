Imports Frame7.DesignSurfaceManagerExt
Imports Frame7.DesignSurfaceExt
Imports System.ComponentModel.Design
Imports System.Drawing.Design
Imports System.ComponentModel

Public Class HRA102

    Dim _mgr As DesignSurfaceManagerExt = New DesignSurfaceManagerExt()

    Private Function GetCurrentIDesignSurface() As IDesignSurfaceExt2

        Dim surface As DesignSurface = _mgr.DesignSurfaces(0)

        Return surface 'as IDesignSurfaceExt2
    End Function


    Private Sub HRA102_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '- STEP.B
        _mgr.PropertyGridHost.Parent = Me.Panel2


        '- Add the toolboxItems to the future toolbox 
        '- the pointer
        Dim toolPointer As ToolboxItem = New System.Drawing.Design.ToolboxItem()
        toolPointer.DisplayName = "<Pointer>"
        toolPointer.Bitmap = New System.Drawing.Bitmap(16, 16)

        ListBox1.Items.Add(toolPointer)
        ListBox1.Items.Add(New ToolboxItem(GetType(Button)))
        ListBox1.Items.Add(New ToolboxItem(GetType(TextBox)))
        ListBox1.Items.Add(New ToolboxItem(GetType(Panel)))
        ListBox1.Items.Add(New ToolboxItem(GetType(Frame7.eText)))
        ListBox1.Items.Add(New ToolboxItem(GetType(DevExpress.XtraTab.XtraTabControl)))

        newFormUseSnapLinesMenuItem_Click()

    End Sub


    Private Sub newFormUseSnapLinesMenuItem_Click()

        '- step.0
        'TabPage tp = CreateNewTabPage( "Use SnapLines" );
        '//- step.1
        Dim surface As DesignSurfaceExt2 = CreateDesignSurface()

        '//- step.2
        '//- choose an alignment mode...
        surface.UseGrid(New System.Drawing.Size(4, 4))
        '//- step.3
        '//- create the Root compoment, in these case a Form


        Dim rootComponent As Control = CreateRootComponent(surface)

        'Dim iTabPageSelectedIndex As Integer = Me.tabControl1.SelectedIndex
        rootComponent.Text = "Root Component hosted by the DesignSurface N." '+ iTabPageSelectedIndex;
        'rootComponent.BackColor = Color.Yellow

    End Sub

    Private Function CreateDesignSurface() As DesignSurfaceExt2
        '//- step.0
        '//- create a DesignSurface and put it inside a Form in DesignTime
        Dim surface As DesignSurfaceExt2 = Me._mgr.CreateDesignSurfaceExt2()

        Dim isurf As IDesignSurfaceExt2 = surface '(IDesignSurfaceExt2) surface
        '//- step.1
        '//- enable the UndoEngines
        isurf.GetUndoEngineExt().Enabled = True
        '//- step.2
        '//- try to get a ptr to ISelectionService interface
        '//- if we obtain it then hook the SelectionChanged event
        Dim selectionService As ISelectionService = isurf.GetIDesignerHost().GetService(GetType(ISelectionService))
        'dim selectionService  as ISelectionService = (ISelectionService) (isurf.GetIDesignerHost().GetService( typeof( ISelectionService ) ))
        'If selectionService IsNot Nothing Then
        '    selectionService.SelectionChanged += New System.EventHandler(OnSelectionChanged)
        'End If
        '//- step.3
        '//- Select the service IToolboxService
        '//- and hook it to our ListBox
        Dim tbox As ToolboxServiceImp = isurf.GetIToolboxService 'as ToolboxServiceImp
        If tbox IsNot Nothing Then
            tbox.Toolbox = ListBox1
        End If
        '//-
        '//- finally return the Designsurface
        Return surface

    End Function


    Private s1 As DesignSurfaceExt2

    Private Function CreateRootComponent(ByVal surface As DesignSurfaceExt2) As IComponent
        'Dim rootComponent As IComponent = surface.CreateRootComponent(GetType(System.Windows.Forms.Form), New Size(Panel1.Width, Panel1.Height))
        Dim rootComponent As IComponent = surface.CreateRootComponent(GetType(System.Windows.Forms.UserControl), New Size(Panel1.Width, Panel1.Height))
        rootComponent.Site.Name = Me._mgr.GetValidFormName()

        '//- display the DesignSurface
        'Dim view As Object = surface.GetView()
        Dim view As Control = surface.GetView()
        If view Is Nothing Then
            Return Nothing
        End If

        '//- change some properties
        view.Text = rootComponent.Site.Name
        view.Dock = DockStyle.Fill

        'view.FormBorderStyle = FormBorderStyle.None

        '//- Note these assignments
        view.Parent = Panel1
        '//- finally enable the Drag&Drop on RootComponent
        surface.EnableDragandDrop()

        s1 = surface

        Return rootComponent




    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(s1.ComponentContainer.Components(0).Site.Container.Components(0).Site.Name)

        Dim host As IDesignerHost = s1.GetService(GetType(IDesignerHost))

        'If (host Is Nothing) Then
        '    return;
        'if( null == host.RootComponent ) 
        '    return;

        Dim nm As String
        Dim cc As ComponentCollection = host.Container.Components
        For Each c As Component In cc
            nm = TranslateComponentToName(c)
            If CType(c, Control).Parent IsNot Nothing Then
                MsgBox("Parent: " + CType(c, Control).Parent.Name + " - " + nm)
            Else
                MsgBox(nm)
            End If
        Next


    End Sub

    Private Function TranslateComponentToName(ByVal c As Component)
        Dim ty As String = c.GetType().ToString
        If String.IsNullOrEmpty(ty) Then
            Return String.Empty
        End If
        If String.IsNullOrEmpty(c.Site.Name) Then
            Return String.Empty
        End If
        ty = ty.Substring(ty.LastIndexOf(".") + 1)

        Return String.Format("({0}) {1}", ty, c.Site.Name)

    End Function



    '    public void UpdatePropertyGridHost( DesignSurfaceExt2 surface ) {
    '    IDesignerHost host = (IDesignerHost) surface.GetService( typeof( IDesignerHost ) );
    '    if( null == host)
    '        return;
    '    if( null == host.RootComponent ) 
    '        return;

    '    //- sync the PropertyGridHost
    '    this.PropertyGridHost.SelectedObject = host.RootComponent;
    '    this.PropertyGridHost.ReloadComboBox();


    'ComponentCollection ctrlsExisting = host.Container.Components;
    '            Debug.Assert( 0 != ctrlsExisting.Count );


    '            foreach( Component comp in ctrlsExisting ) {
    '                string sItemText = TranslateComponentToName( comp );
    '                ctrlsToAdd.Add( sItemText );
    '                if( sName == comp.Site.Name )
    '                    pgrdComboBox_Text = sItemText;
    '            }//end_foreach

    '}




End Class

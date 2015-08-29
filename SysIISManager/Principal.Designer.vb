<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblQtdSites = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblQtdPools = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LblQtdWorkerProcess = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblQtdIPs = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGridSites = New System.Windows.Forms.DataGridView()
        Me.DGridSites_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridSites_Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridSites_PoolDefault = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridSites_State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DGridWorkerProcesses = New System.Windows.Forms.DataGridView()
        Me.DGridWorkerProcesses_RequestId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_DadSite_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_DadSite_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_DadSite_PoolDefault = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_ProcessId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_Verb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_TimeElapsed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_TimeInModule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_TimeInState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_CurrentModule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_PipelineState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_LocalIPAddressPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_ClientIPAddr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridWorkerProcesses_Url = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGridPools = New System.Windows.Forms.DataGridView()
        Me.DGridPools_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridPools_QueueLength = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridPools_State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimerSckSites = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFrmSites = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LblUltimaAtualizacao = New System.Windows.Forms.Label()
        Me.TimerSckPools = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFrmPools = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSckWorkerProcesses = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFrmWorkerProcesses = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGridIPs = New System.Windows.Forms.DataGridView()
        Me.DGridIPs_IP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGridIPs_QtdOcorrencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGridSites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGridWorkerProcesses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGridPools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGridIPs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sys IIS Manager"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblQtdSites)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Qtd. Sites"
        '
        'LblQtdSites
        '
        Me.LblQtdSites.AutoSize = True
        Me.LblQtdSites.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtdSites.ForeColor = System.Drawing.Color.DarkRed
        Me.LblQtdSites.Location = New System.Drawing.Point(7, 20)
        Me.LblQtdSites.Name = "LblQtdSites"
        Me.LblQtdSites.Size = New System.Drawing.Size(25, 25)
        Me.LblQtdSites.TabIndex = 0
        Me.LblQtdSites.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblQtdPools)
        Me.GroupBox2.Location = New System.Drawing.Point(187, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(164, 55)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Qtd. Pools"
        '
        'LblQtdPools
        '
        Me.LblQtdPools.AutoSize = True
        Me.LblQtdPools.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtdPools.ForeColor = System.Drawing.Color.DarkRed
        Me.LblQtdPools.Location = New System.Drawing.Point(7, 20)
        Me.LblQtdPools.Name = "LblQtdPools"
        Me.LblQtdPools.Size = New System.Drawing.Size(25, 25)
        Me.LblQtdPools.TabIndex = 0
        Me.LblQtdPools.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblQtdWorkerProcess)
        Me.GroupBox3.Location = New System.Drawing.Point(357, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(164, 55)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Qtd. Worker Process"
        '
        'LblQtdWorkerProcess
        '
        Me.LblQtdWorkerProcess.AutoSize = True
        Me.LblQtdWorkerProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtdWorkerProcess.ForeColor = System.Drawing.Color.DarkRed
        Me.LblQtdWorkerProcess.Location = New System.Drawing.Point(7, 20)
        Me.LblQtdWorkerProcess.Name = "LblQtdWorkerProcess"
        Me.LblQtdWorkerProcess.Size = New System.Drawing.Size(25, 25)
        Me.LblQtdWorkerProcess.TabIndex = 0
        Me.LblQtdWorkerProcess.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblQtdIPs)
        Me.GroupBox4.Location = New System.Drawing.Point(527, 56)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(164, 55)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Qtd. IPs "
        '
        'LblQtdIPs
        '
        Me.LblQtdIPs.AutoSize = True
        Me.LblQtdIPs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQtdIPs.ForeColor = System.Drawing.Color.DarkRed
        Me.LblQtdIPs.Location = New System.Drawing.Point(7, 20)
        Me.LblQtdIPs.Name = "LblQtdIPs"
        Me.LblQtdIPs.Size = New System.Drawing.Size(25, 25)
        Me.LblQtdIPs.TabIndex = 0
        Me.LblQtdIPs.Text = "0"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGridSites)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(939, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Sites"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DGridSites
        '
        Me.DGridSites.AllowUserToAddRows = False
        Me.DGridSites.AllowUserToDeleteRows = False
        Me.DGridSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridSites.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridSites_ID, Me.DGridSites_Nome, Me.DGridSites_PoolDefault, Me.DGridSites_State})
        Me.DGridSites.Location = New System.Drawing.Point(4, 4)
        Me.DGridSites.Name = "DGridSites"
        Me.DGridSites.ReadOnly = True
        Me.DGridSites.Size = New System.Drawing.Size(932, 404)
        Me.DGridSites.TabIndex = 0
        '
        'DGridSites_ID
        '
        Me.DGridSites_ID.HeaderText = "ID"
        Me.DGridSites_ID.Name = "DGridSites_ID"
        Me.DGridSites_ID.ReadOnly = True
        '
        'DGridSites_Nome
        '
        Me.DGridSites_Nome.HeaderText = "Nome"
        Me.DGridSites_Nome.Name = "DGridSites_Nome"
        Me.DGridSites_Nome.ReadOnly = True
        '
        'DGridSites_PoolDefault
        '
        Me.DGridSites_PoolDefault.HeaderText = "Pool Default"
        Me.DGridSites_PoolDefault.Name = "DGridSites_PoolDefault"
        Me.DGridSites_PoolDefault.ReadOnly = True
        '
        'DGridSites_State
        '
        Me.DGridSites_State.HeaderText = "Estado"
        Me.DGridSites_State.Name = "DGridSites_State"
        Me.DGridSites_State.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(17, 118)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(947, 437)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGridWorkerProcesses)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(939, 411)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "WorkerProcesses"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DGridWorkerProcesses
        '
        Me.DGridWorkerProcesses.AllowUserToAddRows = False
        Me.DGridWorkerProcesses.AllowUserToDeleteRows = False
        Me.DGridWorkerProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridWorkerProcesses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridWorkerProcesses_RequestId, Me.DGridWorkerProcesses_DadSite_ID, Me.DGridWorkerProcesses_DadSite_Name, Me.DGridWorkerProcesses_DadSite_PoolDefault, Me.DGridWorkerProcesses_ProcessId, Me.DGridWorkerProcesses_Verb, Me.DGridWorkerProcesses_TimeElapsed, Me.DGridWorkerProcesses_TimeInModule, Me.DGridWorkerProcesses_TimeInState, Me.DGridWorkerProcesses_CurrentModule, Me.DGridWorkerProcesses_PipelineState, Me.DGridWorkerProcesses_LocalIPAddressPort, Me.DGridWorkerProcesses_ClientIPAddr, Me.DGridWorkerProcesses_Url})
        Me.DGridWorkerProcesses.Location = New System.Drawing.Point(3, 3)
        Me.DGridWorkerProcesses.Name = "DGridWorkerProcesses"
        Me.DGridWorkerProcesses.ReadOnly = True
        Me.DGridWorkerProcesses.Size = New System.Drawing.Size(932, 404)
        Me.DGridWorkerProcesses.TabIndex = 2
        '
        'DGridWorkerProcesses_RequestId
        '
        Me.DGridWorkerProcesses_RequestId.HeaderText = "Request ID"
        Me.DGridWorkerProcesses_RequestId.Name = "DGridWorkerProcesses_RequestId"
        Me.DGridWorkerProcesses_RequestId.ReadOnly = True
        '
        'DGridWorkerProcesses_DadSite_ID
        '
        Me.DGridWorkerProcesses_DadSite_ID.HeaderText = "Site / ID"
        Me.DGridWorkerProcesses_DadSite_ID.Name = "DGridWorkerProcesses_DadSite_ID"
        Me.DGridWorkerProcesses_DadSite_ID.ReadOnly = True
        '
        'DGridWorkerProcesses_DadSite_Name
        '
        Me.DGridWorkerProcesses_DadSite_Name.HeaderText = "Site / Nome"
        Me.DGridWorkerProcesses_DadSite_Name.Name = "DGridWorkerProcesses_DadSite_Name"
        Me.DGridWorkerProcesses_DadSite_Name.ReadOnly = True
        '
        'DGridWorkerProcesses_DadSite_PoolDefault
        '
        Me.DGridWorkerProcesses_DadSite_PoolDefault.HeaderText = "Site / Pool"
        Me.DGridWorkerProcesses_DadSite_PoolDefault.Name = "DGridWorkerProcesses_DadSite_PoolDefault"
        Me.DGridWorkerProcesses_DadSite_PoolDefault.ReadOnly = True
        '
        'DGridWorkerProcesses_ProcessId
        '
        Me.DGridWorkerProcesses_ProcessId.HeaderText = "ID do Processo"
        Me.DGridWorkerProcesses_ProcessId.Name = "DGridWorkerProcesses_ProcessId"
        Me.DGridWorkerProcesses_ProcessId.ReadOnly = True
        '
        'DGridWorkerProcesses_Verb
        '
        Me.DGridWorkerProcesses_Verb.HeaderText = "Método"
        Me.DGridWorkerProcesses_Verb.Name = "DGridWorkerProcesses_Verb"
        Me.DGridWorkerProcesses_Verb.ReadOnly = True
        '
        'DGridWorkerProcesses_TimeElapsed
        '
        Me.DGridWorkerProcesses_TimeElapsed.HeaderText = "Tempo Decorrido"
        Me.DGridWorkerProcesses_TimeElapsed.Name = "DGridWorkerProcesses_TimeElapsed"
        Me.DGridWorkerProcesses_TimeElapsed.ReadOnly = True
        '
        'DGridWorkerProcesses_TimeInModule
        '
        Me.DGridWorkerProcesses_TimeInModule.HeaderText = "Tempo no Módulo"
        Me.DGridWorkerProcesses_TimeInModule.Name = "DGridWorkerProcesses_TimeInModule"
        Me.DGridWorkerProcesses_TimeInModule.ReadOnly = True
        '
        'DGridWorkerProcesses_TimeInState
        '
        Me.DGridWorkerProcesses_TimeInState.HeaderText = "Tempo no Status"
        Me.DGridWorkerProcesses_TimeInState.Name = "DGridWorkerProcesses_TimeInState"
        Me.DGridWorkerProcesses_TimeInState.ReadOnly = True
        '
        'DGridWorkerProcesses_CurrentModule
        '
        Me.DGridWorkerProcesses_CurrentModule.HeaderText = "Módulo Atual"
        Me.DGridWorkerProcesses_CurrentModule.Name = "DGridWorkerProcesses_CurrentModule"
        Me.DGridWorkerProcesses_CurrentModule.ReadOnly = True
        '
        'DGridWorkerProcesses_PipelineState
        '
        Me.DGridWorkerProcesses_PipelineState.HeaderText = "Estado"
        Me.DGridWorkerProcesses_PipelineState.Name = "DGridWorkerProcesses_PipelineState"
        Me.DGridWorkerProcesses_PipelineState.ReadOnly = True
        '
        'DGridWorkerProcesses_LocalIPAddressPort
        '
        Me.DGridWorkerProcesses_LocalIPAddressPort.HeaderText = "Endereço Local"
        Me.DGridWorkerProcesses_LocalIPAddressPort.Name = "DGridWorkerProcesses_LocalIPAddressPort"
        Me.DGridWorkerProcesses_LocalIPAddressPort.ReadOnly = True
        '
        'DGridWorkerProcesses_ClientIPAddr
        '
        Me.DGridWorkerProcesses_ClientIPAddr.HeaderText = "Endereço Remoto"
        Me.DGridWorkerProcesses_ClientIPAddr.Name = "DGridWorkerProcesses_ClientIPAddr"
        Me.DGridWorkerProcesses_ClientIPAddr.ReadOnly = True
        '
        'DGridWorkerProcesses_Url
        '
        Me.DGridWorkerProcesses_Url.HeaderText = "URL"
        Me.DGridWorkerProcesses_Url.Name = "DGridWorkerProcesses_Url"
        Me.DGridWorkerProcesses_Url.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGridPools)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(939, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pools"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DGridPools
        '
        Me.DGridPools.AllowUserToAddRows = False
        Me.DGridPools.AllowUserToDeleteRows = False
        Me.DGridPools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridPools.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridPools_Name, Me.DGridPools_QueueLength, Me.DGridPools_State})
        Me.DGridPools.Location = New System.Drawing.Point(3, 3)
        Me.DGridPools.Name = "DGridPools"
        Me.DGridPools.ReadOnly = True
        Me.DGridPools.Size = New System.Drawing.Size(932, 404)
        Me.DGridPools.TabIndex = 1
        '
        'DGridPools_Name
        '
        Me.DGridPools_Name.HeaderText = "Nome"
        Me.DGridPools_Name.Name = "DGridPools_Name"
        Me.DGridPools_Name.ReadOnly = True
        '
        'DGridPools_QueueLength
        '
        Me.DGridPools_QueueLength.HeaderText = "Fila Máxima"
        Me.DGridPools_QueueLength.Name = "DGridPools_QueueLength"
        Me.DGridPools_QueueLength.ReadOnly = True
        '
        'DGridPools_State
        '
        Me.DGridPools_State.HeaderText = "Estado"
        Me.DGridPools_State.Name = "DGridPools_State"
        Me.DGridPools_State.ReadOnly = True
        '
        'TimerSckSites
        '
        Me.TimerSckSites.Interval = 10000
        '
        'TimerFrmSites
        '
        Me.TimerFrmSites.Interval = 10000
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LblUltimaAtualizacao)
        Me.GroupBox5.Location = New System.Drawing.Point(697, 57)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(260, 55)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Última Checagem"
        '
        'LblUltimaAtualizacao
        '
        Me.LblUltimaAtualizacao.AutoSize = True
        Me.LblUltimaAtualizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUltimaAtualizacao.ForeColor = System.Drawing.Color.DarkRed
        Me.LblUltimaAtualizacao.Location = New System.Drawing.Point(7, 20)
        Me.LblUltimaAtualizacao.Name = "LblUltimaAtualizacao"
        Me.LblUltimaAtualizacao.Size = New System.Drawing.Size(20, 25)
        Me.LblUltimaAtualizacao.TabIndex = 0
        Me.LblUltimaAtualizacao.Text = "-"
        '
        'TimerSckPools
        '
        Me.TimerSckPools.Interval = 10000
        '
        'TimerFrmPools
        '
        Me.TimerFrmPools.Interval = 10000
        '
        'TimerSckWorkerProcesses
        '
        Me.TimerSckWorkerProcesses.Interval = 1000
        '
        'TimerFrmWorkerProcesses
        '
        Me.TimerFrmWorkerProcesses.Interval = 1000
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGridIPs)
        Me.GroupBox6.Location = New System.Drawing.Point(970, 57)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(296, 498)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "IPs Ativos"
        '
        'DGridIPs
        '
        Me.DGridIPs.AllowUserToAddRows = False
        Me.DGridIPs.AllowUserToDeleteRows = False
        Me.DGridIPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridIPs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGridIPs_IP, Me.DGridIPs_QtdOcorrencias})
        Me.DGridIPs.Location = New System.Drawing.Point(7, 20)
        Me.DGridIPs.Name = "DGridIPs"
        Me.DGridIPs.ReadOnly = True
        Me.DGridIPs.Size = New System.Drawing.Size(283, 472)
        Me.DGridIPs.TabIndex = 0
        '
        'DGridIPs_IP
        '
        Me.DGridIPs_IP.HeaderText = "IP"
        Me.DGridIPs_IP.Name = "DGridIPs_IP"
        Me.DGridIPs_IP.ReadOnly = True
        Me.DGridIPs_IP.Width = 140
        '
        'DGridIPs_QtdOcorrencias
        '
        Me.DGridIPs_QtdOcorrencias.HeaderText = "Ocorrências"
        Me.DGridIPs_QtdOcorrencias.Name = "DGridIPs_QtdOcorrencias"
        Me.DGridIPs_QtdOcorrencias.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1154, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "By Charles Macetko" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cmacetko@gmail.com"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 565)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Sys IIS Manager"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGridSites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGridWorkerProcesses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGridPools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGridIPs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblQtdSites As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LblQtdPools As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblQtdWorkerProcess As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LblQtdIPs As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DGridSites As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TimerSckSites As System.Windows.Forms.Timer
    Friend WithEvents TimerFrmSites As System.Windows.Forms.Timer
    Friend WithEvents DGridSites_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridSites_Nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridSites_PoolDefault As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridSites_State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LblUltimaAtualizacao As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DGridPools As System.Windows.Forms.DataGridView
    Friend WithEvents DGridPools_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridPools_QueueLength As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridPools_State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimerSckPools As System.Windows.Forms.Timer
    Friend WithEvents TimerFrmPools As System.Windows.Forms.Timer
    Friend WithEvents TimerSckWorkerProcesses As System.Windows.Forms.Timer
    Friend WithEvents TimerFrmWorkerProcesses As System.Windows.Forms.Timer
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DGridWorkerProcesses As System.Windows.Forms.DataGridView
    Friend WithEvents DGridWorkerProcesses_RequestId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_DadSite_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_DadSite_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_DadSite_PoolDefault As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_ProcessId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_Verb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_TimeElapsed As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_TimeInModule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_TimeInState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_CurrentModule As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_PipelineState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_LocalIPAddressPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_ClientIPAddr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridWorkerProcesses_Url As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DGridIPs As System.Windows.Forms.DataGridView
    Friend WithEvents DGridIPs_IP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGridIPs_QtdOcorrencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

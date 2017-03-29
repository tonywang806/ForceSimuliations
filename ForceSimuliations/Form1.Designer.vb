<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Canvas = New System.Windows.Forms.PictureBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Canvas
        '
        Me.Canvas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Canvas.Location = New System.Drawing.Point(4, 2)
        Me.Canvas.Name = "Canvas"
        Me.Canvas.Size = New System.Drawing.Size(1343, 391)
        Me.Canvas.TabIndex = 0
        Me.Canvas.TabStop = False
        '
        'btnRun
        '
        Me.btnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRun.Location = New System.Drawing.Point(1235, 399)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(49, 20)
        Me.btnRun.TabIndex = 1
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(1290, 399)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(49, 20)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 421)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.Canvas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Canvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Canvas As PictureBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnReset As Button
End Class

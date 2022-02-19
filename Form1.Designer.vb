<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlpNum = New System.Windows.Forms.TextBox()
        Me.txtOwnphoNo = New System.Windows.Forms.TextBox()
        Me.txtOwnname = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.listData = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Location = New System.Drawing.Point(110, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VEHICLE INFORMATION MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Licence plate number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Owners name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Owners phone number"
        '
        'txtlpNum
        '
        Me.txtlpNum.Location = New System.Drawing.Point(67, 113)
        Me.txtlpNum.Name = "txtlpNum"
        Me.txtlpNum.Size = New System.Drawing.Size(118, 23)
        Me.txtlpNum.TabIndex = 4
        '
        'txtOwnphoNo
        '
        Me.txtOwnphoNo.Location = New System.Drawing.Point(392, 113)
        Me.txtOwnphoNo.Name = "txtOwnphoNo"
        Me.txtOwnphoNo.Size = New System.Drawing.Size(126, 23)
        Me.txtOwnphoNo.TabIndex = 6
        '
        'txtOwnname
        '
        Me.txtOwnname.Location = New System.Drawing.Point(218, 113)
        Me.txtOwnname.Name = "txtOwnname"
        Me.txtOwnname.Size = New System.Drawing.Size(126, 23)
        Me.txtOwnname.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(67, 165)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(421, 165)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(97, 23)
        Me.btnLoad.TabIndex = 10
        Me.btnLoad.Text = "LOAD DATA"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(309, 165)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(190, 165)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'listData
        '
        Me.listData.FormattingEnabled = True
        Me.listData.Location = New System.Drawing.Point(67, 217)
        Me.listData.Name = "listData"
        Me.listData.Size = New System.Drawing.Size(451, 184)
        Me.listData.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 429)
        Me.Controls.Add(Me.listData)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtOwnname)
        Me.Controls.Add(Me.txtOwnphoNo)
        Me.Controls.Add(Me.txtlpNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "DMV Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlpNum As TextBox
    Friend WithEvents txtOwnphoNo As TextBox
    Friend WithEvents txtOwnname As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents listData As CheckedListBox
End Class

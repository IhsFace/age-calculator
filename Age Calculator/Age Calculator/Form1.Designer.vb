<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btnCalculate = New Button()
        Label4 = New Label()
        dtpToday = New DateTimePicker()
        dtpBirthday = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(272, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(267, 51)
        Label1.TabIndex = 0
        Label1.Text = "Age Calculator"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(423, 130)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 39)
        txtName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 137)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 32)
        Label2.TabIndex = 2
        Label2.Text = "Enter your Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(45, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(267, 32)
        Label3.TabIndex = 4
        Label3.Text = "What is the date today?"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(398, 358)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(225, 46)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate My Age!"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(45, 294)
        Label4.Name = "Label4"
        Label4.Size = New Size(330, 32)
        Label4.TabIndex = 5
        Label4.Text = "What year were your born in?"
        ' 
        ' dtpToday
        ' 
        dtpToday.Location = New Point(381, 216)
        dtpToday.Name = "dtpToday"
        dtpToday.Size = New Size(400, 39)
        dtpToday.TabIndex = 6
        ' 
        ' dtpBirthday
        ' 
        dtpBirthday.Location = New Point(381, 287)
        dtpBirthday.Name = "dtpBirthday"
        dtpBirthday.Size = New Size(400, 39)
        dtpBirthday.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Orange
        ClientSize = New Size(800, 450)
        Controls.Add(dtpBirthday)
        Controls.Add(dtpToday)
        Controls.Add(Label4)
        Controls.Add(btnCalculate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Age Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpToday As DateTimePicker
    Friend WithEvents dtpBirthday As DateTimePicker

End Class

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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        txtaboutme = New Label()
        shelpict = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(shelpict, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtaboutme
        ' 
        txtaboutme.AutoSize = True
        txtaboutme.BackColor = Color.Transparent
        txtaboutme.Font = New Font("Geometr415 Blk BT", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtaboutme.Location = New Point(312, 30)
        txtaboutme.Name = "txtaboutme"
        txtaboutme.Size = New Size(181, 45)
        txtaboutme.TabIndex = 1
        txtaboutme.Text = "About Me"
        ' 
        ' shelpict
        ' 
        shelpict.Image = CType(resources.GetObject("shelpict.Image"), Image)
        shelpict.Location = New Point(567, 101)
        shelpict.Name = "shelpict"
        shelpict.Size = New Size(187, 196)
        shelpict.SizeMode = PictureBoxSizeMode.StretchImage
        shelpict.TabIndex = 2
        shelpict.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Sitka Small", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(178, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 29)
        Label1.TabIndex = 3
        Label1.Text = "Name : Shellyne Salainti"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(178, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 4
        Label2.Text = "Age : 20"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Silver
        Label3.Font = New Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(178, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(362, 69)
        Label3.TabIndex = 5
        Label3.Text = "Seorang mahasiswa Fakultas Ilmu Komputer. " & vbCrLf & "Mengambil jurusan Informatika, " & vbCrLf & "dan berkuliah di Universitas Klabat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(shelpict)
        Controls.Add(txtaboutme)
        Name = "Form1"
        Text = "Shellyne Salainti"
        CType(shelpict, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtaboutme As Label
    Friend WithEvents shelpict As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class

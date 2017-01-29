<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuitarStore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuitarStore))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picGuitar1 = New System.Windows.Forms.PictureBox()
        Me.picGuitar2 = New System.Windows.Forms.PictureBox()
        Me.picGuitar3 = New System.Windows.Forms.PictureBox()
        Me.picGuitarChoice = New System.Windows.Forms.PictureBox()
        Me.btnGuitar1 = New System.Windows.Forms.Button()
        Me.btnGuitar2 = New System.Windows.Forms.Button()
        Me.btnGuitar3 = New System.Windows.Forms.Button()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.lblEnjoyGuitar = New System.Windows.Forms.Label()
        CType(Me.picGuitar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuitar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuitar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuitarChoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(221, 18)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(316, 46)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "GUITAR STORE"
        '
        'picGuitar1
        '
        Me.picGuitar1.Image = CType(resources.GetObject("picGuitar1.Image"), System.Drawing.Image)
        Me.picGuitar1.Location = New System.Drawing.Point(33, 80)
        Me.picGuitar1.Name = "picGuitar1"
        Me.picGuitar1.Size = New System.Drawing.Size(185, 150)
        Me.picGuitar1.TabIndex = 1
        Me.picGuitar1.TabStop = False
        '
        'picGuitar2
        '
        Me.picGuitar2.Image = CType(resources.GetObject("picGuitar2.Image"), System.Drawing.Image)
        Me.picGuitar2.Location = New System.Drawing.Point(275, 80)
        Me.picGuitar2.Name = "picGuitar2"
        Me.picGuitar2.Size = New System.Drawing.Size(185, 150)
        Me.picGuitar2.TabIndex = 2
        Me.picGuitar2.TabStop = False
        '
        'picGuitar3
        '
        Me.picGuitar3.Image = CType(resources.GetObject("picGuitar3.Image"), System.Drawing.Image)
        Me.picGuitar3.Location = New System.Drawing.Point(517, 80)
        Me.picGuitar3.Name = "picGuitar3"
        Me.picGuitar3.Size = New System.Drawing.Size(185, 150)
        Me.picGuitar3.TabIndex = 3
        Me.picGuitar3.TabStop = False
        '
        'picGuitarChoice
        '
        Me.picGuitarChoice.Image = CType(resources.GetObject("picGuitarChoice.Image"), System.Drawing.Image)
        Me.picGuitarChoice.Location = New System.Drawing.Point(277, 300)
        Me.picGuitarChoice.Name = "picGuitarChoice"
        Me.picGuitarChoice.Size = New System.Drawing.Size(185, 150)
        Me.picGuitarChoice.TabIndex = 4
        Me.picGuitarChoice.TabStop = False
        '
        'btnGuitar1
        '
        Me.btnGuitar1.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuitar1.Location = New System.Drawing.Point(33, 236)
        Me.btnGuitar1.Name = "btnGuitar1"
        Me.btnGuitar1.Size = New System.Drawing.Size(185, 35)
        Me.btnGuitar1.TabIndex = 5
        Me.btnGuitar1.Text = "Classical"
        Me.btnGuitar1.UseVisualStyleBackColor = True
        '
        'btnGuitar2
        '
        Me.btnGuitar2.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuitar2.Location = New System.Drawing.Point(275, 236)
        Me.btnGuitar2.Name = "btnGuitar2"
        Me.btnGuitar2.Size = New System.Drawing.Size(185, 35)
        Me.btnGuitar2.TabIndex = 6
        Me.btnGuitar2.Text = "Electric"
        Me.btnGuitar2.UseVisualStyleBackColor = True
        '
        'btnGuitar3
        '
        Me.btnGuitar3.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuitar3.Location = New System.Drawing.Point(517, 236)
        Me.btnGuitar3.Name = "btnGuitar3"
        Me.btnGuitar3.Size = New System.Drawing.Size(185, 35)
        Me.btnGuitar3.TabIndex = 7
        Me.btnGuitar3.Text = "Steel"
        Me.btnGuitar3.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Font = New System.Drawing.Font("Goudy Old Style", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.Location = New System.Drawing.Point(275, 466)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(185, 36)
        Me.btnPurchase.TabIndex = 8
        Me.btnPurchase.Text = "PURCHASE"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'lblEnjoyGuitar
        '
        Me.lblEnjoyGuitar.AutoSize = True
        Me.lblEnjoyGuitar.Font = New System.Drawing.Font("Goudy Old Style", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoyGuitar.Location = New System.Drawing.Point(272, 516)
        Me.lblEnjoyGuitar.Name = "lblEnjoyGuitar"
        Me.lblEnjoyGuitar.Size = New System.Drawing.Size(188, 28)
        Me.lblEnjoyGuitar.TabIndex = 9
        Me.lblEnjoyGuitar.Text = "Enjoy your guitar!"
        '
        'frmGuitarStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 572)
        Me.Controls.Add(Me.lblEnjoyGuitar)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.btnGuitar3)
        Me.Controls.Add(Me.btnGuitar2)
        Me.Controls.Add(Me.btnGuitar1)
        Me.Controls.Add(Me.picGuitarChoice)
        Me.Controls.Add(Me.picGuitar3)
        Me.Controls.Add(Me.picGuitar2)
        Me.Controls.Add(Me.picGuitar1)
        Me.Controls.Add(Me.lblHeading)
        Me.Font = New System.Drawing.Font("Lucida Sans Typewriter", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmGuitarStore"
        Me.Text = "Guitar Store"
        CType(Me.picGuitar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuitar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuitar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuitarChoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picGuitar1 As PictureBox
    Friend WithEvents picGuitar2 As PictureBox
    Friend WithEvents picGuitar3 As PictureBox
    Friend WithEvents picGuitarChoice As PictureBox
    Friend WithEvents btnGuitar1 As Button
    Friend WithEvents btnGuitar2 As Button
    Friend WithEvents btnGuitar3 As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents lblEnjoyGuitar As Label
End Class

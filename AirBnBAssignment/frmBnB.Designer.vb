<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBnB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBnB))
        Me.picBnB = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.tbxUsIn = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        CType(Me.picBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBnB
        '
        Me.picBnB.BackgroundImage = CType(resources.GetObject("picBnB.BackgroundImage"), System.Drawing.Image)
        Me.picBnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picBnB.Location = New System.Drawing.Point(0, -3)
        Me.picBnB.Name = "picBnB"
        Me.picBnB.Size = New System.Drawing.Size(400, 297)
        Me.picBnB.TabIndex = 0
        Me.picBnB.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(476, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(251, 38)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Orlando AirBnB"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCost.Enabled = False
        Me.btnCost.FlatAppearance.BorderSize = 0
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.White
        Me.btnCost.Location = New System.Drawing.Point(451, 242)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(84, 25)
        Me.btnCost.TabIndex = 2
        Me.btnCost.Text = "Display Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(562, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 25)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(673, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 25)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(514, 62)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(171, 19)
        Me.lblSubtitle.TabIndex = 5
        Me.lblSubtitle.Text = "Only $79.00 per night"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.Location = New System.Drawing.Point(480, 117)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(129, 17)
        Me.lblNights.TabIndex = 6
        Me.lblNights.Text = "Number of Nights: "
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(515, 154)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(93, 17)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "Cost of Stay: "
        '
        'tbxUsIn
        '
        Me.tbxUsIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxUsIn.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUsIn.Location = New System.Drawing.Point(609, 115)
        Me.tbxUsIn.Name = "tbxUsIn"
        Me.tbxUsIn.Size = New System.Drawing.Size(60, 21)
        Me.tbxUsIn.TabIndex = 8
        Me.tbxUsIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(609, 154)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 16)
        Me.lblPrice.TabIndex = 9
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.Location = New System.Drawing.Point(517, 191)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(175, 32)
        Me.lblError.TabIndex = 10
        Me.lblError.Text = "That doesn't look like a number." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please try again."
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.Visible = False
        '
        'frmBnB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 291)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.tbxUsIn)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblNights)
        Me.Controls.Add(Me.lblSubtitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picBnB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBnB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.picBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBnB As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents tbxUsIn As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblError As Label
End Class

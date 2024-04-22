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
        Me.lblusn = New System.Windows.Forms.Label()
        Me.Llblpass = New System.Windows.Forms.Label()
        Me.txtusn = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(278, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SamPleXx"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Script MT Bold", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Fuchsia
        Me.Label2.Location = New System.Drawing.Point(97, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Welcome To"
        '
        'lblusn
        '
        Me.lblusn.AutoSize = True
        Me.lblusn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusn.Location = New System.Drawing.Point(90, 132)
        Me.lblusn.Name = "lblusn"
        Me.lblusn.Size = New System.Drawing.Size(96, 20)
        Me.lblusn.TabIndex = 2
        Me.lblusn.Text = "Username:"
        '
        'Llblpass
        '
        Me.Llblpass.AutoSize = True
        Me.Llblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llblpass.Location = New System.Drawing.Point(90, 215)
        Me.Llblpass.Name = "Llblpass"
        Me.Llblpass.Size = New System.Drawing.Size(91, 20)
        Me.Llblpass.TabIndex = 3
        Me.Llblpass.Text = "Password:"
        '
        'txtusn
        '
        Me.txtusn.BackColor = System.Drawing.Color.LightGreen
        Me.txtusn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusn.Location = New System.Drawing.Point(137, 170)
        Me.txtusn.Name = "txtusn"
        Me.txtusn.Size = New System.Drawing.Size(302, 26)
        Me.txtusn.TabIndex = 4
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.LightGreen
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(137, 253)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(302, 26)
        Me.txtpass.TabIndex = 5
        '
        'btnlog
        '
        Me.btnlog.BackColor = System.Drawing.Color.White
        Me.btnlog.Location = New System.Drawing.Point(331, 339)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(81, 33)
        Me.btnlog.TabIndex = 6
        Me.btnlog.Text = "Log In"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'btnreg
        '
        Me.btnreg.BackColor = System.Drawing.Color.White
        Me.btnreg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreg.Location = New System.Drawing.Point(156, 339)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(81, 33)
        Me.btnreg.TabIndex = 7
        Me.btnreg.Text = "Register"
        Me.btnreg.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 419)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusn)
        Me.Controls.Add(Me.Llblpass)
        Me.Controls.Add(Me.lblusn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SamPleXX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblusn As Label
    Friend WithEvents Llblpass As Label
    Friend WithEvents txtusn As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnlog As Button
    Friend WithEvents btnreg As Button
End Class

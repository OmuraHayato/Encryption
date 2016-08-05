Public Class EncDec

    ''' <summary>復号化フラグ</summary>
    Private isDec As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ''' <summary>
    ''' 暗号化、復号化を行う
    ''' </summary>
    Private Sub EncDec()

        '16進数に変換した文字を格納
        Dim hexStr As String = ""
        '1文字分変換した16進数を格納
        Dim hexStr2 As String = ""

        Dim result As String = ""

        Dim byteStr As Byte()
        Dim byteStr2 As Byte()

        Dim count As Integer = 0
        Dim count2 As Integer = 0

        '初期化
        OutPutTextBox.Clear()

        'UTF8のバイトデータに変換
        byteStr = System.Text.Encoding.UTF8.GetBytes(InputTextBox.Text)

        For i As Integer = 0 To byteStr.Length - 1
            '16進数に変換
            hexStr = Hex(byteStr(i))
            hexStr2 &= hexStr
            count += 1

            '1文字分変換された時に16進数の数値を変更する
            If count = 3 Then

                '文字コードを変更する
                byteStr2 = CharCodeChange(False, hexStr2)

                result = System.Text.Encoding.UTF8.GetString(byteStr2)

                If result.Contains("�") Then
                    '文字化けされていたらまた変更する
                    OutPutTextBox.Text &= System.Text.Encoding.UTF8.GetString(CharCodeChange(True, hexStr2))
                Else
                    OutPutTextBox.Text &= result
                End If

                count = 0
                hexStr2 = ""
            End If

        Next

    End Sub

    ''' <summary>
    ''' 暗号化、復号化に応じて文字コードを変更する
    ''' </summary>
    Private Function CharCodeChange(ByVal mojibake As Boolean, ByVal hexStr2 As String)

        '分割した文字を格納
        Dim moji4 As String()

        Dim hexStr3 As String
        Dim byteStr3 As Byte()
        Dim decStr As Integer = 0
        Dim count2 As Integer = 0

        '10進数に変換
        decStr = Convert.ToInt32(hexStr2, 16)

        '最初の暗号化、復号化で文字化けした場合
        If mojibake = True Then
            '復号化の時は数値を引く
            If isDec = True Then
                decStr -= 205
            Else
                decStr += 205
            End If
        Else
            If isDec = True Then
                decStr -= 13
            Else
                decStr += 13
            End If
        End If

        '16進数に変換
        hexStr3 = Hex(decStr)

        'カンマで区切る
        For j As Integer = 0 To hexStr3.Length - 2
            If j Mod 2 = 1 Then
                '追加したカンマもカウントする
                count2 += 1
                hexStr3 = hexStr3.Insert(j + count2, ",")
            End If
        Next
        count2 = 0

        moji4 = hexStr3.Split(","c)

        '暗号化した文字をバイトに変換
        byteStr3 = New Byte(2) {}
        For k = 0 To moji4.Length - 1
            byteStr3(k) &= CByte(Convert.ToInt32(moji4(k), 16))
        Next

        Return byteStr3

    End Function


    ''' <summary>
    ''' 暗号化ボタンをクリックした時
    ''' </summary>
    Private Sub Encryption_Button_Click(sender As Object, e As EventArgs) Handles Encryption_Button.Click

        isDec = False
        '暗号化を行う
        EncDec()

    End Sub

    ''' <summary>
    ''' 復号化ボタンをクリックした時
    ''' </summary>
    Private Sub Decryption_Button_Click(sender As Object, e As EventArgs) Handles Decryption_Button.Click

        isDec = True
        '復号化を行う
        EncDec()

    End Sub

End Class

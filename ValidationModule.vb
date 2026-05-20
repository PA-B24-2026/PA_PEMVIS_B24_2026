Imports System.Windows.Forms

Public Module ValidationModule

    Public Function ValidasiTambah(nama As String, lane As String, pathGambar As String) As Boolean
        If String.IsNullOrWhiteSpace(nama) Then
            MsgBox("Nama hero wajib diisi!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If
        If String.IsNullOrWhiteSpace(lane) Then
            MsgBox("Lane wajib dipilih!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If
        If String.IsNullOrWhiteSpace(pathGambar) Then
            MsgBox("Gambar hero wajib dipilih!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiHeroTerpilih(idHero As Integer, aksi As String) As Boolean
        If idHero = 0 Then
            MsgBox($"Pilih hero di daftar sebelum melakukan {aksi}!", MsgBoxStyle.Exclamation, "Validasi")
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiMaxRole(checkboxes As IEnumerable(Of CheckBox), chkBaru As CheckBox) As Boolean
        If Not chkBaru.Checked Then Return True

        Dim hitungRole As Integer = checkboxes.Count(Function(c) c.Checked)
        If hitungRole > 2 Then
            MsgBox("Maksimal 2 Role yang bisa dipilih!", MsgBoxStyle.Exclamation, "Validasi")
            chkBaru.Checked = False
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiMaxCheckedListBox(e As ItemCheckEventArgs, clb As CheckedListBox,
                                               labelNama As String, maxItem As Integer) As Boolean
        If e.NewValue = CheckState.Checked AndAlso clb.CheckedItems.Count >= maxItem Then
            MsgBox($"Maksimal {maxItem} {labelNama}!", MsgBoxStyle.Exclamation, "Validasi")
            e.NewValue = CheckState.Unchecked
            Return False
        End If
        Return True
    End Function

    Public Function KonfirmasiHapus(namaHero As String) As Boolean
        Dim hasil = MessageBox.Show(
            $"Yakin ingin menghapus hero '{namaHero}'?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
        Return hasil = DialogResult.Yes
    End Function

    Public Function CekDuplikatTier(dgv As DataGridView, namaHero As String, lane As String, idAbaikan As Integer) As Boolean
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells("nama_hero").Value IsNot Nothing Then
                Dim rowId As Integer = Val(row.Cells("id_hero").Value)
                Dim rowNama As String = row.Cells("nama_hero").Value.ToString()
                Dim rowLane As String = row.Cells("lane").Value.ToString()

                ' Abaikan pengecekan pada ID diri sendiri saat melakukan proses Update (Edit)
                If rowId <> idAbaikan Then
                    If rowNama.ToLower() = namaHero.ToLower() AndAlso rowLane.ToLower() = lane.ToLower() Then
                        Return True ' Duplikat ditemui!
                    End If
                End If
            End If
        Next
        Return False ' Tiada duplikat
    End Function

End Module
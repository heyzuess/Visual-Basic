﻿'============================================================================
' Author.: Jesse Iberri
' Program: SongVotingApp
' Date...: 02/22/2021
' Purpose: Lab 2
'============================================================================
Public Class Form1
    ' Private class to hold the SongGenre object
    Private Class SongGenre
        Public Name As String
        Public Image As Object = Nothing
        Public SongList As List(Of String) = Nothing
        Public VoteCount As Integer = 0

        ' Overloaded constructor
        Public Sub New(GenreName As String)
            Me.New(GenreName, Nothing)
        End Sub

        ' Main constructor
        Public Sub New(GenreName As String, GenreImage As Object)
            Name = GenreName
            Image = GenreImage
        End Sub
    End Class

    ' A dictionary to hold genre + image + songlist for quick selection
    Dim myLib As New Dictionary(Of String, Object)

    ' A List to hold the song item display objects
    Dim songDisplay As New List(Of Object)

    ' Declare constructor for form class
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        myLib.Add("", New SongGenre("", My.Resources.Music))
        myLib.Add("Rock", New SongGenre("Rock", My.Resources.Electric))
        myLib.Add("Country", New SongGenre("Country", My.Resources.Steel))
        myLib.Add("Hip-Hop", New SongGenre("Hip-Hop", My.Resources.Classical))

        ' Add some songs for each genre
        ' Each genre list will be 3 long
        Dim tempList As List(Of String)
        Dim tempGenre As SongGenre = Nothing

        ' Loop through each genre and add 3 songs to each list
        For Each key In myLib.Keys
            ' Add genres to combo box
            GenreList.Items.Add(key)

            ' Get current genre object from selected genre for non blank genres
            If myLib.TryGetValue(key, tempGenre) And key > "" Then
                ' Clear temp list
                tempList = New List(Of String)

                ' Add 3 generic songs to song list object
                For i As Integer = 0 To 2
                    Dim tempString As String = key.ToString() + " song " + (i + 1).ToString()

                    ' Test
                    'MsgBox("Key:  " + key + Chr(10) + "Index: " + i.ToString() + Chr(10) + "String: " + tempString)

                    tempList.Add(tempString)
                Next

                ' Add song list object to dictionary for genre
                tempGenre.SongList = tempList

                ' Test
                'MsgBox("genre: " + tempGenre.Name + Chr(10) + "valid list: " + IsNothing(tempList).ToString())
            End If
        Next

        ' Keep song entry controls in a index to reference it later for updating
        songDisplay.Add(Song1)
        songDisplay.Add(Song2)
        songDisplay.Add(Song3)

        ' Test
        'MsgBox(songDisplay.Count.ToString())

        ' Set initial image and selection text
        PictureBox1.Image = GetSelectionImage(GenreList.Text)
        UpdateSongDisplay(GenreList.Text)
    End Sub

    'On select of option in combo box
    Private Sub GenreList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenreList.SelectedIndexChanged
        ' Set the image from the currently selected genre
        PictureBox1.Image = GetSelectionImage(GenreList.Text)
        UpdateSongDisplay(GenreList.Text)
        UpdateVoteCount(GenreList.Text, 0)
    End Sub

    ' A function to return the image object from the dictionary index
    Function GetSelectionImage(SelectionText As String) As Object
        ' Initialize returnVal object as null
        Dim returnVal As Object = Nothing
        Dim tempGenre As SongGenre = Nothing

        ' Get image from dictionary index based on key
        If myLib.TryGetValue(SelectionText, tempGenre) Then
            returnVal = tempGenre.Image
        End If

        Return returnVal
    End Function

    ' This updates the song display on the change of the drop down list
    Private Sub UpdateSongDisplay(GenreName As String)
        Dim tempList As List(Of String) = Nothing
        Dim tempGenre As SongGenre = Nothing

        Dim hasValues As Boolean

        ' Make sure the lib has the genre selected
        hasValues = myLib.TryGetValue(GenreName, tempGenre)

        ' Test
        'MsgBox("Genre is " + GenreName)

        ' If genre has a song list
        If hasValues And GenreName <> "" Then
            ' Test
            'MsgBox("Number of songs: " + tempGenre.SongList.Count.ToString())

            tempList = tempGenre.SongList
            For i As Integer = 0 To tempList.Count - 1
                ' Test
                'MsgBox("Song number: " + i.ToString())

                songDisplay(i).Text = tempList(i)
            Next
        Else
            ' If no song list for genre, then clear selection
            For i As Integer = 0 To songDisplay.Count - 1
                ' Test
                'MsgBox("Clearing song label " + i.ToString())

                songDisplay(i).Text = ""
            Next
        End If
    End Sub

    ' Handles the vote button click event
    Private Sub VoteButton_Click(sender As Object, e As EventArgs) Handles VoteButton.Click
        UpdateVoteCount(GenreList.Text, 1)
    End Sub

    ' Used to update the vote display and counter
    Private Sub UpdateVoteCount(GenreName As String, VoteInt As Integer)
        Dim myGenre As SongGenre = Nothing

        ' Test
        'MsgBox(GenreList.Text + " " + VoteInt.ToString())

        ' If genre is not blank then incriment vote count on genre
        ' Else alert the user that they can not incriment an unkown genre
        If myLib.TryGetValue(GenreList.Text, myGenre) And GenreList.Text > "" Then
            myGenre.VoteCount = myGenre.VoteCount + VoteInt
        ElseIf GenreList.Text = "" And VoteInt <> 0 Then
            MsgBox("Please select a valid genre before voting", MsgBoxStyle.Information, "Vote Error")
            Return
        End If

        ' Update the genre vote count label for the selected genre
        GenreVoteCount.Text = myGenre.VoteCount.ToString()
    End Sub
End Class

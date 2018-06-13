Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPdfViewer

Namespace SpecifyTextMarkupAnnotationProperties
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Load a document.
            pdfViewer1.LoadDocument("..\..\Demo.pdf")

            ' Handle the TextMarkupAnnotationCreating event to specify the text markup annotation properties when the annotation is being created. 
            AddHandler pdfViewer1.TextMarkupAnnotationCreating, AddressOf pdfViewer1_TextMarkupAnnotationCreating
        End Sub

        Private Sub pdfViewer1_TextMarkupAnnotationCreating(ByVal sender As Object, ByVal e As PdfTextMarkupAnnotationCreatingEventArgs) Handles pdfViewer1.TextMarkupAnnotationCreating
            e.Author = "John Smith"
            e.Comment = "Note."
            e.Color = Color.Gold
        End Sub
    End Class
End Namespace

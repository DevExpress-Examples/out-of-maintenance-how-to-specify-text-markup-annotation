Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Pdf
Imports DevExpress.XtraPdfViewer

Namespace SpecifyTextMarkup
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()

            ' Load a document.
            pdfViewer1.LoadDocument("..\..\Demo.pdf")

            AddHandler pdfViewer1.AnnotationCreating, AddressOf pdfViewer1_TextMarkupAnnotationCreating
        End Sub

        Private Sub pdfViewer1_TextMarkupAnnotationCreating(ByVal sender As Object, ByVal e As PdfAnnotationCreatingEventArgs) Handles pdfViewer1.AnnotationCreating

            'Specify options for text markup and text annotations:
            If e.Builder.AnnotationType = PdfAnnotationType.TextMarkup OrElse e.Builder.AnnotationType = PdfAnnotationType.Text Then
                'Retrieve common options for text and text markup annotations:
                Dim annotationBuilder = e.Builder.AsMarkupAnnotationBuilder()
                annotationBuilder.Author = "John Smith"
                annotationBuilder.Color = New PdfRGBColor(0.2, 0.6, 1.0)
                annotationBuilder.Contents = "Note"
            End If
        End Sub
    End Class
End Namespace

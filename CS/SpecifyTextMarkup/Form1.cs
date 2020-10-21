using DevExpress.Pdf;
using DevExpress.XtraPdfViewer;

namespace SpecifyTextMarkup
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            // Load a document.
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");

            pdfViewer1.AnnotationCreating += pdfViewer1_TextMarkupAnnotationCreating;
        }

        private void pdfViewer1_TextMarkupAnnotationCreating(object sender, PdfAnnotationCreatingEventArgs e)
        {
            //Specify options for text markup and text annotations:
            if (e.Builder.AnnotationType == PdfAnnotationType.TextMarkup || e.Builder.AnnotationType == PdfAnnotationType.Text)
            {
                //Retrieve common options for text and text markup annotations:
                var annotationBuilder = e.Builder.AsMarkupAnnotationBuilder();
                annotationBuilder.Author = "John Smith";
                annotationBuilder.Color = new PdfRGBColor(0.20, 0.60, 1.00);
                annotationBuilder.Contents = "Note";
            }
        }
    }
}

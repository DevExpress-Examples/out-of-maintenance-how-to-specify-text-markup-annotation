using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPdfViewer;

namespace SpecifyTextMarkupAnnotationProperties {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Load a document.
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");

            // Handle the TextMarkupAnnotationCreating event to specify the text markup annotation properties when the annotation is being created. 
            pdfViewer1.TextMarkupAnnotationCreating += pdfViewer1_TextMarkupAnnotationCreating;
        }

        private void pdfViewer1_TextMarkupAnnotationCreating(object sender, PdfTextMarkupAnnotationCreatingEventArgs e) {
            e.Author = "John Smith";
            e.Comment = "Note.";
            e.Color = Color.Gold;
        }
    }
}

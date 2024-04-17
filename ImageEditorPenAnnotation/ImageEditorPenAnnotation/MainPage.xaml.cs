using Syncfusion.Maui.ImageEditor;

namespace ImageEditorPenAnnotation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAnnotationSelected(object sender, AnnotationSelectedEventArgs e)
        {
            if (e.AnnotationSettings is ImageEditorShapeSettings shapeSettings)
            {
                shapeSettings.Color = Colors.CadetBlue;
            }
        }
    }
}

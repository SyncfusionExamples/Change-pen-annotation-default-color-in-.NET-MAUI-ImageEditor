using Syncfusion.Maui.ImageEditor;

namespace ImageEditorPenAnnotation
{
    public class ImageEditorBehavior : Behavior<ContentPage>
    {
        private SfImageEditor? editor;

        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);

            this.editor = bindable.FindByName<SfImageEditor>("imageEditor");
            this.editor.AnnotationSelected += Editor_AnnotationSelected;
        }

        private void Editor_AnnotationSelected(object? sender, AnnotationSelectedEventArgs e)
        {
            if (e.AnnotationSettings is ImageEditorShapeSettings shapeSettings)
            {
                shapeSettings.Color = Colors.CadetBlue;
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (editor != null)
            {
                this.editor.AnnotationSelected -= Editor_AnnotationSelected;
                this.editor = null;
            }
        }
    }
}

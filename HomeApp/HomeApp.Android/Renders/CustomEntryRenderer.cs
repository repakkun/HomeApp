using Mobile.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


#pragma warning disable CS0612 // Тип или член устарел
[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
#pragma warning restore CS0612 // Тип или член устарел
namespace Mobile.Droid.Renderers
{
    /// <summary>
    /// Отключаем подчеркивание по умолчанию для элемента Entry не платформе Android
    /// </summary>
    [System.Obsolete]
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}
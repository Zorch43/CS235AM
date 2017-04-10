using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloAndroid
{
    [Activity(Label = "HelloAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var layout = new LinearLayout(this);

            layout.Orientation = Orientation.Vertical;

            var aLabel = new TextView(this);
            aLabel.Text = "Hello, Xamarin.Android";

            var aButton = new Button(this);
            aButton.Text = "Say Hello";


            layout.AddView(aLabel);
            SetContentView(layout);
        }
    }
}


using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace pokeAScreen
{
    [Activity(Label = "pokeAScreen", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);

            var firstPoke = FindViewById<Button>(Resource.Id.firstPokeButton);
            firstPoke.Click += (sender, e) => {
                var second = new Intent(this, typeof(SecondActivity));
                second.PutExtra("poke", true);
                SetContentView(second);

            };

            var firstHi = FindViewById<Button>(Resource.Id.firstHiButton);
            firstHi.Click += (sender, e) => {
                var second = new Intent(this, typeof(SecondActivity));
                second.PutExtra("text", "Hi from screen 1");
                SetContentView(second);
            };
        }
    }
}


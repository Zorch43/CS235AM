﻿using Android.App;
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
            aLabel.SetText(Resource.String.helloLabelText);

            var aButton = new Button(this);
            aButton.SetText(Resource.String.helloButtonText);
            aButton.Click += (sender, e) =>
            {
                aLabel.Text = "Hello from the button";
            };


            layout.AddView(aLabel);
            layout.AddView(aButton);
            SetContentView(layout);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace pokeAScreen
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var label = FindViewById<TextView>(Resource.Id.secondText);
            if (savedInstanceState.GetBoolean("poke")) label.Text = "Poked by Screen 1!";
            else if (savedInstanceState.GetString("text") != null) label.Text = savedInstanceState.GetString("text");
            else label.Text = "Nothing sent from screen one :(";
        }
    }
}
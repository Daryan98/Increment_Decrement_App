﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace First_P
{
    [Activity(Label = "First_P", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView txtNumber;

        int number;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtNumber = FindViewById<TextView>(Resource.Id.txtNumber);

           FindViewById<Button>(Resource.Id.btnIncrement).Click += (e, o) =>
           txtNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement).Click += (e, o) =>
           txtNumber.Text = (--number).ToString();

        }
    }
}


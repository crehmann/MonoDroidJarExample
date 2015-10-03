using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculator.Droid
{
    [Activity(Label = "TipCalculator.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private TextView _tipOutput;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            InitializeView();
        }

        private void InitializeView()
        {
            _tipOutput = FindViewById<TextView>(Resource.Id.textview_tip_output);
            var calculateButton = FindViewById<Button>(Resource.Id.button_calulate);
            calculateButton.Click += CalculateButton_Click;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}


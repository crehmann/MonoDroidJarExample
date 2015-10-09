using Android.App;
using Android.OS;
using Android.Widget;
using Crehmann.Samples.Monodroidjarexample;
using System;

namespace TipCalculator.Droid
{
    [Activity(Label = "TipCalculator.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private readonly ITipCalculationService _tipService;
        private TextView _tipOutput;
        private EditText _priceEditTExt;

        public MainActivity()
        {
            _tipService = new TipCalculationServiceImpl();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            InitializeView();
        }


        private void InitializeView()
        {
            _tipOutput = FindViewById<TextView>(Resource.Id.textview_tip_output);
            _priceEditTExt = FindViewById<EditText>(Resource.Id.edittext_tip_input);
            var calculateButton = FindViewById<Button>(Resource.Id.button_calulate);
            calculateButton.Click += CalculateButton_Click;
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double price;

            if(double.TryParse(_priceEditTExt.Text, out price))
            {
                var tipRequest = new TipRequest() { Price = price, Satisfaction = Satisfaction.Excellent };
                var result = _tipService.CalculateTip(tipRequest) as TipCalculationResult;
                if (result == null) return;
                _tipOutput.Text = result.Tip.ToString("0.00");
            }
            
            
        }
    }
}
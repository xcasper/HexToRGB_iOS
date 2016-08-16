using System;

using UIKit;

namespace HexToRGB_iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            convertButton.TouchUpInside += ConvertButton_TouchUpInside1;
        }

        private void ConvertButton_TouchUpInside1(object sender, EventArgs e)
        {
            /*string hexValue = hexTextField.Text;
            string redHexValue = hexValue.Substring(0, 2);
            string greenHexValue = hexValue.Substring(2, 2);
            string blueHexValue = hexValue.Substring(4, 2);

            int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
            int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
            int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

            redLabel.Text = redValue.ToString();
            greenLabel.Text = greenValue.ToString();
            blueLabel.Text = blueValue.ToString();

            // colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue); */
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void ConvertButton_TouchUpInside(UIButton sender)
        {
            string hexValue = hexTextField.Text;
            errorLabel.Text = "";
            try
            {
                string redHexValue = hexValue.Substring(0, 2);
                string greenHexValue = hexValue.Substring(2, 2);
                string blueHexValue = hexValue.Substring(4, 2);

                int redValue = int.Parse(redHexValue, System.Globalization.NumberStyles.HexNumber);
                int greenValue = int.Parse(greenHexValue, System.Globalization.NumberStyles.HexNumber);
                int blueValue = int.Parse(blueHexValue, System.Globalization.NumberStyles.HexNumber);

                redLabel.Text = redValue.ToString();
                greenLabel.Text = greenValue.ToString();
                blueLabel.Text = blueValue.ToString();

                colorView.BackgroundColor = UIColor.FromRGB(redValue, greenValue, blueValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                //les then 6 characters entered
                errorLabel.Text = "Please enter 6 digits";
            }
            catch (FormatException)
            {
                //wrong format... valid values: 0-9 A-F
                errorLabel.Text = "Please enter proper values. Valid values are 0-9 and A-F";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
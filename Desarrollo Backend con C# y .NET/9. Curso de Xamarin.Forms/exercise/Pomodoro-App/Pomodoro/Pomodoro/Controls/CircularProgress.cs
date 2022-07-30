using Xamarin.Forms;

namespace Pomodoro.Controls
{
    public class CircularProgress : View
    {
        public static readonly BindableProperty IndeterminateProperty =
            BindableProperty.Create(nameof(Indeterminate), typeof(bool), typeof(CircularProgress), default(bool));

        public bool Indeterminate
        {
            get
            {
                return (bool)GetValue(IndeterminateProperty);
            }
            set
            {
                SetValue(IndeterminateProperty, value);
            }
        }

        public static readonly BindableProperty ProgressProperty =
            BindableProperty.Create(nameof(Progress), typeof(float), typeof(CircularProgress), 0f);

        public float Progress
        {
            get
            {
                return (float)GetValue(ProgressProperty);
            }
            set
            {
                SetValue(ProgressProperty, value);
            }
        }

        public static readonly BindableProperty MaxProperty =
            BindableProperty.Create(nameof(Max), typeof(float), typeof(CircularProgress), 100f);

        public float Max
        {
            get
            {
                return (float)GetValue(MaxProperty);
            }
            set
            {
                SetValue(MaxProperty, value);
            }
        }

        public static readonly BindableProperty ProgressBackgroundColorProperty =
            BindableProperty.Create(nameof(ProgressBackgroundColor), typeof(Color), typeof(CircularProgress),
                Color.White);

        public Color ProgressBackgroundColor
        {
            get
            {
                return (Color)GetValue(ProgressBackgroundColorProperty);
            }
            set
            {
                SetValue(ProgressBackgroundColorProperty, value);
            }
        }

        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create(nameof(ProgressColor), typeof(Color), typeof(CircularProgress), Color.Red);

        public Color ProgressColor
        {
            get
            {
                return (Color)GetValue(ProgressColorProperty);
            }
            set
            {
                SetValue(ProgressColorProperty, value);
            }
        }

        public static readonly BindableProperty IndeterminateSpeedProperty =
            BindableProperty.Create(nameof(IndeterminateSpeed), typeof(int), typeof(CircularProgress), 100);

        public int IndeterminateSpeed
        {
            get
            {
                return (int)GetValue(IndeterminateSpeedProperty);
            }
            set
            {
                SetValue(IndeterminateSpeedProperty, value);
            }
        }
    }
}
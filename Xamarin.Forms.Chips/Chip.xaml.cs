using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Xamarin.Forms.Chips
{
    public partial class Chip : Frame
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text), typeof(string), typeof(Chip));

        public static readonly BindableProperty FontFamilyProperty = BindableProperty.Create(
            nameof(FontFamily), typeof(string), typeof(Chip));

        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create(
            nameof(FontSize), typeof(double), typeof(Chip), Device.GetNamedSize(NamedSize.Default, typeof(Label)));

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
            nameof(TextColor), typeof(Color), typeof(Chip), Color.DarkGray);

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            nameof(Image), typeof(ImageSource), typeof(Chip));

        public static readonly BindableProperty ClickedCommandProperty = BindableProperty.Create(
            nameof(ClickedCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty ClickedCommandParameterProperty = BindableProperty.Create(
            nameof(ClickedCommandParameter), typeof(object), typeof(Chip));

        public static readonly BindableProperty CloseCommandProperty = BindableProperty.Create(
            nameof(CloseCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty CloseCommandParameterProperty = BindableProperty.Create(
            nameof(CloseCommandParameter), typeof(object), typeof(Chip));

        public static readonly BindableProperty CloseImageProperty = BindableProperty.Create(
            nameof(CloseImage), typeof(ImageSource), typeof(Chip));

        public static readonly BindableProperty IsToggleableProperty = BindableProperty.Create(
            nameof(IsToggleable), typeof(bool), typeof(Chip), propertyChanged: OnIsSelectedPropertyChanged);

        public static readonly BindableProperty AutoToggleProperty = BindableProperty.Create(
            nameof(AutoToggle), typeof(bool), typeof(Chip));

        public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
            nameof(IsSelected), typeof(bool), typeof(Chip), false, BindingMode.TwoWay, propertyChanged: OnIsSelectedPropertyChanged);

        public static readonly BindableProperty SelectCommandProperty = BindableProperty.Create(
            nameof(SelectCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty SelectCommandParameterProperty = BindableProperty.Create(
            nameof(SelectCommandParameterProperty), typeof(object), typeof(Chip));

        public static readonly BindableProperty UnselectCommandProperty = BindableProperty.Create(
            nameof(UnselectCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty UnselectCommandParameterProperty = BindableProperty.Create(
            nameof(UnselectCommandParameterProperty), typeof(object), typeof(Chip));

        public static readonly BindableProperty UnselectedBackgroundColorProperty = BindableProperty.Create(
            nameof(UnselectedBackgroundColor), typeof(Color), typeof(Chip), Color.DarkOrange);

        public static readonly BindableProperty SelectedBackgroundColorProperty = BindableProperty.Create(
            nameof(SelectedBackgroundColor), typeof(Color), typeof(Chip), Color.Yellow);

        public static readonly BindableProperty UnselectedHasShadowProperty = BindableProperty.Create(
            nameof(UnselectedHasShadow), typeof(bool), typeof(Chip));

        public static readonly BindableProperty SelectedHasShadowProperty = BindableProperty.Create(
            nameof(SelectedHasShadow), typeof(bool), typeof(Chip), true);

        public event EventHandler OnClicked;

        public event EventHandler OnClose;

        public event EventHandler OnSelect;

        public event EventHandler OnUnselect;

        public string Text
        {
            get => (string)GetValue(Chip.TextProperty);
            set => SetValue(Chip.TextProperty, value);
        }

        public string FontFamily
        {
            get => (string)GetValue(Chip.FontFamilyProperty);
            set => SetValue(Chip.FontFamilyProperty, value);
        }

        [Xamarin.Forms.TypeConverter(typeof(FontSizeConverter))]
        public double FontSize
        {
            get => (double)GetValue(Chip.FontSizeProperty);
            set => SetValue(Chip.FontSizeProperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(Chip.TextColorProperty);
            set => SetValue(Chip.TextColorProperty, value);
        }

        public ImageSource Image
        {
            get => (ImageSource)GetValue(Chip.ImageProperty);
            set => SetValue(Chip.ImageProperty, value);
        }

        public ICommand ClickedCommand
        {
            get => (ICommand)GetValue(Chip.ClickedCommandProperty);
            set => SetValue(Chip.ClickedCommandProperty, value);
        }

        public object ClickedCommandParameter
        {
            get => GetValue(Chip.ClickedCommandParameterProperty);
            set => SetValue(Chip.ClickedCommandParameterProperty, value);
        }

        public ICommand CloseCommand
        {
            get => (ICommand)GetValue(Chip.CloseCommandProperty);
            set => SetValue(Chip.CloseCommandProperty, value);
        }

        public object CloseCommandParameter
        {
            get => GetValue(Chip.CloseCommandParameterProperty);
            set => SetValue(Chip.CloseCommandParameterProperty, value);
        }

        public ImageSource CloseImage
        {
            get => (ImageSource)GetValue(Chip.CloseImageProperty);
            set => SetValue(Chip.CloseImageProperty, value);
        }

        public bool IsToggleable
        {
            get => (bool)GetValue(Chip.IsToggleableProperty);
            set => SetValue(Chip.IsToggleableProperty, value);
        }

        public bool AutoToggle
        {
            get => (bool)GetValue(Chip.AutoToggleProperty);
            set => SetValue(Chip.AutoToggleProperty, value);
        }

        public bool IsSelected
        {
            get => (bool)GetValue(Chip.IsSelectedProperty);
            set => SetValue(Chip.IsSelectedProperty, value);
        }

        public ICommand SelectCommand
        {
            get => (ICommand)GetValue(Chip.SelectCommandProperty);
            set => SetValue(Chip.SelectCommandProperty, value);
        }

        public object SelectCommandParameter
        {
            get => GetValue(Chip.SelectCommandParameterProperty);
            set => SetValue(Chip.SelectCommandParameterProperty, value);
        }

        public ICommand UnselectCommand
        {
            get => (ICommand)GetValue(Chip.UnselectCommandProperty);
            set => SetValue(Chip.UnselectCommandProperty, value);
        }

        public object UnselectCommandParameter
        {
            get => GetValue(Chip.UnselectCommandParameterProperty);
            set => SetValue(Chip.UnselectCommandParameterProperty, value);
        }

        public Color UnselectedBackgroundColor
        {
            get => (Color)GetValue(Chip.UnselectedBackgroundColorProperty);
            set => SetValue(Chip.UnselectedBackgroundColorProperty, value);
        }

        public Color SelectedBackgroundColor
        {
            get => (Color)GetValue(Chip.SelectedBackgroundColorProperty);
            set => SetValue(Chip.SelectedBackgroundColorProperty, value);
        }

        public bool UnselectedHasShadow
        {
            get => (bool)GetValue(Chip.UnselectedHasShadowProperty);
            set => SetValue(Chip.UnselectedHasShadowProperty, value);
        }

        public bool SelectedHasShadow
        {
            get => (bool)GetValue(Chip.SelectedHasShadowProperty);
            set => SetValue(Chip.SelectedHasShadowProperty, value);
        }

        private static void OnIsSelectedPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue != oldValue)
                ((Chip)bindable).RefreshVisualState();
        }

        public Chip()
        {
            InitializeComponent();

            this.LayoutChanged += (object sender, EventArgs e) =>
            {
                this.CornerRadius = (float)(this.Height / DeviceDisplay.MainDisplayInfo.Density);
            };
        }

        private void RefreshVisualState()
        {
            var stateName = this.IsToggleable ? (this.IsSelected ? "Selected" : "Unselected") : "Normal";
            VisualStateManager.GoToState(this, stateName);
        }

        private void Clicked(object sender, EventArgs args)
        {
            this.OnClicked?.Invoke(sender, args);

            if (this.ClickedCommand != null && this.ClickedCommand.CanExecute(this.ClickedCommandParameter))
                this.ClickedCommand.Execute(this.ClickedCommandParameter);

            if (this.IsToggleable)
            {
                if (this.AutoToggle)
                {
                    this.IsSelected = !this.IsSelected;
                    this.RefreshVisualState();
                }

                if (this.IsSelected)
                {
                    this.OnSelect?.Invoke(this, new EventArgs());

                    if (this.SelectCommand != null && this.SelectCommand.CanExecute(this.SelectCommandParameter))
                        this.SelectCommand.Execute(this.SelectCommandParameter);
                }
                else
                {
                    this.OnUnselect?.Invoke(this, new EventArgs());

                    if (this.UnselectCommand != null && this.SelectCommand.CanExecute(this.UnselectCommandParameter))
                        this.UnselectCommand.Execute(this.UnselectCommandParameter);
                }
            }
        }

        private void CloseButton_Clicked(object sender, EventArgs args)
        {
            this.OnClose?.Invoke(sender, args);

            if (this.CloseCommand != null && this.CloseCommand.CanExecute(this.CloseCommandParameter))
                this.CloseCommand.Execute(this.CloseCommandParameter);
        }
    }
}

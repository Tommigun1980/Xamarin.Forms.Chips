using System;
using System.Windows.Input;

namespace Xamarin.Forms.Chips
{
    public partial class Chip : Frame
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
            nameof(Text), typeof(string), typeof(Chip));

        public static readonly BindableProperty FormattedTextProperty = BindableProperty.Create(
            nameof(FormattedText), typeof(FormattedString), typeof(Chip));

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
            nameof(TextColor), typeof(Color), typeof(Chip));

        public static readonly BindableProperty TextStyleProperty = BindableProperty.Create(
            nameof(TextStyle), typeof(Style), typeof(Chip));

        public static readonly BindableProperty LineBreakModeProperty = BindableProperty.Create(
            nameof(LineBreakMode), typeof(LineBreakMode), typeof(Chip));

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(
            nameof(Image), typeof(ImageSource), typeof(Chip));

        public static readonly BindableProperty ImageStyleProperty = BindableProperty.Create(
            nameof(ImageStyle), typeof(Style), typeof(Chip));

        public static readonly BindableProperty CloseButtonImageProperty = BindableProperty.Create(
            nameof(CloseButtonImage), typeof(ImageSource), typeof(Chip));

        public static readonly BindableProperty CloseButtonImageStyleProperty = BindableProperty.Create(
            nameof(CloseButtonImageStyle), typeof(Style), typeof(Chip));

        public static readonly BindableProperty FontImageTextProperty = BindableProperty.Create(
            nameof(FontImageText), typeof(string), typeof(Chip));

        public static readonly BindableProperty FontImageStyleProperty = BindableProperty.Create(
            nameof(FontImageStyle), typeof(Style), typeof(Chip));

        public static readonly BindableProperty CloseButtonFontImageTextProperty = BindableProperty.Create(
            nameof(CloseButtonFontImageText), typeof(string), typeof(Chip));

        public static readonly BindableProperty CloseButtonFontImageStyleProperty = BindableProperty.Create(
            nameof(CloseButtonFontImageStyle), typeof(Style), typeof(Chip));

        public static readonly BindableProperty ClickedCommandProperty = BindableProperty.Create(
            nameof(ClickedCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty ClickedCommandParameterProperty = BindableProperty.Create(
            nameof(ClickedCommandParameter), typeof(object), typeof(Chip));

        public static readonly BindableProperty CloseCommandProperty = BindableProperty.Create(
            nameof(CloseCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty CloseCommandParameterProperty = BindableProperty.Create(
            nameof(CloseCommandParameter), typeof(object), typeof(Chip));

        public static readonly BindableProperty IsToggleableProperty = BindableProperty.Create(
            nameof(IsToggleable), typeof(bool), typeof(Chip), propertyChanged: StatePropertyChanged);

        public static readonly BindableProperty AutoToggleProperty = BindableProperty.Create(
            nameof(AutoToggle), typeof(bool), typeof(Chip));

        public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
            nameof(IsSelected), typeof(bool), typeof(Chip), false, BindingMode.TwoWay, propertyChanged: StatePropertyChanged);

        public static readonly BindableProperty IsDisabledProperty = BindableProperty.Create(
            nameof(IsDisabled), typeof(bool), typeof(Chip), false, BindingMode.OneWay, propertyChanged: StatePropertyChanged);

        public static readonly BindableProperty SelectCommandProperty = BindableProperty.Create(
            nameof(SelectCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty SelectCommandParameterProperty = BindableProperty.Create(
            nameof(SelectCommandParameter), typeof(object), typeof(Chip));

        public static readonly BindableProperty UnselectCommandProperty = BindableProperty.Create(
            nameof(UnselectCommand), typeof(ICommand), typeof(Chip));

        public static readonly BindableProperty UnselectCommandParameterProperty = BindableProperty.Create(
            nameof(UnselectCommandParameter), typeof(object), typeof(Chip));

        public event EventHandler OnClicked;

        public event EventHandler OnClose;

        public event EventHandler OnSelect;

        public event EventHandler OnUnselect;

        public string Text
        {
            get => (string)GetValue(Chip.TextProperty);
            set => SetValue(Chip.TextProperty, value);
        }

        public FormattedString FormattedText
        {
            get => (FormattedString)GetValue(Chip.FormattedTextProperty);
            set => SetValue(Chip.FormattedTextProperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(Chip.TextColorProperty);
            set => SetValue(Chip.TextColorProperty, value);
        }

        public Style TextStyle
        {
            get => (Style)GetValue(Chip.TextStyleProperty);
            set => SetValue(Chip.TextStyleProperty, value);
        }

        public LineBreakMode LineBreakMode
        {
            get => (LineBreakMode)GetValue(Chip.LineBreakModeProperty);
            set => SetValue(Chip.LineBreakModeProperty, value);
        }

        public ImageSource Image
        {
            get => (ImageSource)GetValue(Chip.ImageProperty);
            set => SetValue(Chip.ImageProperty, value);
        }

        public Style ImageStyle
        {
            get => (Style)GetValue(Chip.ImageStyleProperty);
            set => SetValue(Chip.ImageStyleProperty, value);
        }

        public ImageSource CloseButtonImage
        {
            get => (ImageSource)GetValue(Chip.CloseButtonImageProperty);
            set => SetValue(Chip.CloseButtonImageProperty, value);
        }

        public Style CloseButtonImageStyle
        {
            get => (Style)GetValue(Chip.CloseButtonImageStyleProperty);
            set => SetValue(Chip.CloseButtonImageStyleProperty, value);
        }

        public string FontImageText
        {
            get => (string)GetValue(Chip.FontImageTextProperty);
            set => SetValue(Chip.FontImageTextProperty, value);
        }

        public Style FontImageStyle
        {
            get => (Style)GetValue(Chip.FontImageStyleProperty);
            set => SetValue(Chip.FontImageStyleProperty, value);
        }

        public string CloseButtonFontImageText
        {
            get => (string)GetValue(Chip.CloseButtonFontImageTextProperty);
            set => SetValue(Chip.CloseButtonFontImageTextProperty, value);
        }

        public Style CloseButtonFontImageStyle
        {
            get => (Style)GetValue(Chip.CloseButtonFontImageStyleProperty);
            set => SetValue(Chip.CloseButtonFontImageStyleProperty, value);
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

        public bool IsDisabled
        {
            get => (bool)GetValue(Chip.IsDisabledProperty);
            set => SetValue(Chip.IsDisabledProperty, value);
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

        private static void StatePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (newValue != oldValue)
                ((Chip)bindable).RefreshVisualState();
        }

        public Chip()
        {
            InitializeComponent();

            this.SizeChanged += (object sender, EventArgs e) =>
            {
                this.CornerRadius = (float)(this.Height * 0.5);
            };
        }

        private void RefreshVisualState()
        {
            var stateName = this.IsDisabled ? "Disabled" : (!this.IsToggleable ? "Normal" : (this.IsSelected ? "Selected" : "Normal"));

            VisualStateManager.GoToState(this, stateName);
        }

        private void Clicked(object sender, EventArgs args)
        {
            if (this.IsDisabled)
                return;

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
            if (this.IsDisabled)
                return;

            this.OnClose?.Invoke(sender, args);

            if (this.CloseCommand != null && this.CloseCommand.CanExecute(this.CloseCommandParameter))
                this.CloseCommand.Execute(this.CloseCommandParameter);
        }
    }
}

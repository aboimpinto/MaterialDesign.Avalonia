using System;
using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls.Primitives;
using MaterialDesign.Avalonia.PackIcon;

namespace MaterialDesign.Avalonia.PackIcon
{
    public class PackIcon : TemplatedControl
    {
        private static readonly Lazy<IDictionary<PackIconKind, string>> _dataIndex
            = new Lazy<IDictionary<PackIconKind, string>>(PackIconDataFactory.Create);

        public static readonly AvaloniaProperty KindProperty = 
            AvaloniaProperty.Register<PackIcon, PackIconKind>(
                nameof(Kind));

        public PackIconKind Kind
        {
            get => (PackIconKind)GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }

        public static AvaloniaProperty DataProperty =  
            AvaloniaProperty.Register<PackIcon, string>(
                nameof(Data));

        public string? Data
        { 
            get => (string)GetValue(DataProperty);  
            set => SetValue(DataProperty, value);
        }

        static PackIcon()
        {
            KindProperty.Changed.Subscribe(OnKindPropertyChanged);
        }

        private static void OnKindPropertyChanged(AvaloniaPropertyChangedEventArgs obj)
        {
            var packIcon = obj.Sender as PackIcon;

            if (packIcon == null)
            {
                return;
            }

            packIcon.UpdateData();
        }

        protected override void OnTemplateApplied(TemplateAppliedEventArgs e)
        {
            base.OnTemplateApplied(e);
            this.UpdateData();
        }

        private void UpdateData()
        {
            string? data = null;
            _dataIndex.Value?.TryGetValue(Kind, out data);
            Data = data;
        }
    }
}
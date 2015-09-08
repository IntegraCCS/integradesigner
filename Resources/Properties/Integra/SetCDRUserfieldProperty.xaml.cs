﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IntegraDesigner.Resources.Properties
{
    /// <summary>
    /// Interaction logic for SetCDRUserfieldProperty.xaml
    /// </summary>
    public partial class SetCDRUserfieldProperty : UserControl
    {
        SetCDRUserfield s { get; set; }

        public SetCDRUserfieldProperty()
        {
            InitializeComponent();
        }
        public override string ToString()
        {
            s = (SetCDRUserfield)base.Tag;

          
            Binding myBinding2 = new Binding("userfield");
            myBinding2.Mode = BindingMode.TwoWay;
            myBinding2.Source = s;
            txtval.SetBinding(TextBox.TextProperty, myBinding2);



            Binding descbinding = new Binding("Description");
            descbinding.Mode = BindingMode.TwoWay;
            descbinding.Source = s;
            txtdesc.SetBinding(TextBox.TextProperty, descbinding);

            return base.ToString();
        }
    }
}
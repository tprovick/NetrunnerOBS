﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace NetrunnerOBS {
	public class CardLoadTemplateSelector : DataTemplateSelector {
		public override DataTemplate SelectTemplate(object item, DependencyObject container) {
			Window wnd = Application.Current.MainWindow;
			if (item is string)
				return wnd.FindResource("WaitTemplate") as DataTemplate;
			else
				return wnd.FindResource("TheItemTemplate") as DataTemplate;
		}
	}
}

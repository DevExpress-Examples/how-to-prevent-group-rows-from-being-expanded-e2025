﻿using System.Windows;
using DevExpress.Xpf.Grid;
using DXExample.DemoData;

namespace DXGrid_PreventGroupRowsFromExpanding {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            gridControl1.ItemsSource = Invoice.GetData();
        }
        private void gridControl1_GroupRowExpanding(object sender, RowAllowEventArgs e) {
            if ( e.Row == null ||
                ((Invoice)e.Row).Status == InvoiceStatus.Invalidated &&
                colStatus.GroupIndex != -1 )
                e.Allow = false;
        }
    }
}

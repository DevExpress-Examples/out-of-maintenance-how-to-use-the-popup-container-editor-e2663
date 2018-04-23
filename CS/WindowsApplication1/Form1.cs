using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            popupContainerEdit1.Text = ValuesConverter.TrackBarRangeToString(new TrackBarRange(5, 10));
        }


        private void OnQueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = ValuesConverter.TrackBarRangeToString(rangeTrackBarControl1.Value);
        }

        private void OnQueryPopup(object sender, CancelEventArgs e)
        {
            TrackBarRange value = ValuesConverter.StringToTrackBarRange((sender as PopupContainerEdit).Text);
            if (value.IsEmpty)
                e.Cancel = true;
            else
                ApplyValue(value);
        }
        private void ApplyValue(TrackBarRange value)
        {
            RepositoryItemRangeTrackBar properties = rangeTrackBarControl1.Properties;
            properties.Minimum = Math.Min(properties.Minimum, value.Minimum);
            properties.Maximum = Math.Max(properties.Maximum, value.Maximum);
            rangeTrackBarControl1.Value = value;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            popupContainerEdit1.ClosePopup();
        }
    }
}
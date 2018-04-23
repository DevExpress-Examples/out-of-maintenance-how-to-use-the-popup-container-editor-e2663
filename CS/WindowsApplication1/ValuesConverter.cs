using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;

namespace WindowsApplication1
{
    public class ValuesConverter
    {



        public static string TrackBarRangeToString(TrackBarRange range)
        {
            return string.Format("{0},{1}", range.Minimum, range.Maximum);
        }

        public static TrackBarRange StringToTrackBarRange(string value)
        {
            TrackBarRange result = TrackBarRange.Empty;
            string[] values = value.Split(',');
            if (values.Length == 2)
            {
                int min = Convert.ToInt32(values[0]);
                int max = Convert.ToInt32(values[1]);
                result = new TrackBarRange(min, max);
            }
            return result;
        }


    }
}

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AutomaticCloseControlLibrary
{
	public partial class AutomaticCloseControl : UserControl
	{
		[Category("Behaviour")]
		[Description("This allows us to turn inner timer controls")]
		public bool TimersEnabled { get; set; }

		private TimeSpan _time;

		[Category("Behaviour")]
		[Description("Set time to close form. Beware - it can't be more than max value of int!")]
		public TimeSpan Time
		{
			get { return _time; }
			set
			{
				_time = value;
				labelTime.Text = _time.ToString();
				timerClose.Interval = (int) Time.TotalMilliseconds;
			}
		}

		private readonly TimeSpan _oneSecondTime = new TimeSpan(0, 0, 1);
		
		public AutomaticCloseControl()
		{
			InitializeComponent();
		}

		private void TimerUpdateLabelTick(object sender, EventArgs e)
		{
			if (DesignMode) return;

			Time = Time.Subtract(_oneSecondTime);
			labelTime.Text = Time.ToString();
		}

		private void TimerCloseTick(object sender, EventArgs e)
		{
			if (DesignMode) return;

			try
			{
				var form = (Form) Parent;
				form.Close();
			}
			catch (Exception)
			{
				try
				{
					var form = (Form) Parent.Parent;
					form.Close();
				}
				catch (Exception)
				{
					var form = (Form) Parent.Parent.Parent;
					form.Close();
				}
			}
		}

		private void AutomaticCloseControlLoad(object sender, EventArgs e)
		{
			if (DesignMode) return;

			timerUpdateLabel.Interval = (int)_oneSecondTime.TotalMilliseconds;
			timerClose.Enabled = timerUpdateLabel.Enabled = TimersEnabled;
		}
	}
}

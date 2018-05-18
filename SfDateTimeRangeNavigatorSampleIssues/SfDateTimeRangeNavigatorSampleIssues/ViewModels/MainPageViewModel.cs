using System;
using Xamarin.Forms;

namespace SfDateTimeRangeNavigatorSampleIssues.ViewModels
{
    class MainPageViewModel
    {
        #region Private Properties

        private DateTime maximum;
        private DateTime minimum;

        #endregion

        #region Public Properties

        public DateTime Maximum { get { return maximum; } set { maximum = value; } }
        public DateTime Minimum { get { return minimum; } set { minimum = value; } }

        #endregion

        #region Constructors

        public MainPageViewModel(INavigation navigation)
        {
            var year = DateTime.Now.Year;
            minimum = new DateTime(year, 1, 1);
            maximum = new DateTime(year, 12, 31);
        }

        #endregion
    }
}
namespace MakingTask
{
    partial class Program
    {
        class SettingRange
        {
            string _startDate;
            string _endDate;

            public string Start
            {
                get { return _startDate; }
                set { _startDate = value; }
            }

            public string End
            {
                get { return _endDate; }
                set { _endDate = value; }
            }

        }
    }
}

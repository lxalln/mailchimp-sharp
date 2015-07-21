using System;
using System.Collections.Generic;
using System.Linq;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateContentOptions
    {
        internal CampaignCreateContentOptions()
        {
            Sections = new Dictionary<string, string>();
        }

        public enum ArchiveTypeOption
        {
            Zip, 
            TarGz, 
            TarBz2, 
            Tar, 
            Tgz, 
            Tbz
        }

        public string Archive { get; internal set; }

        public ArchiveTypeOption ArchiveType { get; internal set; }

        public string Html { get; internal set; }

        public IDictionary<string, string> Sections { get; private set; }

        public string Text { get; internal set; }

        public string Url { get; internal set; }
    }

    public class CampaignCreateTypeOptions
    {
        public class AbSplitOptions
        {
            internal AbSplitOptions()
            {
            }

            public enum PickWinnerOption
            {
                Opens, 
                Clicks, 
                Manual
            }

            public enum SplitTestType
            {
                Subject, 
                FromName, 
                Schedule
            }

            public string FromEmailA { get; internal set; }

            public string FromEmailB { get; internal set; }

            public string FromNameA { get; internal set; }

            public string FromNameB { get; internal set; }

            public PickWinnerOption PickWinner { get; internal set; }

            public int SplitSize { get; internal set; }

            public SplitTestType SplitTest { get; internal set; }

            public string SubjectA { get; internal set; }

            public string SubjectB { get; internal set; }

            public int WaitTime { get; internal set; }

            public int WaitUnits { get; internal set; }
        }

        public class AbSplitOptionsBuilder
        {
            public AbSplitOptionsBuilder()
            {
                Options = new AbSplitOptions();
            }

            private AbSplitOptions Options { get; set; }

            public static implicit operator AbSplitOptions(AbSplitOptionsBuilder builder)
            {
                return builder.Options;
            }

            public AbSplitOptionsBuilder SplitOn(AbSplitOptions.SplitTestType splitTestType)
            {
                Options.SplitTest = splitTestType;
                return this;
            }

            public AbSplitOptionsBuilder WonBy(AbSplitOptions.PickWinnerOption winner)
            {
                Options.PickWinner = winner;
                return this;
            }
        }

        public class RssOptions
        {
            internal RssOptions()
            {
                Schedule = RssSchedule.Daily;
            }

            public enum RssSchedule
            {
                Daily, 
                Weekly, 
                Monthly
            }

            public RssScheduleDays Days { get; internal set; }

            public RssSchedule Schedule { get; internal set; }

            public string ScheduleHour { get; internal set; }

            public string ScheduleMonthDay { get; internal set; }

            public DayOfWeek ScheduleWeekDay { get; internal set; }

            public string Url { get; internal set; }

            public class RssScheduleDays
            {
                public RssScheduleDays()
                {
                    Monday = true;
                    Tuesday = true;
                    Wednesday = true;
                    Thursday = true;
                    Friday = true;
                    Saturday = true;
                    Sunday = true;
                }

                public bool Friday { get; set; }

                public bool Monday { get; set; }

                public bool Saturday { get; set; }

                public bool Sunday { get; set; }

                public bool Thursday { get; set; }

                public bool Tuesday { get; set; }

                public bool Wednesday { get; set; }
            }
        }

        public class RssOptionsBuilder
        {
            public RssOptionsBuilder()
            {
                Options = new RssOptions();
            }

            private RssOptions Options { get; set; }

            public static implicit operator RssOptions(RssOptionsBuilder builder)
            {
                return builder.Options;
            }

            public RssOptionsBuilder At(int hour)
            {
                if (hour < 0 || hour > 24)
                {
                    throw new ArgumentException("Hour must be between 0 and 24");
                }

                Options.ScheduleHour = Convert.ToString(hour);
                return this;
            }

            public RssOptionsBuilder FromUrl(string url)
            {
                Options.Url = url;
                return this;
            }

            public RssOptionsBuilder On(DayOfWeek dayOfWeek)
            {
                Options.ScheduleWeekDay = dayOfWeek;
                return this;
            }

            public RssOptionsBuilder On(params DayOfWeek[] daysOfWeek)
            {
                Options.Days = new RssOptions.RssScheduleDays
                {
                    Monday = daysOfWeek.Contains(DayOfWeek.Monday), 
                    Tuesday = daysOfWeek.Contains(DayOfWeek.Tuesday), 
                    Wednesday = daysOfWeek.Contains(DayOfWeek.Wednesday), 
                    Thursday = daysOfWeek.Contains(DayOfWeek.Thursday), 
                    Friday = daysOfWeek.Contains(DayOfWeek.Friday), 
                    Saturday = daysOfWeek.Contains(DayOfWeek.Saturday), 
                    Sunday = daysOfWeek.Contains(DayOfWeek.Sunday)
                };

                return this;
            }

            public RssOptionsBuilder OnDayOfMonth(int dayOfMonth)
            {
                if (dayOfMonth < 1 || dayOfMonth > 28)
                {
                    throw new ArgumentException("Day of month must be between 1 and 28");
                }

                Options.ScheduleMonthDay = Convert.ToString(dayOfMonth);
                return this;
            }

            public RssOptionsBuilder OnLastDayOfMonth()
            {
                Options.ScheduleMonthDay = "last";
                return this;
            }

            public RssOptionsBuilder UsingSchedule(RssOptions.RssSchedule schedule)
            {
                Options.Schedule = schedule;
                return this;
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace MailChimpSharp.Core.Sections.Campaigns
{
    public class CampaignCreateOptions
    {
        public CampaignCreateOptions()
        {
            Authenticate = false;
            AutoFooter = false;
            InlineCss = false;
            GenerateText = false;
            AutoTweet = false;
            AutoFacebookPost = new List<string>();
            FacebookComments = true;
            Timewarp = false;
            Tracking = new TrackingOptions();
        }

        public string ListId { get; internal set; }

        public string Subject { get; internal set; }

        public string FromEmail { get; internal set; }

        public string FromName { get; internal set; }

        public string ToName { get; internal set; }

        public int? TemplateId { get; internal set; }

        public int? GalleryTemplateId { get; internal set; }

        public int? BaseTemplateId { get; internal set; }

        public int? FolderId { get; internal set; }

        public TrackingOptions Tracking { get; internal set; }

        public string Title { get; internal set; }

        public bool Authenticate { get; internal set; }

        public AnalyticsOptions Analytics { get; internal set; }

        public bool AutoFooter { get; internal set; }

        public bool InlineCss { get; internal set; }

        public bool GenerateText { get; internal set; }

        public bool AutoTweet { get; internal set; }

        public List<string> AutoFacebookPost { get; private set; } 

        public bool FacebookComments { get; internal set; }

        public bool Timewarp { get; internal set; }

        public bool Ecomm360 { get; internal set; }

        public CrmTrackingOptions CrmTracking { get; internal set; }

        public class TrackingOptions
        {
            public TrackingOptions()
            {
                Opens = true;
                HtmlClicks = true;
                TextClicks = false;
            }

            public bool Opens { get; internal set; }

            public bool HtmlClicks { get; internal set; }

            public bool TextClicks { get; internal set; }
        }

        public class AnalyticsOptions
        {
            private string _google;
            private string _clickTale;
            private string _goal;

            public string Google
            {
                get
                {
                    return _google;
                }

                internal set
                {
                    if (System.Text.Encoding.Unicode.GetByteCount(value) > 50)
                    {
                        throw new ArgumentException("Value must be no more than 50 bytes");
                    }

                    _google = value;
                }
            }

            public string ClickTale
            {
                get
                {
                    return _clickTale;
                }

                internal set
                {
                    if (System.Text.Encoding.Unicode.GetByteCount(value) > 50)
                    {
                        throw new ArgumentException("Value must be no more than 50 bytes");
                    }

                    _clickTale = value;
                }
            }

            /// <summary>
            /// todo: ensure param is gooal (including the extra o)
            /// </summary>
            public string Goal
            {
                get
                {
                    return _goal;
                }

                internal set
                {
                    if (System.Text.Encoding.Unicode.GetByteCount(value) > 50)
                    {
                        throw new ArgumentException("Value must be no more than 50 bytes");
                    }

                    _goal = value;
                }
            }
        }

        public class CrmTrackingOptions 
        {
            public SalesForceOptions SalesForce { get; internal set; }

            public HighriseOptions Highrise { get; internal set; }

            public CapsuleOptions Capsule { get; internal set; }

            public class SalesForceOptions
            {
                public bool Campaign { get; internal set; }

                public bool Notes { get; internal set; }
            }

            public class HighriseOptions
            {
                public bool Campaign { get; internal set; }

                public bool Notes { get; internal set; }
            }

            public class CapsuleOptions
            {
                public bool Notes { get; internal set; }
            }
        }
    }
}
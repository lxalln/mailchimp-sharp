﻿namespace MailChimpSharp.Core.Sections.Vip
{
    public class Vip : IVip
    {
        private readonly IMailChimpConnector _connector;

        internal Vip(IMailChimpConnector connector)
        {
            _connector = connector;
        }
    }
}
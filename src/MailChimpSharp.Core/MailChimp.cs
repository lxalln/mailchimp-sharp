using MailChimpSharp.Core.Sections.Automations;
using MailChimpSharp.Core.Sections.Campaigns;
using MailChimpSharp.Core.Sections.Conversations;
using MailChimpSharp.Core.Sections.Ecomm;
using MailChimpSharp.Core.Sections.Folders;
using MailChimpSharp.Core.Sections.Gallery;
using MailChimpSharp.Core.Sections.Goal;
using MailChimpSharp.Core.Sections.Helper;
using MailChimpSharp.Core.Sections.Lists;
using MailChimpSharp.Core.Sections.Reports;
using MailChimpSharp.Core.Sections.Templates;
using MailChimpSharp.Core.Sections.Users;
using MailChimpSharp.Core.Sections.Vip;

namespace MailChimpSharp.Core
{
    public class MailChimp : IMailChimp
    {
        internal MailChimp(
            IAutomations automations, 
            ICampaigns campaigns, 
            IConversations conversations, 
            IEcomm ecomm, 
            IFolders folders, 
            IGallery gallery, 
            IGoal goal, 
            IHelper helper, 
            ILists lists, 
            IReports reports, 
            ITemplates templates, 
            IUsers users, 
            IVip vip)
        {
            Automations = automations;
            Campaigns = campaigns;
            Conversations = conversations;
            Ecomm = ecomm;
            Folders = folders;
            Gallery = gallery;
            Goal = goal;
            Helper = helper;
            Lists = lists;
            Reports = reports;
            Templates = templates;
            Users = users;
            Vip = vip;
        }

        public IAutomations Automations { get; set; }

        public ICampaigns Campaigns { get; set; }

        public IConversations Conversations { get; set; }

        public IEcomm Ecomm { get; set; }

        public IFolders Folders { get; set; }

        public IGallery Gallery { get; set; }

        public IGoal Goal { get; set; }

        public IHelper Helper { get; set; }

        public ILists Lists { get; set; }

        public IReports Reports { get; set; }

        public ITemplates Templates { get; set; }

        public IUsers Users { get; set; }

        public IVip Vip { get; set; }
    }
}
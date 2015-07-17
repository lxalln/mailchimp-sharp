using MailChimpSharp.Core.Automations;
using MailChimpSharp.Core.Campaigns;
using MailChimpSharp.Core.Conversations;
using MailChimpSharp.Core.Ecomm;
using MailChimpSharp.Core.Folders;
using MailChimpSharp.Core.Gallery;
using MailChimpSharp.Core.Goal;
using MailChimpSharp.Core.Helper;
using MailChimpSharp.Core.Lists;
using MailChimpSharp.Core.Reports;
using MailChimpSharp.Core.Templates;
using MailChimpSharp.Core.Users;
using MailChimpSharp.Core.Vip;

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
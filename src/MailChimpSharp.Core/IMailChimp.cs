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
    public interface IMailChimp
    {
        IAutomations Automations { get; set; }

        ICampaigns Campaigns { get; set; }

        IConversations Conversations { get; set; }

        IEcomm Ecomm { get; set; }

        IFolders Folders { get; set; }

        IGallery Gallery { get; set; }

        IGoal Goal { get; set; }

        IHelper Helper { get; set; }

        ILists Lists { get; set; }

        IReports Reports { get; set; }

        ITemplates Templates { get; set; }

        IUsers Users { get; set; }

        IVip Vip { get; set; }
    }
}

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

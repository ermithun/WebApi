using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiCore.Entities.Enum
{
    public enum RowStatus
    {
        New = 0,
        Approved = 1,
        Modified = 2,
        Deleted = 3,
        NonApproval = 4,
        Rejected=5
    }

    public enum DisplayStatus
    {
        All = 0,
        ApprovedOnly = 1,
        UnapprovedOnly = 2,
        DeletedOnly = 3,
    }
}

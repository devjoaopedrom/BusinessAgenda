using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessAgenda.Core.Entites;

namespace BusinessAgenda.Core.Entities
{
    public class MeetingComment : BaseEntity
    {
        public int MeetingId { get; private set; }
        public string Comment { get; private set; }
        public Meeting Meeting { get; private set; }

        protected MeetingComment() { }

        public MeetingComment(int meetingId, string comment)
        {
            MeetingId = meetingId;
            Comment = comment;
        }
    }
}

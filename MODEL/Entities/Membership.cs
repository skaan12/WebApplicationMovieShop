﻿using MODEL.Abstract.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entities
{
    public class Membership:BaseMembershipEntity
    {
        //Relation
        public List<User> User { get; set; }
    }
}

﻿using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Security.JWT
{
    public interface ITokenHelperAttendee
    {
        AccessToken CreateToken(Attendee attendee, List<OperationClaim> operationClaims);

    }
}

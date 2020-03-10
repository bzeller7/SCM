using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCM.Models
{
    public class ContactDB
    {
        public static Contact AddContact(Contact c
                                , InfoContext context)
        {
            //Create insert query
            //context.contact.Add(c);


            return c;
        }
    }
}

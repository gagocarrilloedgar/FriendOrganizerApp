using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    class FriendDataService : IFriendDataService
    {
       public IEnumerable<Friend> GetAll()
        {
            // TODO: load real data from data base
            yield return new Friend { FirstName = "Thomas", LastName = "Huber"};
            yield return new Friend { FirstName = "Andreas", LastName ="Boehler" };
            yield return new Friend { FirstName = "Julia", LastName = "Huber" };
            yield return new Friend { FirstName = "Chrissi", LastName ="Egin" };

        }
    }
}

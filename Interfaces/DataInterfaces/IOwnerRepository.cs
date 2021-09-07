using Entities.Models;
using System.Collections.Generic;

namespace Interfaces.DataInterfaces
{
    public interface IOwnerRepository 
    {
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(int id);
    }
}

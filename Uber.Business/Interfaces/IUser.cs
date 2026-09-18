using System;
using System.Collections.Generic;
using System.Text;
using UberApp.Domain;

namespace Uber.Business.Interfaces
{
    public interface IUser : IBusiness<User>
    {
        bool Register();
    }

}

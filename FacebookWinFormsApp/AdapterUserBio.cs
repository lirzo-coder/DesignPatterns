using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicUnit;

namespace BasicFacebookFeatures
{
    internal class AdapterUserBio : IUserBio
    {
        private AppLogicSingleton m_LogicUnit = Singleton<AppLogicSingleton>.Instance;

        public void GetUserBio(List<object> o_UserBio)
        {
            o_UserBio.Add(m_LogicUnit.m_LoggedInUser.FirstName);
            o_UserBio.Add(m_LogicUnit.m_LoggedInUser.LastName);
            o_UserBio.Add(m_LogicUnit.m_LoggedInUser.Gender);
            o_UserBio.Add(m_LogicUnit.m_LoggedInUser.Birthday);
            o_UserBio.Add(m_LogicUnit.m_LoggedInUser.Email);
        }   
    }
}
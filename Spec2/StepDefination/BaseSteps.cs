using Spec2.Data;
using Spec2.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Spec2.StepDefination
{
    [Binding]
    public class BaseSteps
    {

        public UserData GetUserData(string userType)
        {
            var userData = Prop.GetUserType(userType);
            return userData;
        }
  


    }
}

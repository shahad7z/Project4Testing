
using System;
using System.Collections.Generic;


namespace phase4
{
    
    public class TestFeatureSteps
    {
        private string text = "pizza,SMALL";
        
        public void GivenTheFollowingData()
        {
            var text = "pizza,SMALL";
            //  ScenarioContext.Current.TryAdd(text);
        }

       
        public void ThenMYBIDINGSHOULDDOTHAT()
        {
            var actual = "BBQ,SMALL";
            var expexted = "BBQ,SMALL";
            if (!actual.Equals(expexted))
            {
                
            }
            //ScenarioContext.Current.Pending();
        }
    }
}

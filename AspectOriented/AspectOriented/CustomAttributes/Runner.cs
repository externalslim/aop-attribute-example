using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectOriented.CustomAttributes
{
    public class Runner
    {
        public void Execute(Action action)
        {
            var attr = action.Method.GetCustomAttributes(typeof(WorkLoadAttribute), true)
                .First() as WorkLoadAttribute;
            
            var preMethod = action.Target.GetType().GetMethod(attr.preAction);
            var postMethod = action.Target.GetType().GetMethod(attr.postAction);

            // now first invoke the pre-action method
            preMethod.Invoke(null, null);
            // the actual action
            action();
            // the post-action
            postMethod.Invoke(null, null);

        }
    }
}

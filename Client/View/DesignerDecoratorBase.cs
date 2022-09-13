using System;
using System.Collections.Generic;
using System.Text;

namespace Client.View
{
    abstract class DesignerDecoratorBase : IDesigner
    {
        private readonly IDesigner _designer;
        public DesignerDecoratorBase(IDesigner designer)
        {
            _designer = designer;
        }
        public virtual string GetTableStyle()
        {
            return _designer.GetTableStyle();
        }
    }
}

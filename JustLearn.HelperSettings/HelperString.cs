using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLearn.HelperSettings
{  
    public static class HelperString {

        public const string Id = "Id";
        public const string ProductId = "ProductId";
        public const string ProductName = "ProductName";
        public const string UnitPrice = "UnitPrice";

        public const string GeneralErrorMessage = "An error occured!";

        public static class ViewStates {
            public const string SortExpression = "SortExpression";
            public const string SortState = "SortState";
        }

        public static class CommandNames {
            public const string Raise = "Raise";
            public const string Sort = "Sort";
        }

        public static class Cookies {
            public const string Name = "Name";
            public const string NameValue = "John Doe";
        }
    }
}

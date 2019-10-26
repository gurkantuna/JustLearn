using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JustLearn.CustomExtensions {
    public static class CustomExtensions {
        public static void ShowJSMessageBox(this TemplateControl page, string message, Exception ex = null) {
            if (page is Page p) {
                if (!p.ClientScript.IsClientScriptBlockRegistered("PopupScript")) {

                    var exMessage = string.Empty;

                    if (ex != null) {
                        if (ex.InnerException != null && ex.InnerException.InnerException != null) {
                            exMessage = ex.InnerException.InnerException.Message;
                        }
                        else if (ex.Message != null) {
                            exMessage = ex.Message;
                        }
                    }

                    if (exMessage.Contains("\"")) exMessage = exMessage.Replace("\"", "");
                    if (exMessage.Contains("\'")) exMessage = exMessage.Replace("\'", "");
                    if (exMessage.Contains("\r")) exMessage = exMessage.Replace("\r", "");
                    if (exMessage.Contains("\t")) exMessage = exMessage.Replace("\t", "");
                    if (exMessage.Contains("\n")) exMessage = exMessage.Replace("\n", " ");

                    if (ex != null) {
                        p.ClientScript.RegisterClientScriptBlock(page.GetType(), "AlertBox", $"alert('{message}: {exMessage}')", true);
                    }
                    else {
                        p.ClientScript.RegisterClientScriptBlock(page.GetType(), "AlertBox", $"alert('{message}')", true);
                    }
                }
            }
        }

        public static DataTable ToDataTable<T>(this IList<T> data) {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data) {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        //https://stackoverflow.com/questions/213148/sort-columns-of-gridview-in-asp-net-c-sharp/357276#357276
        public static IQueryable<T> SortBy<T>(this IQueryable<T> source, string sortExpression, SortDirection direction) {
            if (source == null) {
                throw new ArgumentNullException("source");
            }

            string methodName = "OrderBy";
            if (direction == SortDirection.Descending) {
                methodName += "Descending";
            }

            var paramExp = Expression.Parameter(typeof(T), String.Empty);
            var propExp = Expression.PropertyOrField(paramExp, sortExpression);

            // p => p.sortExpression
            var sortLambda = Expression.Lambda(propExp, paramExp);            

            var methodCallExp = Expression.Call(typeof(Queryable), methodName, new Type[] { typeof(T), propExp.Type }, source.Expression, Expression.Quote(sortLambda));

            return (IQueryable<T>)source.Provider.CreateQuery(methodCallExp);
        }
    }
}

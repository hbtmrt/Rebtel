using RebtelTest.Data.Statics;
using RebtelTest.Web.Protos;
using System.Linq;
using System.Text;

namespace RebtelTest.Web.Helpers
{
    /// <summary>
    /// A helper class to provide support for the controller.
    /// </summary>
    public sealed class ConverterHelper
    {
        public string GetMostBorrowedBooksString(Books books)
        {
            StringBuilder sb = new();
            sb.AppendLine(string.Format(Constants.GrpcClient.Message.MostBorrowedBooksThreshold, Constants.MostBorrowedBooksThreshold));
            sb.AppendLine(string.Join(",", books.BookList.Select(bl => bl.Name)));

            return sb.ToString();
        }
    }
}
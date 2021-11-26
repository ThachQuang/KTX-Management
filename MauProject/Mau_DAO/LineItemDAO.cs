using R2S.Training.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2S.Training.Dao
{
    internal class LineItemDAO : ILineItemDAO
    {
        const string ADD_LINEITEM = @"SP_Add_LineItem @oder_id , @product_id , @quantity , @price";

        private static LineItemDAO instance;

        public static LineItemDAO Instance
        {
            get { if (instance == null) instance = new LineItemDAO(); return LineItemDAO.instance; }
            private set { LineItemDAO.instance = value; }
        }

        /// <summary>
        /// ADD LINE ITEM
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddLineItem(LineItem item)
        {
            try
            {
                object[] Para = new object[] { item.OrderId, item.ProductId, item.Quantity, item.Price };

                return DataProvider.Instance.ExecuteNonQuery(ADD_LINEITEM, Para) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
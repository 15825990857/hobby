using hobby.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace hobbywebApi.Areas.WebApi.Model
{
    public class ResponseObject
    {
        /// <summary>
        /// 消息码
        /// </summary>
        public int Status { get; set; }
        /// <summary>
        /// 消息信息
        /// </summary>
        public string  Message { get; set; }
        /// <summary>
        /// 结果集
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// 附加结果集
        /// </summary>
        public object additional_data { get; set; }

        /// <summary>
        /// 初始化结果集
        /// </summary>
        /// <returns></returns>
        public static ResponseObject InitFromDataSet(DataSet data)
        {
            ResponseObject obj = new ResponseObject();
            if (data == null)
            {
                obj.Status = 0;
                obj.Message = "异常";
            }
            else if (data.Tables[0].Rows.Count == 0)
            {
                obj.Status = 0;
                obj.Message = "未查到相关数据";
            }
            else
            {
                obj.Status = 1;
                obj.Message = "成功";
            }
            obj.Data = (data == null ? null : data.Tables[0]);
            return obj;
        }

       
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public  class ResultView<T>
    {
        /// <summary>
        /// 消息码
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 消息信息
        /// </summary>
        public string message { get; set; }

        /// <summary>
        /// 结果数据集
        /// </summary>
        public T data { get; set; }

        /// <summary>
        /// 使用DataSet初始化结果对象
        /// </summary>
        /// <param name="data">数据集</param>
        /// <returns>结果对象</returns>
        public static ResultView<List<T>> InitFromDataSet(DataSet data)
        {
            ResultView<List<T>> Resault = new ResultView<List<T>>();
            if (data == null)
            {
                Resault.status = 0;
                Resault.message = "异常";
            }
            else if (data.Tables[0].Rows.Count == 0)
            {
                Resault.status = 0;
                Resault.message = "未查到相关信息";
            }
            else
            {
                Resault.status = 1;
                Resault.message = "成功";
            }
            Resault.data = (List<T>)DataSetHelper.ConvertDataTableToList<T>(data.Tables[0]);
            return Resault;
        }

    

        /// <summary>
        /// 使用列表初始化结果对象
        /// </summary>
        /// <param name="List">列表</param>
        /// <returns>结果对象</returns>
        public static ResultView<List<T>> InitFromList(List<T> List)
        {
            ResultView<List<T>> Resault = new ResultView<List<T>>();

            if (List.Count == 0)
            {
                Resault.status = 0;
                Resault.message = "数据异常";
            }
            else
            {
                Resault.status = 0;
                Resault.message = "成功";
            }
            Resault.data = List;
            return Resault;
        }

        
    }
}